using System;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace OpenStackAPI_Web
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void loginBt_Click(object sender, EventArgs e)
        {
            string username = usenameTb.Text;
            string password = passwordTb.Text;
            string projectId = "NT533.P11.206"; // Thay thế bằng Project ID thực tế

            try
            {
                var (token, responseContent) = await GetAuthToken(username, password, projectId);

                if (!string.IsNullOrEmpty(token))
                {
                    MainApplication mainApplication = new MainApplication(token);
                    var formattedResponse = JsonConvert.SerializeObject(JsonConvert.DeserializeObject(responseContent), Formatting.Indented);
                    // Ghi log vào MainApplication
                    mainApplication.LogEvent($"Đăng nhập thành công với token: {token}");
                    mainApplication.LogEvent($"Nội dung trả về: {formattedResponse}");

                    mainApplication.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xác thực không thành công: " + ex.Message);
            }
        }

        public async Task<(string token, string responseContent)> GetAuthToken(string username, string password, string projectName)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://cloud-identity.uitiot.vn/v3/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                var authData = new
                {
                    auth = new
                    {
                        identity = new
                        {
                            methods = new[] { "password" },
                            password = new
                            {
                                user = new
                                {
                                    name = username,
                                    domain = new { name = "default" },
                                    password = password
                                }
                            }
                        },
                        scope = new
                        {
                            project = new
                            {
                                domain = new { name = "default" },
                                name = projectName
                            }
                        }
                    }
                };

                var jsonContent = new StringContent(JsonConvert.SerializeObject(authData), Encoding.UTF8, "application/json");

                var response = await client.PostAsync("auth/tokens", jsonContent);
                string responseContent = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    string token = response.Headers.Contains("X-Subject-Token")
                        ? response.Headers.GetValues("X-Subject-Token").FirstOrDefault()
                        : null;

                    return (token, responseContent);
                }
                else
                {
                    throw new Exception($"Xác thực không thành công. Nội dung: {responseContent}");
                }
            }
        }
    }
}

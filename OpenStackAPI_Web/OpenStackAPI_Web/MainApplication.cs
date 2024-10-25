using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace OpenStackAPI_Web
{
    public partial class MainApplication : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private string authToken; // Biến để lưu token xác thực

        public MainApplication(string token)
        {
            InitializeComponent();
            authToken = token; // Nhận token từ đối tượng Login
        }

        public void LogEvent(string message)
        {
            eventlogTb.Text = "";
            eventlogTb.AppendText(message + Environment.NewLine);
            eventlogTb.ScrollToCaret();
        }

        private async void imagelistBt_Click(object sender, EventArgs e)
        {
            await GetImages();
        }

        private async void keypairlistBt_Click(object sender, EventArgs e)
        {
            await GetKeyPairs();
        }

        private async void flavorslistBt_Click(object sender, EventArgs e)
        {
            await GetFlavors();
        }

        private async Task GetImages()
        {
            string url = "https://cloud-image.uitiot.vn/v2/images";
            try
            {
                client.DefaultRequestHeaders.Clear(); // Dọn dẹp header cũ
                client.DefaultRequestHeaders.Add("X-Auth-Token", authToken); // Thêm header X-Auth-Token

                var response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();

                // Chuyển đổi nội dung thành JSON có định dạng
                var formattedJson = JsonConvert.SerializeObject(JsonConvert.DeserializeObject(content), Formatting.Indented);
                LogEvent($"Images: {formattedJson}");
            }
            catch (Exception ex)
            {
                LogEvent($"Error: {ex.Message}");
            }
        }

        private async Task GetKeyPairs()
        {
            string url = "http://cloud-compute.uitiot.vn/v2/os-keypairs";
            try
            {
                client.DefaultRequestHeaders.Clear(); // Dọn dẹp header cũ
                client.DefaultRequestHeaders.Add("X-Auth-Token", authToken); // Thêm header X-Auth-Token

                var response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();

                // Chuyển đổi nội dung thành JSON có định dạng
                var formattedJson = JsonConvert.SerializeObject(JsonConvert.DeserializeObject(content), Formatting.Indented);
                LogEvent($"Key Pairs: {formattedJson}");
            }
            catch (Exception ex)
            {
                LogEvent($"Error: {ex.Message}");
            }
        }

        private async Task GetFlavors()
        {
            string url = "http://cloud-compute.uitiot.vn/v2/flavors";
            try
            {
                client.DefaultRequestHeaders.Clear(); // Dọn dẹp header cũ
                client.DefaultRequestHeaders.Add("X-Auth-Token", authToken); // Thêm header X-Auth-Token

                var response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();

                // Chuyển đổi nội dung thành JSON có định dạng
                var formattedJson = JsonConvert.SerializeObject(JsonConvert.DeserializeObject(content), Formatting.Indented);
                LogEvent($"Flavors: {formattedJson}");
            }
            catch (Exception ex)
            {
                LogEvent($"Error: {ex.Message}");
            }
        }
        private async void  CreateNetworkBt_Click_1(object sender, EventArgs e)
        {
            string networkName = networknameTb.Text;
            string url = "https://cloud-network.uitiot.vn/v2.0/networks"; // Địa chỉ API tạo mạng
            try
            {
                client.DefaultRequestHeaders.Clear(); // Dọn dẹp header cũ
                client.DefaultRequestHeaders.Add("X-Auth-Token", authToken); // Thêm header X-Auth-Token

                var networkData = new
                {
                    network = new
                    {
                        name = networkName,
                        admin_state_up = true // Đặt trạng thái quản trị là true
                    }
                };

                var jsonContent = new StringContent(JsonConvert.SerializeObject(networkData), Encoding.UTF8, "application/json");
                var response = await client.PostAsync(url, jsonContent);
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();

                // Chuyển đổi nội dung thành JSON có định dạng
                var formattedJson = JsonConvert.SerializeObject(JsonConvert.DeserializeObject(content), Formatting.Indented);
                LogEvent($"Network Created: {formattedJson}");
            }
            catch (Exception ex)
            {
                LogEvent($"Error: {ex.Message}");
            }
        }

        private async void CreateSubnetBt_Click(object sender, EventArgs e)
        {
            string subnetName = subnetnameTb.Text;
            string cidr = networkaddressTb.Text;
            string networkId = networknameTb.Text;
            string url = "https://cloud-network.uitiot.vn/v2.0/subnets"; // Địa chỉ API tạo subnet
            try
            {
                client.DefaultRequestHeaders.Clear(); // Dọn dẹp header cũ
                client.DefaultRequestHeaders.Add("X-Auth-Token", authToken); // Thêm header X-Auth-Token

                var subnetData = new
                {
                    subnet = new
                    {
                        name = subnetName,
                        cidr = cidr,
                        network_id = networkId,
                        ip_version = 4 // Đặt phiên bản IP là 4
                    }
                };

                var jsonContent = new StringContent(JsonConvert.SerializeObject(subnetData), Encoding.UTF8, "application/json");
                var response = await client.PostAsync(url, jsonContent);
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();

                // Chuyển đổi nội dung thành JSON có định dạng
                var formattedJson = JsonConvert.SerializeObject(JsonConvert.DeserializeObject(content), Formatting.Indented);
                LogEvent($"Subnet Created: {formattedJson}");
            }
            catch (Exception ex)
            {
                LogEvent($"Error: {ex.Message}");
            }
        }

        private async void CreatePortBt_Click(object sender, EventArgs e)
        {
            string ipAddress = portaddressTb.Text;
            string networkId = networknameTb.Text;
            string subnetId = subnetnameTb.Text;
            string url = "https://cloud-network.uitiot.vn/v2.0/ports"; // Địa chỉ API tạo port
            try
            {
                client.DefaultRequestHeaders.Clear(); // Dọn dẹp header cũ
                client.DefaultRequestHeaders.Add("X-Auth-Token", authToken); // Thêm header X-Auth-Token

                var portData = new
                {
                    ports = new[]
                    {
                new
                {
                    admin_state_up = true,
                    port_security_enabled = false,
                    security_groups = (string)null, // Có thể để null
                    network_id = networkId,
                    fixed_ips = new[]
                    {
                        new
                        {
                            ip_address = ipAddress,
                            subnet_id = subnetId
                        }
                    }
                }
            }
                };

                var jsonContent = new StringContent(JsonConvert.SerializeObject(portData), Encoding.UTF8, "application/json");
                var response = await client.PostAsync(url, jsonContent);
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();

                // Chuyển đổi nội dung thành JSON có định dạng
                var formattedJson = JsonConvert.SerializeObject(JsonConvert.DeserializeObject(content), Formatting.Indented);
                LogEvent($"Port Created: {formattedJson}");
            }
            catch (Exception ex)
            {
                LogEvent($"Error: {ex.Message}");
            }
        }
        private async Task CreateInstance(string instanceName, string imageRef, string flavorRef, string networkId, string portId, string userData)
        {
            string url = "http://cloud-compute.uitiot.vn/v2/servers"; // Địa chỉ API tạo instance
            try
            {
                client.DefaultRequestHeaders.Clear(); // Dọn dẹp header cũ
                client.DefaultRequestHeaders.Add("X-Auth-Token", authToken); // Thêm header X-Auth-Token

                var instanceData = new
                {
                    server = new
                    {
                        name = instanceName,
                        imageRef = imageRef,
                        flavorRef = flavorRef,
                        networks = new[]
                        {
                    new
                    {
                        uuid = networkId,
                        port = portId // ID của port
                    }
                },
                        user_data = userData // Dữ liệu người dùng
                    }
                };

                var jsonContent = new StringContent(JsonConvert.SerializeObject(instanceData), Encoding.UTF8, "application/json");
                var response = await client.PostAsync(url, jsonContent);
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();

                // Chuyển đổi nội dung thành JSON có định dạng
                var formattedJson = JsonConvert.SerializeObject(JsonConvert.DeserializeObject(content), Formatting.Indented);
                LogEvent($"Instance Created: {formattedJson}");
            }
            catch (Exception ex)
            {
                LogEvent($"Error: {ex.Message}");
            }
        }

        private async void createinstanceBt_Click(object sender, EventArgs e)
        {
            string instanceName = NameInstanceTb.Text; // Tên của instance bạn muốn tạo
            string imageRef = ImageInstanceTb.Text; // ID của image
            string flavorRef = FavorsInstanceTb.Text; // ID của flavor
            string networkId = networkIdInstanceTb.Text; // ID của network
            string portId = PortInstanceTb.Text; // ID của port
            string userData = "IyEvYmluL2Jhc2gKcHJpbnRmICJERVZJQ0U9XCJldGgxXCJcbk9OQk9PVD1cInllc1wiXG5UWVBFPVwiRXRoZXJuZXRcIlxuSVBBRERSPTE5Mi4xNjguMTEuMTFcbk5FVE1BU0s9MjU1LjI1NS4yNTUuMCIgPiAvZXRjL3N5c2NvbmZpZy9uZXR3b3JrLXNjcmlwdHMvaWZjZmctZXRoMQpwcmludGYgIm5ldC5pcHY0LmlwX2ZvcndhcmQ9MSIgPiAvZXRjL3N5c2N0bC5jb25mCnNlcnZpY2UgbmV0d29yayByZXN0YXJ0Cnl1bSBpbnN0YWxsIC15IHF1YWdnYQpjaG1vZCA3NzcgL2V0Yy9xdWFnZ2EKY2QgL2V0Yy9xdWFnZ2EKcHJpbnRmICJob3N0bmFtZSBuaGFuaDFcbnBhc3N3b3JkIGNlbnRvc1xuaW50ZXJmYWNlIGV0aDBcbmlwNiBuZCBzdXBwcmVzcy1yYVxuaW50ZXJmYWNlIGV0aDFcbmlwNiBuZCBzdXBwcmVzcy1yYVxuaW50ZXJmYWNlIGxvXG5pcCBmb3J3YXJkaW5nIiA+IHplYnJhLmNvbmYKc2VydmljZSB6ZWJyYSBzdGFydApjaGtjb25maWcgemVicmEgb24KcHJpbnRmICJob3N0bmFtZSByaXBkXG5wYXNzd29yZCBjZW50b3NcbmxvZyBzdGRvdXRcbnJvdXRlciByaXBcbnZlcnNpb24gMlxubmV0d29yayBldGgxXG5saW5lIHZ0eSIgPiAvZXRjL3F1YWdnYS9yaXBkLmNvbmYKc2VydmljZSByaXBkIHN0YXJ0CmNoa2NvbmZpZyByaXBkIG9uCg=="; // Dữ liệu người dùng

            await CreateInstance(instanceName, imageRef, flavorRef, networkId, portId, userData);
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenStackAPI_Web
{
    public partial class MainApplication : Form
    {
        public MainApplication()
        {
            InitializeComponent();
        }

        public void LogEvent(string message)
        {
            eventlogTb.Text = "";
            eventlogTb.AppendText(message + Environment.NewLine);
        }


    }
}

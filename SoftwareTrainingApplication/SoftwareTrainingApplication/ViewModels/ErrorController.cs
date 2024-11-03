using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareTrainingApplication.ViewModels
{
    internal class ErrorController
    {

        public static bool CheckForInternetConnection()
        {
            try
            {
                Ping myPing = new Ping();
                String host = "google.com";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);

                return (reply.Status == IPStatus.Success);
            }
            catch (Exception)
            {
                MessageBox.Show("İnternet bağlantısını kontrol edin.");
                return false;
            }
        }
    }
}

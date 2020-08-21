using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Web;
using System.Windows.Forms;

namespace CommonClassLibrary
{
    public class CommonClass
    {
        //DB Name
        public static readonly string DB_OPERATOR = "info_employees";

        //IP and Host
        public static string HOST_NAME = "";
        public static string IP = "";

        public static string OPERATOR_ID = "";
        public static string Login_TYPE_FORM = "";

        public static double chkDouble;
        public static int chkInt;

        public static void showSuccess(string msg)
        {
            MessageBox.Show(msg, "การแจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void showError(string msg)
        {
            MessageBox.Show(msg, "เกิดข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        public static string GetLocalHostName()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            return host.HostName;
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

    }
}
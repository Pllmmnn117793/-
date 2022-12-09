using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Net;

namespace Тестер_сети
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            foreach (var mos in new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapter").Get())
            
            {
                label1.Text = mos.GetPropertyValue("MACAddress").ToString();
                return;
            }
            
            foreach (var s in new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapter").Get()) 
            {
                label5.Text = s.GetPropertyValue("IpV4Address").ToString();
                return;
            }

            foreach (var n in new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapter").Get())
            {
                label6.Text = n.GetPropertyValue("Manufacturer").ToString();
                return;
            }




        }
    }

}

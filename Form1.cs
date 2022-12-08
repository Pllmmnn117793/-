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
            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM ISCSI_IP_Address");
            ManagementObjectCollection moc = mos.Get();
            foreach (ManagementObject m in moc) { label1.Text = m.GetPropertyValue("IpV4Address").ToString(); }


               





        }
    }

}

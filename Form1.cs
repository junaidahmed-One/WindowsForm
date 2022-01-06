using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsClient_20181COM0065
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();
            string forcurr = Convert.ToString(textBox1.Text);
            double ans = obj.ShowCurrencyRate(forcurr);
            MessageBox.Show("Rs." + ans);
        }
    }
}

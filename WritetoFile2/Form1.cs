using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WritetoFile2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWriteData_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"C:\CC6\SampleDataFile.txt", true);
            sw.WriteLine(DateTime.Now);
            sw.Close();
        }

        private void btnReadData_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"C:\CC6\SampleDataFile.txt");
            tbResults.Text = sr.ReadToEnd();
            sr.Close();
        }
    }
}

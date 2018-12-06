using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scheduleApp
{
    public partial class Form1 : Form
    {
        OpenFileDialog openfile = new OpenFileDialog();
        string line = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openfile.Filter = "Text  File(.txt)| *.txt";
        }

        private void save_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"names.txt");
            //StreamWriter sw = File.AppendText(@"names.txt");
            string datefrom = datafrom.Text;
            string dateto = dateeto.Text;
            string fullname = impname.Text;
            string workingdirectory = workdir.Text;
            string bodyofsigner = bodysinger.Text;
            string data = majoractivities.Text;
            string plane = datefrom + "_" + dateto + "_" + fullname +
                "_" + workingdirectory + "_" + bodyofsigner + "_" + data+",";
            sw.WriteLine(plane);
            majoractivities.Text = "";
            sw.Close();
         }

        private void read_Click(object sender, EventArgs e)
        {
         if(openfile.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openfile.FileName);
                while (line != null)
                {
                    line = sr.ReadLine();
                    if(line != null)
                    {
                        majoractivities.AppendText(line);
                    }
                }
                sr.Close();
            }
        }
    }
}

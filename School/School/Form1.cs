using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class Form1 : Form
    {
        Student stud = new Student();
        public Form1()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            //stud.register("tesfay bsrat", 24, "Male", "black");

            stud.Full_Name = tname.Text;
            stud.GEnder = tgender.Text;
            stud.AGe = int.Parse(tage.Text);
            stud.COlor = tcolor.Text;

            stud.register(stud.Full_Name, stud.AGe, stud.GEnder, stud.COlor);
            string r =stud.Access_from_proprrties();
            Result.Text = r;
           // stud.register();
        }
    }
}

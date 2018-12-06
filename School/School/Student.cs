using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    class Student
    {
        private string F_name, Gender, Color;
        private int Age;
 
        public string Full_Name
        {
            set { F_name = value; }
            get { return F_name; }
        }
        public string GEnder
        {
            set { Gender = value; }
            get { return Gender; }
        }
        public int AGe
        {
            set { Age = value; }
            get { return Age; }
        }
        public string COlor
        {
            set { Color = value; }
            get { return Color; }
        }


        public void register(string f_name, int age, string gender, string color)
        {
            F_name = f_name;
            Gender = gender;
            Color = color;
            Age = age;

            MessageBox.Show("hello" + F_name + " " + Gender + " " + " "+Color+ " "+Age);


        }

        public string Access_from_proprrties()
        {
            F_name = Full_Name;
            Gender = GEnder;
            Color = COlor;
            Age = AGe;
            
          string  Result = F_name + " " + Gender + " " + " " + Color + " " + Age;
            return Result;

           // MessageBox.Show("hello" + F_name + " " + Gender + " " + " " + Color + " " + Age);


        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Serial_port_chat
{
    class serial_port_manager
    {
        public string dataOUT;
        public string sendwith;
        public string dataIN;
        public string porta;
        public double datalength;



        public string result;
        public SerialPort serialport1 = new SerialPort();

        public string PortName;
        public string BaudRate;
        public string DataBits;
        public string StopBits;
        public string Parity;
        public string[] portsr;

        public void portaa()
        {
          portsr = SerialPort.GetPortNames();
         // Pname.Items.AddRange(portsr);
            //cBoxcomport.Items.AddRange(class1.ports);
        } 

        //propertices
        public string ports {
            get
            {
                return porta;
            }
            set
            {
                porta = value;
            }
        }
        public string Pname
        {
            get
            {
                return PortName;
            }
            set
            {
                PortName = value;
            }
        }
        public string Results
        {
            get
            {
                return result;
            }
        }
        public string Brate
        {
            get{
                return BaudRate;
            }
            set{
                BaudRate = value;
                }
        }
        public string Dbits
        {
            get
            {
                return DataBits;
            }
            set
            {
                DataBits = value;
            }
        }
        public string Sbits
        {
            get
            {
                return StopBits;
            }
            set
            {
                StopBits = value;
            }
        }
        public string Parityy
        {
            get
            {
               return Parity;
            }
            set
            {
                Parity = value;
            }
        }
        public string dOut
        {
            get
            {
                return dataOUT;
            }
            set
            {
                dataOUT = value;
            }
        }
        public string dIN
        {
            get
            {
                return dataIN;
            }
            set
            {
                dataIN = value;
            }
        }
        public string Swith
        {
            get
            {
                return sendwith;
            }
            set
            {
                sendwith = value;
            }
        }

        public void About()
        {
            MessageBox.Show("Date 24/12/2010 E.C", "First P", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void send()
        {
  
        }

        public void clear()
        {
          result = "";           
        }

        public void TextStyle()
        {
            if (Swith == "None")
            {
               sendwith = "None";
            }
            else if (Swith == "Both")
            {
                sendwith = "Both";
            }
            else if (Swith == "New Line")
            {
                sendwith = "New Line";
            }
            else if (Swith == "Carriage Return")
            {
                sendwith = "Carriage Return";
            }
        }

        public string Swith1
        {
            get
            {
                return dataIN;
            }
            set
            {
                dataIN = value;
            }
        }

        //public void serialP()
        //{
        //    dataIN = serialport1.ReadExisting();
        //    this.Invoke(new EventHandler(ShowData));
        //}



        public void ShowD()
        {
            if (Swith1 == "Always Update")
            // if (cBoxalwaysupdate.Checked)
            {
                dIN = dataIN;
            }
            else if (Swith1 == "Add to old data")
            {
                //else if (cBoxaddtoolddata.Checked)

                dIN += dataIN;
                // tBoxrecievecontrol.Text = tBoxrecievecontrol.Text.Insert(0, tBoxrecievecontrol);
            }
        }

        public void OpenConnection()
        {

        }

        public void CloseConnection()
        {
            if (serialport1.IsOpen)
            {
                serialport1.Close();
               // Progressbar.Value = 0;
            }
        }
    }
}

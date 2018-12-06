using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports;

namespace Best
{
    public delegate void dataReceived(object sender, SerialPortEventArgs arg);
    public class SerialPortEventArgs : EventArgs
    {
        public string ReceivedData { get; private set; }
        public SerialPortEventArgs(string data)
        {
            ReceivedData = data;
        }
    }

    class Class1
    {
        public event dataReceived DataReceived;
        /// <summary>
        /// event based on delegate
        /// </summary>
        private string Send_data;
        private string Recieve_data;
        private string portname;
        public string display;
        public string[] Ports_incbox;
        private TextBox textboxshow;
        private ProgressBar Connection;
        private string toolStripCombo1;
        private string toolStripCombo2;

        SerialPort serial = new SerialPort();
     
        public string data_to_send
        {
            get
            {
                return Send_data;
            }
            set
            {
                Send_data = value;
            }
        }
        public TextBox ChatWindow
        {
            get { return textboxshow; }
            set { textboxshow = value; }
        }
        public ProgressBar Conx
        {
            get
            {
                return Connection;
            }
        }

        public string data_to_reciev
        {
            get
            {
                return Recieve_data;
            }
            set
            {
                Recieve_data = value;
            }
        }

        public string Port
        {
            get
            {
                return portname;
            }
            set
            {
                portname = value;
            }
        }

        public string toolStripComboBox1
        {
            set
            {
                toolStripCombo1 = value;
            }
            get
            {
                return toolStripCombo1;
            }
        }

        public string toolStripComboBox2
        {
            set
            {
                toolStripCombo2 = value;
            }
            get
            {
               return toolStripCombo2;
            }
        }

        public string displayed
        {
            get
            {
                return display;
            }
           
        }

        public void Show_Ports()
        {
            Ports_incbox = SerialPort.GetPortNames();
        }
        
        public void OpenConnection()
        {
            if (!serial.IsOpen)
            {
                serial.PortName = Port;
                serial.Open();
               // serial.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
               serial.DataReceived += new SerialDataReceivedEventHandler(_serialPort_DataReceived);

            }
            else
            {
                MessageBox.Show(" Please Select Communication Port First!");
            }
        }

        public void CloseConnection()
        {
            if (serial.IsOpen)
            {
                serial.Close();
                Connection = null;
            }
        }
        //private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
          private void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            data_to_reciev = serial.ReadExisting();

            if (this.DataReceived != null)
            {
                SerialPortEventArgs args = new SerialPortEventArgs(data_to_reciev);
                this.DataReceived(this, args);
            }

            //ShowData();
        }
        //private void ShowData()
        //{
        //  if (toolStripComboBox1 == "Add to old data")
        //    {
        //    textboxshow.Invoke(new EventHandler(delegate {
        //        textboxshow.Text += data_to_reciev;
        //        //textboxshow.Text = textboxshow.Text.Insert(0, textboxshow);
        //        }));
            
        //    }
        //    else if (toolStripComboBox1 == "Always Update")
        //    {
        //        textboxshow.Invoke(new EventHandler(delegate
        //        {
        //            textboxshow.Text = data_to_reciev;
        //            //textboxshow.Text = textboxshow.Text.Insert(0, textboxshow);
        //        }));
        //    }
        //    else
        //    {
        //        textboxshow.Invoke(new EventHandler(delegate {
        //            textboxshow.Text += data_to_reciev;
        //       }));
        //    }
        //}

        public void Gone()
        {
            if (serial.IsOpen)
            {
        if(toolStripComboBox2 == "None")
                {
                    serial.WriteLine(data_to_send);
                }
        else if(toolStripComboBox2 == "Both")
                {
                    serial.WriteLine(data_to_send + "\r\n");
                }
        else if(toolStripComboBox2 == "New Line")
                {
                    serial.WriteLine(data_to_send + "\n");
                }
        else if(toolStripComboBox2 == "Carriage Return")
                {
                    serial.WriteLine(data_to_send + "\r");
                }
                else
                {
                    serial.WriteLine(data_to_send + "\r");
                    //MessageBox.Show("Too " + toolStripComboBox2);
                }
            }
            else
            {
                MessageBox.Show(" Please Open Connection First!");
            }
         }

        public void Clear()
        {
            display = "";
        }
    }

}

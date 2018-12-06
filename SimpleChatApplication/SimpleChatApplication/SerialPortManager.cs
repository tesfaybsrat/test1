using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleChatApplication
{
    public class udpEventArgss : EventArgs
    {
        public string ReceivedData { get; set; }
    }

    class SerialPortManager : Interface1
    {
        public event EventHandler DataReceived;
        /// <summary>
        /// event based on delegate
        /// </summary>
        private string Send_data;
        private string Recieve_data;
        private string portname;
        public string display;
        //public string[] Ports_incbox;
        //private string textboxshow;
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
        //public string ChatWindow
        //{
        //    get { return textboxshow; }
        //    set { textboxshow = value; }
        //}
        public ProgressBar Conx{get{return Connection; }}
        public string data_to_reciev{get{return Recieve_data;}set{Recieve_data = value;}}
        //public string[] ports_incbox
        //{
        //    set { Ports_incbox = value; }
        //    get { return Ports_incbox; }
        //}
        public string Port{ get{return portname;}set{portname = value;} }
        public string toolStripComboBox1{set{toolStripCombo1 = value;}get{return toolStripCombo1;}}
        public string toolStripComboBox2{set{toolStripCombo2 = value;}get{return toolStripCombo2;}}
        public string displayed {get{ return display;} set { display = value; } }

        public string Local_Ip { get; set; }
        public string Local_Port { get; set; }
        public string Remot_Ip { get; set; }
        public string Remot_Port { get; set; }

        //public void Show_Ports()
        //{
        //    ports_incbox = SerialPort.GetPortNames();
        //}

        public void OpenConnection()
        {
            if (!serial.IsOpen)
            {
                serial.PortName = Port;
                serial.Open();
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
        private void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            data_to_reciev = serial.ReadExisting();

            if (this.DataReceived != null)
            {
               // SerialPortEventArgs args = new SerialPortEventArgs(data_to_reciev);
                DataReceived(this, new udpEventArgss() { ReceivedData = data_to_reciev });
                //this.DataReceived(this, args);
            }

        }

        public void send()
        {
            if (serial.IsOpen)
            {
                if (toolStripComboBox2 == "None")
                {
                    serial.WriteLine(data_to_send);
                }
                else if (toolStripComboBox2 == "Both")
                {
                    serial.WriteLine(data_to_send + "\r\n");
                }
                else if (toolStripComboBox2 == "New Line")
                {
                    serial.WriteLine(data_to_send + "\n");
                }
                else if (toolStripComboBox2 == "Carriage Return")
                {
                    serial.WriteLine(data_to_send + "\r");
                }
                else
                {
                    serial.WriteLine(data_to_send + "\r");
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

        public void Send()
        {
            throw new NotImplementedException();
        }
    }
}

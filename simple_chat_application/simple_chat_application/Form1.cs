using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_chat_application
{
    public partial class Form1 : Form
    {
        SerialPortInterface _workingObject = new SerialPortInterface();
        public Form1()
        {
            InitializeComponent();
            _workingObject.Show_Ports();
            cBoxPortSelect.Items.AddRange(_workingObject.Ports_incbox);
            //serialPortSettingsControl1.WorkingObject = _workingObject;
            //_workingObject.DataReceived += new dataReceived(_workingObject_DataReceived);


        }

        void _workingObject_DataReceived(object sender, SerialPortEventArgs arg)
        {
            this.ReceivedText.Text += arg.ReceivedData;
        }

        //Open Button
        private void button1_Click_1(object sender, EventArgs e)
        {
            _workingObject.Port = cBoxPortSelect.Text;
            if (_workingObject.Open())
                MessageBox.Show("Port Opened Successfuly");
            else MessageBox.Show("Port could not be opened");
        }
        //Close button
        private void button2_Click_1(object sender, EventArgs e)
        {
            _workingObject.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //_workingObject.Show_Ports();
            //cBoxPortSelect.Items.AddRange(_workingObject.Ports_incbox);
        }
        //send button
        private void button3_Click_1(object sender, EventArgs e)
        {
            _workingObject.Send(this.SendText.Text);
            _workingObject.DataReceived += new dataReceived(_workingObject_DataReceived);
        }
    }
}

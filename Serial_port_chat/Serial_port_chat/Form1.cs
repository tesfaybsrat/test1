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
    public partial class Form1 : Form
    {
        serial_port_manager class1 = new serial_port_manager();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          AcceptValuse();
          class1.portaa();

            //class1.ports = SerialPort.GetPortNames();
            cBoxcomport.Items.AddRange(class1.portsr);
            // class1.ports = SerialPort.GetPortNames();
            // cBoxcomport.Items.AddRange(s.ports);
            //cBoxbaudrate.Items.AddRange(ports);
            // cBoxdatabits.Items.AddRange(ports);
            // cBoxstopbits.Items.AddRange(ports);
            // cBoxparitybits.Items.AddRange(ports);

            //btnopen.Enabled = true;
            //btnclose.Enabled = false;

            cBoxdtrenable.Checked = false;
            serialPort1.DtrEnable = false;

            cBoxrtsenable.Checked = false;
            serialPort1.RtsEnable = false;

            btnsenddata.Enabled = true;

            //cBoxwriteline.Checked = false;
            //cBoxwrite.Checked = true;
            //serial_port_manager class1 = new serial_port_manager();
            class1.sendwith = "Both";

            //cBoxaddtoolddata.Checked = true;
            //cBoxalwaysupdate.Checked = false;

            toolStripComboBox1.Text = "Add to old data";
            toolStripComboBox2.Text = "Both";

        }

        private void comPortControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cBoxcomport.Text;
                serialPort1.BaudRate = Convert.ToInt32(cBoxbaudrate.Text);
                serialPort1.DataBits = Convert.ToInt32(cBoxdatabits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxstopbits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxparitybits.Text);
                
                serialPort1.Open();
                progressBar.Value = 100;
                //btnopen.Enabled = false;
                //btnclose.Enabled = true;
                // lbstatuscom.Text = "ON";
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               // btnopen.Enabled = true;
               // btnclose.Enabled = false;
                //lbstatuscom.Text = "OFF";
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            class1.CloseConnection();
            progressBar.Value = 0;

            //if (serialPort1.IsOpen)
            //{
            //    serialPort1.Close();
            //    progressBar.Value = 0;
            //    //btnopen.Enabled = true;
            //   // btnclose.Enabled = false;
            //   // lbstatuscom.Text = "OFF";
            //}

        }



        private void btnsenddata_Click(object sender, EventArgs e)
        {
            //class1.send();
            if (serialPort1.IsOpen)
            {
                class1.dOut = tBoxdataout.Text;
                //serialPort1.WriteLine(class1.dataOUT);
                if (class1.sendwith == "None")
                {
                    serialPort1.Write(class1.dOut);
                }
                else if (class1.sendwith == "Both")
                {
                    serialPort1.Write(class1.dOut + "\r\n");
                }
                else if (class1.sendwith == "New Line")
                {
                    serialPort1.Write(class1.dOut + "\n");
                }
                else if (class1.sendwith == "Carriage Return")
                {
                    serialPort1.Write(class1.dOut + "\r");
                }

            }
            else
            {
                tBoxdataout.Text = "Please Open The Connection First";
            }
        }

        private void toolStripComboBox2_DropDownClosed(object sender, EventArgs e)
        {
            //if (toolStripComboBox2.Text == "None")
            //{
            //    class1.sendwith = "None";
            //}
            //else if (toolStripComboBox2.Text == "Both")
            //{
            //    class1.sendwith = "Both";
            //}
            //else if (toolStripComboBox2.Text == "New Line")
            //{
            //    class1.sendwith = "New Line";
            //}
            //else if (toolStripComboBox2.Text == "Carriage Return")
            //{
            //    class1.sendwith = "Carriage Return";
            //}

            // toolStripComboBox2.Text = class1.toolStripComboBox2;

            AcceptValuse();
            class1.TextStyle();

        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }

        private void cBoxdtrenable_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxdtrenable.Checked)
            {
                serialPort1.DtrEnable = true;
            }
            else
            {
                serialPort1.DtrEnable = false;
            }
        }

        private void cBoxrtsenable_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxrtsenable.Checked)
            {
                serialPort1.RtsEnable = true;
            }
            else
            {
                serialPort1.RtsEnable = false;
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (tBoxdataout.Text != "")
            //{
            //    tBoxdataout.Text = " ";
            //}          
                class1.clear();
                tBoxdataout.Text = class1.Results;          
        }


        private void lbdataoutlength_Click(object sender, EventArgs e)
        {

        }

        private void tBoxdataout_TextChanged(object sender, EventArgs e)
        {
            class1.datalength = tBoxdataout.TextLength;
            lbdataoutlength.Text = string.Format("{0:00}", class1.datalength);
            //if (cBoxusingenter.Checked)
            //{
                tBoxdataout.Text = tBoxdataout.Text.Replace(Environment.NewLine, "");
            //}
        }

        //private void cBoxusingbutton_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (cBoxusingbutton.Checked)
        //    {
        //        btnsenddata.Enabled = true;
        //    }
        //    else
        //    {
        //        btnsenddata.Enabled = false;
        //    }
        //}

        private void cBoxusingenter_CheckedChanged(object sender, EventArgs e)
        {
            // if(e.KeyCode == Keys.Enter)
            //{
            this.dosamething();
           // e.Handled();
                
            //}

        }


        private void dosamething()
        {
            if (serialPort1.IsOpen)
            {
                class1.dataOUT = tBoxdataout.Text;
                if (class1.sendwith == "None")
                {
                    serialPort1.Write(class1.dataOUT);
                }
                else if (class1.sendwith == "Both")
                {
                    serialPort1.Write(class1.dataOUT + "\r\n");
                }
                else if (class1.sendwith == "New Line")
                {
                    serialPort1.Write(class1.dataOUT + "\n");
                }
                else if (class1.sendwith == "Carriage Return")
                {
                    serialPort1.Write(class1.dataOUT + "\r");
                }
            }
        }

        //private void cBoxwriteline_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (cBoxwriteline.Checked)
        //    {
        //        class1.sendwith = "writeline";
        //        cBoxwrite.Checked = false;
        //        cBoxwriteline.Checked = true;
        //    }
        //}

        //private void cBoxwrite_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (cBoxwrite.Checked)
        //    {
        //        class1.sendwith = "write";
        //        cBoxwrite.Checked = true;
        //        cBoxwriteline.Checked = false;
        //    }
        //}

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            class1.dIN = serialPort1.ReadExisting();
            Invoke(new EventHandler(ShowData ));
        }

        private void ShowData(object sender, EventArgs e)
        {
            //class1.ShowD();
            if (toolStripComboBox1.Text == "Always Update")
            // if (cBoxalwaysupdate.Checked)
            {
                tBoxrecievecontrol.Text = class1.dIN;
            }
            else if (toolStripComboBox1.Text == "Add to old data")
            {
                //else if (cBoxaddtoolddata.Checked)

                tBoxrecievecontrol.Text += class1.dIN ;
                // tBoxrecievecontrol.Text = tBoxrecievecontrol.Text.Insert(0, tBoxrecievecontrol);
            }
        }

        // private void cBoxalwaysupdate_CheckedChanged(object sender, EventArgs e)
        // {
        // if (cBoxalwaysupdate.Checked)
        // {
        // cBoxalwaysupdate.Checked = true;
        // cBoxaddtoolddata.Checked = false;
        // }
        // }

        // private void cBoxaddtoolddata_CheckedChanged(object sender, EventArgs e)
        //  {
        //  if (cBoxaddtoolddata.Checked)
        //  {
        //      cBoxaddtoolddata.Checked = true;
        //      cBoxalwaysupdate.Checked = false;
        //   }
        // }


        private void clearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            class1.clear();
            tBoxrecievecontrol.Text = class1.Results;
          //  if (serialPort1.IsOpen)
          //  {
                // btnopen.Enabled = true;
                // btnclose.Enabled = false;
                // lbstatuscom.Text = "OFF";
                //tBoxrecievecontrol.Text = "";
           // }
        }

        private void eXiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            class1.About();
        }

        public void AcceptValuse()
        {
          
            class1.dOut = tBoxdataout.Text;
            class1.dIN = tBoxrecievecontrol.Text;

            class1.ports = cBoxcomport.Text;
            class1.Brate = cBoxbaudrate.Text;
            class1.Sbits = cBoxstopbits.Text;
            class1.Parityy = cBoxparitybits.Text;

            class1.Swith = toolStripComboBox2.Text;
            class1.Swith1 = toolStripComboBox1.Text;
       }

 

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void tBoxdataout_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != ('.'))
            {
                e.Handled = true;
            }
        }

        private void settingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Setting gotosetting = new Setting();
            this.Hide();
            gotosetting.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cBoxbaudrate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cBoxdatabits_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cBoxstopbits_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cBoxparitybits_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

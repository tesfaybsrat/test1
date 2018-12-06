using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDisplayName.Text != "")
            {
                Entities.Properties.Settings.Default.DisplayName = txtDisplayName.Text;
                Entities.Properties.Settings.Default.Status = cmbStatus.SelectedIndex;

                Entities.Properties.Settings.Default.Save();
                Close();
            }
            else
                MessageBox.Show("Display name can not be empty.", "Mini Chat - Error");
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            txtDisplayName.Text = Entities.Properties.Settings.Default.DisplayName;
            cmbStatus.DataSource = Enum.GetNames(typeof(Entities.UserStatus));
            cmbStatus.SelectedIndex = Entities.Properties.Settings.Default.Status;
        }
    }
}

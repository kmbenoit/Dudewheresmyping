using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class IPAdd : Form
    {
        public IPAdd()
        {
            InitializeComponent();
        }
        public string IPAdder
        {
            get
            {

                return txtIPAdd.Text;
            }
         }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtIPAdd.Text))
            {
                MessageBox.Show("Please type an IP Address Dumbass.");
                return;

            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }

}

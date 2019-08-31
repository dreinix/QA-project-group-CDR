using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QAproject
{
    public partial class AddProvider : Material
    {
        public AddProvider()
        {
            InitializeComponent();
        }

        private void AddProvider_Load(object sender, EventArgs e)
        {
            nameTextBox.BackColor = Color.White;
            directionTextbox.BackColor = Color.White;
            companyTextbox.BackColor = Color.White;
            nameTextBox.Focus();
        }

        private void nameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
                directionTextbox.Focus();
           
        }

        private void directionTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
                companyTextbox.Focus();
        }

        private void companyTextbox_KeyDown(object sender, KeyEventArgs e)
        { 
            /*
            if (Keys.Enter == e.KeyCode)
              */  
        }
    }
}

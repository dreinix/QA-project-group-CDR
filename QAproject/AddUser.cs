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
    public partial class AddUser : Material
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            userTextbox.Focus();
          
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (passwordTextbox.Text != repeatPasswordTextbox.Text)
            {
                MessageBox.Show("Contraseña diferente", "Google LLC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordTextbox.Text = "";
                repeatPasswordTextbox.Text = "";
                passwordTextbox.Focus();
                return;
            }
            // Despues de Agregar Usuario
            MessageBox.Show("Usuario agregado Correctamente", "Google LLC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Login a = new Login();
            a.ShowDialog();
            this.Close();
        }

        private void userTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
                comboBox1.Focus();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}

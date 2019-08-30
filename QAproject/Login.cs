using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QAproject
{
    public partial class Login : Material   
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://es.wikipedia.org/wiki/Google");
        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {
            if (TxtUserName.Text == "Nombre Usuario")
                TxtUserName.Text = "";

        }

        private void materialSingleLineTextField2_Click(object sender, EventArgs e)
        {
            if (TxtPsw.Text == "Contraseña")
            {
                TxtPsw.Text = "";
                TxtPsw.PasswordChar = '*';
            }
        }


        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();

            if (TxtUserName.Text == "admin")
            {
                if (TxtPsw.Text == "123")
                {
                    this.Hide();
                    a.ShowDialog();
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("Contraseña Invalidad", "Google LLC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtPsw.Text = "";
                    TxtPsw.Focus();
                }
            }
            else
            {
                MessageBox.Show("Usuario Invalido", "Google LLC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtPsw.Text = "";
                TxtUserName.Text = "";
                TxtPsw.PasswordChar = '\0';
                TxtPsw.Text = "Contraseña";
                TxtUserName.Focus();
             
            }

        }

        private void materialSingleLineTextField2_Leave(object sender, EventArgs e)
        {

            if (TxtPsw.Text == "")
            {
                TxtPsw.PasswordChar = '\0';
                TxtPsw.Text = "Contraseña";

            }
        }

        private void materialSingleLineTextField1_Leave(object sender, EventArgs e)
        {
            if (TxtUserName.Text == "")
                TxtUserName.Text = "Nombre Usuario";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Actualmente no se encuentra en funcionamiento, esta es una version de prueba usuario: admin & password: 123", "Google LLC", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void MaterialSingleLineTextField2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void MaterialSingleLineTextField2_KeyDown(object sender, KeyEventArgs e)
        {
            if(Keys.Enter == e.KeyCode)
            {
                Form1 a = new Form1();
                a.ShowDialog();
                this.Close();
            }
        }

        private void MaterialSingleLineTextField1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
                TxtPsw.Focus();
        }
    }
}

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
    public partial class Login : Form
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
            if (materialSingleLineTextField1.Text == "Nombre Usuario")
                materialSingleLineTextField1.Text = "";

        }

        private void materialSingleLineTextField2_Click(object sender, EventArgs e)
        {
            if (materialSingleLineTextField2.Text == "Contraseña")
            {
                materialSingleLineTextField2.Text = "";
                materialSingleLineTextField2.PasswordChar = '*';
            }
        }


        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();

            if (materialSingleLineTextField1.Text == "admin")
            {
                if (materialSingleLineTextField2.Text == "123")
                {
                    a.Show();
                    this.Hide();
                    
                }
                else
                {
                    MessageBox.Show("Contraseña Invalidad", "Google LLC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    materialSingleLineTextField2.Text = "";
                    materialSingleLineTextField2.Focus();
                }
            }
            else
            {
                MessageBox.Show("Usuario Invalido", "Google LLC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                materialSingleLineTextField2.Text = "";
                materialSingleLineTextField1.Text = "";
                materialSingleLineTextField2.PasswordChar = '\0';
                materialSingleLineTextField2.Text = "Contraseña";
                materialSingleLineTextField1.Focus();
             
            }

        }

        private void materialSingleLineTextField2_Leave(object sender, EventArgs e)
        {

            if (materialSingleLineTextField2.Text == "")
            {
                materialSingleLineTextField2.PasswordChar = '\0';
                materialSingleLineTextField2.Text = "Contraseña";

            }
        }

        private void materialSingleLineTextField1_Leave(object sender, EventArgs e)
        {
            if (materialSingleLineTextField1.Text == "")
                materialSingleLineTextField1.Text = "Nombre Usuario";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Actualmente no se encuentra en funcionamiento, esta es una version de prueba usuario: admin & password: 123", "Google LLC", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

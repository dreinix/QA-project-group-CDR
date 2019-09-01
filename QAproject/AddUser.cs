using QAproject.Data;
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
            TxtUsername.Focus();
          
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
            if (TxtPsw.Text != TxtRepeatPsw.Text)
            {
                MessageBox.Show("Contraseña diferente", "Google LLC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtPsw.Text = "";
                TxtRepeatPsw.Text = "";
                TxtPsw.Focus();
                return;
            }

            try
            {
                if (TxtPsw.Text == TxtUsername.Text)
                {
                    MessageBox.Show("El usuario y al contraseña no pueden ser iguales");
                    TxtUsername.Clear();
                    TxtPsw.Clear();
                    TxtRepeatPsw.Clear();
                    comboBox1.SelectedIndex = 0;
                    return;
                }
                ControlDB DBControl = new ControlDB(ControlDB.cPath, "dbQA.mdf");
                string[] parameters = { "@name", "@Username", "@pass", "cat" };
                string[] elements = { TxtName.Name, TxtUsername.Text, TxtPsw.Text, comboBox1.SelectedIndex.ToString() };
                if (DBControl.Buscar("Select * from [User] where Username=@userName", parameters, elements))
                {
                    MessageBox.Show("El usuario ya existe");
                    TxtUsername.Clear();
                    TxtPsw.Clear();
                    
                    return;
                }
                if (DBControl.Insertar("insert into [User] values(@Name,@userName,@pass,@cat)", parameters, elements))
                {   
                    //MessageBox.Show("Usuario agregado");
                }
                else
                {
                    MessageBox.Show("El usuario no pudo ser agregado");
                    DBControl.Close();
                    return;
                }
                DBControl.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor, verifique los datos");
            }

            // Despues de Agregar Usuario
            MessageBox.Show("Usuario agregado Correctamente", "Google LLC", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

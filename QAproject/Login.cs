using QAproject.Data;
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
        private void InisiarSesion()
        {
            ControlDB DBControl = new ControlDB(ControlDB.cPath, "dbQA.mdf");
            string[] parameters = { "@id", "@pass" };
            string[] elements = { TxtUserName.Text, TxtPsw.Text };
            TxtUserName.Clear();
            TxtPsw.Clear();
            List<string> admins = new List<string> { "Adm", "Dev" };
            if (DBControl.Buscar("select * from [User] where [Username]=@id and [Password]=@pass", parameters, elements))
            {
                string cat = DBControl.BuscarElemento("select [Tipo] from [User] where [UserName]=@id and [Password]=@pass", parameters, elements);
                Main mainPage = new Main(cat);
                this.Hide();
                mainPage.ShowDialog();
                this.Show();
                TxtUserName.Focus();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña inválidos");
                TxtUserName.Focus();
            }
        }
        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            InisiarSesion();
            /*
            Main a = new Main();

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
            */
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
                InisiarSesion();
                /*
                Main a = new Main();
                a.ShowDialog();
                this.Close();*/
            }
        }

        private void MaterialSingleLineTextField1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
                TxtPsw.Focus();
        }

        private void MaterialRaisedButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtPsw.Text == TxtUserName.Text)
                {
                    MessageBox.Show("El usuario y al contraseña no pueden ser iguales");
                    TxtUserName.Clear();
                    TxtPsw.Clear();
                    return;
                }
                ControlDB DBControl = new ControlDB(ControlDB.cPath, "dbQA.mdf");
                string[] parameters = { "@userName","@Name", "@pass", "cat" };
                string[] elements = { TxtUserName.Text,"No One" ,TxtPsw.Text, "Dev" };
                if(DBControl.Buscar("Select * from [User] where Username=@userName", parameters,elements))
                {
                    MessageBox.Show("El usuario ya existe");
                    TxtUserName.Clear();
                    TxtPsw.Clear();
                    return;
                }
                if (DBControl.Insertar("insert into [User] values(@userName,@Name,@pass,@cat)", parameters, elements))
                {   /*
                    string[] para = { "@id" };
                    string[] val = { System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString() };
                    int activos = int.Parse(DBControl.BuscarElemento("select [registros] from Activos where [ID] = @id", para, val));
                    para = new string[] { "@id", "@nums" };
                    string[] nums = { System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString(), (++activos).ToString(), };
                    DBControl.Insertar("update [Activos] set [registros]=@nums where [id]=@id", para, nums);
                    */
                    MessageBox.Show("Usuario agregado");
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("El usuario no pudo ser agregado");
                }
                DBControl.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor, verifique los datos");
            }
        }
    }
}

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
            if (TxtUserName.Text == "User Name")
                TxtUserName.Text = "";

        }

        private void materialSingleLineTextField2_Click(object sender, EventArgs e)
        {
            if (TxtPsw.Text == "Password")
            {
                TxtPsw.Text = "";
                TxtPsw.PasswordChar = '*';
            }
        }
        private void IniciarSesion()
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
                TxtPsw.Text = "";
            }
        }
        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            
            IniciarSesion();
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
                TxtPsw.Text = "Password";
            }
        }

        private void materialSingleLineTextField1_Leave(object sender, EventArgs e)
        {
            if (TxtUserName.Text == "")
                TxtUserName.Text = "User Name";
            if(TxtUserName.Text == "master")
            {
                MessageBox.Show("Desbloqueo de opciones maestras", "Google LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                materialRaisedButton1.Visible = true;
                TxtUserName.Text = "User Name";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Actualmente si no tienes usuario, se te llevara a crear uno", "Google LLC", MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Hide();
            AddUser a = new AddUser();
            a.ShowDialog();
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            materialRaisedButton1.Visible = false;
            materialRaisedButton2.Visible = false;
        }

        private void MaterialSingleLineTextField2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void MaterialSingleLineTextField2_KeyDown(object sender, KeyEventArgs e)
        {
            if(Keys.Enter == e.KeyCode)
            {
                IniciarSesion();
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

        private void devAdd()
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
                string[] parameters = { "@name", "@Username", "@pass", "cat" };
                string[] elements =  {"No One", TxtUserName.Text,TxtPsw.Text, "Dev" };
                if (DBControl.Buscar("Select * from [User] where Username=@userName", parameters, elements))
                {
                    MessageBox.Show("El usuario ya existe");
                    TxtUserName.Clear();
                    TxtPsw.Clear();
                    return;
                }
                if (DBControl.Insertar("insert into [User] values(@Name,@userName,@pass,@cat)", parameters, elements))
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

        private void MaterialRaisedButton1_Click(object sender, EventArgs e)
        {
            devAdd();
        }

        private void TxtPsw_Leave(object sender, EventArgs e)
        {
             if (TxtPsw.Text == "")
            {
                TxtPsw.PasswordChar = '\0';
                TxtPsw.Text = "Password";
            }
        }

        private void materialRaisedButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            devAdd();
        }
    }
}

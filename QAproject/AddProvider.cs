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
    public partial class AddProvider : Material
    {
        public AddProvider()
        {
            InitializeComponent();
        }

        private void AddProvider_Load(object sender, EventArgs e)
        {
            TxtName.BackColor = Color.White;
            TxtDirection.BackColor = Color.White;
            TxtCompany.BackColor = Color.White;
            TxtName.Focus();
        }

        private void nameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
                TxtDirection.Focus();
           
        }

        private void directionTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
                TxtCompany.Focus();
        }

        private void companyTextbox_KeyDown(object sender, KeyEventArgs e)
        { 
            /*
            if (Keys.Enter == e.KeyCode)
              */  
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            ControlDB control = new ControlDB(ControlDB.cPath, "dbQA.mdf");

            try
            {
                string[] parameters = { "@name", "@dir", "@comp" };
                string[] elements = { TxtName.Text, TxtDirection.Text, TxtCompany.Text };
                if (!control.Insertar("insert into [Proveedor] values(@name,@dir,@comp)", parameters, elements))
                {
                    MessageBox.Show("EL proovedor no pudo ser agregado", "Google LLC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
            // Paso despues de agregar

            TxtName.Clear();
            TxtDirection.Clear();
            TxtCompany.Clear();
            MessageBox.Show("Proveedor Agregado Correctamente", "Google LLC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            TxtName.Focus();

            // Fin
        }
    }
}

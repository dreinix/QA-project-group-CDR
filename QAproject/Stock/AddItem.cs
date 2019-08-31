using QAproject.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QAproject
{
    public partial class AddItem : Material
    {
        public AddItem()
        {
            InitializeComponent();
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            TxtName.BackColor = Color.White;
            NUDCant.BackColor = Color.White;
            TxtName.Focus();
            ControlDB control = new ControlDB(ControlDB.cPath, "dbQA.mdf");
            BindingSource bs = new BindingSource();
            List<string> dataList = control.Buscar("select [Nombre] from Proveedor");
            /*foreach (SqlDataReader datar in )
            {   

                datar.Read();
                dataList.Add(datar.GetValue(0).ToString());
            }*/
            CBProveedor.DataSource = dataList;
        }

        private void AgregarButtom_Click(object sender, EventArgs e)
        {
            ControlDB control = new ControlDB(ControlDB.cPath, "dbQA.mdf");

            try
            {
                string[] parameters = { "@name", "@cant", "@prov"};
                string[] elements = { TxtName.Text,NUDCant.Value.ToString(), CBProveedor.SelectedValue.ToString()};
                if (!control.Insertar("insert into Item values(@name,@cant,@prov)",parameters,elements))
                {   
                    MessageBox.Show("EL Item no pudo ser agregado", "Google LLC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            };
            // Paso despues de agregar

            TxtName.Clear();
            NUDCant.Value = 1;
            MessageBox.Show("Item Agregado Correctamente", "Google LLC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            TxtName.Focus();

            // Fin
        }

        private void NombreItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
                NUDCant.Focus();
        }
    }
}

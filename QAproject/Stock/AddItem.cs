using QAproject.Data;
using QAproject.Utility;
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

        private List<Provider> providers = new List<Provider>();
        private void AddItem_Load(object sender, EventArgs e)
        {
            string[] parameters = {};
            string[] elements = {};
            TxtName.BackColor = Color.White;
            NUDCant.BackColor = Color.White;
            TxtName.Focus();
            ControlDB control = new ControlDB(ControlDB.cPath, "dbQA.mdf");
            BindingSource bs = new BindingSource();
            List<string[]> dataList = control.Buscar("select * from Proveedor",parameters,elements,4);
            List<string> ProvName = new List<string>();
            foreach(string[] value in dataList)
            {
                Provider prov = new Provider(int.Parse(value[0]), value[1], value[2], value[3]);
                providers.Add(prov);
                CBProveedor.Items.Add(prov.Name);
                ProvName.Add(prov.Name);
            }
            CBProveedor.DataSource = ProvName;
        }

        private void AgregarButtom_Click(object sender, EventArgs e)
        {
            ControlDB control = new ControlDB(ControlDB.cPath, "dbQA.mdf");

            try
            {
                string[] parameters = { "@name", "@cant", "@prov"};
                int provedor = providers[CBProveedor.SelectedIndex].ID;
                string[] elements = { TxtName.Text,NUDCant.Value.ToString(), provedor.ToString()};
                if (!control.Insertar("insert into Item values(@name,@cant,@prov)",parameters,elements))
                {   
                    MessageBox.Show("EL Item no pudo ser agregado", "Google LLC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            };
            TxtName.Clear();
            NUDCant.Value = 1;
            MessageBox.Show("Item Agregado Correctamente", "Google LLC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            TxtName.Focus();
        }

        private void NombreItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
                NUDCant.Focus();
        }

        private void CancelarButtom_Click(object sender, EventArgs e)
        {
            MainPage a = new MainPage("");
            a.ShowDialog();
            this.Close();
            
        }
    }
}

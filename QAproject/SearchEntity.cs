using QAproject.Data;
using QAproject.Utility;
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
    public partial class SearchEntity : Material
    {
        public SearchEntity()
        {
            InitializeComponent();
        }
        private void ResetDataGrid()
        {
            dataGridView1.Rows.Clear();
            ControlDB control = new ControlDB(ControlDB.cPath, "dbQA.mdf");

            string[] para = { "@name" };
            List<string[]> items = control.Buscar("select * from Item where [Item]!=@name", para, para, 0);
            List<Item> ItemList = new List<Item>();
            foreach (var item in items)
            {
                para = new string[] { "@id" };
                string[] val = { item[3].ToString() };
                string provider = control.BuscarElemento("select [Nombre] from Proveedor where [Id_Proveedor]=@id", para, val);
                Item it = new Item(int.Parse(item[0]), item[1], int.Parse(item[2]), provider);
                ItemList.Add(it);
            }
            var itemData = new BindingList<Item>(ItemList);
            dataGridView1.DataSource = itemData;
            dataGridView1.Refresh();
        }
        private void SearchEntity_Load(object sender, EventArgs e)
        {
            TxtSearch.BackColor = Color.White;
            TxtSearch.Focus();
            materialRaisedButton3.Visible = true;
            ResetDataGrid();
            
        }
        private void LoadData(string value)
        {
            dataGridView1.Rows.Clear();
            ControlDB control = new ControlDB(ControlDB.cPath, "dbQA.mdf");

            string[] para = { "@name"};
            string[] val = {value };
            List<string[]> items = control.Buscar("select * from Item where [Item] like concat('%',@name,'%')", para, val, 0);
            List<Item> ItemList = new List<Item>();
            foreach (var item in items)
            {
                para = new string[] { "@id" };
                val = new string[] { item[3].ToString() };
                string provider = control.BuscarElemento("select [Nombre] from Proveedor where [Id_Proveedor]=@id", para, val);
                Item it = new Item(int.Parse(item[0]), item[1], int.Parse(item[2]), provider);
                ItemList.Add(it);
            }
            var itemData = new BindingList<Item>(ItemList);
            dataGridView1.DataSource = itemData;
            dataGridView1.RefreshEdit();
        }
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            TxtSearch.Text = "";

        }

        private void materialRaisedButton1_Click_1(object sender, EventArgs e)
        {
            if (TxtSearch.Text == "")
            {
                MessageBox.Show("Ingrese algun dato", "Google LLC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtSearch.Focus();
            }
            else
            {
                LoadData(TxtSearch.Text);
                materialRaisedButton3.Visible = true;
                materialRaisedButton2.Location = new Point(458, 82);
            }

        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 1)
            {
                MessageBox.Show("Debe modificar el stock 1 a 1");
            }
            
            DataGridViewCellCollection row = dataGridView1.CurrentRow.Cells;
            
            Item item = new Item(int.Parse(row[0].Value.ToString()),row[1].Value.ToString(), 
                int.Parse(row[2].Value.ToString()), row[3].Value.ToString());
            ChangeStock stock = new ChangeStock(item);
            stock.ShowDialog();
            ResetDataGrid();
            //dataGridView1.Refresh();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData(TxtSearch.Text);
        }
    }
}

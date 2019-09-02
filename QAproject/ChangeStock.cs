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
    public partial class ChangeStock : Material
    {   
        private Utility.Item it;
        public ChangeStock(Utility.Item item)
        {
            InitializeComponent();
            it = item;
        }

        private void ChangeStock_Load(object sender, EventArgs e)
        {
            TxtNewCant.Focus();
            TxtName.Text = it.Name;
            TxtCant.Text = it.Count.ToString();
            TxtProv.Text = it.Provider;

        }


        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtCant.Text);
            int y = 0;
            try
            {
                 y = Convert.ToInt32(TxtCant.Text);
            }
            catch
            {
                y = -1;
            }
            if (y != -1 && y > 0)
            {
                y += x;
                string z = Convert.ToString(y);
                ControlDB control = new ControlDB(ControlDB.cPath, "dbQA.mdf");
                string[] para = { "@cant", "@id" };
                string[] element = { z, it.ID.ToString() };
                if (!control.Update("Update [Item] set [count]=@cant where [Id_Item]=@id", para, element))
                {

                    MessageBox.Show("No se pudieron guardar los cambios");
                    return;
                }
                TxtCant.Text = TxtNewCant.Text;
                TxtNewCant.Clear();
                MessageBox.Show("Cambios guardados!", "Google LLC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error verificar Contenido", "Google LLC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNewCant.Text = "";
                TxtNewCant.Focus();
            }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtCant.Text);
            int y = 0;
            try
            {
                y = Convert.ToInt32(TxtCant.Text);
            }
            catch
            {
                y = int.MaxValue-5;
            }
            if (y < x && y > 0)
            {
                x -= y;
                string z = Convert.ToString(y);
                ControlDB control = new ControlDB(ControlDB.cPath, "dbQA.mdf");
                string[] para = { "@cant", "@id" };
                string[] element = { z, it.ID.ToString() };
                if (!control.Update("Update [Item] set [count]=@cant where [Id_Item]=@id", para, element))
                {

                    MessageBox.Show("No se pudieron guardar los cambios");
                    return;
                }
                TxtCant.Text = TxtNewCant.Text;
                TxtNewCant.Clear();
                MessageBox.Show("Cambios guardados!", "Google LLC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error verificar Contenido", "Google LLC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNewCant.Text = "";
                TxtNewCant.Focus();
            }
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            MainPage a = new MainPage("");
            a.ShowDialog();
            this.Close();
        }

      
    }
}

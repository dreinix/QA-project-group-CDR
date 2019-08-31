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
    public partial class AddItem : Material
    {
        public AddItem()
        {
            InitializeComponent();
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            NombreItem.BackColor = Color.White;
            CantidadItem.BackColor = Color.White;
            NombreItem.Focus();
        }

        private void AgregarButtom_Click(object sender, EventArgs e)
        {
            // Paso despues de agregar

            NombreItem.Text = "";
            CantidadItem.Text = "";
            MessageBox.Show("Item Agregado Correctamente", "Google LLC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            NombreItem.Focus();

            // Fin
        }

        private void NombreItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
                CantidadItem.Focus();
        }
    }
}

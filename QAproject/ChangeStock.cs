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
        public ChangeStock()
        {
            InitializeComponent();
        }

        private void ChangeStock_Load(object sender, EventArgs e)
        {
            newTextBox.Focus();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(CountTextBox.Text);
            int y = 0;
            try
            {
                 y = Convert.ToInt32(CountTextBox.Text);
            }
            catch
            {
                y = -1;
            }
            if(y>x)
            {
                // Base de dato actua
                MessageBox.Show("Cambio realizado", "Google LLC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error verificar Contenido", "Google LLC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                newTextBox.Text = "";
                newTextBox.Focus();
            }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(CountTextBox.Text);
            int y = 0;
            try
            {
                y = Convert.ToInt32(CountTextBox.Text);
            }
            catch
            {
                y = int.MaxValue-5;
            }
            if (y < x)
            {
                // Base de dato actua
                MessageBox.Show("Cambio realizado", "Google LLC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error verificar Contenido", "Google LLC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                newTextBox.Text = "";
                newTextBox.Focus();
            }
        }

        private void ProveedorTextBox_Click(object sender, EventArgs e)
        {

        }
    }
}

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

        private void SearchEntity_Load(object sender, EventArgs e)
        {
            searchTextbox.BackColor = Color.White;
            searchTextbox.Focus();
            materialRaisedButton3.Visible = false;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            searchTextbox.Text = "";

        }

        private void materialRaisedButton1_Click_1(object sender, EventArgs e)
        {
            if (searchTextbox.Text == "")
            {
                MessageBox.Show("Ingrese algun dato", "Google LLC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                searchTextbox.Focus();
            }
            else
            {
                materialRaisedButton3.Visible = true;
                materialRaisedButton2.Location = new Point(458, 82);
            }

        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {

        }
    }
}

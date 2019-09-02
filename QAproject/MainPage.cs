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
    public partial class MainPage : Material
    {
        string userCat;
        public MainPage(string _userCat)
        {
            InitializeComponent();
            userCat = _userCat;

            if (userCat == "Adm" || userCat == "Dev")
                MessageBox.Show("Acceso de Administrador", "Google LLC", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            else
                MessageBox.Show("Dirigiendose al Menu Principal", "Google LLC", MessageBoxButtons.OK,MessageBoxIcon.Information);
        
            this.Sizable = true;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            AddProvider prov = new AddProvider();
            prov.ShowDialog();
            this.Close();

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            AddItem itm = new AddItem();
            itm.ShowDialog();
            this.Close();
        }

        private void MaterialFlatButton3_Click(object sender, EventArgs e)
        {
            SearchEntity entity = new SearchEntity();
            entity.ShowDialog();
            this.Close();
        }

        private void MaterialFlatButton4_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.ShowDialog();
            this.Close();
        }
    }
}

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
    public partial class Main : Material
    {
        string userCat;
        public Main(string _userCat)
        {
            InitializeComponent();
            userCat = _userCat;

            if (userCat == "Adm" || userCat == "Dev")
            {
                MessageBox.Show("Admin");

            }
            else
            {
                MessageBox.Show("Cont");
            }
            this.Sizable = true;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Material a = new Material();
            a.Show();
            this.Hide();
        }
    }
}

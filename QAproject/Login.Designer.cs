namespace QAproject
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.BTLogIn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtUserName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtPsw = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BTLogIn
            // 
            this.BTLogIn.AutoSize = true;
            this.BTLogIn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTLogIn.Depth = 0;
            this.BTLogIn.Icon = null;
            this.BTLogIn.Location = new System.Drawing.Point(159, 402);
            this.BTLogIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.BTLogIn.Name = "BTLogIn";
            this.BTLogIn.Primary = true;
            this.BTLogIn.Size = new System.Drawing.Size(129, 36);
            this.BTLogIn.TabIndex = 1;
            this.BTLogIn.Text = "Iniciar Sección";
            this.BTLogIn.UseVisualStyleBackColor = true;
            this.BTLogIn.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(75, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TxtUserName
            // 
            this.TxtUserName.BackColor = System.Drawing.Color.White;
            this.TxtUserName.Depth = 0;
            this.TxtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserName.Hint = "";
            this.TxtUserName.Location = new System.Drawing.Point(159, 310);
            this.TxtUserName.MaxLength = 32767;
            this.TxtUserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.PasswordChar = '\0';
            this.TxtUserName.SelectedText = "";
            this.TxtUserName.SelectionLength = 0;
            this.TxtUserName.SelectionStart = 0;
            this.TxtUserName.Size = new System.Drawing.Size(274, 23);
            this.TxtUserName.TabIndex = 3;
            this.TxtUserName.TabStop = false;
            this.TxtUserName.Text = "User Name";
            this.TxtUserName.UseSystemPasswordChar = false;
            this.TxtUserName.Click += new System.EventHandler(this.materialSingleLineTextField1_Click);
            this.TxtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MaterialSingleLineTextField1_KeyDown);
            this.TxtUserName.Leave += new System.EventHandler(this.materialSingleLineTextField1_Leave);
            // 
            // TxtPsw
            // 
            this.TxtPsw.Depth = 0;
            this.TxtPsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPsw.Hint = "";
            this.TxtPsw.Location = new System.Drawing.Point(159, 360);
            this.TxtPsw.MaxLength = 32767;
            this.TxtPsw.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtPsw.Name = "TxtPsw";
            this.TxtPsw.PasswordChar = '\0';
            this.TxtPsw.SelectedText = "";
            this.TxtPsw.SelectionLength = 0;
            this.TxtPsw.SelectionStart = 0;
            this.TxtPsw.Size = new System.Drawing.Size(274, 23);
            this.TxtPsw.TabIndex = 4;
            this.TxtPsw.TabStop = false;
            this.TxtPsw.UseSystemPasswordChar = true;
            this.TxtPsw.Click += new System.EventHandler(this.materialSingleLineTextField2_Click);
            this.TxtPsw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MaterialSingleLineTextField2_KeyDown);
            this.TxtPsw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MaterialSingleLineTextField2_KeyPress);
            this.TxtPsw.Leave += new System.EventHandler(this.TxtPsw_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(532, 73);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(375, 353);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(79, 36);
            this.materialRaisedButton1.TabIndex = 6;
            this.materialRaisedButton1.Text = "DevTest";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.MaterialRaisedButton1_Click);
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.AutoSize = true;
            this.materialRaisedButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Icon = null;
            this.materialRaisedButton3.Location = new System.Drawing.Point(375, 310);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(79, 36);
            this.materialRaisedButton3.TabIndex = 8;
            this.materialRaisedButton3.Text = "DevTest";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            this.materialRaisedButton3.Click += new System.EventHandler(this.materialRaisedButton3_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(579, 450);
            this.Controls.Add(this.materialRaisedButton3);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.TxtPsw);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTLogIn);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Google Sing-in";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton BTLogIn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtUserName;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtPsw;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
    }
}
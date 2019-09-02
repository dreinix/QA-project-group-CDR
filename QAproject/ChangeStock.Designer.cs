namespace QAproject
{
    partial class ChangeStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeStock));
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.NombreProveedor = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtProv = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtCant = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtNewCant = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.AutoSize = true;
            this.materialRaisedButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Icon = null;
            this.materialRaisedButton3.Location = new System.Drawing.Point(476, 369);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(91, 36);
            this.materialRaisedButton3.TabIndex = 2;
            this.materialRaisedButton3.Text = "Cancelar";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            this.materialRaisedButton3.Click += new System.EventHandler(this.materialRaisedButton3_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(293, 104);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(97, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Nombre Item";
            // 
            // NombreProveedor
            // 
            this.NombreProveedor.AutoSize = true;
            this.NombreProveedor.Depth = 0;
            this.NombreProveedor.Font = new System.Drawing.Font("Roboto", 11F);
            this.NombreProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NombreProveedor.Location = new System.Drawing.Point(293, 163);
            this.NombreProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.NombreProveedor.Name = "NombreProveedor";
            this.NombreProveedor.Size = new System.Drawing.Size(135, 19);
            this.NombreProveedor.TabIndex = 4;
            this.NombreProveedor.Text = "Nombre Proveedor";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(293, 227);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(149, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Cantidad Item Actual";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(293, 293);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(68, 19);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "Cantidad";
            // 
            // TxtName
            // 
            this.TxtName.Depth = 0;
            this.TxtName.Enabled = false;
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Hint = "";
            this.TxtName.Location = new System.Drawing.Point(297, 134);
            this.TxtName.MaxLength = 32767;
            this.TxtName.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtName.Name = "TxtName";
            this.TxtName.PasswordChar = '\0';
            this.TxtName.SelectedText = "";
            this.TxtName.SelectionLength = 0;
            this.TxtName.SelectionStart = 0;
            this.TxtName.Size = new System.Drawing.Size(273, 23);
            this.TxtName.TabIndex = 7;
            this.TxtName.TabStop = false;
            this.TxtName.UseSystemPasswordChar = false;
            // 
            // TxtProv
            // 
            this.TxtProv.Depth = 0;
            this.TxtProv.Enabled = false;
            this.TxtProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProv.Hint = "";
            this.TxtProv.Location = new System.Drawing.Point(297, 193);
            this.TxtProv.MaxLength = 32767;
            this.TxtProv.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtProv.Name = "TxtProv";
            this.TxtProv.PasswordChar = '\0';
            this.TxtProv.SelectedText = "";
            this.TxtProv.SelectionLength = 0;
            this.TxtProv.SelectionStart = 0;
            this.TxtProv.Size = new System.Drawing.Size(273, 23);
            this.TxtProv.TabIndex = 8;
            this.TxtProv.TabStop = false;
            this.TxtProv.UseSystemPasswordChar = false;
            // 
            // TxtCant
            // 
            this.TxtCant.Depth = 0;
            this.TxtCant.Enabled = false;
            this.TxtCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCant.Hint = "";
            this.TxtCant.Location = new System.Drawing.Point(295, 260);
            this.TxtCant.MaxLength = 32767;
            this.TxtCant.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtCant.Name = "TxtCant";
            this.TxtCant.PasswordChar = '\0';
            this.TxtCant.SelectedText = "";
            this.TxtCant.SelectionLength = 0;
            this.TxtCant.SelectionStart = 0;
            this.TxtCant.Size = new System.Drawing.Size(275, 23);
            this.TxtCant.TabIndex = 9;
            this.TxtCant.TabStop = false;
            this.TxtCant.UseSystemPasswordChar = false;
            // 
            // TxtNewCant
            // 
            this.TxtNewCant.Depth = 0;
            this.TxtNewCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNewCant.Hint = "";
            this.TxtNewCant.Location = new System.Drawing.Point(297, 322);
            this.TxtNewCant.MaxLength = 32767;
            this.TxtNewCant.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtNewCant.Name = "TxtNewCant";
            this.TxtNewCant.PasswordChar = '\0';
            this.TxtNewCant.SelectedText = "";
            this.TxtNewCant.SelectionLength = 0;
            this.TxtNewCant.SelectionStart = 0;
            this.TxtNewCant.Size = new System.Drawing.Size(273, 23);
            this.TxtNewCant.TabIndex = 10;
            this.TxtNewCant.TabStop = false;
            this.TxtNewCant.UseSystemPasswordChar = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-37, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.AutoSize = true;
            this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Icon = null;
            this.materialRaisedButton2.Location = new System.Drawing.Point(393, 369);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(77, 36);
            this.materialRaisedButton2.TabIndex = 1;
            this.materialRaisedButton2.Text = "Reducir";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(292, 369);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(95, 36);
            this.materialRaisedButton1.TabIndex = 0;
            this.materialRaisedButton1.Text = "Aumentar";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // ChangeStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 450);
            this.Controls.Add(this.TxtNewCant);
            this.Controls.Add(this.TxtCant);
            this.Controls.Add(this.TxtProv);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.NombreProveedor);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialRaisedButton3);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "ChangeStock";
            this.Text = "ChangeStock";
            this.Load += new System.EventHandler(this.ChangeStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel NombreProveedor;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtName;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtProv;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtCant;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtNewCant;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}
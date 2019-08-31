namespace QAproject
{
    partial class AddItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItem));
            this.TxtName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.CBProveedor = new System.Windows.Forms.ComboBox();
            this.AgregarButtom = new MaterialSkin.Controls.MaterialRaisedButton();
            this.CancelarButtom = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NUDCant = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCant)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtName
            // 
            this.TxtName.BackColor = System.Drawing.Color.White;
            this.TxtName.Depth = 0;
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Hint = "";
            this.TxtName.Location = new System.Drawing.Point(451, 187);
            this.TxtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtName.MaxLength = 32767;
            this.TxtName.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtName.Name = "TxtName";
            this.TxtName.PasswordChar = '\0';
            this.TxtName.SelectedText = "";
            this.TxtName.SelectionLength = 0;
            this.TxtName.SelectionStart = 0;
            this.TxtName.Size = new System.Drawing.Size(299, 28);
            this.TxtName.TabIndex = 14;
            this.TxtName.TabStop = false;
            this.TxtName.UseSystemPasswordChar = false;
            this.TxtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NombreItem_KeyDown);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.White;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(445, 149);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(153, 24);
            this.materialLabel3.TabIndex = 13;
            this.materialLabel3.Text = "Nombre del item";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.White;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(444, 245);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(85, 24);
            this.materialLabel2.TabIndex = 11;
            this.materialLabel2.Text = "Cantidad";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.White;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(445, 348);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(96, 24);
            this.materialLabel1.TabIndex = 9;
            this.materialLabel1.Text = "Proveedor";
            // 
            // CBProveedor
            // 
            this.CBProveedor.FormattingEnabled = true;
            this.CBProveedor.Location = new System.Drawing.Point(451, 394);
            this.CBProveedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBProveedor.Name = "CBProveedor";
            this.CBProveedor.Size = new System.Drawing.Size(297, 24);
            this.CBProveedor.TabIndex = 17;
            // 
            // AgregarButtom
            // 
            this.AgregarButtom.AutoSize = true;
            this.AgregarButtom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AgregarButtom.Depth = 0;
            this.AgregarButtom.Icon = null;
            this.AgregarButtom.Location = new System.Drawing.Point(496, 455);
            this.AgregarButtom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AgregarButtom.MouseState = MaterialSkin.MouseState.HOVER;
            this.AgregarButtom.Name = "AgregarButtom";
            this.AgregarButtom.Primary = true;
            this.AgregarButtom.Size = new System.Drawing.Size(99, 36);
            this.AgregarButtom.TabIndex = 18;
            this.AgregarButtom.Text = "Agregar";
            this.AgregarButtom.UseVisualStyleBackColor = true;
            this.AgregarButtom.Click += new System.EventHandler(this.AgregarButtom_Click);
            // 
            // CancelarButtom
            // 
            this.CancelarButtom.AutoSize = true;
            this.CancelarButtom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelarButtom.Depth = 0;
            this.CancelarButtom.Icon = null;
            this.CancelarButtom.Location = new System.Drawing.Point(627, 455);
            this.CancelarButtom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CancelarButtom.MouseState = MaterialSkin.MouseState.HOVER;
            this.CancelarButtom.Name = "CancelarButtom";
            this.CancelarButtom.Primary = true;
            this.CancelarButtom.Size = new System.Drawing.Size(109, 36);
            this.CancelarButtom.TabIndex = 19;
            this.CancelarButtom.Text = "Cancelar";
            this.CancelarButtom.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 116);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 373);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // NUDCant
            // 
            this.NUDCant.Location = new System.Drawing.Point(449, 299);
            this.NUDCant.Name = "NUDCant";
            this.NUDCant.Size = new System.Drawing.Size(180, 22);
            this.NUDCant.TabIndex = 21;
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(772, 554);
            this.Controls.Add(this.NUDCant);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CancelarButtom);
            this.Controls.Add(this.AgregarButtom);
            this.Controls.Add(this.CBProveedor);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.Name = "AddItem";
            this.Text = "Agregar Item";
            this.Load += new System.EventHandler(this.AddItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtName;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ComboBox CBProveedor;
        private MaterialSkin.Controls.MaterialRaisedButton AgregarButtom;
        private MaterialSkin.Controls.MaterialRaisedButton CancelarButtom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown NUDCant;
    }
}
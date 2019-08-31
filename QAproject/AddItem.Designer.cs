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
            this.NombreItem = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.CantidadItem = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.providerCombobox = new System.Windows.Forms.ComboBox();
            this.AgregarButtom = new MaterialSkin.Controls.MaterialRaisedButton();
            this.CancelarButtom = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NombreItem
            // 
            this.NombreItem.BackColor = System.Drawing.Color.White;
            this.NombreItem.Depth = 0;
            this.NombreItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreItem.Hint = "";
            this.NombreItem.Location = new System.Drawing.Point(338, 152);
            this.NombreItem.MaxLength = 32767;
            this.NombreItem.MouseState = MaterialSkin.MouseState.HOVER;
            this.NombreItem.Name = "NombreItem";
            this.NombreItem.PasswordChar = '\0';
            this.NombreItem.SelectedText = "";
            this.NombreItem.SelectionLength = 0;
            this.NombreItem.SelectionStart = 0;
            this.NombreItem.Size = new System.Drawing.Size(224, 23);
            this.NombreItem.TabIndex = 14;
            this.NombreItem.TabStop = false;
            this.NombreItem.UseSystemPasswordChar = false;
            this.NombreItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NombreItem_KeyDown);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.White;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(334, 121);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(121, 19);
            this.materialLabel3.TabIndex = 13;
            this.materialLabel3.Text = "Nombre del item";
            // 
            // CantidadItem
            // 
            this.CantidadItem.BackColor = System.Drawing.Color.White;
            this.CantidadItem.Depth = 0;
            this.CantidadItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadItem.Hint = "";
            this.CantidadItem.Location = new System.Drawing.Point(337, 230);
            this.CantidadItem.MaxLength = 32767;
            this.CantidadItem.MouseState = MaterialSkin.MouseState.HOVER;
            this.CantidadItem.Name = "CantidadItem";
            this.CantidadItem.PasswordChar = '\0';
            this.CantidadItem.SelectedText = "";
            this.CantidadItem.SelectionLength = 0;
            this.CantidadItem.SelectionStart = 0;
            this.CantidadItem.Size = new System.Drawing.Size(224, 23);
            this.CantidadItem.TabIndex = 12;
            this.CantidadItem.TabStop = false;
            this.CantidadItem.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.White;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(333, 199);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(68, 19);
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
            this.materialLabel1.Location = new System.Drawing.Point(334, 283);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(77, 19);
            this.materialLabel1.TabIndex = 9;
            this.materialLabel1.Text = "Proveedor";
            // 
            // providerCombobox
            // 
            this.providerCombobox.FormattingEnabled = true;
            this.providerCombobox.Location = new System.Drawing.Point(338, 320);
            this.providerCombobox.Name = "providerCombobox";
            this.providerCombobox.Size = new System.Drawing.Size(224, 21);
            this.providerCombobox.TabIndex = 17;
            // 
            // AgregarButtom
            // 
            this.AgregarButtom.AutoSize = true;
            this.AgregarButtom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AgregarButtom.Depth = 0;
            this.AgregarButtom.Icon = null;
            this.AgregarButtom.Location = new System.Drawing.Point(372, 370);
            this.AgregarButtom.MouseState = MaterialSkin.MouseState.HOVER;
            this.AgregarButtom.Name = "AgregarButtom";
            this.AgregarButtom.Primary = true;
            this.AgregarButtom.Size = new System.Drawing.Size(83, 36);
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
            this.CancelarButtom.Location = new System.Drawing.Point(470, 370);
            this.CancelarButtom.MouseState = MaterialSkin.MouseState.HOVER;
            this.CancelarButtom.Name = "CancelarButtom";
            this.CancelarButtom.Primary = true;
            this.CancelarButtom.Size = new System.Drawing.Size(91, 36);
            this.CancelarButtom.TabIndex = 19;
            this.CancelarButtom.Text = "Cancelar";
            this.CancelarButtom.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 303);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(579, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CancelarButtom);
            this.Controls.Add(this.AgregarButtom);
            this.Controls.Add(this.providerCombobox);
            this.Controls.Add(this.NombreItem);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.CantidadItem);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.MaximizeBox = false;
            this.Name = "AddItem";
            this.Text = "Agregar Item";
            this.Load += new System.EventHandler(this.AddItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField NombreItem;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField CantidadItem;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ComboBox providerCombobox;
        private MaterialSkin.Controls.MaterialRaisedButton AgregarButtom;
        private MaterialSkin.Controls.MaterialRaisedButton CancelarButtom;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
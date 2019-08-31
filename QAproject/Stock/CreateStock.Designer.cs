namespace QAproject.Stock
{
    partial class CreateStock
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
            this.Btsave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TxtName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LbName = new MaterialSkin.Controls.MaterialLabel();
            this.LbCantidad = new MaterialSkin.Controls.MaterialLabel();
            this.NUDCantidad = new System.Windows.Forms.NumericUpDown();
            this.LBProveedor = new MaterialSkin.Controls.MaterialLabel();
            this.CBProveedor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // Btsave
            // 
            this.Btsave.AutoSize = true;
            this.Btsave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btsave.Depth = 0;
            this.Btsave.Icon = null;
            this.Btsave.Location = new System.Drawing.Point(262, 84);
            this.Btsave.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btsave.Name = "Btsave";
            this.Btsave.Primary = true;
            this.Btsave.Size = new System.Drawing.Size(84, 36);
            this.Btsave.TabIndex = 1;
            this.Btsave.Text = "Guardar";
            this.Btsave.UseVisualStyleBackColor = true;
            // 
            // TxtName
            // 
            this.TxtName.Depth = 0;
            this.TxtName.Hint = "";
            this.TxtName.Location = new System.Drawing.Point(12, 97);
            this.TxtName.MaxLength = 32767;
            this.TxtName.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtName.Name = "TxtName";
            this.TxtName.PasswordChar = '\0';
            this.TxtName.SelectedText = "";
            this.TxtName.SelectionLength = 0;
            this.TxtName.SelectionStart = 0;
            this.TxtName.Size = new System.Drawing.Size(159, 23);
            this.TxtName.TabIndex = 2;
            this.TxtName.TabStop = false;
            this.TxtName.UseSystemPasswordChar = false;
            // 
            // LbName
            // 
            this.LbName.AutoSize = true;
            this.LbName.Depth = 0;
            this.LbName.Font = new System.Drawing.Font("Roboto", 11F);
            this.LbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LbName.Location = new System.Drawing.Point(12, 75);
            this.LbName.MouseState = MaterialSkin.MouseState.HOVER;
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(63, 19);
            this.LbName.TabIndex = 3;
            this.LbName.Text = "Nombre";
            // 
            // LbCantidad
            // 
            this.LbCantidad.AutoSize = true;
            this.LbCantidad.Depth = 0;
            this.LbCantidad.Font = new System.Drawing.Font("Roboto", 11F);
            this.LbCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LbCantidad.Location = new System.Drawing.Point(12, 137);
            this.LbCantidad.MouseState = MaterialSkin.MouseState.HOVER;
            this.LbCantidad.Name = "LbCantidad";
            this.LbCantidad.Size = new System.Drawing.Size(68, 19);
            this.LbCantidad.TabIndex = 5;
            this.LbCantidad.Text = "Cantidad";
            // 
            // NUDCantidad
            // 
            this.NUDCantidad.Location = new System.Drawing.Point(12, 169);
            this.NUDCantidad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NUDCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDCantidad.Name = "NUDCantidad";
            this.NUDCantidad.Size = new System.Drawing.Size(120, 20);
            this.NUDCantidad.TabIndex = 6;
            this.NUDCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LBProveedor
            // 
            this.LBProveedor.AutoSize = true;
            this.LBProveedor.Depth = 0;
            this.LBProveedor.Font = new System.Drawing.Font("Roboto", 11F);
            this.LBProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LBProveedor.Location = new System.Drawing.Point(16, 219);
            this.LBProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.LBProveedor.Name = "LBProveedor";
            this.LBProveedor.Size = new System.Drawing.Size(78, 19);
            this.LBProveedor.TabIndex = 7;
            this.LBProveedor.Text = "Proovedor";
            // 
            // CBProveedor
            // 
            this.CBProveedor.FormattingEnabled = true;
            this.CBProveedor.Location = new System.Drawing.Point(12, 242);
            this.CBProveedor.Name = "CBProveedor";
            this.CBProveedor.Size = new System.Drawing.Size(121, 21);
            this.CBProveedor.TabIndex = 8;
            // 
            // CreateStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 450);
            this.Controls.Add(this.CBProveedor);
            this.Controls.Add(this.LBProveedor);
            this.Controls.Add(this.NUDCantidad);
            this.Controls.Add(this.LbCantidad);
            this.Controls.Add(this.LbName);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.Btsave);
            this.Name = "CreateStock";
            this.Text = "AddStock";
            this.Load += new System.EventHandler(this.AddStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUDCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton Btsave;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtName;
        private MaterialSkin.Controls.MaterialLabel LbName;
        private MaterialSkin.Controls.MaterialLabel LbCantidad;
        private System.Windows.Forms.NumericUpDown NUDCantidad;
        private MaterialSkin.Controls.MaterialLabel LBProveedor;
        private System.Windows.Forms.ComboBox CBProveedor;
    }
}
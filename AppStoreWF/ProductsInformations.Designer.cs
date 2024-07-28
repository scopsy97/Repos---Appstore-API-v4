namespace AppStoreWF
{
    partial class ProductsInformations
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
            lblProductsInfo = new Label();
            dgvProductsInfo = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProductsInfo).BeginInit();
            SuspendLayout();
            // 
            // lblProductsInfo
            // 
            lblProductsInfo.AutoSize = true;
            lblProductsInfo.Location = new Point(31, 35);
            lblProductsInfo.Name = "lblProductsInfo";
            lblProductsInfo.Size = new Size(120, 15);
            lblProductsInfo.TabIndex = 0;
            lblProductsInfo.Text = "Product Informations";
            lblProductsInfo.Click += lblProductsInfo_Click;
           
            // 
            // dgvProductsInfo
            // 
            dgvProductsInfo.AllowUserToAddRows = false;
            dgvProductsInfo.AllowUserToDeleteRows = false;
            dgvProductsInfo.AllowUserToResizeColumns = false;
            dgvProductsInfo.AllowUserToResizeRows = false;
            dgvProductsInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvProductsInfo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProductsInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductsInfo.Location = new Point(238, 79);
            dgvProductsInfo.MaximumSize = new Size(800, 500);
            dgvProductsInfo.Name = "dgvProductsInfo";
            dgvProductsInfo.ReadOnly = true;
            dgvProductsInfo.Size = new Size(299, 171);
            dgvProductsInfo.TabIndex = 1;
            dgvProductsInfo.DataBindingComplete += dgvProductsInfo_DataBindingComplete;
            // 
            // ProductsInformations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 686);
            Controls.Add(dgvProductsInfo);
            Controls.Add(lblProductsInfo);
            Name = "ProductsInformations";
            Text = "ProductsInformations";
            Load += ProductsInformations_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductsInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProductsInfo;
        private DataGridView dgvProductsInfo;
    }
}
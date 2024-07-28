namespace AppStoreWFApi
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
            lblProdName = new Label();
            lblProdRef = new Label();
            lblProdDesc = new Label();
            lblProdPrice = new Label();
            lblTNameProd = new Label();
            lblTProdRef = new Label();
            lblTProdDesc = new Label();
            lblTProdPrice = new Label();
            lblTCatName = new Label();
            lblCatName = new Label();
            dgvDetails = new DataGridView();
            btnDetails = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductsInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetails).BeginInit();
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
            dgvProductsInfo.Location = new Point(31, 70);
            dgvProductsInfo.MaximumSize = new Size(800, 500);
            dgvProductsInfo.Name = "dgvProductsInfo";
            dgvProductsInfo.ReadOnly = true;
            dgvProductsInfo.Size = new Size(775, 241);
            dgvProductsInfo.TabIndex = 1;
            dgvProductsInfo.RowHeaderMouseClick += dgvProductsInfo_RowHeaderMouseClick;
            // 
            // lblProdName
            // 
            lblProdName.AutoSize = true;
            lblProdName.Location = new Point(46, 409);
            lblProdName.Name = "lblProdName";
            lblProdName.Size = new Size(38, 15);
            lblProdName.TabIndex = 5;
            lblProdName.Text = "label1";
            // 
            // lblProdRef
            // 
            lblProdRef.AutoSize = true;
            lblProdRef.Location = new Point(224, 409);
            lblProdRef.Name = "lblProdRef";
            lblProdRef.Size = new Size(38, 15);
            lblProdRef.TabIndex = 6;
            lblProdRef.Text = "label2";
            // 
            // lblProdDesc
            // 
            lblProdDesc.AutoSize = true;
            lblProdDesc.Location = new Point(648, 409);
            lblProdDesc.Name = "lblProdDesc";
            lblProdDesc.Size = new Size(38, 15);
            lblProdDesc.TabIndex = 7;
            lblProdDesc.Text = "label3";
            // 
            // lblProdPrice
            // 
            lblProdPrice.AutoSize = true;
            lblProdPrice.Location = new Point(363, 409);
            lblProdPrice.Name = "lblProdPrice";
            lblProdPrice.Size = new Size(38, 15);
            lblProdPrice.TabIndex = 8;
            lblProdPrice.Text = "label4";
            // 
            // lblTNameProd
            // 
            lblTNameProd.AutoSize = true;
            lblTNameProd.Location = new Point(46, 374);
            lblTNameProd.Name = "lblTNameProd";
            lblTNameProd.Size = new Size(67, 15);
            lblTNameProd.TabIndex = 9;
            lblTNameProd.Text = "Name Prod";
            // 
            // lblTProdRef
            // 
            lblTProdRef.AutoSize = true;
            lblTProdRef.Location = new Point(200, 374);
            lblTProdRef.Name = "lblTProdRef";
            lblTProdRef.Size = new Size(104, 15);
            lblTProdRef.TabIndex = 10;
            lblTProdRef.Text = "Product Reference";
            // 
            // lblTProdDesc
            // 
            lblTProdDesc.AutoSize = true;
            lblTProdDesc.Location = new Point(648, 374);
            lblTProdDesc.Name = "lblTProdDesc";
            lblTProdDesc.Size = new Size(112, 15);
            lblTProdDesc.TabIndex = 11;
            lblTProdDesc.Text = "Product Description";
            // 
            // lblTProdPrice
            // 
            lblTProdPrice.AutoSize = true;
            lblTProdPrice.Location = new Point(348, 374);
            lblTProdPrice.Name = "lblTProdPrice";
            lblTProdPrice.Size = new Size(78, 15);
            lblTProdPrice.TabIndex = 12;
            lblTProdPrice.Text = "Product Price";
            // 
            // lblTCatName
            // 
            lblTCatName.AutoSize = true;
            lblTCatName.Location = new Point(500, 374);
            lblTCatName.Name = "lblTCatName";
            lblTCatName.Size = new Size(90, 15);
            lblTCatName.TabIndex = 13;
            lblTCatName.Text = "Category Name";
            // 
            // lblCatName
            // 
            lblCatName.AutoSize = true;
            lblCatName.Location = new Point(524, 409);
            lblCatName.Name = "lblCatName";
            lblCatName.Size = new Size(38, 15);
            lblCatName.TabIndex = 14;
            lblCatName.Text = "label5";
            // 
            // dgvDetails
            // 
            dgvDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetails.Location = new Point(31, 504);
            dgvDetails.Name = "dgvDetails";
            dgvDetails.Size = new Size(827, 150);
            dgvDetails.TabIndex = 15;
            // 
            // btnDetails
            // 
            btnDetails.Location = new Point(101, 456);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(75, 23);
            btnDetails.TabIndex = 16;
            btnDetails.Text = "Details";
            btnDetails.UseVisualStyleBackColor = true;
            btnDetails.Click += btnDetails_Click;
            // 
            // ProductsInformations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 809);
            Controls.Add(btnDetails);
            Controls.Add(dgvDetails);
            Controls.Add(lblCatName);
            Controls.Add(lblTCatName);
            Controls.Add(lblTProdPrice);
            Controls.Add(lblTProdDesc);
            Controls.Add(lblTProdRef);
            Controls.Add(lblTNameProd);
            Controls.Add(lblProdPrice);
            Controls.Add(lblProdDesc);
            Controls.Add(lblProdRef);
            Controls.Add(lblProdName);
            Controls.Add(dgvProductsInfo);
            Controls.Add(lblProductsInfo);
            Name = "ProductsInformations";
            Text = "ProductsInformations";
            Load += ProductsInformations_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductsInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProductsInfo;
        private DataGridView dgvProductsInfo;
        private Label lblProdName;
        private Label lblProdRef;
        private Label lblProdDesc;
        private Label lblProdPrice;
        private Label lblTNameProd;
        private Label lblTProdRef;
        private Label lblTProdDesc;
        private Label lblTProdPrice;
        private Label lblTCatName;
        private Label lblCatName;
        private DataGridView dgvDetails;
        private Button btnDetails;
    }
}
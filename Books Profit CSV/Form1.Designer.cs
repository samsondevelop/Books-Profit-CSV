namespace Books_Profit_CSV
{
    partial class Form1
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
            this.datagridBooks = new System.Windows.Forms.DataGridView();
            this.TextBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purchaser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCalcProfit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridBooks
            // 
            this.datagridBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TextBook,
            this.Subject,
            this.Seller,
            this.Purchaser,
            this.PurchasePrice,
            this.SalePrice,
            this.Profit});
            this.datagridBooks.Location = new System.Drawing.Point(28, 35);
            this.datagridBooks.Name = "datagridBooks";
            this.datagridBooks.Size = new System.Drawing.Size(745, 403);
            this.datagridBooks.TabIndex = 0;
            this.datagridBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridBooks_CellContentClick);
            // 
            // TextBook
            // 
            this.TextBook.HeaderText = "TextBook";
            this.TextBook.Name = "TextBook";
            // 
            // Subject
            // 
            this.Subject.HeaderText = "Subject";
            this.Subject.Name = "Subject";
            // 
            // Seller
            // 
            this.Seller.HeaderText = "Seller";
            this.Seller.Name = "Seller";
            // 
            // Purchaser
            // 
            this.Purchaser.HeaderText = "Purchaser";
            this.Purchaser.Name = "Purchaser";
            // 
            // PurchasePrice
            // 
            this.PurchasePrice.HeaderText = "Purchase Price";
            this.PurchasePrice.Name = "PurchasePrice";
            // 
            // SalePrice
            // 
            this.SalePrice.HeaderText = "Sale Price";
            this.SalePrice.Name = "SalePrice";
            // 
            // Profit
            // 
            this.Profit.HeaderText = "Profit";
            this.Profit.Name = "Profit";
            // 
            // btnCalcProfit
            // 
            this.btnCalcProfit.Location = new System.Drawing.Point(28, 6);
            this.btnCalcProfit.Name = "btnCalcProfit";
            this.btnCalcProfit.Size = new System.Drawing.Size(138, 23);
            this.btnCalcProfit.TabIndex = 1;
            this.btnCalcProfit.Text = "Calculate Profit";
            this.btnCalcProfit.UseVisualStyleBackColor = true;
            this.btnCalcProfit.Click += new System.EventHandler(this.btnCalcProfit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcProfit);
            this.Controls.Add(this.datagridBooks);
            this.Name = "Form1";
            this.Text = "TextBooks";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn TextBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seller;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purchaser;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;
        private System.Windows.Forms.Button btnCalcProfit;
    }
}


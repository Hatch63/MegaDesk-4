namespace MegaDesk
{
    partial class SearchQuotes
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
            this.label1 = new System.Windows.Forms.Label();
            this.SCancelBtn = new System.Windows.Forms.Button();
            this.gridSearchQuotes = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridDepth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drawers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurfaceMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShippingType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuoteTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.com_SearchBox = new System.Windows.Forms.ComboBox();
            this.Search = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridSearchQuotes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Quotes Form";
            // 
            // SCancelBtn
            // 
            this.SCancelBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.SCancelBtn.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SCancelBtn.Location = new System.Drawing.Point(289, 400);
            this.SCancelBtn.Name = "SCancelBtn";
            this.SCancelBtn.Size = new System.Drawing.Size(262, 38);
            this.SCancelBtn.TabIndex = 8;
            this.SCancelBtn.Text = "Return to Menu";
            this.SCancelBtn.UseVisualStyleBackColor = false;
            this.SCancelBtn.Click += new System.EventHandler(this.SCancelBtn_Click);
            // 
            // gridSearchQuotes
            // 
            this.gridSearchQuotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSearchQuotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSearchQuotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Customer,
            this.GridDepth,
            this.GridWidth,
            this.Drawers,
            this.SurfaceMaterial,
            this.ShippingType,
            this.QuoteTotal});
            this.gridSearchQuotes.Location = new System.Drawing.Point(12, 117);
            this.gridSearchQuotes.Name = "gridSearchQuotes";
            this.gridSearchQuotes.Size = new System.Drawing.Size(776, 244);
            this.gridSearchQuotes.TabIndex = 9;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Customer
            // 
            this.Customer.HeaderText = "Customer";
            this.Customer.Name = "Customer";
            // 
            // GridDepth
            // 
            this.GridDepth.HeaderText = "Depth";
            this.GridDepth.Name = "GridDepth";
            // 
            // GridWidth
            // 
            this.GridWidth.HeaderText = "Width";
            this.GridWidth.Name = "GridWidth";
            // 
            // Drawers
            // 
            this.Drawers.HeaderText = "Drawers";
            this.Drawers.Name = "Drawers";
            // 
            // SurfaceMaterial
            // 
            this.SurfaceMaterial.HeaderText = "Surface Material";
            this.SurfaceMaterial.Name = "SurfaceMaterial";
            // 
            // ShippingType
            // 
            this.ShippingType.HeaderText = "Shipping Type";
            this.ShippingType.Name = "ShippingType";
            // 
            // QuoteTotal
            // 
            this.QuoteTotal.HeaderText = "Quote Total";
            this.QuoteTotal.Name = "QuoteTotal";
            // 
            // com_SearchBox
            // 
            this.com_SearchBox.FormattingEnabled = true;
            this.com_SearchBox.Location = new System.Drawing.Point(180, 70);
            this.com_SearchBox.Name = "com_SearchBox";
            this.com_SearchBox.Size = new System.Drawing.Size(423, 21);
            this.com_SearchBox.TabIndex = 10;
            this.com_SearchBox.SelectedIndexChanged += new System.EventHandler(this.com_SearchBox_SelectedIndexChanged);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Location = new System.Drawing.Point(118, 70);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(41, 13);
            this.Search.TabIndex = 11;
            this.Search.Text = "Search";
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.com_SearchBox);
            this.Controls.Add(this.gridSearchQuotes);
            this.Controls.Add(this.SCancelBtn);
            this.Controls.Add(this.label1);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            ((System.ComponentModel.ISupportInitialize)(this.gridSearchQuotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SCancelBtn;
        private System.Windows.Forms.DataGridView gridSearchQuotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridDepth;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drawers;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurfaceMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShippingType;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuoteTotal;
        private System.Windows.Forms.ComboBox com_SearchBox;
        private System.Windows.Forms.Label Search;
    }
}
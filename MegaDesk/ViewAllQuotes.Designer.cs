namespace MegaDesk
{
    partial class ViewAllQuotes
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
            this.gridAllQuotes = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridDepth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drawers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurfaceMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShippingType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuoteTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewAllCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridAllQuotes)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAllQuotes
            // 
            this.gridAllQuotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridAllQuotes.BackgroundColor = System.Drawing.Color.LightGray;
            this.gridAllQuotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAllQuotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Customer,
            this.GridDepth,
            this.GridWidth,
            this.Drawers,
            this.SurfaceMaterial,
            this.ShippingType,
            this.QuoteTotal});
            this.gridAllQuotes.Location = new System.Drawing.Point(0, 1);
            this.gridAllQuotes.Name = "gridAllQuotes";
            this.gridAllQuotes.Size = new System.Drawing.Size(806, 384);
            this.gridAllQuotes.TabIndex = 0;
            this.gridAllQuotes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAllQuotes_CellContentClick);
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
            // viewAllCancel
            // 
            this.viewAllCancel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.viewAllCancel.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllCancel.Location = new System.Drawing.Point(295, 391);
            this.viewAllCancel.Name = "viewAllCancel";
            this.viewAllCancel.Size = new System.Drawing.Size(279, 47);
            this.viewAllCancel.TabIndex = 6;
            this.viewAllCancel.Text = "Return to Menu";
            this.viewAllCancel.UseVisualStyleBackColor = false;
            this.viewAllCancel.Click += new System.EventHandler(this.CancelViewButton_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewAllCancel);
            this.Controls.Add(this.gridAllQuotes);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            ((System.ComponentModel.ISupportInitialize)(this.gridAllQuotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridAllQuotes;
        private System.Windows.Forms.Button viewAllCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridDepth;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drawers;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurfaceMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShippingType;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuoteTotal;
    }
}
namespace MegaDesk
{
    partial class AddForm
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
            this.AddCancelBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.widthBox = new System.Windows.Forms.NumericUpDown();
            this.depthBox = new System.Windows.Forms.NumericUpDown();
            this.box_Materials = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.num_Drawers = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.box_Shipping = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_CustomerName = new System.Windows.Forms.TextBox();
            this.btn_GetQuote = new System.Windows.Forms.Button();
            this.QuoteLabel = new System.Windows.Forms.Label();
            this.box_QuoteAmount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.widthBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Drawers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the Add Quote Form";
            // 
            // AddCancelBtn
            // 
            this.AddCancelBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.AddCancelBtn.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCancelBtn.Location = new System.Drawing.Point(444, 331);
            this.AddCancelBtn.Name = "AddCancelBtn";
            this.AddCancelBtn.Size = new System.Drawing.Size(242, 70);
            this.AddCancelBtn.TabIndex = 5;
            this.AddCancelBtn.Text = "Cancel";
            this.AddCancelBtn.UseVisualStyleBackColor = false;
            this.AddCancelBtn.Click += new System.EventHandler(this.AddCancelButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "What is the desired width of the desk?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "What is the desired depth of the desk?";
            // 
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(99, 131);
            this.widthBox.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.widthBox.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(120, 20);
            this.widthBox.TabIndex = 18;
            this.widthBox.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // depthBox
            // 
            this.depthBox.Location = new System.Drawing.Point(99, 199);
            this.depthBox.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.depthBox.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.depthBox.Name = "depthBox";
            this.depthBox.Size = new System.Drawing.Size(120, 20);
            this.depthBox.TabIndex = 19;
            this.depthBox.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // box_Materials
            // 
            this.box_Materials.FormattingEnabled = true;
            this.box_Materials.Location = new System.Drawing.Point(585, 149);
            this.box_Materials.Name = "box_Materials";
            this.box_Materials.Size = new System.Drawing.Size(121, 21);
            this.box_Materials.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(508, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Material Type";
            // 
            // num_Drawers
            // 
            this.num_Drawers.Location = new System.Drawing.Point(585, 101);
            this.num_Drawers.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.num_Drawers.Name = "num_Drawers";
            this.num_Drawers.Size = new System.Drawing.Size(120, 20);
            this.num_Drawers.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(481, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Number of Drawers";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(492, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Shipping Options";
            // 
            // box_Shipping
            // 
            this.box_Shipping.FormattingEnabled = true;
            this.box_Shipping.Location = new System.Drawing.Point(585, 192);
            this.box_Shipping.Name = "box_Shipping";
            this.box_Shipping.Size = new System.Drawing.Size(121, 21);
            this.box_Shipping.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(146, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Customer Name";
            // 
            // txt_CustomerName
            // 
            this.txt_CustomerName.Location = new System.Drawing.Point(245, 66);
            this.txt_CustomerName.Name = "txt_CustomerName";
            this.txt_CustomerName.Size = new System.Drawing.Size(324, 20);
            this.txt_CustomerName.TabIndex = 27;
            // 
            // btn_GetQuote
            // 
            this.btn_GetQuote.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_GetQuote.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GetQuote.Location = new System.Drawing.Point(183, 331);
            this.btn_GetQuote.Name = "btn_GetQuote";
            this.btn_GetQuote.Size = new System.Drawing.Size(242, 70);
            this.btn_GetQuote.TabIndex = 28;
            this.btn_GetQuote.Text = "Get Quote";
            this.btn_GetQuote.UseVisualStyleBackColor = false;
            this.btn_GetQuote.Click += new System.EventHandler(this.calculateQuote_click);
            // 
            // QuoteLabel
            // 
            this.QuoteLabel.AutoSize = true;
            this.QuoteLabel.Location = new System.Drawing.Point(368, 246);
            this.QuoteLabel.Name = "QuoteLabel";
            this.QuoteLabel.Size = new System.Drawing.Size(75, 13);
            this.QuoteLabel.TabIndex = 29;
            this.QuoteLabel.Text = "Quote Amount";
            // 
            // box_QuoteAmount
            // 
            this.box_QuoteAmount.Location = new System.Drawing.Point(245, 262);
            this.box_QuoteAmount.Name = "box_QuoteAmount";
            this.box_QuoteAmount.Size = new System.Drawing.Size(324, 20);
            this.box_QuoteAmount.TabIndex = 30;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.box_QuoteAmount);
            this.Controls.Add(this.QuoteLabel);
            this.Controls.Add(this.btn_GetQuote);
            this.Controls.Add(this.txt_CustomerName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.box_Shipping);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.num_Drawers);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.box_Materials);
            this.Controls.Add(this.depthBox);
            this.Controls.Add(this.widthBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddCancelBtn);
            this.Controls.Add(this.label1);
            this.Name = "AddForm";
            this.Text = "AddQuote";
            ((System.ComponentModel.ISupportInitialize)(this.widthBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Drawers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddCancelBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown widthBox;
        private System.Windows.Forms.NumericUpDown depthBox;
        private System.Windows.Forms.ComboBox box_Materials;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown num_Drawers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox box_Shipping;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_CustomerName;
        private System.Windows.Forms.Button btn_GetQuote;
        private System.Windows.Forms.Label QuoteLabel;
        private System.Windows.Forms.TextBox box_QuoteAmount;
    }
}
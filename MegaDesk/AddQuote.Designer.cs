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
            this.surfaceAreBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.calcSurfaceArea = new System.Windows.Forms.Button();
            this.widthBox = new System.Windows.Forms.NumericUpDown();
            this.depthBox = new System.Windows.Forms.NumericUpDown();
            this.box_Materials = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.box_Shipping = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.widthBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.AddCancelBtn.Location = new System.Drawing.Point(288, 342);
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
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "What is the desired width of the desk?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "What is the desired depth of the desk?";
            // 
            // surfaceAreBox
            // 
            this.surfaceAreBox.Location = new System.Drawing.Point(72, 207);
            this.surfaceAreBox.Name = "surfaceAreBox";
            this.surfaceAreBox.Size = new System.Drawing.Size(124, 20);
            this.surfaceAreBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(69, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Total Surface Area";
            // 
            // calcSurfaceArea
            // 
            this.calcSurfaceArea.Location = new System.Drawing.Point(95, 233);
            this.calcSurfaceArea.Name = "calcSurfaceArea";
            this.calcSurfaceArea.Size = new System.Drawing.Size(75, 23);
            this.calcSurfaceArea.TabIndex = 15;
            this.calcSurfaceArea.Text = "Calculate";
            this.calcSurfaceArea.UseVisualStyleBackColor = true;
            this.calcSurfaceArea.Click += new System.EventHandler(this.calculateSurfaceArea_Click);
            // 
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(76, 80);
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
            this.widthBox.Validating += new System.ComponentModel.CancelEventHandler(this.widthBox_Validating);
            // 
            // depthBox
            // 
            this.depthBox.Location = new System.Drawing.Point(76, 148);
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
            this.depthBox.Validating += new System.ComponentModel.CancelEventHandler(this.depthBox_Validating);
            // 
            // box_Materials
            // 
            this.box_Materials.FormattingEnabled = true;
            this.box_Materials.Items.AddRange(new object[] {
            "oak",
            "laminate",
            "pine",
            "rosewood",
            "veneer"});
            this.box_Materials.Location = new System.Drawing.Point(585, 57);
            this.box_Materials.Name = "box_Materials";
            this.box_Materials.Size = new System.Drawing.Size(121, 21);
            this.box_Materials.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(508, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Material Type";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(585, 101);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 22;
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
            this.label9.Location = new System.Drawing.Point(492, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Shipping Options";
            // 
            // box_Shipping
            // 
            this.box_Shipping.FormattingEnabled = true;
            this.box_Shipping.Items.AddRange(new object[] {
            "3",
            "5",
            "7",
            "Normal"});
            this.box_Shipping.Location = new System.Drawing.Point(584, 164);
            this.box_Shipping.Name = "box_Shipping";
            this.box_Shipping.Size = new System.Drawing.Size(121, 21);
            this.box_Shipping.TabIndex = 25;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.box_Shipping);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.box_Materials);
            this.Controls.Add(this.depthBox);
            this.Controls.Add(this.widthBox);
            this.Controls.Add(this.calcSurfaceArea);
            this.Controls.Add(this.surfaceAreBox);
            this.Controls.Add(this.label7);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.TextBox surfaceAreBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button calcSurfaceArea;
        private System.Windows.Forms.NumericUpDown widthBox;
        private System.Windows.Forms.NumericUpDown depthBox;
        private System.Windows.Forms.ComboBox box_Materials;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox box_Shipping;
    }
}
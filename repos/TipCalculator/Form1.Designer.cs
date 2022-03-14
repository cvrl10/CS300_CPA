namespace TipCalculator
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblTipPercentage = new System.Windows.Forms.Label();
            this.lblTipAmount = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.txtTipPercentage = new System.Windows.Forms.TextBox();
            this.btnCalculateTip = new System.Windows.Forms.Button();
            this.butClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalAmount.Location = new System.Drawing.Point(48, 40);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(167, 31);
            this.lblTotalAmount.TabIndex = 0;
            this.lblTotalAmount.Text = "Total Amount:";
            this.lblTotalAmount.UseWaitCursor = true;
            // 
            // lblTipPercentage
            // 
            this.lblTipPercentage.AutoSize = true;
            this.lblTipPercentage.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTipPercentage.Location = new System.Drawing.Point(37, 86);
            this.lblTipPercentage.Name = "lblTipPercentage";
            this.lblTipPercentage.Size = new System.Drawing.Size(178, 31);
            this.lblTipPercentage.TabIndex = 1;
            this.lblTipPercentage.Text = "Tip Percentage ";
            this.lblTipPercentage.UseWaitCursor = true;
            // 
            // lblTipAmount
            // 
            this.lblTipAmount.AutoSize = true;
            this.lblTipAmount.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTipAmount.Location = new System.Drawing.Point(472, 176);
            this.lblTipAmount.Name = "lblTipAmount";
            this.lblTipAmount.Size = new System.Drawing.Size(148, 31);
            this.lblTipAmount.TabIndex = 2;
            this.lblTipAmount.Text = "Tip Amount ";
            this.lblTipAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTipAmount.UseWaitCursor = true;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalAmount.Location = new System.Drawing.Point(221, 40);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.PlaceholderText = "Enter total amount ";
            this.txtTotalAmount.Size = new System.Drawing.Size(201, 38);
            this.txtTotalAmount.TabIndex = 3;
            this.txtTotalAmount.UseWaitCursor = true;
            this.txtTotalAmount.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTipPercentage
            // 
            this.txtTipPercentage.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTipPercentage.Location = new System.Drawing.Point(221, 79);
            this.txtTipPercentage.Name = "txtTipPercentage";
            this.txtTipPercentage.PlaceholderText = "Enter the tip percentage ";
            this.txtTipPercentage.Size = new System.Drawing.Size(260, 38);
            this.txtTipPercentage.TabIndex = 4;
            this.txtTipPercentage.Text = "15";
            this.txtTipPercentage.UseWaitCursor = true;
            // 
            // btnCalculateTip
            // 
            this.btnCalculateTip.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalculateTip.Location = new System.Drawing.Point(79, 152);
            this.btnCalculateTip.Name = "btnCalculateTip";
            this.btnCalculateTip.Size = new System.Drawing.Size(136, 78);
            this.btnCalculateTip.TabIndex = 5;
            this.btnCalculateTip.Text = "Calculate Tip";
            this.btnCalculateTip.UseVisualStyleBackColor = true;
            this.btnCalculateTip.UseWaitCursor = true;
            this.btnCalculateTip.Click += new System.EventHandler(this.btnCalculateTip_Click);
            // 
            // butClear
            // 
            this.butClear.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butClear.Location = new System.Drawing.Point(286, 152);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(136, 78);
            this.butClear.TabIndex = 6;
            this.butClear.Text = "Clear";
            this.butClear.UseVisualStyleBackColor = true;
            this.butClear.UseWaitCursor = true;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 354);
            this.Controls.Add(this.butClear);
            this.Controls.Add(this.btnCalculateTip);
            this.Controls.Add(this.txtTipPercentage);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.lblTipAmount);
            this.Controls.Add(this.lblTipPercentage);
            this.Controls.Add(this.lblTotalAmount);
            this.Name = "frmMain";
            this.Text = " ";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTotalAmount;
        private Label lblTipPercentage;
        private Label lblTipAmount;
        private TextBox txtTotalAmount;
        private TextBox txtTipPercentage;
        private Button btnCalculateTip;
        private Button butClear;
    }
}
namespace TipCalculator
{
    partial class frmTipCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipCalculator));
            this.btnCalcTip = new System.Windows.Forms.Button();
            this.lbl15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl15PecentTotal = new System.Windows.Forms.Label();
            this.lbl20PecentTotal = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.rad15Percent = new System.Windows.Forms.RadioButton();
            this.rad20Percent = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTipAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcTip
            // 
            this.btnCalcTip.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCalcTip.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcTip.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCalcTip.Location = new System.Drawing.Point(40, 156);
            this.btnCalcTip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCalcTip.Name = "btnCalcTip";
            this.btnCalcTip.Size = new System.Drawing.Size(100, 33);
            this.btnCalcTip.TabIndex = 0;
            this.btnCalcTip.Text = "Calculate Tip";
            this.btnCalcTip.UseVisualStyleBackColor = false;
            this.btnCalcTip.Click += new System.EventHandler(this.btnCalcTip_Click);
            // 
            // lbl15
            // 
            this.lbl15.AutoSize = true;
            this.lbl15.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl15.Location = new System.Drawing.Point(222, 34);
            this.lbl15.Name = "lbl15";
            this.lbl15.Size = new System.Drawing.Size(56, 16);
            this.lbl15.TabIndex = 1;
            this.lbl15.Text = "15% Tip";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "20% Tip";
            // 
            // lbl15PecentTotal
            // 
            this.lbl15PecentTotal.AutoSize = true;
            this.lbl15PecentTotal.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl15PecentTotal.Location = new System.Drawing.Point(222, 50);
            this.lbl15PecentTotal.Name = "lbl15PecentTotal";
            this.lbl15PecentTotal.Size = new System.Drawing.Size(62, 25);
            this.lbl15PecentTotal.TabIndex = 3;
            this.lbl15PecentTotal.Text = "$0.00";
            // 
            // lbl20PecentTotal
            // 
            this.lbl20PecentTotal.AutoSize = true;
            this.lbl20PecentTotal.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl20PecentTotal.Location = new System.Drawing.Point(222, 112);
            this.lbl20PecentTotal.Name = "lbl20PecentTotal";
            this.lbl20PecentTotal.Size = new System.Drawing.Size(62, 25);
            this.lbl20PecentTotal.TabIndex = 4;
            this.lbl20PecentTotal.Text = "$0.00";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(40, 34);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(72, 16);
            this.lblAmount.TabIndex = 5;
            this.lblAmount.Text = "Bill Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(40, 52);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 23);
            this.txtAmount.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(222, 172);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(62, 25);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "$0.00";
            // 
            // rad15Percent
            // 
            this.rad15Percent.AutoSize = true;
            this.rad15Percent.Location = new System.Drawing.Point(40, 115);
            this.rad15Percent.Name = "rad15Percent";
            this.rad15Percent.Size = new System.Drawing.Size(52, 20);
            this.rad15Percent.TabIndex = 9;
            this.rad15Percent.TabStop = true;
            this.rad15Percent.Text = "15%";
            this.rad15Percent.UseVisualStyleBackColor = true;
            // 
            // rad20Percent
            // 
            this.rad20Percent.AutoSize = true;
            this.rad20Percent.Location = new System.Drawing.Point(107, 115);
            this.rad20Percent.Name = "rad20Percent";
            this.rad20Percent.Size = new System.Drawing.Size(52, 20);
            this.rad20Percent.TabIndex = 10;
            this.rad20Percent.TabStop = true;
            this.rad20Percent.Text = "20%";
            this.rad20Percent.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.Location = new System.Drawing.Point(59, 236);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 33);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Location = new System.Drawing.Point(178, 236);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 33);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTipAmount
            // 
            this.lblTipAmount.AutoSize = true;
            this.lblTipAmount.Location = new System.Drawing.Point(40, 95);
            this.lblTipAmount.Name = "lblTipAmount";
            this.lblTipAmount.Size = new System.Drawing.Size(74, 16);
            this.lblTipAmount.TabIndex = 13;
            this.lblTipAmount.Text = "Tip Amount";
            // 
            // frmTipCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(334, 296);
            this.Controls.Add(this.lblTipAmount);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.rad20Percent);
            this.Controls.Add(this.rad15Percent);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lbl20PecentTotal);
            this.Controls.Add(this.lbl15PecentTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl15);
            this.Controls.Add(this.btnCalcTip);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTipCalculator";
            this.Text = "Tip Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcTip;
        private System.Windows.Forms.Label lbl15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl15PecentTotal;
        private System.Windows.Forms.Label lbl20PecentTotal;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.RadioButton rad15Percent;
        private System.Windows.Forms.RadioButton rad20Percent;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTipAmount;
    }
}


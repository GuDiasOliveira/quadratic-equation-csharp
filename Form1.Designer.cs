namespace QuadraticEquation
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
            this.TxtA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtC = new System.Windows.Forms.TextBox();
            this.LblRes = new System.Windows.Forms.Label();
            this.BCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtA
            // 
            this.TxtA.Location = new System.Drawing.Point(14, 17);
            this.TxtA.Name = "TxtA";
            this.TxtA.Size = new System.Drawing.Size(47, 20);
            this.TxtA.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "x² + ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "x + ";
            // 
            // TxtB
            // 
            this.TxtB.Location = new System.Drawing.Point(100, 17);
            this.TxtB.Name = "TxtB";
            this.TxtB.Size = new System.Drawing.Size(47, 20);
            this.TxtB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = " = 0";
            // 
            // TxtC
            // 
            this.TxtC.Location = new System.Drawing.Point(186, 17);
            this.TxtC.Name = "TxtC";
            this.TxtC.Size = new System.Drawing.Size(47, 20);
            this.TxtC.TabIndex = 4;
            // 
            // LblRes
            // 
            this.LblRes.AutoSize = true;
            this.LblRes.Location = new System.Drawing.Point(12, 68);
            this.LblRes.Name = "LblRes";
            this.LblRes.Size = new System.Drawing.Size(100, 13);
            this.LblRes.TabIndex = 6;
            this.LblRes.Text = "Δ=?    X1=?    X2=?";
            // 
            // BCalc
            // 
            this.BCalc.Location = new System.Drawing.Point(303, 19);
            this.BCalc.Name = "BCalc";
            this.BCalc.Size = new System.Drawing.Size(75, 23);
            this.BCalc.TabIndex = 7;
            this.BCalc.Text = "Calculate";
            this.BCalc.UseVisualStyleBackColor = true;
            this.BCalc.Click += new System.EventHandler(this.BCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 100);
            this.Controls.Add(this.BCalc);
            this.Controls.Add(this.LblRes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Quadratic equation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtC;
        private System.Windows.Forms.Label LblRes;
        private System.Windows.Forms.Button BCalc;
    }
}


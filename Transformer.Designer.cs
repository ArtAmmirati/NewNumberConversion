namespace NumTransformer
{
    partial class numberTransformer
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
            this.romanTransformerBTN = new System.Windows.Forms.Button();
            this.arabicTransformerBTN = new System.Windows.Forms.Button();
            this.inArabicNumTB = new System.Windows.Forms.TextBox();
            this.inRomanNumTB = new System.Windows.Forms.TextBox();
            this.arabicLB = new System.Windows.Forms.Label();
            this.romanLB = new System.Windows.Forms.Label();
            this.outRomanNumLB = new System.Windows.Forms.Label();
            this.outArabicNumLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // romanTransformerBTN
            // 
            this.romanTransformerBTN.Location = new System.Drawing.Point(45, 172);
            this.romanTransformerBTN.Margin = new System.Windows.Forms.Padding(4);
            this.romanTransformerBTN.Name = "romanTransformerBTN";
            this.romanTransformerBTN.Size = new System.Drawing.Size(225, 130);
            this.romanTransformerBTN.TabIndex = 0;
            this.romanTransformerBTN.Text = "Convert to Roman";
            this.romanTransformerBTN.UseVisualStyleBackColor = true;
            this.romanTransformerBTN.Click += new System.EventHandler(this.romanTransformerBTN_Click);
            // 
            // arabicTransformerBTN
            // 
            this.arabicTransformerBTN.Location = new System.Drawing.Point(460, 172);
            this.arabicTransformerBTN.Margin = new System.Windows.Forms.Padding(4);
            this.arabicTransformerBTN.Name = "arabicTransformerBTN";
            this.arabicTransformerBTN.Size = new System.Drawing.Size(225, 130);
            this.arabicTransformerBTN.TabIndex = 1;
            this.arabicTransformerBTN.Text = "Convert to Arabic";
            this.arabicTransformerBTN.UseVisualStyleBackColor = true;
            this.arabicTransformerBTN.Click += new System.EventHandler(this.arabicTransformerBTN_Click);
            // 
            // inArabicNumTB
            // 
            this.inArabicNumTB.Location = new System.Drawing.Point(45, 105);
            this.inArabicNumTB.Margin = new System.Windows.Forms.Padding(4);
            this.inArabicNumTB.Name = "inArabicNumTB";
            this.inArabicNumTB.Size = new System.Drawing.Size(224, 22);
            this.inArabicNumTB.TabIndex = 2;
            this.inArabicNumTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inRomanNumTB
            // 
            this.inRomanNumTB.Location = new System.Drawing.Point(460, 105);
            this.inRomanNumTB.Margin = new System.Windows.Forms.Padding(4);
            this.inRomanNumTB.Name = "inRomanNumTB";
            this.inRomanNumTB.Size = new System.Drawing.Size(224, 22);
            this.inRomanNumTB.TabIndex = 3;
            this.inRomanNumTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // arabicLB
            // 
            this.arabicLB.AutoSize = true;
            this.arabicLB.Location = new System.Drawing.Point(41, 46);
            this.arabicLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.arabicLB.Name = "arabicLB";
            this.arabicLB.Size = new System.Drawing.Size(50, 16);
            this.arabicLB.TabIndex = 4;
            this.arabicLB.Text = "Arabic:";
            // 
            // romanLB
            // 
            this.romanLB.AutoSize = true;
            this.romanLB.Location = new System.Drawing.Point(456, 46);
            this.romanLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.romanLB.Name = "romanLB";
            this.romanLB.Size = new System.Drawing.Size(55, 16);
            this.romanLB.TabIndex = 5;
            this.romanLB.Text = "Roman:";
            // 
            // outRomanNumLB
            // 
            this.outRomanNumLB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.outRomanNumLB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outRomanNumLB.Location = new System.Drawing.Point(45, 346);
            this.outRomanNumLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outRomanNumLB.Name = "outRomanNumLB";
            this.outRomanNumLB.Size = new System.Drawing.Size(225, 28);
            this.outRomanNumLB.TabIndex = 6;
            this.outRomanNumLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outArabicNumLB
            // 
            this.outArabicNumLB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.outArabicNumLB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outArabicNumLB.Location = new System.Drawing.Point(460, 346);
            this.outArabicNumLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outArabicNumLB.Name = "outArabicNumLB";
            this.outArabicNumLB.Size = new System.Drawing.Size(225, 28);
            this.outArabicNumLB.TabIndex = 7;
            this.outArabicNumLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberTransformer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 497);
            this.Controls.Add(this.outArabicNumLB);
            this.Controls.Add(this.outRomanNumLB);
            this.Controls.Add(this.romanLB);
            this.Controls.Add(this.arabicLB);
            this.Controls.Add(this.inRomanNumTB);
            this.Controls.Add(this.inArabicNumTB);
            this.Controls.Add(this.arabicTransformerBTN);
            this.Controls.Add(this.romanTransformerBTN);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "numberTransformer";
            this.Text = "Number Transformer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button romanTransformerBTN;
        private System.Windows.Forms.Button arabicTransformerBTN;
        private System.Windows.Forms.TextBox inArabicNumTB;
        private System.Windows.Forms.TextBox inRomanNumTB;
        private System.Windows.Forms.Label arabicLB;
        private System.Windows.Forms.Label romanLB;
        private System.Windows.Forms.Label outRomanNumLB;
        private System.Windows.Forms.Label outArabicNumLB;
    }
}


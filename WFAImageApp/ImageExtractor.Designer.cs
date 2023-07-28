namespace WFAImageApp
{
    partial class ImageExtractor
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
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_Proceed = new System.Windows.Forms.Button();
            this.tb_ThreshSize = new System.Windows.Forms.TextBox();
            this.tb_Size = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.tb_From = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Browse2 = new System.Windows.Forms.Button();
            this.tb_To = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_Amount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Max:";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 223);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // btn_Proceed
            // 
            this.btn_Proceed.Location = new System.Drawing.Point(431, 223);
            this.btn_Proceed.Name = "btn_Proceed";
            this.btn_Proceed.Size = new System.Drawing.Size(75, 23);
            this.btn_Proceed.TabIndex = 2;
            this.btn_Proceed.Text = "Proceed";
            this.btn_Proceed.UseVisualStyleBackColor = true;
            this.btn_Proceed.Click += new System.EventHandler(this.btn_Proceed_Click);
            // 
            // tb_ThreshSize
            // 
            this.tb_ThreshSize.Location = new System.Drawing.Point(75, 149);
            this.tb_ThreshSize.Name = "tb_ThreshSize";
            this.tb_ThreshSize.Size = new System.Drawing.Size(100, 20);
            this.tb_ThreshSize.TabIndex = 3;
            // 
            // tb_Size
            // 
            this.tb_Size.Location = new System.Drawing.Point(75, 97);
            this.tb_Size.Name = "tb_Size";
            this.tb_Size.Size = new System.Drawing.Size(100, 20);
            this.tb_Size.TabIndex = 7;
            this.tb_Size.TextChanged += new System.EventHandler(this.tb_Size_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Size";
            // 
            // btn_Browse
            // 
            this.btn_Browse.Location = new System.Drawing.Point(153, 11);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(80, 23);
            this.btn_Browse.TabIndex = 14;
            this.btn_Browse.Text = "Browse...";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // tb_From
            // 
            this.tb_From.Location = new System.Drawing.Point(55, 12);
            this.tb_From.Name = "tb_From";
            this.tb_From.Size = new System.Drawing.Size(92, 20);
            this.tb_From.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Folder:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "To:";
            // 
            // btn_Browse2
            // 
            this.btn_Browse2.Location = new System.Drawing.Point(426, 11);
            this.btn_Browse2.Name = "btn_Browse2";
            this.btn_Browse2.Size = new System.Drawing.Size(80, 23);
            this.btn_Browse2.TabIndex = 18;
            this.btn_Browse2.Text = "Browse...";
            this.btn_Browse2.UseVisualStyleBackColor = true;
            this.btn_Browse2.Click += new System.EventHandler(this.btn_Browse2_Click);
            // 
            // tb_To
            // 
            this.tb_To.Location = new System.Drawing.Point(328, 12);
            this.tb_To.Name = "tb_To";
            this.tb_To.Size = new System.Drawing.Size(92, 20);
            this.tb_To.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(282, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Folder:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "KB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "KB";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Min:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(285, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Amount:";
            // 
            // tb_Amount
            // 
            this.tb_Amount.Location = new System.Drawing.Point(328, 97);
            this.tb_Amount.Name = "tb_Amount";
            this.tb_Amount.Size = new System.Drawing.Size(100, 20);
            this.tb_Amount.TabIndex = 22;
            // 
            // ImageExtractor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 254);
            this.Controls.Add(this.tb_Amount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Browse2);
            this.Controls.Add(this.tb_To);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.tb_From);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_Size);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_ThreshSize);
            this.Controls.Add(this.btn_Proceed);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label1);
            this.Name = "ImageExtractor";
            this.Text = "ImageExtractor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_Proceed;
        private System.Windows.Forms.TextBox tb_ThreshSize;
        private System.Windows.Forms.TextBox tb_Size;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.TextBox tb_From;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Browse2;
        private System.Windows.Forms.TextBox tb_To;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_Amount;
    }
}
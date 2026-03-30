namespace Test_5
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
            this.btnAntoin = new System.Windows.Forms.Button();
            this.btnDean = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAntoin
            // 
            this.btnAntoin.Location = new System.Drawing.Point(180, 135);
            this.btnAntoin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAntoin.Name = "btnAntoin";
            this.btnAntoin.Size = new System.Drawing.Size(100, 28);
            this.btnAntoin.TabIndex = 0;
            this.btnAntoin.Text = "Antoin";
            this.btnAntoin.UseVisualStyleBackColor = true;
            // 
            // btnDean
            // 
            this.btnDean.Location = new System.Drawing.Point(483, 263);
            this.btnDean.Margin = new System.Windows.Forms.Padding(4);
            this.btnDean.Name = "btnDean";
            this.btnDean.Size = new System.Drawing.Size(100, 28);
            this.btnDean.TabIndex = 1;
            this.btnDean.Text = "Dean";
            this.btnDean.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnDean);
            this.Controls.Add(this.btnAntoin);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAntoin;
        private System.Windows.Forms.Button btnDean;
    }
}


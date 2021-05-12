namespace xlsFilter
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
            this.excelButton = new System.Windows.Forms.Button();
            this.excelLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // excelButton
            // 
            this.excelButton.Location = new System.Drawing.Point(342, 32);
            this.excelButton.Name = "excelButton";
            this.excelButton.Size = new System.Drawing.Size(82, 78);
            this.excelButton.TabIndex = 0;
            this.excelButton.Text = "select excel file";
            this.excelButton.UseVisualStyleBackColor = true;
            this.excelButton.Click += new System.EventHandler(this.excelButton_Click);
            // 
            // excelLabel
            // 
            this.excelLabel.AutoSize = true;
            this.excelLabel.Location = new System.Drawing.Point(339, 146);
            this.excelLabel.Name = "excelLabel";
            this.excelLabel.Size = new System.Drawing.Size(0, 17);
            this.excelLabel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 515);
            this.Controls.Add(this.excelLabel);
            this.Controls.Add(this.excelButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button excelButton;
        private System.Windows.Forms.Label excelLabel;
    }
}


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
            this.generateButton = new System.Windows.Forms.Button();
            this.fileNameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // excelButton
            // 
            this.excelButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.excelButton.BackgroundImage = global::xlsFilter.Properties.Resources.excel_icon;
            this.excelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.excelButton.Location = new System.Drawing.Point(50, 43);
            this.excelButton.Name = "excelButton";
            this.excelButton.Size = new System.Drawing.Size(116, 75);
            this.excelButton.TabIndex = 0;
            this.excelButton.UseVisualStyleBackColor = false;
            this.excelButton.Click += new System.EventHandler(this.excelButton_Click);
            // 
            // excelLabel
            // 
            this.excelLabel.AutoSize = true;
            this.excelLabel.Location = new System.Drawing.Point(58, 135);
            this.excelLabel.Name = "excelLabel";
            this.excelLabel.Size = new System.Drawing.Size(0, 17);
            this.excelLabel.TabIndex = 1;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(50, 205);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(459, 66);
            this.generateButton.TabIndex = 2;
            this.generateButton.Text = "Generate filtered excel";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // fileNameInput
            // 
            this.fileNameInput.Location = new System.Drawing.Point(290, 86);
            this.fileNameInput.Name = "fileNameInput";
            this.fileNameInput.Size = new System.Drawing.Size(219, 22);
            this.fileNameInput.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose Excel File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter Name for Filtered Excel FIle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 299);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileNameInput);
            this.Controls.Add(this.generateButton);
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
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TextBox fileNameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


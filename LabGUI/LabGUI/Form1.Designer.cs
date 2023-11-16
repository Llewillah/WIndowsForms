namespace LabGUI
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
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.colourCheckBox = new System.Windows.Forms.CheckBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(361, 167);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(100, 26);
            this.messageTextBox.TabIndex = 0;
            // 
            // colourCheckBox
            // 
            this.colourCheckBox.AutoSize = true;
            this.colourCheckBox.Location = new System.Drawing.Point(361, 298);
            this.colourCheckBox.Name = "colourCheckBox";
            this.colourCheckBox.Size = new System.Drawing.Size(113, 24);
            this.colourCheckBox.TabIndex = 1;
            this.colourCheckBox.Text = "checkBox1";
            this.colourCheckBox.UseVisualStyleBackColor = true;
            this.colourCheckBox.CheckedChanged += new System.EventHandler(this.colourCheckBox_CheckedChanged);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(361, 77);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(100, 26);
            this.outputTextBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.colourCheckBox);
            this.Controls.Add(this.messageTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.CheckBox colourCheckBox;
        private System.Windows.Forms.TextBox outputTextBox;
    }
}


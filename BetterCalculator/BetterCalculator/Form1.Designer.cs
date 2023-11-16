namespace BetterCalculator
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
            this.equationTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.enterLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.calculateTextBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // equationTextBox
            // 
            this.equationTextBox.Location = new System.Drawing.Point(362, 94);
            this.equationTextBox.Name = "equationTextBox";
            this.equationTextBox.Size = new System.Drawing.Size(153, 26);
            this.equationTextBox.TabIndex = 0;
            this.equationTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(362, 296);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(153, 26);
            this.resultTextBox.TabIndex = 1;
            // 
            // enterLabel
            // 
            this.enterLabel.AutoSize = true;
            this.enterLabel.Location = new System.Drawing.Point(209, 97);
            this.enterLabel.Name = "enterLabel";
            this.enterLabel.Size = new System.Drawing.Size(114, 20);
            this.enterLabel.TabIndex = 2;
            this.enterLabel.Text = "Enter equation";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(209, 302);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(55, 20);
            this.resultLabel.TabIndex = 3;
            this.resultLabel.Text = "Result";
            // 
            // calculateTextBox
            // 
            this.calculateTextBox.Location = new System.Drawing.Point(362, 181);
            this.calculateTextBox.Name = "calculateTextBox";
            this.calculateTextBox.Size = new System.Drawing.Size(153, 53);
            this.calculateTextBox.TabIndex = 4;
            this.calculateTextBox.Text = "button1";
            this.calculateTextBox.UseVisualStyleBackColor = true;
            this.calculateTextBox.Click += new System.EventHandler(this.calculateTextBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calculateTextBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.enterLabel);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.equationTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox equationTextBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label enterLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button calculateTextBox;
    }
}


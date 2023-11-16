namespace Calculator
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
            this.num1TextBox = new System.Windows.Forms.TextBox();
            this.num2TextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.num1Label = new System.Windows.Forms.Label();
            this.num2Label = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.RadioButton();
            this.subButton = new System.Windows.Forms.RadioButton();
            this.multiplyButton = new System.Windows.Forms.RadioButton();
            this.powerButton = new System.Windows.Forms.RadioButton();
            this.operatorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // num1TextBox
            // 
            this.num1TextBox.Location = new System.Drawing.Point(174, 73);
            this.num1TextBox.Name = "num1TextBox";
            this.num1TextBox.Size = new System.Drawing.Size(188, 26);
            this.num1TextBox.TabIndex = 0;
            // 
            // num2TextBox
            // 
            this.num2TextBox.Location = new System.Drawing.Point(174, 143);
            this.num2TextBox.Name = "num2TextBox";
            this.num2TextBox.Size = new System.Drawing.Size(188, 26);
            this.num2TextBox.TabIndex = 1;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(174, 227);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(188, 26);
            this.resultTextBox.TabIndex = 2;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(174, 312);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(188, 75);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "button1";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // num1Label
            // 
            this.num1Label.AutoSize = true;
            this.num1Label.Location = new System.Drawing.Point(64, 79);
            this.num1Label.Name = "num1Label";
            this.num1Label.Size = new System.Drawing.Size(78, 20);
            this.num1Label.TabIndex = 4;
            this.num1Label.Text = "Number 1";
            // 
            // num2Label
            // 
            this.num2Label.AutoSize = true;
            this.num2Label.Location = new System.Drawing.Point(64, 149);
            this.num2Label.Name = "num2Label";
            this.num2Label.Size = new System.Drawing.Size(78, 20);
            this.num2Label.TabIndex = 5;
            this.num2Label.Text = "Number 2";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(64, 230);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(55, 20);
            this.resultLabel.TabIndex = 6;
            this.resultLabel.Text = "Result";
            this.resultLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // addButton
            // 
            this.addButton.AutoSize = true;
            this.addButton.Location = new System.Drawing.Point(566, 120);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(43, 24);
            this.addButton.TabIndex = 7;
            this.addButton.TabStop = true;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.CheckedChanged += new System.EventHandler(this.addButton_CheckedChanged);
            // 
            // subButton
            // 
            this.subButton.AutoSize = true;
            this.subButton.Location = new System.Drawing.Point(566, 150);
            this.subButton.Name = "subButton";
            this.subButton.Size = new System.Drawing.Size(39, 24);
            this.subButton.TabIndex = 8;
            this.subButton.TabStop = true;
            this.subButton.Text = "-";
            this.subButton.UseVisualStyleBackColor = true;
            // 
            // multiplyButton
            // 
            this.multiplyButton.AutoSize = true;
            this.multiplyButton.Location = new System.Drawing.Point(566, 180);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(40, 24);
            this.multiplyButton.TabIndex = 9;
            this.multiplyButton.TabStop = true;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.CheckedChanged += new System.EventHandler(this.multiplyButton_CheckedChanged);
            // 
            // powerButton
            // 
            this.powerButton.AutoSize = true;
            this.powerButton.Location = new System.Drawing.Point(566, 210);
            this.powerButton.Name = "powerButton";
            this.powerButton.Size = new System.Drawing.Size(77, 24);
            this.powerButton.TabIndex = 10;
            this.powerButton.TabStop = true;
            this.powerButton.Text = "power";
            this.powerButton.UseVisualStyleBackColor = true;
            // 
            // operatorLabel
            // 
            this.operatorLabel.AutoSize = true;
            this.operatorLabel.Location = new System.Drawing.Point(562, 79);
            this.operatorLabel.Name = "operatorLabel";
            this.operatorLabel.Size = new System.Drawing.Size(72, 20);
            this.operatorLabel.TabIndex = 11;
            this.operatorLabel.Text = "Operator";
            this.operatorLabel.Click += new System.EventHandler(this.operatorLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.operatorLabel);
            this.Controls.Add(this.powerButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.subButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.num2Label);
            this.Controls.Add(this.num1Label);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.num2TextBox);
            this.Controls.Add(this.num1TextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num1TextBox;
        private System.Windows.Forms.TextBox num2TextBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label num1Label;
        private System.Windows.Forms.Label num2Label;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.RadioButton addButton;
        private System.Windows.Forms.RadioButton subButton;
        private System.Windows.Forms.RadioButton multiplyButton;
        private System.Windows.Forms.RadioButton powerButton;
        private System.Windows.Forms.Label operatorLabel;
    }
}


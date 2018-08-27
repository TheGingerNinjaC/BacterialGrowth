namespace BacterialGrowth
{
    partial class growthCalcForm
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
            this.startPromptLabel = new System.Windows.Forms.Label();
            this.bacteriaTextBox = new System.Windows.Forms.TextBox();
            this.daysPromptLabel = new System.Windows.Forms.Label();
            this.daysTextBox = new System.Windows.Forms.TextBox();
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startPromptLabel
            // 
            this.startPromptLabel.AutoSize = true;
            this.startPromptLabel.Location = new System.Drawing.Point(29, 13);
            this.startPromptLabel.Name = "startPromptLabel";
            this.startPromptLabel.Size = new System.Drawing.Size(100, 13);
            this.startPromptLabel.TabIndex = 0;
            this.startPromptLabel.Text = "Number of bacteria:";
            // 
            // bacteriaTextBox
            // 
            this.bacteriaTextBox.Location = new System.Drawing.Point(135, 10);
            this.bacteriaTextBox.Name = "bacteriaTextBox";
            this.bacteriaTextBox.Size = new System.Drawing.Size(100, 20);
            this.bacteriaTextBox.TabIndex = 1;
            // 
            // daysPromptLabel
            // 
            this.daysPromptLabel.AutoSize = true;
            this.daysPromptLabel.Location = new System.Drawing.Point(48, 42);
            this.daysPromptLabel.Name = "daysPromptLabel";
            this.daysPromptLabel.Size = new System.Drawing.Size(81, 13);
            this.daysPromptLabel.TabIndex = 2;
            this.daysPromptLabel.Text = "Days to double:";
            // 
            // daysTextBox
            // 
            this.daysTextBox.Location = new System.Drawing.Point(135, 39);
            this.daysTextBox.Name = "daysTextBox";
            this.daysTextBox.Size = new System.Drawing.Size(100, 20);
            this.daysTextBox.TabIndex = 2;
            // 
            // outputListBox
            // 
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.Location = new System.Drawing.Point(12, 78);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(237, 147);
            this.outputListBox.TabIndex = 3;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(12, 237);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(93, 237);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(174, 237);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // growthCalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 272);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.outputListBox);
            this.Controls.Add(this.daysTextBox);
            this.Controls.Add(this.daysPromptLabel);
            this.Controls.Add(this.bacteriaTextBox);
            this.Controls.Add(this.startPromptLabel);
            this.Name = "growthCalcForm";
            this.Text = "Bacterial Growth Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label startPromptLabel;
        private System.Windows.Forms.TextBox bacteriaTextBox;
        private System.Windows.Forms.Label daysPromptLabel;
        private System.Windows.Forms.TextBox daysTextBox;
        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}


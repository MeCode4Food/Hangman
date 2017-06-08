namespace hungmen
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
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GuessBox = new System.Windows.Forms.TextBox();
            this.GuessButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OutputBox
            // 
            this.OutputBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OutputBox.Location = new System.Drawing.Point(42, 12);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.Size = new System.Drawing.Size(206, 207);
            this.OutputBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type your guess!";
            // 
            // GuessBox
            // 
            this.GuessBox.Location = new System.Drawing.Point(42, 245);
            this.GuessBox.MaxLength = 1;
            this.GuessBox.Name = "GuessBox";
            this.GuessBox.Size = new System.Drawing.Size(206, 26);
            this.GuessBox.TabIndex = 2;
            this.GuessBox.TextChanged += new System.EventHandler(this.GuessBox_TextChanged);
            // 
            // GuessButton
            // 
            this.GuessButton.Location = new System.Drawing.Point(164, 277);
            this.GuessButton.Name = "GuessButton";
            this.GuessButton.Size = new System.Drawing.Size(84, 41);
            this.GuessButton.TabIndex = 3;
            this.GuessButton.Text = "Guess!";
            this.GuessButton.UseVisualStyleBackColor = true;
            this.GuessButton.Click += new System.EventHandler(this.GuessButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.GuessButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 320);
            this.Controls.Add(this.GuessButton);
            this.Controls.Add(this.GuessBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OutputBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GuessBox;
        private System.Windows.Forms.Button GuessButton;
    }
}


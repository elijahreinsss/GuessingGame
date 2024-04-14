namespace GuessingGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            guessWordLabel = new Label();
            guessTextBox = new TextBox();
            submitGuessButton = new Button();
            label2 = new Label();
            wrongGuessBox = new ListBox();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guessWordLabel
            // 
            guessWordLabel.AllowDrop = true;
            guessWordLabel.AutoSize = true;
            guessWordLabel.BackColor = Color.DarkSeaGreen;
            guessWordLabel.FlatStyle = FlatStyle.Flat;
            guessWordLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            guessWordLabel.ForeColor = Color.White;
            guessWordLabel.Location = new Point(160, 24);
            guessWordLabel.Name = "guessWordLabel";
            guessWordLabel.Size = new Size(0, 32);
            guessWordLabel.TabIndex = 0;
            guessWordLabel.Tag = "";
            guessWordLabel.TextAlign = ContentAlignment.MiddleCenter;
            guessWordLabel.Click += guessWordLabel_Click;
            // 
            // guessTextBox
            // 
            guessTextBox.Font = new Font("Segoe UI", 12F);
            guessTextBox.Location = new Point(95, 112);
            guessTextBox.Name = "guessTextBox";
            guessTextBox.Size = new Size(268, 29);
            guessTextBox.TabIndex = 1;
            // 
            // submitGuessButton
            // 
            submitGuessButton.BackColor = Color.DarkSeaGreen;
            submitGuessButton.Font = new Font("Segoe UI", 12F);
            submitGuessButton.ForeColor = Color.White;
            submitGuessButton.Location = new Point(152, 147);
            submitGuessButton.Name = "submitGuessButton";
            submitGuessButton.Size = new Size(144, 38);
            submitGuessButton.TabIndex = 2;
            submitGuessButton.Text = "Guess";
            submitGuessButton.UseVisualStyleBackColor = false;
            submitGuessButton.Click += submitGuessButton_Click;
            // 
            // label2
            // 
            label2.AllowDrop = true;
            label2.AutoSize = true;
            label2.BackColor = Color.DarkSeaGreen;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(448, 25);
            label2.Name = "label2";
            label2.Padding = new Padding(20, 0, 20, 0);
            label2.Size = new Size(144, 21);
            label2.TabIndex = 3;
            label2.Tag = "guessWordLabel";
            label2.Text = "Wrong Guess";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // wrongGuessBox
            // 
            wrongGuessBox.FormattingEnabled = true;
            wrongGuessBox.ItemHeight = 15;
            wrongGuessBox.Location = new Point(448, 49);
            wrongGuessBox.Name = "wrongGuessBox";
            wrongGuessBox.Size = new Size(144, 94);
            wrongGuessBox.TabIndex = 4;
            wrongGuessBox.Tag = "";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(guessWordLabel);
            panel1.Location = new Point(25, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(417, 81);
            panel1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 208);
            Controls.Add(panel1);
            Controls.Add(wrongGuessBox);
            Controls.Add(label2);
            Controls.Add(submitGuessButton);
            Controls.Add(guessTextBox);
            Name = "Form1";
            Text = "Guess the Word";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label guessWordLabel;
        private TextBox guessTextBox;
        private Button submitGuessButton;
        private Label label2;
        private ListBox wrongGuessBox;
        private Panel panel1;
    }
}

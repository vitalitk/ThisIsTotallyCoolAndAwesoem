namespace Ass1
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
            calcBtn = new Button();
            leftBox = new TextBox();
            rightBox = new TextBox();
            itsALabel = new Label();
            button1 = new Button();
            btnMult = new Button();
            btnDiv = new Button();
            theOperator = new Label();
            SuspendLayout();
            // 
            // calcBtn
            // 
            calcBtn.BackColor = Color.FromArgb(163, 247, 153);
            calcBtn.Location = new Point(77, 125);
            calcBtn.Name = "calcBtn";
            calcBtn.Size = new Size(56, 44);
            calcBtn.TabIndex = 0;
            calcBtn.Text = "+";
            calcBtn.UseVisualStyleBackColor = false;
            calcBtn.Click += button1_Click;
            // 
            // leftBox
            // 
            leftBox.Location = new Point(77, 65);
            leftBox.Name = "leftBox";
            leftBox.Size = new Size(100, 23);
            leftBox.TabIndex = 1;
            // 
            // rightBox
            // 
            rightBox.Location = new Point(467, 65);
            rightBox.Name = "rightBox";
            rightBox.Size = new Size(100, 23);
            rightBox.TabIndex = 2;
            // 
            // itsALabel
            // 
            itsALabel.AutoSize = true;
            itsALabel.ForeColor = Color.White;
            itsALabel.Location = new Point(255, 376);
            itsALabel.Name = "itsALabel";
            itsALabel.Size = new Size(138, 15);
            itsALabel.TabIndex = 3;
            itsALabel.Text = "Enter two valid numbers.";
            itsALabel.TextAlign = ContentAlignment.BottomCenter;
            itsALabel.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 106, 111);
            button1.Location = new Point(77, 175);
            button1.Name = "button1";
            button1.Size = new Size(56, 44);
            button1.TabIndex = 4;
            button1.Text = "-";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // btnMult
            // 
            btnMult.BackColor = Color.FromArgb(116, 224, 239);
            btnMult.Location = new Point(511, 125);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(56, 44);
            btnMult.TabIndex = 5;
            btnMult.Text = "*";
            btnMult.UseVisualStyleBackColor = false;
            btnMult.Click += btnMult_Click;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = Color.FromArgb(243, 152, 241);
            btnDiv.Location = new Point(511, 175);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(56, 44);
            btnDiv.TabIndex = 6;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = false;
            btnDiv.Click += btnDiv_Click;
            // 
            // theOperator
            // 
            theOperator.AutoSize = true;
            theOperator.Font = new Font("Impact", 12F, FontStyle.Bold, GraphicsUnit.Point);
            theOperator.ForeColor = Color.White;
            theOperator.Location = new Point(317, 68);
            theOperator.Name = "theOperator";
            theOperator.Size = new Size(18, 20);
            theOperator.TabIndex = 7;
            theOperator.Text = "?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 37, 105);
            ClientSize = new Size(673, 450);
            Controls.Add(theOperator);
            Controls.Add(btnDiv);
            Controls.Add(btnMult);
            Controls.Add(button1);
            Controls.Add(itsALabel);
            Controls.Add(rightBox);
            Controls.Add(leftBox);
            Controls.Add(calcBtn);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calcBtn;
        private TextBox leftBox;
        private TextBox rightBox;
        private Label itsALabel;
        private Button button1;
        private Button btnMult;
        private Button btnDiv;
        private Label theOperator;
    }
}
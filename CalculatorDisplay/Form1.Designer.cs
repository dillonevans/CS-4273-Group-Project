
namespace CalculatorDisplay
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.AllClearButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.EqualsButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.DivisionButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.MultiplicationButton = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.DisplayBox = new System.Windows.Forms.TextBox();
            this.NegationButton = new System.Windows.Forms.Button();
            this.DecimalButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(24, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 126);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.NumericButtonHandler);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.ForeColor = System.Drawing.Color.Navy;
            this.button2.Location = new System.Drawing.Point(182, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 126);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.NumericButtonHandler);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkGray;
            this.button3.ForeColor = System.Drawing.Color.Navy;
            this.button3.Location = new System.Drawing.Point(345, 373);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 126);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.NumericButtonHandler);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkGray;
            this.button4.ForeColor = System.Drawing.Color.Navy;
            this.button4.Location = new System.Drawing.Point(345, 531);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 126);
            this.button4.TabIndex = 5;
            this.button4.Text = "6";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.NumericButtonHandler);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkGray;
            this.button5.ForeColor = System.Drawing.Color.Navy;
            this.button5.Location = new System.Drawing.Point(182, 531);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(137, 126);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.NumericButtonHandler);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkGray;
            this.button6.ForeColor = System.Drawing.Color.Navy;
            this.button6.Location = new System.Drawing.Point(24, 531);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(137, 126);
            this.button6.TabIndex = 3;
            this.button6.Text = "4";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.NumericButtonHandler);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DarkGray;
            this.button7.ForeColor = System.Drawing.Color.Navy;
            this.button7.Location = new System.Drawing.Point(345, 691);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(137, 126);
            this.button7.TabIndex = 8;
            this.button7.Text = "9";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.NumericButtonHandler);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DarkGray;
            this.button8.ForeColor = System.Drawing.Color.Navy;
            this.button8.Location = new System.Drawing.Point(182, 691);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(137, 126);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.NumericButtonHandler);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.DarkGray;
            this.button9.ForeColor = System.Drawing.Color.Navy;
            this.button9.Location = new System.Drawing.Point(25, 691);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(137, 126);
            this.button9.TabIndex = 6;
            this.button9.Text = "7";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.NumericButtonHandler);
            // 
            // AllClearButton
            // 
            this.AllClearButton.BackColor = System.Drawing.Color.DarkGray;
            this.AllClearButton.ForeColor = System.Drawing.Color.Navy;
            this.AllClearButton.Location = new System.Drawing.Point(24, 270);
            this.AllClearButton.Name = "AllClearButton";
            this.AllClearButton.Size = new System.Drawing.Size(137, 72);
            this.AllClearButton.TabIndex = 9;
            this.AllClearButton.Text = "AC";
            this.AllClearButton.UseVisualStyleBackColor = false;
            this.AllClearButton.Click += new System.EventHandler(this.AllClearButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.DarkGray;
            this.ClearButton.ForeColor = System.Drawing.Color.Navy;
            this.ClearButton.Location = new System.Drawing.Point(182, 270);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(300, 72);
            this.ClearButton.TabIndex = 10;
            this.ClearButton.Text = "C";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // EqualsButton
            // 
            this.EqualsButton.BackColor = System.Drawing.Color.DarkGray;
            this.EqualsButton.ForeColor = System.Drawing.Color.Navy;
            this.EqualsButton.Location = new System.Drawing.Point(520, 837);
            this.EqualsButton.Name = "EqualsButton";
            this.EqualsButton.Size = new System.Drawing.Size(218, 126);
            this.EqualsButton.TabIndex = 11;
            this.EqualsButton.Text = "=";
            this.EqualsButton.UseVisualStyleBackColor = false;
            this.EqualsButton.Click += new System.EventHandler(this.EqualsButtonClicked);
            // 
            // MinusButton
            // 
            this.MinusButton.BackColor = System.Drawing.Color.Tomato;
            this.MinusButton.Location = new System.Drawing.Point(520, 740);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(218, 77);
            this.MinusButton.TabIndex = 14;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = false;
            this.MinusButton.Click += new System.EventHandler(this.ArithmeticButtonClicked);
            // 
            // DivisionButton
            // 
            this.DivisionButton.BackColor = System.Drawing.Color.Tomato;
            this.DivisionButton.Location = new System.Drawing.Point(520, 574);
            this.DivisionButton.Name = "DivisionButton";
            this.DivisionButton.Size = new System.Drawing.Size(218, 77);
            this.DivisionButton.TabIndex = 15;
            this.DivisionButton.Text = "/";
            this.DivisionButton.UseVisualStyleBackColor = false;
            this.DivisionButton.Click += new System.EventHandler(this.ArithmeticButtonClicked);
            // 
            // PlusButton
            // 
            this.PlusButton.BackColor = System.Drawing.Color.Tomato;
            this.PlusButton.Location = new System.Drawing.Point(520, 657);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(218, 77);
            this.PlusButton.TabIndex = 16;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = false;
            this.PlusButton.Click += new System.EventHandler(this.ArithmeticButtonClicked);
            // 
            // MultiplicationButton
            // 
            this.MultiplicationButton.BackColor = System.Drawing.Color.Tomato;
            this.MultiplicationButton.Location = new System.Drawing.Point(520, 491);
            this.MultiplicationButton.Name = "MultiplicationButton";
            this.MultiplicationButton.Size = new System.Drawing.Size(218, 77);
            this.MultiplicationButton.TabIndex = 17;
            this.MultiplicationButton.Text = "*";
            this.MultiplicationButton.UseVisualStyleBackColor = false;
            this.MultiplicationButton.Click += new System.EventHandler(this.ArithmeticButtonClicked);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.DarkGray;
            this.button17.ForeColor = System.Drawing.Color.Navy;
            this.button17.Location = new System.Drawing.Point(25, 837);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(294, 126);
            this.button17.TabIndex = 18;
            this.button17.Text = "0";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.NumericButtonHandler);
            // 
            // DisplayBox
            // 
            this.DisplayBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DisplayBox.Font = new System.Drawing.Font("CaskaydiaCove Nerd Font", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DisplayBox.Location = new System.Drawing.Point(25, 34);
            this.DisplayBox.Multiline = true;
            this.DisplayBox.Name = "DisplayBox";
            this.DisplayBox.ReadOnly = true;
            this.DisplayBox.Size = new System.Drawing.Size(713, 173);
            this.DisplayBox.TabIndex = 19;
            this.DisplayBox.Text = "0";
            // 
            // NegationButton
            // 
            this.NegationButton.BackColor = System.Drawing.Color.DarkGray;
            this.NegationButton.Location = new System.Drawing.Point(520, 373);
            this.NegationButton.Name = "NegationButton";
            this.NegationButton.Size = new System.Drawing.Size(218, 102);
            this.NegationButton.TabIndex = 20;
            this.NegationButton.Text = "+/-";
            this.NegationButton.UseVisualStyleBackColor = false;
            this.NegationButton.Click += new System.EventHandler(this.NegationButton_Click);
            // 
            // DecimalButton
            // 
            this.DecimalButton.BackColor = System.Drawing.Color.DarkGray;
            this.DecimalButton.Font = new System.Drawing.Font("Segoe UI", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DecimalButton.ForeColor = System.Drawing.Color.Navy;
            this.DecimalButton.Location = new System.Drawing.Point(345, 837);
            this.DecimalButton.Name = "DecimalButton";
            this.DecimalButton.Size = new System.Drawing.Size(137, 126);
            this.DecimalButton.TabIndex = 21;
            this.DecimalButton.Text = ".";
            this.DecimalButton.UseVisualStyleBackColor = false;
            this.DecimalButton.Click += new System.EventHandler(this.DecimalButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.EqualsButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.AllClearButton;
            this.ClientSize = new System.Drawing.Size(770, 997);
            this.Controls.Add(this.DecimalButton);
            this.Controls.Add(this.NegationButton);
            this.Controls.Add(this.DisplayBox);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.MultiplicationButton);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.DivisionButton);
            this.Controls.Add(this.MinusButton);
            this.Controls.Add(this.EqualsButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.AllClearButton);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button AllClearButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button EqualsButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button DivisionButton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button MultiplicationButton;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.TextBox DisplayBox;
        private System.Windows.Forms.Button NegationButton;
        private System.Windows.Forms.Button DecimalButton;
    }
}


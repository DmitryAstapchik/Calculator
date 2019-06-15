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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonPoint = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonMult = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonErase = new System.Windows.Forms.Button();
            this.buttonClearEntry = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSign = new System.Windows.Forms.Button();
            this.buttonPercent = new System.Windows.Forms.Button();
            this.buttonInverse = new System.Windows.Forms.Button();
            this.buttonSqrt = new System.Windows.Forms.Button();
            this.buttonPow = new System.Windows.Forms.Button();
            this.buttonMemoryPlus = new System.Windows.Forms.Button();
            this.buttonMemoryMinus = new System.Windows.Forms.Button();
            this.buttonMemoryRecall = new System.Windows.Forms.Button();
            this.buttonMemoryClear = new System.Windows.Forms.Button();
            this.labelMemory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDisplay.Location = new System.Drawing.Point(13, 13);
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.ReadOnly = true;
            this.textBoxDisplay.Size = new System.Drawing.Size(217, 20);
            this.textBoxDisplay.TabIndex = 0;
            this.textBoxDisplay.TabStop = false;
            this.textBoxDisplay.Text = "0";
            this.textBoxDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 39);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(25, 25);
            this.button7.TabIndex = 1;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.ButtonDigit_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(43, 39);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(25, 25);
            this.button8.TabIndex = 2;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.ButtonDigit_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(74, 39);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(25, 25);
            this.button9.TabIndex = 3;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.ButtonDigit_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 25);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ButtonDigit_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(43, 70);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(25, 25);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ButtonDigit_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(74, 70);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(25, 25);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.ButtonDigit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 7;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonDigit_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(43, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 25);
            this.button2.TabIndex = 8;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ButtonDigit_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(74, 101);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 25);
            this.button3.TabIndex = 9;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ButtonDigit_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(12, 132);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(25, 25);
            this.button0.TabIndex = 10;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.ButtonDigit_Click);
            // 
            // buttonPoint
            // 
            this.buttonPoint.Location = new System.Drawing.Point(43, 132);
            this.buttonPoint.Name = "buttonPoint";
            this.buttonPoint.Size = new System.Drawing.Size(25, 25);
            this.buttonPoint.TabIndex = 11;
            this.buttonPoint.Text = ",";
            this.buttonPoint.UseVisualStyleBackColor = true;
            this.buttonPoint.Click += new System.EventHandler(this.ButtonPoint_Click);
            // 
            // buttonEquals
            // 
            this.buttonEquals.Location = new System.Drawing.Point(74, 132);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(25, 25);
            this.buttonEquals.TabIndex = 12;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = true;
            this.buttonEquals.Click += new System.EventHandler(this.ButtonEquals_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(105, 132);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(25, 25);
            this.buttonPlus.TabIndex = 13;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.HandleOperator);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(105, 101);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(25, 25);
            this.buttonMinus.TabIndex = 14;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.HandleOperator);
            // 
            // buttonMult
            // 
            this.buttonMult.Location = new System.Drawing.Point(105, 70);
            this.buttonMult.Name = "buttonMult";
            this.buttonMult.Size = new System.Drawing.Size(25, 25);
            this.buttonMult.TabIndex = 15;
            this.buttonMult.Text = "*";
            this.buttonMult.UseVisualStyleBackColor = true;
            this.buttonMult.Click += new System.EventHandler(this.HandleOperator);
            // 
            // buttonDiv
            // 
            this.buttonDiv.Location = new System.Drawing.Point(105, 39);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(25, 25);
            this.buttonDiv.TabIndex = 16;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.HandleOperator);
            // 
            // buttonErase
            // 
            this.buttonErase.Location = new System.Drawing.Point(200, 39);
            this.buttonErase.Name = "buttonErase";
            this.buttonErase.Size = new System.Drawing.Size(30, 25);
            this.buttonErase.TabIndex = 17;
            this.buttonErase.UseVisualStyleBackColor = true;
            this.buttonErase.Click += new System.EventHandler(this.ButtonErase_Click);
            // 
            // buttonClearEntry
            // 
            this.buttonClearEntry.Location = new System.Drawing.Point(200, 70);
            this.buttonClearEntry.Name = "buttonClearEntry";
            this.buttonClearEntry.Size = new System.Drawing.Size(30, 25);
            this.buttonClearEntry.TabIndex = 18;
            this.buttonClearEntry.Text = "CE";
            this.buttonClearEntry.UseVisualStyleBackColor = true;
            this.buttonClearEntry.Click += new System.EventHandler(this.ButtonClearEntry_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(200, 101);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(30, 25);
            this.buttonClear.TabIndex = 19;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // buttonSign
            // 
            this.buttonSign.Location = new System.Drawing.Point(200, 132);
            this.buttonSign.Name = "buttonSign";
            this.buttonSign.Size = new System.Drawing.Size(30, 25);
            this.buttonSign.TabIndex = 20;
            this.buttonSign.Text = "+/-";
            this.buttonSign.UseVisualStyleBackColor = true;
            this.buttonSign.Click += new System.EventHandler(this.ButtonSign_Click);
            // 
            // buttonPercent
            // 
            this.buttonPercent.Location = new System.Drawing.Point(136, 39);
            this.buttonPercent.Name = "buttonPercent";
            this.buttonPercent.Size = new System.Drawing.Size(35, 25);
            this.buttonPercent.TabIndex = 21;
            this.buttonPercent.Text = "%";
            this.buttonPercent.UseVisualStyleBackColor = true;
            this.buttonPercent.Click += new System.EventHandler(this.ButtonPercent_Click);
            // 
            // buttonInverse
            // 
            this.buttonInverse.Location = new System.Drawing.Point(136, 70);
            this.buttonInverse.Name = "buttonInverse";
            this.buttonInverse.Size = new System.Drawing.Size(35, 25);
            this.buttonInverse.TabIndex = 22;
            this.buttonInverse.Text = "1/x";
            this.buttonInverse.UseVisualStyleBackColor = true;
            this.buttonInverse.Click += new System.EventHandler(this.ButtonInverse_Click);
            // 
            // buttonSqrt
            // 
            this.buttonSqrt.Location = new System.Drawing.Point(136, 101);
            this.buttonSqrt.Name = "buttonSqrt";
            this.buttonSqrt.Size = new System.Drawing.Size(35, 25);
            this.buttonSqrt.TabIndex = 23;
            this.buttonSqrt.UseVisualStyleBackColor = true;
            this.buttonSqrt.Click += new System.EventHandler(this.ButtonSqrt_Click);
            // 
            // buttonPow
            // 
            this.buttonPow.Location = new System.Drawing.Point(136, 132);
            this.buttonPow.Name = "buttonPow";
            this.buttonPow.Size = new System.Drawing.Size(35, 25);
            this.buttonPow.TabIndex = 24;
            this.buttonPow.Text = "x^2";
            this.buttonPow.UseVisualStyleBackColor = true;
            this.buttonPow.Click += new System.EventHandler(this.ButtonPow_Click);
            // 
            // buttonMemoryPlus
            // 
            this.buttonMemoryPlus.Location = new System.Drawing.Point(236, 132);
            this.buttonMemoryPlus.Name = "buttonMemoryPlus";
            this.buttonMemoryPlus.Size = new System.Drawing.Size(35, 25);
            this.buttonMemoryPlus.TabIndex = 25;
            this.buttonMemoryPlus.Text = "M+";
            this.buttonMemoryPlus.UseVisualStyleBackColor = true;
            this.buttonMemoryPlus.Click += new System.EventHandler(this.ButtonMemoryPlus_Click);
            // 
            // buttonMemoryMinus
            // 
            this.buttonMemoryMinus.Location = new System.Drawing.Point(236, 101);
            this.buttonMemoryMinus.Name = "buttonMemoryMinus";
            this.buttonMemoryMinus.Size = new System.Drawing.Size(35, 25);
            this.buttonMemoryMinus.TabIndex = 26;
            this.buttonMemoryMinus.Text = "M-";
            this.buttonMemoryMinus.UseVisualStyleBackColor = true;
            this.buttonMemoryMinus.Click += new System.EventHandler(this.ButtonMemoryMinus_Click);
            // 
            // buttonMemoryRecall
            // 
            this.buttonMemoryRecall.Location = new System.Drawing.Point(236, 70);
            this.buttonMemoryRecall.Name = "buttonMemoryRecall";
            this.buttonMemoryRecall.Size = new System.Drawing.Size(35, 25);
            this.buttonMemoryRecall.TabIndex = 27;
            this.buttonMemoryRecall.Text = "MR";
            this.buttonMemoryRecall.UseVisualStyleBackColor = true;
            this.buttonMemoryRecall.Click += new System.EventHandler(this.ButtonMemoryRecall_Click);
            // 
            // buttonMemoryClear
            // 
            this.buttonMemoryClear.Location = new System.Drawing.Point(236, 39);
            this.buttonMemoryClear.Name = "buttonMemoryClear";
            this.buttonMemoryClear.Size = new System.Drawing.Size(35, 25);
            this.buttonMemoryClear.TabIndex = 28;
            this.buttonMemoryClear.Text = "MC";
            this.buttonMemoryClear.UseVisualStyleBackColor = true;
            this.buttonMemoryClear.Click += new System.EventHandler(this.ButtonMemoryClear_Click);
            // 
            // labelMemory
            // 
            this.labelMemory.AutoSize = true;
            this.labelMemory.Location = new System.Drawing.Point(236, 16);
            this.labelMemory.Name = "labelMemory";
            this.labelMemory.Size = new System.Drawing.Size(16, 13);
            this.labelMemory.TabIndex = 29;
            this.labelMemory.Text = "M";
            this.labelMemory.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(292, 212);
            this.Controls.Add(this.labelMemory);
            this.Controls.Add(this.buttonMemoryClear);
            this.Controls.Add(this.buttonMemoryRecall);
            this.Controls.Add(this.buttonMemoryMinus);
            this.Controls.Add(this.buttonMemoryPlus);
            this.Controls.Add(this.buttonPow);
            this.Controls.Add(this.buttonSqrt);
            this.Controls.Add(this.buttonInverse);
            this.Controls.Add(this.buttonPercent);
            this.Controls.Add(this.buttonSign);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonClearEntry);
            this.Controls.Add(this.buttonErase);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonMult);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonEquals);
            this.Controls.Add(this.buttonPoint);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBoxDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDisplay;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonPoint;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonMult;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonErase;
        private System.Windows.Forms.Button buttonClearEntry;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSign;
        private System.Windows.Forms.Button buttonPercent;
        private System.Windows.Forms.Button buttonInverse;
        private System.Windows.Forms.Button buttonSqrt;
        private System.Windows.Forms.Button buttonPow;
        private System.Windows.Forms.Button buttonMemoryPlus;
        private System.Windows.Forms.Button buttonMemoryMinus;
        private System.Windows.Forms.Button buttonMemoryRecall;
        private System.Windows.Forms.Button buttonMemoryClear;
        private System.Windows.Forms.Label labelMemory;
    }
}


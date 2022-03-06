namespace Week2WinForm2
{
    partial class Week2WinForm2
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
            this.LbllInput = new System.Windows.Forms.Label();
            this.TxtBoxInput = new System.Windows.Forms.TextBox();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.CheckBoxBold = new System.Windows.Forms.CheckBox();
            this.CheckBoxItalic = new System.Windows.Forms.CheckBox();
            this.CheckBoxUnderline = new System.Windows.Forms.CheckBox();
            this.RadioBtnRed = new System.Windows.Forms.RadioButton();
            this.RadioBtnBlue = new System.Windows.Forms.RadioButton();
            this.LblOutput = new System.Windows.Forms.Label();
            this.LblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LbllInput
            // 
            this.LbllInput.AutoSize = true;
            this.LbllInput.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbllInput.Location = new System.Drawing.Point(38, 39);
            this.LbllInput.Name = "LbllInput";
            this.LbllInput.Size = new System.Drawing.Size(80, 30);
            this.LbllInput.TabIndex = 0;
            this.LbllInput.Text = "Input : ";
            // 
            // TxtBoxInput
            // 
            this.TxtBoxInput.Location = new System.Drawing.Point(124, 39);
            this.TxtBoxInput.Multiline = true;
            this.TxtBoxInput.Name = "TxtBoxInput";
            this.TxtBoxInput.Size = new System.Drawing.Size(231, 38);
            this.TxtBoxInput.TabIndex = 1;
            // 
            // BtnPrint
            // 
            this.BtnPrint.Location = new System.Drawing.Point(375, 39);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(112, 38);
            this.BtnPrint.TabIndex = 2;
            this.BtnPrint.Text = "Print";
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // CheckBoxBold
            // 
            this.CheckBoxBold.AutoSize = true;
            this.CheckBoxBold.Location = new System.Drawing.Point(127, 121);
            this.CheckBoxBold.Name = "CheckBoxBold";
            this.CheckBoxBold.Size = new System.Drawing.Size(74, 29);
            this.CheckBoxBold.TabIndex = 3;
            this.CheckBoxBold.Text = "Bold";
            this.CheckBoxBold.UseVisualStyleBackColor = true;
            this.CheckBoxBold.CheckedChanged += new System.EventHandler(this.CheckBoxBold_CheckedChanged);
            // 
            // CheckBoxItalic
            // 
            this.CheckBoxItalic.AutoSize = true;
            this.CheckBoxItalic.Location = new System.Drawing.Point(227, 121);
            this.CheckBoxItalic.Name = "CheckBoxItalic";
            this.CheckBoxItalic.Size = new System.Drawing.Size(74, 29);
            this.CheckBoxItalic.TabIndex = 4;
            this.CheckBoxItalic.Text = "Italic";
            this.CheckBoxItalic.UseVisualStyleBackColor = true;
            this.CheckBoxItalic.CheckedChanged += new System.EventHandler(this.CheckBoxItalic_CheckedChanged);
            // 
            // CheckBoxUnderline
            // 
            this.CheckBoxUnderline.AutoSize = true;
            this.CheckBoxUnderline.Location = new System.Drawing.Point(324, 121);
            this.CheckBoxUnderline.Name = "CheckBoxUnderline";
            this.CheckBoxUnderline.Size = new System.Drawing.Size(113, 29);
            this.CheckBoxUnderline.TabIndex = 5;
            this.CheckBoxUnderline.Text = "Underline";
            this.CheckBoxUnderline.UseVisualStyleBackColor = true;
            this.CheckBoxUnderline.CheckedChanged += new System.EventHandler(this.CheckBoxUnderline_CheckedChanged);
            // 
            // RadioBtnRed
            // 
            this.RadioBtnRed.AutoSize = true;
            this.RadioBtnRed.Location = new System.Drawing.Point(127, 180);
            this.RadioBtnRed.Name = "RadioBtnRed";
            this.RadioBtnRed.Size = new System.Drawing.Size(67, 29);
            this.RadioBtnRed.TabIndex = 6;
            this.RadioBtnRed.TabStop = true;
            this.RadioBtnRed.Text = "Red";
            this.RadioBtnRed.UseVisualStyleBackColor = true;
            this.RadioBtnRed.CheckedChanged += new System.EventHandler(this.RadioBtnRed_CheckedChanged);
            // 
            // RadioBtnBlue
            // 
            this.RadioBtnBlue.AutoSize = true;
            this.RadioBtnBlue.Location = new System.Drawing.Point(227, 180);
            this.RadioBtnBlue.Name = "RadioBtnBlue";
            this.RadioBtnBlue.Size = new System.Drawing.Size(70, 29);
            this.RadioBtnBlue.TabIndex = 7;
            this.RadioBtnBlue.TabStop = true;
            this.RadioBtnBlue.Text = "Blue";
            this.RadioBtnBlue.UseVisualStyleBackColor = true;
            this.RadioBtnBlue.CheckedChanged += new System.EventHandler(this.RadioBtnBlue_CheckedChanged);
            // 
            // LblOutput
            // 
            this.LblOutput.AutoSize = true;
            this.LblOutput.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblOutput.Location = new System.Drawing.Point(38, 312);
            this.LblOutput.Name = "LblOutput";
            this.LblOutput.Size = new System.Drawing.Size(98, 30);
            this.LblOutput.TabIndex = 8;
            this.LblOutput.Text = "Output : ";
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblResult.Location = new System.Drawing.Point(142, 312);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(0, 30);
            this.LblResult.TabIndex = 9;
            // 
            // Week2WinForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 461);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.LblOutput);
            this.Controls.Add(this.RadioBtnBlue);
            this.Controls.Add(this.RadioBtnRed);
            this.Controls.Add(this.CheckBoxUnderline);
            this.Controls.Add(this.CheckBoxItalic);
            this.Controls.Add(this.CheckBoxBold);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.TxtBoxInput);
            this.Controls.Add(this.LbllInput);
            this.Name = "Week2WinForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Week 2 WinForm 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbllInput;
        private System.Windows.Forms.TextBox TxtBoxInput;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.CheckBox CheckBoxBold;
        private System.Windows.Forms.CheckBox CheckBoxItalic;
        private System.Windows.Forms.CheckBox CheckBoxUnderline;
        private System.Windows.Forms.RadioButton RadioBtnRed;
        private System.Windows.Forms.RadioButton RadioBtnBlue;
        private System.Windows.Forms.Label LblOutput;
        private System.Windows.Forms.Label LblResult;
    }
}

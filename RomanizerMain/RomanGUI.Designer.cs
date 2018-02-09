namespace RomanNumeralsGUI
{
    partial class RomanizerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RomanizerForm));
            this.intInLabel = new System.Windows.Forms.Label();
            this.intOutLabel = new System.Windows.Forms.Label();
            this.intIn = new System.Windows.Forms.TextBox();
            this.intOut = new System.Windows.Forms.TextBox();
            this.Romanize = new System.Windows.Forms.Button();
            this.Deromanize = new System.Windows.Forms.Button();
            this.InstructionBox = new System.Windows.Forms.TextBox();
            this.outBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // intInLabel
            // 
            this.intInLabel.AutoSize = true;
            this.intInLabel.Location = new System.Drawing.Point(47, 91);
            this.intInLabel.Name = "intInLabel";
            this.intInLabel.Size = new System.Drawing.Size(89, 13);
            this.intInLabel.TabIndex = 0;
            this.intInLabel.Text = "Arabic to Roman:";
            // 
            // intOutLabel
            // 
            this.intOutLabel.AutoSize = true;
            this.intOutLabel.Location = new System.Drawing.Point(47, 141);
            this.intOutLabel.Name = "intOutLabel";
            this.intOutLabel.Size = new System.Drawing.Size(89, 13);
            this.intOutLabel.TabIndex = 1;
            this.intOutLabel.Text = "Roman to Arabic:";
            // 
            // intIn
            // 
            this.intIn.Location = new System.Drawing.Point(35, 107);
            this.intIn.Name = "intIn";
            this.intIn.Size = new System.Drawing.Size(129, 20);
            this.intIn.TabIndex = 2;
            // 
            // intOut
            // 
            this.intOut.Location = new System.Drawing.Point(35, 157);
            this.intOut.Name = "intOut";
            this.intOut.Size = new System.Drawing.Size(129, 20);
            this.intOut.TabIndex = 3;
            // 
            // Romanize
            // 
            this.Romanize.Location = new System.Drawing.Point(170, 105);
            this.Romanize.Name = "Romanize";
            this.Romanize.Size = new System.Drawing.Size(84, 23);
            this.Romanize.TabIndex = 4;
            this.Romanize.Text = "Romanize!";
            this.Romanize.UseVisualStyleBackColor = true;
            this.Romanize.Click += new System.EventHandler(this.Romanize_Click);
            // 
            // Deromanize
            // 
            this.Deromanize.Location = new System.Drawing.Point(170, 154);
            this.Deromanize.Name = "Deromanize";
            this.Deromanize.Size = new System.Drawing.Size(84, 23);
            this.Deromanize.TabIndex = 5;
            this.Deromanize.Text = "Deromanize!";
            this.Deromanize.UseVisualStyleBackColor = true;
            this.Deromanize.Click += new System.EventHandler(this.Deromanize_Click);
            // 
            // InstructionBox
            // 
            this.InstructionBox.Location = new System.Drawing.Point(12, 12);
            this.InstructionBox.Multiline = true;
            this.InstructionBox.Name = "InstructionBox";
            this.InstructionBox.ReadOnly = true;
            this.InstructionBox.Size = new System.Drawing.Size(260, 62);
            this.InstructionBox.TabIndex = 6;
            this.InstructionBox.Text = resources.GetString("InstructionBox.Text");
            // 
            // outBox
            // 
            this.outBox.Font = new System.Drawing.Font("Felix Titling", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outBox.Location = new System.Drawing.Point(12, 220);
            this.outBox.Multiline = true;
            this.outBox.Name = "outBox";
            this.outBox.ReadOnly = true;
            this.outBox.Size = new System.Drawing.Size(260, 29);
            this.outBox.TabIndex = 7;
            this.outBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RomanizerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.outBox);
            this.Controls.Add(this.InstructionBox);
            this.Controls.Add(this.Deromanize);
            this.Controls.Add(this.Romanize);
            this.Controls.Add(this.intOut);
            this.Controls.Add(this.intIn);
            this.Controls.Add(this.intOutLabel);
            this.Controls.Add(this.intInLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RomanizerForm";
            this.Text = "Romanizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label intInLabel;
        private System.Windows.Forms.Label intOutLabel;
        private System.Windows.Forms.TextBox intIn;
        private System.Windows.Forms.TextBox intOut;
        private System.Windows.Forms.Button Romanize;
        private System.Windows.Forms.Button Deromanize;
        private System.Windows.Forms.TextBox InstructionBox;
        private System.Windows.Forms.TextBox outBox;
    }
}


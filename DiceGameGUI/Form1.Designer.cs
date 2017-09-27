namespace DiceGameGUI
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
            this.btnThrowDice = new System.Windows.Forms.Button();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnThrowDice
            // 
            this.btnThrowDice.Location = new System.Drawing.Point(83, 22);
            this.btnThrowDice.Name = "btnThrowDice";
            this.btnThrowDice.Size = new System.Drawing.Size(125, 64);
            this.btnThrowDice.TabIndex = 0;
            this.btnThrowDice.Text = "Throw Dice";
            this.btnThrowDice.UseVisualStyleBackColor = true;
            this.btnThrowDice.Click += new System.EventHandler(this.btnThrowDice_Click);
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(129, 147);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(29, 13);
            this.lblFeedback.TabIndex = 1;
            this.lblFeedback.Text = "Dice";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 261);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.btnThrowDice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThrowDice;
        private System.Windows.Forms.Label lblFeedback;
    }
}


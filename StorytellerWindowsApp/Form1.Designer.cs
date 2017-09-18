namespace StorytellerWindowsApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNameOfChild = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.cbScary = new System.Windows.Forms.CheckBox();
            this.btnTellstory = new System.Windows.Forms.Button();
            this.tbStory = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of Child";
            // 
            // tbNameOfChild
            // 
            this.tbNameOfChild.Location = new System.Drawing.Point(13, 30);
            this.tbNameOfChild.Name = "tbNameOfChild";
            this.tbNameOfChild.Size = new System.Drawing.Size(180, 20);
            this.tbNameOfChild.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Age of Child";
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(13, 74);
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(120, 20);
            this.numAge.TabIndex = 3;
            // 
            // cbScary
            // 
            this.cbScary.AutoSize = true;
            this.cbScary.Location = new System.Drawing.Point(13, 111);
            this.cbScary.Name = "cbScary";
            this.cbScary.Size = new System.Drawing.Size(102, 17);
            this.cbScary.TabIndex = 4;
            this.cbScary.Text = "Should be scary";
            this.cbScary.UseVisualStyleBackColor = true;
            // 
            // btnTellstory
            // 
            this.btnTellstory.Location = new System.Drawing.Point(13, 147);
            this.btnTellstory.Name = "btnTellstory";
            this.btnTellstory.Size = new System.Drawing.Size(75, 23);
            this.btnTellstory.TabIndex = 5;
            this.btnTellstory.Text = "Tell story!";
            this.btnTellstory.UseVisualStyleBackColor = true;
            this.btnTellstory.Click += new System.EventHandler(this.btnTellstory_Click);
            // 
            // tbStory
            // 
            this.tbStory.Location = new System.Drawing.Point(13, 192);
            this.tbStory.Multiline = true;
            this.tbStory.Name = "tbStory";
            this.tbStory.Size = new System.Drawing.Size(539, 116);
            this.tbStory.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 320);
            this.Controls.Add(this.tbStory);
            this.Controls.Add(this.btnTellstory);
            this.Controls.Add(this.cbScary);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNameOfChild);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Storyteller App";
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNameOfChild;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.CheckBox cbScary;
        private System.Windows.Forms.Button btnTellstory;
        private System.Windows.Forms.TextBox tbStory;
    }
}


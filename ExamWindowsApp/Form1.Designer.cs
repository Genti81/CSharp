namespace ExamWindowsApp
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
            this.btnAssign = new System.Windows.Forms.Button();
            this.txtStudent = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbGrade = new System.Windows.Forms.ComboBox();
            this.btnGrade = new System.Windows.Forms.Button();
            this.cbStudents = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lbVG = new System.Windows.Forms.Label();
            this.lbG = new System.Windows.Forms.Label();
            this.lbIG = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(423, 16);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(75, 23);
            this.btnAssign.TabIndex = 0;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // txtStudent
            // 
            this.txtStudent.Location = new System.Drawing.Point(17, 19);
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.Size = new System.Drawing.Size(357, 20);
            this.txtStudent.TabIndex = 1;
            this.txtStudent.TextChanged += new System.EventHandler(this.txtStudent_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtStudent);
            this.groupBox1.Controls.Add(this.btnAssign);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 50);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbGrade);
            this.groupBox2.Controls.Add(this.btnGrade);
            this.groupBox2.Controls.Add(this.cbStudents);
            this.groupBox2.Location = new System.Drawing.Point(12, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(637, 110);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grade";
            // 
            // cmbGrade
            // 
            this.cmbGrade.FormattingEnabled = true;
            this.cmbGrade.Items.AddRange(new object[] {
            "IG",
            "G",
            "VG"});
            this.cmbGrade.Location = new System.Drawing.Point(17, 66);
            this.cmbGrade.Name = "cmbGrade";
            this.cmbGrade.Size = new System.Drawing.Size(121, 21);
            this.cmbGrade.TabIndex = 2;
            this.cmbGrade.SelectedIndexChanged += new System.EventHandler(this.cmbGrade_SelectedIndexChanged);
            // 
            // btnGrade
            // 
            this.btnGrade.Location = new System.Drawing.Point(174, 66);
            this.btnGrade.Name = "btnGrade";
            this.btnGrade.Size = new System.Drawing.Size(75, 23);
            this.btnGrade.TabIndex = 1;
            this.btnGrade.Text = "Grade";
            this.btnGrade.UseVisualStyleBackColor = true;
            this.btnGrade.Click += new System.EventHandler(this.btnGrade_Click);
            // 
            // cbStudents
            // 
            this.cbStudents.FormattingEnabled = true;
            this.cbStudents.Location = new System.Drawing.Point(17, 19);
            this.cbStudents.Name = "cbStudents";
            this.cbStudents.Size = new System.Drawing.Size(357, 21);
            this.cbStudents.TabIndex = 0;
            this.cbStudents.SelectedIndexChanged += new System.EventHandler(this.txtGrade_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGenerate);
            this.groupBox3.Controls.Add(this.lbVG);
            this.groupBox3.Controls.Add(this.lbG);
            this.groupBox3.Controls.Add(this.lbIG);
            this.groupBox3.Location = new System.Drawing.Point(12, 184);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(637, 182);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Statistics";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(342, 73);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(156, 66);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate Statistics";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lbVG
            // 
            this.lbVG.AutoSize = true;
            this.lbVG.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVG.Location = new System.Drawing.Point(178, 116);
            this.lbVG.Name = "lbVG";
            this.lbVG.Size = new System.Drawing.Size(71, 29);
            this.lbVG.TabIndex = 2;
            this.lbVG.Text = "VG: 0";
            // 
            // lbG
            // 
            this.lbG.AutoSize = true;
            this.lbG.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbG.Location = new System.Drawing.Point(178, 73);
            this.lbG.Name = "lbG";
            this.lbG.Size = new System.Drawing.Size(56, 29);
            this.lbG.TabIndex = 1;
            this.lbG.Text = "G: 0";
            // 
            // lbIG
            // 
            this.lbIG.AutoSize = true;
            this.lbIG.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIG.Location = new System.Drawing.Point(176, 28);
            this.lbIG.Name = "lbIG";
            this.lbIG.Size = new System.Drawing.Size(62, 29);
            this.lbIG.TabIndex = 0;
            this.lbIG.Text = "IG: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 369);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.TextBox txtStudent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGrade;
        private System.Windows.Forms.ComboBox cbStudents;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbVG;
        private System.Windows.Forms.Label lbG;
        private System.Windows.Forms.Label lbIG;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ComboBox cmbGrade;
    }
}


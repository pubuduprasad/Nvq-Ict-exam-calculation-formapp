
namespace FormsApp
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
            this.Name = new System.Windows.Forms.TextBox();
            this.MsAccess = new System.Windows.Forms.TextBox();
            this.MsExcel = new System.Windows.Forms.TextBox();
            this.MsWord = new System.Windows.Forms.TextBox();
            this.MsPowerPoint = new System.Windows.Forms.TextBox();
            this.CalculateBTN = new System.Windows.Forms.Button();
            this.ClearBTN = new System.Windows.Forms.Button();
            this.ExitBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TotalResult = new System.Windows.Forms.TextBox();
            this.AverageResult = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.GradeResult = new System.Windows.Forms.TextBox();
            this.CompetentResult = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(148, 28);
            this.Name.Multiline = true;
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(269, 26);
            this.Name.TabIndex = 0;
            // 
            // MsAccess
            // 
            this.MsAccess.Location = new System.Drawing.Point(148, 152);
            this.MsAccess.Multiline = true;
            this.MsAccess.Name = "MsAccess";
            this.MsAccess.Size = new System.Drawing.Size(269, 26);
            this.MsAccess.TabIndex = 1;
            // 
            // MsExcel
            // 
            this.MsExcel.Location = new System.Drawing.Point(148, 111);
            this.MsExcel.Multiline = true;
            this.MsExcel.Name = "MsExcel";
            this.MsExcel.Size = new System.Drawing.Size(269, 26);
            this.MsExcel.TabIndex = 2;
            // 
            // MsWord
            // 
            this.MsWord.Location = new System.Drawing.Point(148, 70);
            this.MsWord.Multiline = true;
            this.MsWord.Name = "MsWord";
            this.MsWord.Size = new System.Drawing.Size(269, 26);
            this.MsWord.TabIndex = 3;
            // 
            // MsPowerPoint
            // 
            this.MsPowerPoint.Location = new System.Drawing.Point(148, 197);
            this.MsPowerPoint.Multiline = true;
            this.MsPowerPoint.Name = "MsPowerPoint";
            this.MsPowerPoint.Size = new System.Drawing.Size(269, 26);
            this.MsPowerPoint.TabIndex = 4;
            // 
            // CalculateBTN
            // 
            this.CalculateBTN.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBTN.Location = new System.Drawing.Point(31, 280);
            this.CalculateBTN.Name = "CalculateBTN";
            this.CalculateBTN.Size = new System.Drawing.Size(252, 37);
            this.CalculateBTN.TabIndex = 5;
            this.CalculateBTN.Text = "Calculate ";
            this.CalculateBTN.UseVisualStyleBackColor = true;
            this.CalculateBTN.Click += new System.EventHandler(this.CalculateBTN_Click);
            // 
            // ClearBTN
            // 
            this.ClearBTN.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.ClearBTN.Location = new System.Drawing.Point(292, 280);
            this.ClearBTN.Name = "ClearBTN";
            this.ClearBTN.Size = new System.Drawing.Size(252, 37);
            this.ClearBTN.TabIndex = 6;
            this.ClearBTN.Text = "Clear";
            this.ClearBTN.UseVisualStyleBackColor = true;
            this.ClearBTN.Click += new System.EventHandler(this.ClearBTN_Click);
            // 
            // ExitBTN
            // 
            this.ExitBTN.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.ExitBTN.Location = new System.Drawing.Point(558, 280);
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.Size = new System.Drawing.Size(252, 37);
            this.ExitBTN.TabIndex = 7;
            this.ExitBTN.Text = "Exit";
            this.ExitBTN.UseVisualStyleBackColor = true;
            this.ExitBTN.Click += new System.EventHandler(this.ExitBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "MS Access ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "MS Excel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "MS Word";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "MS Power Point ";
            // 
            // TotalResult
            // 
            this.TotalResult.Location = new System.Drawing.Point(160, 363);
            this.TotalResult.Multiline = true;
            this.TotalResult.Name = "TotalResult";
            this.TotalResult.Size = new System.Drawing.Size(251, 40);
            this.TotalResult.TabIndex = 14;
            // 
            // AverageResult
            // 
            this.AverageResult.Location = new System.Drawing.Point(160, 411);
            this.AverageResult.Multiline = true;
            this.AverageResult.Name = "AverageResult";
            this.AverageResult.Size = new System.Drawing.Size(251, 41);
            this.AverageResult.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(94, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Total ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(69, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Average ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(486, 425);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 19);
            this.label8.TabIndex = 23;
            this.label8.Text = "Grade ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(450, 369);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "Competent";
            // 
            // GradeResult
            // 
            this.GradeResult.Location = new System.Drawing.Point(559, 411);
            this.GradeResult.Multiline = true;
            this.GradeResult.Name = "GradeResult";
            this.GradeResult.Size = new System.Drawing.Size(251, 41);
            this.GradeResult.TabIndex = 21;
            // 
            // CompetentResult
            // 
            this.CompetentResult.Location = new System.Drawing.Point(559, 363);
            this.CompetentResult.Multiline = true;
            this.CompetentResult.Name = "CompetentResult";
            this.CompetentResult.Size = new System.Drawing.Size(251, 40);
            this.CompetentResult.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MsPowerPoint);
            this.groupBox1.Controls.Add(this.Name);
            this.groupBox1.Controls.Add(this.MsAccess);
            this.groupBox1.Controls.Add(this.MsExcel);
            this.groupBox1.Controls.Add(this.MsWord);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 254);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MARKS";
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 337);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(815, 132);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RESULTS";
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel.Location = new System.Drawing.Point(623, 480);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(204, 16);
            this.linkLabel.TabIndex = 26;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "https://github.com/pubuduprasad";
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label10.Location = new System.Drawing.Point(467, 480);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 16);
            this.label10.TabIndex = 27;
            this.label10.Text = "Created by pubuduzeo :)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 505);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.GradeResult);
            this.Controls.Add(this.CompetentResult);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AverageResult);
            this.Controls.Add(this.TotalResult);
            this.Controls.Add(this.ExitBTN);
            this.Controls.Add(this.ClearBTN);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.CalculateBTN);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form C#";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
        private System.Windows.Forms.TextBox Name;
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
        private System.Windows.Forms.TextBox MsAccess;
        private System.Windows.Forms.TextBox MsExcel;
        private System.Windows.Forms.TextBox MsWord;
        private System.Windows.Forms.TextBox MsPowerPoint;
        private System.Windows.Forms.Button CalculateBTN;
        private System.Windows.Forms.Button ClearBTN;
        private System.Windows.Forms.Button ExitBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TotalResult;
        private System.Windows.Forms.TextBox AverageResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox GradeResult;
        private System.Windows.Forms.TextBox CompetentResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel linkLabel;
        private System.Windows.Forms.Label label10;
    }
}


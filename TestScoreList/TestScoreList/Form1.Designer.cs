namespace TestScoreList
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.belowAvgoutputLabel = new System.Windows.Forms.Label();
            this.aboveAvgOutputLabel = new System.Windows.Forms.Label();
            this.avgScoreOutputLabel = new System.Windows.Forms.Label();
            this.belowAvgScore = new System.Windows.Forms.Label();
            this.aboveAvgScore = new System.Windows.Forms.Label();
            this.AvgScoreLabel = new System.Windows.Forms.Label();
            this.getScore = new System.Windows.Forms.Button();
            this.exitScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(39, 60);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(161, 329);
            this.listBox1.TabIndex = 0;
            // 
            // belowAvgoutputLabel
            // 
            this.belowAvgoutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.belowAvgoutputLabel.Location = new System.Drawing.Point(446, 157);
            this.belowAvgoutputLabel.Name = "belowAvgoutputLabel";
            this.belowAvgoutputLabel.Size = new System.Drawing.Size(122, 23);
            this.belowAvgoutputLabel.TabIndex = 1;
            this.belowAvgoutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aboveAvgOutputLabel
            // 
            this.aboveAvgOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aboveAvgOutputLabel.Location = new System.Drawing.Point(446, 109);
            this.aboveAvgOutputLabel.Name = "aboveAvgOutputLabel";
            this.aboveAvgOutputLabel.Size = new System.Drawing.Size(122, 23);
            this.aboveAvgOutputLabel.TabIndex = 2;
            this.aboveAvgOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // avgScoreOutputLabel
            // 
            this.avgScoreOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.avgScoreOutputLabel.Location = new System.Drawing.Point(446, 60);
            this.avgScoreOutputLabel.Name = "avgScoreOutputLabel";
            this.avgScoreOutputLabel.Size = new System.Drawing.Size(122, 23);
            this.avgScoreOutputLabel.TabIndex = 3;
            this.avgScoreOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // belowAvgScore
            // 
            this.belowAvgScore.AutoSize = true;
            this.belowAvgScore.Location = new System.Drawing.Point(276, 167);
            this.belowAvgScore.Name = "belowAvgScore";
            this.belowAvgScore.Size = new System.Drawing.Size(164, 13);
            this.belowAvgScore.TabIndex = 4;
            this.belowAvgScore.Text = "Numer of Scores Below Average:";
            // 
            // aboveAvgScore
            // 
            this.aboveAvgScore.AutoSize = true;
            this.aboveAvgScore.Location = new System.Drawing.Point(268, 119);
            this.aboveAvgScore.Name = "aboveAvgScore";
            this.aboveAvgScore.Size = new System.Drawing.Size(172, 13);
            this.aboveAvgScore.TabIndex = 5;
            this.aboveAvgScore.Text = "Number of Scores Above Average:";
            // 
            // AvgScoreLabel
            // 
            this.AvgScoreLabel.AutoSize = true;
            this.AvgScoreLabel.Location = new System.Drawing.Point(353, 65);
            this.AvgScoreLabel.Name = "AvgScoreLabel";
            this.AvgScoreLabel.Size = new System.Drawing.Size(87, 13);
            this.AvgScoreLabel.TabIndex = 6;
            this.AvgScoreLabel.Text = "Avearage Score:";
            // 
            // getScore
            // 
            this.getScore.Location = new System.Drawing.Point(345, 369);
            this.getScore.Name = "getScore";
            this.getScore.Size = new System.Drawing.Size(75, 23);
            this.getScore.TabIndex = 7;
            this.getScore.Text = "Get Scores";
            this.getScore.UseVisualStyleBackColor = true;
            this.getScore.Click += new System.EventHandler(this.getScore_Click);
            // 
            // exitScore
            // 
            this.exitScore.Location = new System.Drawing.Point(493, 369);
            this.exitScore.Name = "exitScore";
            this.exitScore.Size = new System.Drawing.Size(75, 23);
            this.exitScore.TabIndex = 8;
            this.exitScore.Text = "Exit";
            this.exitScore.UseVisualStyleBackColor = true;
            this.exitScore.Click += new System.EventHandler(this.exitScore_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 404);
            this.Controls.Add(this.exitScore);
            this.Controls.Add(this.getScore);
            this.Controls.Add(this.AvgScoreLabel);
            this.Controls.Add(this.aboveAvgScore);
            this.Controls.Add(this.belowAvgScore);
            this.Controls.Add(this.avgScoreOutputLabel);
            this.Controls.Add(this.aboveAvgOutputLabel);
            this.Controls.Add(this.belowAvgoutputLabel);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label belowAvgoutputLabel;
        private System.Windows.Forms.Label aboveAvgOutputLabel;
        private System.Windows.Forms.Label avgScoreOutputLabel;
        private System.Windows.Forms.Label belowAvgScore;
        private System.Windows.Forms.Label aboveAvgScore;
        private System.Windows.Forms.Label AvgScoreLabel;
        private System.Windows.Forms.Button getScore;
        private System.Windows.Forms.Button exitScore;
    }
}


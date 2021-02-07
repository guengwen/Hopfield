
namespace IS2HopfieldNetwork
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.imageMagnifier3 = new ImageMagnifier.ImageMagnifier();
            this.imageMagnifier5 = new ImageMagnifier.ImageMagnifier();
            this.imageMagnifier6 = new ImageMagnifier.ImageMagnifier();
            this.imageMagnifier2 = new ImageMagnifier.ImageMagnifier();
            this.imageMagnifier1 = new ImageMagnifier.ImageMagnifier();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.imageMagnifier4 = new ImageMagnifier.ImageMagnifier();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(244, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 57);
            this.label2.TabIndex = 15;
            this.label2.Text = "Suwat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(198, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Writing Aid Utilizing Neural Network";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(203, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 19);
            this.label6.TabIndex = 28;
            this.label6.Text = "(2. Write your word on the canvases.)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(39, 263);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 193);
            this.panel1.TabIndex = 25;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(281, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "CANVAS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(281, 493);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 19);
            this.label8.TabIndex = 34;
            this.label8.Text = "(3. Voila!)";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Khaki;
            this.button2.Location = new System.Drawing.Point(214, 515);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "Recognize Word";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imageMagnifier3
            // 
            this.imageMagnifier3.BackColor = System.Drawing.Color.Gold;
            this.imageMagnifier3.ImageToMagnify = null;
            this.imageMagnifier3.Location = new System.Drawing.Point(149, 544);
            this.imageMagnifier3.MagnificationCoefficient = 1;
            this.imageMagnifier3.Name = "imageMagnifier3";
            this.imageMagnifier3.Size = new System.Drawing.Size(105, 105);
            this.imageMagnifier3.TabIndex = 31;
            this.imageMagnifier3.Text = "imageMagnifier3";
            // 
            // imageMagnifier5
            // 
            this.imageMagnifier5.BackColor = System.Drawing.Color.Gold;
            this.imageMagnifier5.ImageToMagnify = null;
            this.imageMagnifier5.Location = new System.Drawing.Point(260, 544);
            this.imageMagnifier5.MagnificationCoefficient = 1;
            this.imageMagnifier5.Name = "imageMagnifier5";
            this.imageMagnifier5.Size = new System.Drawing.Size(105, 105);
            this.imageMagnifier5.TabIndex = 32;
            this.imageMagnifier5.Text = "imageMagnifier5";
            // 
            // imageMagnifier6
            // 
            this.imageMagnifier6.BackColor = System.Drawing.Color.Gold;
            this.imageMagnifier6.ImageToMagnify = null;
            this.imageMagnifier6.Location = new System.Drawing.Point(371, 544);
            this.imageMagnifier6.MagnificationCoefficient = 1;
            this.imageMagnifier6.Name = "imageMagnifier6";
            this.imageMagnifier6.Size = new System.Drawing.Size(105, 105);
            this.imageMagnifier6.TabIndex = 33;
            this.imageMagnifier6.Text = "imageMagnifier6";
            // 
            // imageMagnifier2
            // 
            this.imageMagnifier2.BackColor = System.Drawing.Color.Gold;
            this.imageMagnifier2.ImageToMagnify = null;
            this.imageMagnifier2.Location = new System.Drawing.Point(283, 119);
            this.imageMagnifier2.MagnificationCoefficient = 1;
            this.imageMagnifier2.Name = "imageMagnifier2";
            this.imageMagnifier2.Size = new System.Drawing.Size(60, 59);
            this.imageMagnifier2.TabIndex = 37;
            this.imageMagnifier2.Text = "imageMagnifier2";
            this.imageMagnifier2.Click += new System.EventHandler(this.imageMagnifier2_Click);
            // 
            // imageMagnifier1
            // 
            this.imageMagnifier1.BackColor = System.Drawing.Color.Gold;
            this.imageMagnifier1.ImageToMagnify = null;
            this.imageMagnifier1.Location = new System.Drawing.Point(217, 119);
            this.imageMagnifier1.MagnificationCoefficient = 1;
            this.imageMagnifier1.Name = "imageMagnifier1";
            this.imageMagnifier1.Size = new System.Drawing.Size(60, 59);
            this.imageMagnifier1.TabIndex = 36;
            this.imageMagnifier1.Text = "imageMagnifier1";
            this.imageMagnifier1.Click += new System.EventHandler(this.imageMagnifier1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(327, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "A, B, C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(247, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Letters to Use:";
            // 
            // imageMagnifier4
            // 
            this.imageMagnifier4.BackColor = System.Drawing.Color.Gold;
            this.imageMagnifier4.ImageToMagnify = null;
            this.imageMagnifier4.Location = new System.Drawing.Point(349, 119);
            this.imageMagnifier4.MagnificationCoefficient = 1;
            this.imageMagnifier4.Name = "imageMagnifier4";
            this.imageMagnifier4.Size = new System.Drawing.Size(60, 59);
            this.imageMagnifier4.TabIndex = 39;
            this.imageMagnifier4.Text = "imageMagnifier4";
            this.imageMagnifier4.Click += new System.EventHandler(this.imageMagnifier4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(236, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 19);
            this.label4.TabIndex = 40;
            this.label4.Text = "(1. Click to select letters.)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(284, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "TEAM HOP";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Khaki;
            this.button1.Location = new System.Drawing.Point(81, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 44;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Khaki;
            this.button3.Location = new System.Drawing.Point(271, 462);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 23);
            this.button3.TabIndex = 45;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Khaki;
            this.button4.Location = new System.Drawing.Point(459, 462);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 23);
            this.button4.TabIndex = 46;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(225, 264);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 193);
            this.panel2.TabIndex = 26;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Info;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(411, 264);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 193);
            this.panel3.TabIndex = 26;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(642, 652);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.imageMagnifier2);
            this.Controls.Add(this.imageMagnifier1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.imageMagnifier4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.imageMagnifier3);
            this.Controls.Add(this.imageMagnifier5);
            this.Controls.Add(this.imageMagnifier6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Suwat: Writing Aid Utilizing Neural Network";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private ImageMagnifier.ImageMagnifier imageMagnifier3;
        private ImageMagnifier.ImageMagnifier imageMagnifier5;
        private ImageMagnifier.ImageMagnifier imageMagnifier6;
        private ImageMagnifier.ImageMagnifier imageMagnifier2;
        private ImageMagnifier.ImageMagnifier imageMagnifier1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private ImageMagnifier.ImageMagnifier imageMagnifier4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}


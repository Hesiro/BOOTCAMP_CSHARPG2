namespace WinFormsAppTikTakTok
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            label1 = new Label();
            label2 = new Label();
            labelScorePlayerX = new Label();
            labelScorePlayer0 = new Label();
            button10 = new Button();
            button11 = new Button();
            buttonExit = new Button();
            panel1 = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(14, 15);
            button1.Margin = new Padding(5, 6, 5, 6);
            button1.Name = "button1";
            button1.Size = new Size(86, 100);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(110, 15);
            button2.Margin = new Padding(5, 6, 5, 6);
            button2.Name = "button2";
            button2.Size = new Size(86, 100);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(206, 15);
            button3.Margin = new Padding(5, 6, 5, 6);
            button3.Name = "button3";
            button3.Size = new Size(86, 100);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(14, 127);
            button4.Margin = new Padding(5, 6, 5, 6);
            button4.Name = "button4";
            button4.Size = new Size(86, 100);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(110, 127);
            button5.Margin = new Padding(5, 6, 5, 6);
            button5.Name = "button5";
            button5.Size = new Size(86, 100);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(206, 127);
            button6.Margin = new Padding(5, 6, 5, 6);
            button6.Name = "button6";
            button6.Size = new Size(86, 100);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(14, 239);
            button7.Margin = new Padding(5, 6, 5, 6);
            button7.Name = "button7";
            button7.Size = new Size(86, 100);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(110, 239);
            button8.Margin = new Padding(5, 6, 5, 6);
            button8.Name = "button8";
            button8.Size = new Size(86, 100);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(206, 239);
            button9.Margin = new Padding(5, 6, 5, 6);
            button9.Name = "button9";
            button9.Size = new Size(86, 100);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 27);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(125, 40);
            label1.TabIndex = 9;
            label1.Text = "Player X:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 87);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(124, 40);
            label2.TabIndex = 10;
            label2.Text = "Player 0:";
            // 
            // labelScorePlayerX
            // 
            labelScorePlayerX.BackColor = Color.White;
            labelScorePlayerX.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelScorePlayerX.Location = new Point(183, 27);
            labelScorePlayerX.Margin = new Padding(5, 0, 5, 0);
            labelScorePlayerX.Name = "labelScorePlayerX";
            labelScorePlayerX.Size = new Size(89, 40);
            labelScorePlayerX.TabIndex = 11;
            labelScorePlayerX.Text = "0";
            labelScorePlayerX.TextAlign = ContentAlignment.MiddleCenter;
            labelScorePlayerX.Click += labelScorePlayerX_Click;
            // 
            // labelScorePlayer0
            // 
            labelScorePlayer0.BackColor = Color.White;
            labelScorePlayer0.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelScorePlayer0.Location = new Point(183, 87);
            labelScorePlayer0.Margin = new Padding(5, 0, 5, 0);
            labelScorePlayer0.Name = "labelScorePlayer0";
            labelScorePlayer0.Size = new Size(89, 40);
            labelScorePlayer0.TabIndex = 12;
            labelScorePlayer0.Text = "0";
            labelScorePlayer0.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.Location = new Point(21, 22);
            button10.Margin = new Padding(5, 6, 5, 6);
            button10.Name = "button10";
            button10.Size = new Size(264, 46);
            button10.TabIndex = 13;
            button10.Text = "NEW GAME";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(21, 91);
            button11.Margin = new Padding(5, 6, 5, 6);
            button11.Name = "button11";
            button11.Size = new Size(129, 46);
            button11.TabIndex = 14;
            button11.Text = "RESET";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(156, 91);
            buttonExit.Margin = new Padding(5, 6, 5, 6);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(129, 46);
            buttonExit.TabIndex = 15;
            buttonExit.Text = "EXIT";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label3);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(660, 69);
            panel1.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(45, 11);
            label3.Name = "label3";
            label3.Size = new Size(555, 40);
            label3.TabIndex = 0;
            label3.Text = "JUEGO TIC TAC TOC - WINDOWS FORM";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(12, 87);
            panel2.Name = "panel2";
            panel2.Size = new Size(660, 394);
            panel2.TabIndex = 17;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(button1);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button7);
            panel3.Controls.Add(button8);
            panel3.Controls.Add(button9);
            panel3.Location = new Point(13, 11);
            panel3.Name = "panel3";
            panel3.Size = new Size(309, 363);
            panel3.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label1);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(labelScorePlayerX);
            panel4.Controls.Add(labelScorePlayer0);
            panel4.Location = new Point(328, 11);
            panel4.Name = "panel4";
            panel4.Size = new Size(308, 180);
            panel4.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(button10);
            panel5.Controls.Add(button11);
            panel5.Controls.Add(buttonExit);
            panel5.Location = new Point(328, 197);
            panel5.Name = "panel5";
            panel5.Size = new Size(308, 177);
            panel5.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(696, 505);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Tic Tac Toc";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label label1;
        private Label label2;
        private Label labelScorePlayerX;
        private Label labelScorePlayer0;
        private Button button10;
        private Button button11;
        private Button buttonExit;
        private Panel panel1;
        private Label label3;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
    }
}

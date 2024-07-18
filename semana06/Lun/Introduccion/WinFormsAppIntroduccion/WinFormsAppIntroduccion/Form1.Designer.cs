namespace WinFormsAppIntroduccion
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
            btnSaluda = new Button();
            label1 = new Label();
            label2 = new Label();
            txtFirstName = new TextBox();
            txtSecondName = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnSaluda
            // 
            btnSaluda.Location = new Point(89, 88);
            btnSaluda.Name = "btnSaluda";
            btnSaluda.Size = new Size(75, 23);
            btnSaluda.TabIndex = 0;
            btnSaluda.Text = "Saluda";
            btnSaluda.UseVisualStyleBackColor = true;
            btnSaluda.Click += btnSaluda_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 15);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 1;
            label1.Text = "First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 2;
            label2.Text = "Second Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(102, 12);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 3;
            // 
            // txtSecondName
            // 
            txtSecondName.Location = new Point(102, 41);
            txtSecondName.Name = "txtSecondName";
            txtSecondName.Size = new Size(100, 23);
            txtSecondName.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(89, 119);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Ventana 2";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 154);
            Controls.Add(button1);
            Controls.Add(txtSecondName);
            Controls.Add(txtFirstName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSaluda);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaluda;
        private Label label1;
        private Label label2;
        private TextBox txtFirstName;
        private TextBox txtSecondName;
        private Button button1;
    }
}

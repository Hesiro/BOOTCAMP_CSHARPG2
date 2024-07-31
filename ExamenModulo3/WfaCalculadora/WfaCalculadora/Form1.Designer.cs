namespace WfaCalculadora
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
            textBoxResultado = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            buttonBorrarUltimo = new Button();
            buttonBorrarTodo = new Button();
            buttonRecorrer = new Button();
            button13 = new Button();
            button14 = new Button();
            buttonDivision = new Button();
            buttonMultiplicacion = new Button();
            buttonSuma = new Button();
            buttonResta = new Button();
            buttonIgual = new Button();
            buttonSigno = new Button();
            button0 = new Button();
            buttonPunto = new Button();
            SuspendLayout();
            // 
            // textBoxResultado
            // 
            textBoxResultado.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxResultado.Location = new Point(12, 12);
            textBoxResultado.MaxLength = 10;
            textBoxResultado.Multiline = true;
            textBoxResultado.Name = "textBoxResultado";
            textBoxResultado.Size = new Size(249, 51);
            textBoxResultado.TabIndex = 0;
            textBoxResultado.Text = "0";
            textBoxResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 222);
            button1.Name = "button1";
            button1.Size = new Size(45, 45);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += AgregarNumero;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(63, 222);
            button2.Name = "button2";
            button2.Size = new Size(45, 45);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += AgregarNumero;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(114, 222);
            button3.Name = "button3";
            button3.Size = new Size(45, 45);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += AgregarNumero;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(12, 171);
            button4.Name = "button4";
            button4.Size = new Size(45, 45);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += AgregarNumero;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(63, 171);
            button5.Name = "button5";
            button5.Size = new Size(45, 45);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += AgregarNumero;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(114, 171);
            button6.Name = "button6";
            button6.Size = new Size(45, 45);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += AgregarNumero;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(12, 120);
            button7.Name = "button7";
            button7.Size = new Size(45, 45);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += AgregarNumero;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.Location = new Point(63, 120);
            button8.Name = "button8";
            button8.Size = new Size(45, 45);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += AgregarNumero;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.Location = new Point(114, 120);
            button9.Name = "button9";
            button9.Size = new Size(45, 45);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += AgregarNumero;
            // 
            // buttonBorrarUltimo
            // 
            buttonBorrarUltimo.Font = new Font("Segoe UI", 12F);
            buttonBorrarUltimo.Location = new Point(114, 69);
            buttonBorrarUltimo.Name = "buttonBorrarUltimo";
            buttonBorrarUltimo.Size = new Size(45, 45);
            buttonBorrarUltimo.TabIndex = 10;
            buttonBorrarUltimo.Text = "<-";
            buttonBorrarUltimo.UseVisualStyleBackColor = true;
            buttonBorrarUltimo.Click += buttonBorrarUltimo_Click;
            // 
            // buttonBorrarTodo
            // 
            buttonBorrarTodo.Font = new Font("Segoe UI", 12F);
            buttonBorrarTodo.Location = new Point(63, 69);
            buttonBorrarTodo.Name = "buttonBorrarTodo";
            buttonBorrarTodo.Size = new Size(45, 45);
            buttonBorrarTodo.TabIndex = 11;
            buttonBorrarTodo.Text = "C";
            buttonBorrarTodo.UseVisualStyleBackColor = true;
            buttonBorrarTodo.Click += buttonBorrarTodo_Click;
            // 
            // buttonRecorrer
            // 
            buttonRecorrer.Font = new Font("Segoe UI", 12F);
            buttonRecorrer.Location = new Point(12, 69);
            buttonRecorrer.Name = "buttonRecorrer";
            buttonRecorrer.Size = new Size(45, 45);
            buttonRecorrer.TabIndex = 12;
            buttonRecorrer.Text = "CE";
            buttonRecorrer.UseVisualStyleBackColor = true;
            buttonRecorrer.Click += buttonRecorrer_Click;
            // 
            // button13
            // 
            button13.Font = new Font("Segoe UI", 12F);
            button13.Location = new Point(165, 69);
            button13.Name = "button13";
            button13.Size = new Size(45, 45);
            button13.TabIndex = 13;
            button13.Tag = "Æ";
            button13.Text = "Æ";
            button13.UseVisualStyleBackColor = true;
            button13.Click += AgregarOperador;
            // 
            // button14
            // 
            button14.Font = new Font("Segoe UI", 12F);
            button14.Location = new Point(216, 69);
            button14.Name = "button14";
            button14.Size = new Size(45, 45);
            button14.TabIndex = 14;
            button14.Text = "x^2";
            button14.UseVisualStyleBackColor = true;
            button14.Click += AgregarOperador;
            // 
            // buttonDivision
            // 
            buttonDivision.Font = new Font("Segoe UI", 12F);
            buttonDivision.Location = new Point(165, 120);
            buttonDivision.Name = "buttonDivision";
            buttonDivision.Size = new Size(45, 45);
            buttonDivision.TabIndex = 15;
            buttonDivision.Tag = "/";
            buttonDivision.Text = "/";
            buttonDivision.UseVisualStyleBackColor = true;
            buttonDivision.Click += AgregarOperador;
            // 
            // buttonMultiplicacion
            // 
            buttonMultiplicacion.Font = new Font("Segoe UI", 12F);
            buttonMultiplicacion.Location = new Point(216, 120);
            buttonMultiplicacion.Name = "buttonMultiplicacion";
            buttonMultiplicacion.Size = new Size(45, 45);
            buttonMultiplicacion.TabIndex = 16;
            buttonMultiplicacion.Tag = "x";
            buttonMultiplicacion.Text = "x";
            buttonMultiplicacion.UseVisualStyleBackColor = true;
            buttonMultiplicacion.Click += AgregarOperador;
            // 
            // buttonSuma
            // 
            buttonSuma.Font = new Font("Segoe UI", 12F);
            buttonSuma.Location = new Point(165, 171);
            buttonSuma.Name = "buttonSuma";
            buttonSuma.Size = new Size(45, 45);
            buttonSuma.TabIndex = 17;
            buttonSuma.Tag = "+";
            buttonSuma.Text = "+";
            buttonSuma.UseVisualStyleBackColor = true;
            buttonSuma.Click += AgregarOperador;
            // 
            // buttonResta
            // 
            buttonResta.Font = new Font("Segoe UI", 12F);
            buttonResta.Location = new Point(216, 171);
            buttonResta.Name = "buttonResta";
            buttonResta.Size = new Size(45, 45);
            buttonResta.TabIndex = 18;
            buttonResta.Tag = "-";
            buttonResta.Text = "-";
            buttonResta.UseVisualStyleBackColor = true;
            buttonResta.Click += AgregarOperador;
            // 
            // buttonIgual
            // 
            buttonIgual.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonIgual.Location = new Point(165, 222);
            buttonIgual.Name = "buttonIgual";
            buttonIgual.Size = new Size(96, 96);
            buttonIgual.TabIndex = 19;
            buttonIgual.Text = "=";
            buttonIgual.UseVisualStyleBackColor = true;
            buttonIgual.Click += buttonIgual_Click;
            // 
            // buttonSigno
            // 
            buttonSigno.Font = new Font("Segoe UI", 12F);
            buttonSigno.Location = new Point(12, 273);
            buttonSigno.Name = "buttonSigno";
            buttonSigno.Size = new Size(45, 45);
            buttonSigno.TabIndex = 20;
            buttonSigno.Text = "+/-";
            buttonSigno.UseVisualStyleBackColor = true;
            buttonSigno.Click += buttonSigno_Click;
            // 
            // button0
            // 
            button0.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button0.Location = new Point(63, 273);
            button0.Name = "button0";
            button0.Size = new Size(45, 45);
            button0.TabIndex = 21;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += AgregarNumero;
            // 
            // buttonPunto
            // 
            buttonPunto.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonPunto.Location = new Point(114, 273);
            buttonPunto.Name = "buttonPunto";
            buttonPunto.Size = new Size(45, 45);
            buttonPunto.TabIndex = 22;
            buttonPunto.Text = ".";
            buttonPunto.UseVisualStyleBackColor = true;
            buttonPunto.Click += buttonPunto_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(281, 335);
            Controls.Add(buttonPunto);
            Controls.Add(button0);
            Controls.Add(buttonSigno);
            Controls.Add(buttonIgual);
            Controls.Add(buttonResta);
            Controls.Add(buttonSuma);
            Controls.Add(buttonMultiplicacion);
            Controls.Add(buttonDivision);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(buttonRecorrer);
            Controls.Add(buttonBorrarTodo);
            Controls.Add(buttonBorrarUltimo);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBoxResultado);
            Name = "Form1";
            Text = "Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxResultado;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button buttonBorrarUltimo;
        private Button buttonBorrarTodo;
        private Button buttonRecorrer;
        private Button button13;
        private Button button14;
        private Button buttonDivision;
        private Button buttonMultiplicacion;
        private Button buttonSuma;
        private Button buttonResta;
        private Button buttonIgual;
        private Button buttonSigno;
        private Button button0;
        private Button buttonPunto;
    }
}

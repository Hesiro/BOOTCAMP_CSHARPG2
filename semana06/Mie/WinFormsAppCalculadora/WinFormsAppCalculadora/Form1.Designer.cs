namespace WinFormsAppCalculadora
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtPrimero = new TextBox();
            txtSegundo = new TextBox();
            btnLimpiar = new Button();
            btnCalcular = new Button();
            button3 = new Button();
            txtResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(81, 9);
            label1.Name = "label1";
            label1.Size = new Size(203, 21);
            label1.TabIndex = 0;
            label1.Text = "SUMA DE DOS NUMEROS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 60);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 1;
            label2.Text = "Primer Número";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 89);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 2;
            label3.Text = "Segundo Número";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 130);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 3;
            label4.Text = "Resultado";
            // 
            // txtPrimero
            // 
            txtPrimero.Location = new Point(146, 57);
            txtPrimero.Name = "txtPrimero";
            txtPrimero.Size = new Size(170, 23);
            txtPrimero.TabIndex = 4;
            // 
            // txtSegundo
            // 
            txtSegundo.Location = new Point(146, 86);
            txtSegundo.Name = "txtSegundo";
            txtSegundo.Size = new Size(170, 23);
            txtSegundo.TabIndex = 5;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(56, 180);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(148, 180);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // button3
            // 
            button3.Location = new Point(241, 180);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 8;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtResultado
            // 
            txtResultado.AutoSize = true;
            txtResultado.Location = new Point(148, 130);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(0, 15);
            txtResultado.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 244);
            Controls.Add(txtResultado);
            Controls.Add(button3);
            Controls.Add(btnCalcular);
            Controls.Add(btnLimpiar);
            Controls.Add(txtSegundo);
            Controls.Add(txtPrimero);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Ejercicios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtPrimero;
        private TextBox txtSegundo;
        private Button btnLimpiar;
        private Button btnCalcular;
        private Button button3;
        private Label txtResultado;
    }
}

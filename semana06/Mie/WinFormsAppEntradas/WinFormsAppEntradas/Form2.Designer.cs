namespace WinFormsAppEntradas
{
    partial class Form2
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
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            labelGenero = new Label();
            labelDireccion = new Label();
            labelEdad = new Label();
            labelApellido = new Label();
            labelNombre = new Label();
            buttonSalir = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 144);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 16;
            label6.Text = "Genero";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 115);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 15;
            label5.Text = "Dirección";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 86);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 14;
            label4.Text = "Edad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 57);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 13;
            label3.Text = "Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 28);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 12;
            label2.Text = "Nombre";
            // 
            // labelGenero
            // 
            labelGenero.AutoSize = true;
            labelGenero.Location = new Point(150, 144);
            labelGenero.Name = "labelGenero";
            labelGenero.Size = new Size(45, 15);
            labelGenero.TabIndex = 21;
            labelGenero.Text = "Genero";
            // 
            // labelDireccion
            // 
            labelDireccion.AutoSize = true;
            labelDireccion.Location = new Point(150, 115);
            labelDireccion.Name = "labelDireccion";
            labelDireccion.Size = new Size(57, 15);
            labelDireccion.TabIndex = 20;
            labelDireccion.Text = "Dirección";
            // 
            // labelEdad
            // 
            labelEdad.AutoSize = true;
            labelEdad.Location = new Point(150, 86);
            labelEdad.Name = "labelEdad";
            labelEdad.Size = new Size(33, 15);
            labelEdad.TabIndex = 19;
            labelEdad.Text = "Edad";
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Location = new Point(150, 57);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(51, 15);
            labelApellido.TabIndex = 18;
            labelApellido.Text = "Apellido";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(150, 28);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(51, 15);
            labelNombre.TabIndex = 17;
            labelNombre.Text = "Nombre";
            // 
            // buttonSalir
            // 
            buttonSalir.Location = new Point(284, 211);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(75, 23);
            buttonSalir.TabIndex = 22;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 262);
            Controls.Add(buttonSalir);
            Controls.Add(labelGenero);
            Controls.Add(labelDireccion);
            Controls.Add(labelEdad);
            Controls.Add(labelApellido);
            Controls.Add(labelNombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Form2";
            Text = "Pantalla 2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label labelGenero;
        private Label labelDireccion;
        private Label labelEdad;
        private Label labelApellido;
        private Label labelNombre;
        private Button buttonSalir;
    }
}
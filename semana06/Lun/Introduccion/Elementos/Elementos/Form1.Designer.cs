namespace Elementos
{
    partial class FormElementos
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
            labelPrueba = new Label();
            buttonIniciar = new Button();
            checkBoxMasculino = new CheckBox();
            checkBoxFemenino = new CheckBox();
            radioButtonSoltero = new RadioButton();
            radioButtonCasado = new RadioButton();
            radioButtonDivorciado = new RadioButton();
            labelEstadoCivil = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            radioButtonCuzco = new RadioButton();
            radioButtonLima = new RadioButton();
            radioButtonArequipa = new RadioButton();
            groupBox3 = new GroupBox();
            radioButtonFemenino = new RadioButton();
            radioButtonMasculino = new RadioButton();
            labelCiudad = new Label();
            labelGenero = new Label();
            comboBoxPais = new ComboBox();
            labelPais = new Label();
            pictureBox1 = new PictureBox();
            listView1 = new ListView();
            button1 = new Button();
            listBox1 = new ListBox();
            button2 = new Button();
            button3 = new Button();
            progressBar1 = new ProgressBar();
            button4 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelPrueba
            // 
            labelPrueba.AutoSize = true;
            labelPrueba.Location = new Point(263, 40);
            labelPrueba.Margin = new Padding(4, 0, 4, 0);
            labelPrueba.Name = "labelPrueba";
            labelPrueba.Size = new Size(39, 16);
            labelPrueba.TabIndex = 0;
            labelPrueba.Text = "Sexo";
            // 
            // buttonIniciar
            // 
            buttonIniciar.Location = new Point(144, 35);
            buttonIniciar.Margin = new Padding(4, 3, 4, 3);
            buttonIniciar.Name = "buttonIniciar";
            buttonIniciar.Size = new Size(85, 24);
            buttonIniciar.TabIndex = 1;
            buttonIniciar.Text = "Boton iniciar";
            buttonIniciar.UseVisualStyleBackColor = true;
            buttonIniciar.Click += buttonIniciar_Click;
            // 
            // checkBoxMasculino
            // 
            checkBoxMasculino.AutoSize = true;
            checkBoxMasculino.Location = new Point(20, 22);
            checkBoxMasculino.Margin = new Padding(4, 3, 4, 3);
            checkBoxMasculino.Name = "checkBoxMasculino";
            checkBoxMasculino.Size = new Size(98, 20);
            checkBoxMasculino.TabIndex = 2;
            checkBoxMasculino.Text = "Masculino";
            checkBoxMasculino.UseVisualStyleBackColor = true;
            // 
            // checkBoxFemenino
            // 
            checkBoxFemenino.AutoSize = true;
            checkBoxFemenino.Location = new Point(20, 49);
            checkBoxFemenino.Margin = new Padding(4, 3, 4, 3);
            checkBoxFemenino.Name = "checkBoxFemenino";
            checkBoxFemenino.Size = new Size(90, 20);
            checkBoxFemenino.TabIndex = 3;
            checkBoxFemenino.Text = "Femenino";
            checkBoxFemenino.UseVisualStyleBackColor = true;
            // 
            // radioButtonSoltero
            // 
            radioButtonSoltero.AutoSize = true;
            radioButtonSoltero.Location = new Point(7, 24);
            radioButtonSoltero.Margin = new Padding(4, 3, 4, 3);
            radioButtonSoltero.Name = "radioButtonSoltero";
            radioButtonSoltero.Size = new Size(81, 20);
            radioButtonSoltero.TabIndex = 4;
            radioButtonSoltero.TabStop = true;
            radioButtonSoltero.Text = "Soltero";
            radioButtonSoltero.UseVisualStyleBackColor = true;
            radioButtonSoltero.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButtonCasado
            // 
            radioButtonCasado.AutoSize = true;
            radioButtonCasado.Location = new Point(7, 50);
            radioButtonCasado.Margin = new Padding(4, 3, 4, 3);
            radioButtonCasado.Name = "radioButtonCasado";
            radioButtonCasado.Size = new Size(73, 20);
            radioButtonCasado.TabIndex = 5;
            radioButtonCasado.TabStop = true;
            radioButtonCasado.Text = "Casado";
            radioButtonCasado.UseVisualStyleBackColor = true;
            radioButtonCasado.CheckedChanged += radioButtonCasado_CheckedChanged;
            // 
            // radioButtonDivorciado
            // 
            radioButtonDivorciado.AutoSize = true;
            radioButtonDivorciado.Location = new Point(7, 77);
            radioButtonDivorciado.Margin = new Padding(4, 3, 4, 3);
            radioButtonDivorciado.Name = "radioButtonDivorciado";
            radioButtonDivorciado.Size = new Size(105, 20);
            radioButtonDivorciado.TabIndex = 6;
            radioButtonDivorciado.TabStop = true;
            radioButtonDivorciado.Text = "Divorciado";
            radioButtonDivorciado.UseVisualStyleBackColor = true;
            radioButtonDivorciado.CheckedChanged += radioButtonDivorciado_CheckedChanged;
            // 
            // labelEstadoCivil
            // 
            labelEstadoCivil.AutoSize = true;
            labelEstadoCivil.Location = new Point(38, 227);
            labelEstadoCivil.Margin = new Padding(4, 0, 4, 0);
            labelEstadoCivil.Name = "labelEstadoCivil";
            labelEstadoCivil.Size = new Size(103, 16);
            labelEstadoCivil.TabIndex = 7;
            labelEstadoCivil.Text = "Estado Civil";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.AliceBlue;
            groupBox1.Controls.Add(radioButtonSoltero);
            groupBox1.Controls.Add(radioButtonCasado);
            groupBox1.Controls.Add(radioButtonDivorciado);
            groupBox1.Location = new Point(20, 117);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(144, 107);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estado Civil";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.AliceBlue;
            groupBox2.Controls.Add(radioButtonCuzco);
            groupBox2.Controls.Add(radioButtonLima);
            groupBox2.Controls.Add(radioButtonArequipa);
            groupBox2.Location = new Point(204, 117);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(172, 107);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ciudad";
            // 
            // radioButtonCuzco
            // 
            radioButtonCuzco.AutoSize = true;
            radioButtonCuzco.Location = new Point(7, 77);
            radioButtonCuzco.Margin = new Padding(4, 3, 4, 3);
            radioButtonCuzco.Name = "radioButtonCuzco";
            radioButtonCuzco.Size = new Size(65, 20);
            radioButtonCuzco.TabIndex = 2;
            radioButtonCuzco.TabStop = true;
            radioButtonCuzco.Text = "Cuzco";
            radioButtonCuzco.UseVisualStyleBackColor = true;
            radioButtonCuzco.CheckedChanged += radioButtonCuzco_CheckedChanged;
            // 
            // radioButtonLima
            // 
            radioButtonLima.AutoSize = true;
            radioButtonLima.Location = new Point(7, 50);
            radioButtonLima.Margin = new Padding(4, 3, 4, 3);
            radioButtonLima.Name = "radioButtonLima";
            radioButtonLima.Size = new Size(57, 20);
            radioButtonLima.TabIndex = 1;
            radioButtonLima.TabStop = true;
            radioButtonLima.Text = "Lima";
            radioButtonLima.UseVisualStyleBackColor = true;
            radioButtonLima.CheckedChanged += radioButtonLima_CheckedChanged;
            // 
            // radioButtonArequipa
            // 
            radioButtonArequipa.AutoSize = true;
            radioButtonArequipa.Location = new Point(7, 24);
            radioButtonArequipa.Margin = new Padding(4, 3, 4, 3);
            radioButtonArequipa.Name = "radioButtonArequipa";
            radioButtonArequipa.Size = new Size(89, 20);
            radioButtonArequipa.TabIndex = 0;
            radioButtonArequipa.TabStop = true;
            radioButtonArequipa.Text = "Arequipa";
            radioButtonArequipa.UseVisualStyleBackColor = true;
            radioButtonArequipa.CheckedChanged += radioButtonArequipa_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.AliceBlue;
            groupBox3.Controls.Add(radioButtonFemenino);
            groupBox3.Controls.Add(radioButtonMasculino);
            groupBox3.Location = new Point(401, 117);
            groupBox3.Margin = new Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 3, 4, 3);
            groupBox3.Size = new Size(148, 107);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Genero";
            // 
            // radioButtonFemenino
            // 
            radioButtonFemenino.AutoSize = true;
            radioButtonFemenino.Location = new Point(7, 50);
            radioButtonFemenino.Margin = new Padding(4, 3, 4, 3);
            radioButtonFemenino.Name = "radioButtonFemenino";
            radioButtonFemenino.Size = new Size(89, 20);
            radioButtonFemenino.TabIndex = 1;
            radioButtonFemenino.TabStop = true;
            radioButtonFemenino.Text = "Femenibo";
            radioButtonFemenino.UseVisualStyleBackColor = true;
            radioButtonFemenino.CheckedChanged += radioButtonFemenino_CheckedChanged;
            // 
            // radioButtonMasculino
            // 
            radioButtonMasculino.AutoSize = true;
            radioButtonMasculino.Location = new Point(7, 24);
            radioButtonMasculino.Margin = new Padding(4, 3, 4, 3);
            radioButtonMasculino.Name = "radioButtonMasculino";
            radioButtonMasculino.Size = new Size(97, 20);
            radioButtonMasculino.TabIndex = 0;
            radioButtonMasculino.TabStop = true;
            radioButtonMasculino.Text = "Masculino";
            radioButtonMasculino.UseVisualStyleBackColor = true;
            radioButtonMasculino.CheckedChanged += radioButtonMasculino_CheckedChanged;
            // 
            // labelCiudad
            // 
            labelCiudad.AutoSize = true;
            labelCiudad.Location = new Point(263, 227);
            labelCiudad.Margin = new Padding(4, 0, 4, 0);
            labelCiudad.Name = "labelCiudad";
            labelCiudad.Size = new Size(55, 16);
            labelCiudad.TabIndex = 11;
            labelCiudad.Text = "Ciudad";
            // 
            // labelGenero
            // 
            labelGenero.AutoSize = true;
            labelGenero.Location = new Point(450, 227);
            labelGenero.Margin = new Padding(4, 0, 4, 0);
            labelGenero.Name = "labelGenero";
            labelGenero.Size = new Size(55, 16);
            labelGenero.TabIndex = 12;
            labelGenero.Text = "Genero";
            // 
            // comboBoxPais
            // 
            comboBoxPais.FormattingEnabled = true;
            comboBoxPais.Items.AddRange(new object[] { "Peru", "Chile", "Argentina", "Uruguay" });
            comboBoxPais.Location = new Point(437, 35);
            comboBoxPais.Name = "comboBoxPais";
            comboBoxPais.Size = new Size(121, 24);
            comboBoxPais.TabIndex = 13;
            comboBoxPais.SelectedIndexChanged += comboBoxPais_SelectedIndexChanged;
            // 
            // labelPais
            // 
            labelPais.AutoSize = true;
            labelPais.Location = new Point(576, 41);
            labelPais.Name = "labelPais";
            labelPais.Size = new Size(39, 16);
            labelPais.TabIndex = 14;
            labelPais.Text = "Pais";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._DSC2909_Pano;
            pictureBox1.Location = new Point(576, 92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 151);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            listView1.Location = new Point(20, 282);
            listView1.Name = "listView1";
            listView1.Size = new Size(236, 151);
            listView1.TabIndex = 16;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.Location = new Point(20, 439);
            button1.Name = "button1";
            button1.Size = new Size(75, 34);
            button1.TabIndex = 17;
            button1.Text = "Agregar List";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(300, 282);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 148);
            listBox1.TabIndex = 18;
            // 
            // button2
            // 
            button2.Location = new Point(300, 439);
            button2.Name = "button2";
            button2.Size = new Size(120, 23);
            button2.TabIndex = 19;
            button2.Text = "Agregar a ListBox";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(300, 468);
            button3.Name = "button3";
            button3.Size = new Size(120, 23);
            button3.TabIndex = 20;
            button3.Text = "Seleccion";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(437, 282);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(315, 23);
            progressBar1.TabIndex = 21;
            // 
            // button4
            // 
            button4.Location = new Point(758, 282);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 22;
            button4.Text = "Avanza";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(437, 335);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(396, 26);
            dateTimePicker1.TabIndex = 23;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(437, 375);
            label1.Name = "label1";
            label1.Size = new Size(55, 16);
            label1.TabIndex = 24;
            label1.Text = "label1";
            // 
            // FormElementos
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(845, 568);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(button4);
            Controls.Add(progressBar1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(pictureBox1);
            Controls.Add(labelPais);
            Controls.Add(comboBoxPais);
            Controls.Add(labelGenero);
            Controls.Add(labelCiudad);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(labelEstadoCivil);
            Controls.Add(checkBoxFemenino);
            Controls.Add(checkBoxMasculino);
            Controls.Add(buttonIniciar);
            Controls.Add(labelPrueba);
            Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormElementos";
            Text = "Elementos";
            Load += FormElementos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPrueba;
        private Button buttonIniciar;
        private CheckBox checkBoxMasculino;
        private CheckBox checkBoxFemenino;
        private RadioButton radioButtonSoltero;
        private RadioButton radioButtonCasado;
        private RadioButton radioButtonDivorciado;
        private Label labelEstadoCivil;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton radioButtonCuzco;
        private RadioButton radioButtonLima;
        private RadioButton radioButtonArequipa;
        private GroupBox groupBox3;
        private RadioButton radioButtonFemenino;
        private RadioButton radioButtonMasculino;
        private Label labelCiudad;
        private Label labelGenero;
        private ComboBox comboBoxPais;
        private Label labelPais;
        private PictureBox pictureBox1;
        private ListView listView1;
        private Button button1;
        private ListBox listBox1;
        private Button button2;
        private Button button3;
        private ProgressBar progressBar1;
        private Button button4;
        private DateTimePicker dateTimePicker1;
        private Label label1;
    }
}

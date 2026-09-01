namespace CASO_DE_ESTUDIO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            label1 = new Label();
            MOSRAR_RESUMEN = new Button();
            limpiar = new Button();
            label4 = new Label();
            groupBox1 = new GroupBox();
            rblinea = new RadioButton();
            rbHibrida = new RadioButton();
            rbPresencial = new RadioButton();
            ACT = new GroupBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            Rsmn = new TextBox();
            groupBox1.SuspendLayout();
            ACT.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(274, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(275, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.InfoText;
            label1.Location = new Point(123, 50);
            label1.Name = "label1";
            label1.Size = new Size(136, 15);
            label1.TabIndex = 1;
            label1.Text = "NOMBRE DEL ALUMNO:";
            label1.Click += label1_Click;
            // 
            // MOSRAR_RESUMEN
            // 
            MOSRAR_RESUMEN.BackColor = SystemColors.ButtonHighlight;
            MOSRAR_RESUMEN.ForeColor = SystemColors.InfoText;
            MOSRAR_RESUMEN.Location = new Point(229, 347);
            MOSRAR_RESUMEN.Name = "MOSRAR_RESUMEN";
            MOSRAR_RESUMEN.Size = new Size(141, 39);
            MOSRAR_RESUMEN.TabIndex = 4;
            MOSRAR_RESUMEN.Text = "Mostrar resumen";
            MOSRAR_RESUMEN.UseVisualStyleBackColor = false;
            MOSRAR_RESUMEN.Click += button1_Click;
            // 
            // limpiar
            // 
            limpiar.BackColor = SystemColors.ButtonHighlight;
            limpiar.Location = new Point(487, 347);
            limpiar.Name = "limpiar";
            limpiar.Size = new Size(117, 39);
            limpiar.TabIndex = 5;
            limpiar.Text = "Limpiar";
            limpiar.UseVisualStyleBackColor = false;
            limpiar.Click += limpiar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.InfoText;
            label4.Location = new Point(66, 432);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 6;
            label4.Text = "Resumen:";
            label4.Click += label4_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rblinea);
            groupBox1.Controls.Add(rbHibrida);
            groupBox1.Controls.Add(rbPresencial);
            groupBox1.ForeColor = SystemColors.InfoText;
            groupBox1.Location = new Point(383, 156);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(255, 166);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Modalidad favorita (solo puedes elegir una)";
            // 
            // rblinea
            // 
            rblinea.AutoSize = true;
            rblinea.Location = new Point(34, 123);
            rblinea.Name = "rblinea";
            rblinea.Size = new Size(75, 19);
            rblinea.TabIndex = 2;
            rblinea.TabStop = true;
            rblinea.Text = "EN LÍNEA";
            rblinea.UseVisualStyleBackColor = true;
            // 
            // rbHibrida
            // 
            rbHibrida.AutoSize = true;
            rbHibrida.Location = new Point(34, 78);
            rbHibrida.Name = "rbHibrida";
            rbHibrida.Size = new Size(70, 19);
            rbHibrida.TabIndex = 1;
            rbHibrida.TabStop = true;
            rbHibrida.Text = "HÍBRIDA";
            rbHibrida.UseVisualStyleBackColor = true;
            // 
            // rbPresencial
            // 
            rbPresencial.AutoSize = true;
            rbPresencial.Location = new Point(34, 34);
            rbPresencial.Name = "rbPresencial";
            rbPresencial.Size = new Size(99, 19);
            rbPresencial.TabIndex = 0;
            rbPresencial.TabStop = true;
            rbPresencial.Text = "PRESCENCIAL";
            rbPresencial.UseVisualStyleBackColor = true;
            // 
            // ACT
            // 
            ACT.Controls.Add(checkBox4);
            ACT.Controls.Add(checkBox3);
            ACT.Controls.Add(checkBox2);
            ACT.Controls.Add(checkBox1);
            ACT.ForeColor = SystemColors.InfoText;
            ACT.Location = new Point(57, 156);
            ACT.Name = "ACT";
            ACT.Size = new Size(258, 166);
            ACT.TabIndex = 3;
            ACT.TabStop = false;
            ACT.Text = "Actividades favoritas (puedes elegir varias)";
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(15, 110);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(76, 19);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "LECTURA";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(15, 85);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(100, 19);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "AURA BATTLE";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(15, 60);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(89, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "VOLLEYBOL";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(15, 34);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(69, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "FUTBOL";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Rsmn
            // 
            Rsmn.BackColor = SystemColors.MenuHighlight;
            Rsmn.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Rsmn.Location = new Point(72, 461);
            Rsmn.Multiline = true;
            Rsmn.Name = "Rsmn";
            Rsmn.ReadOnly = true;
            Rsmn.ScrollBars = ScrollBars.Vertical;
            Rsmn.Size = new Size(532, 172);
            Rsmn.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(662, 658);
            Controls.Add(Rsmn);
            Controls.Add(ACT);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(limpiar);
            Controls.Add(MOSRAR_RESUMEN);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Preferencia de actividades";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ACT.ResumeLayout(false);
            ACT.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button MOSRAR_RESUMEN;
        private Button limpiar;
        private Label label4;
        private GroupBox groupBox1;
        private RadioButton rblinea;
        private RadioButton rbHibrida;
        private RadioButton rbPresencial;
        private GroupBox ACT;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private CheckBox checkBox4;
        private TextBox Rsmn;
    }
}

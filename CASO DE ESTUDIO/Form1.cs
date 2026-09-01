namespace CASO_DE_ESTUDIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //==============================
            //1.-VALIDAR EL NOMBRE
            //==============================
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Escribe tu nombre w, plis",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                textBox1.Focus();
            }
            //==============================
            //2.-OBTENER LAS ACTIVIDADES SELECCIONADAS
            //==============================
            List<string> actividades = new List<string>();

            if (checkBox1.Checked)
            {
                actividades.Add("FUTBOL");
            }
            if (checkBox2.Checked)
            {
                actividades.Add("VOLLEYBOL");
            }
            if (checkBox3.Checked)
            {
                actividades.Add("AURA BATTLE");
            }
            if (checkBox4.Checked)
            {
                actividades.Add("LECTURA");
            }
            //==============================
            //3,-AL MENOS UNA ACTIVIDAD SELECCIONADA
            //==============================
            if (actividades.Count == 0)
            {
                MessageBox.Show("Selecciona al menos una actividad",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            //==============================
            //4.-obtener la modalidad seleccionada
            //==============================
            string modalidad = "";
            if (rbPresencial.Checked)
            {
                modalidad = "PRESENCIAL";
            }
            else if (rbHibrida.Checked)
            {
                modalidad = "HÍBRIDA";
            }
            else if (rblinea.Checked)
            {
                modalidad = "EN LÍNEA";
            }
            //==============================
            //5.-validar que se haya seleccionado una modalidad
            //==============================
            else if (string.IsNullOrWhiteSpace(modalidad))
            {
                MessageBox.Show("Selecciona una modalidad",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            //==============================
            //6.-MOSTRAR LOS DATOS EN EL TEXTBOX
            //==============================
            string resumen =

            "RESUMEN DE PREFERENCIAS\r\n" +
                "-----------------------\r\n" +
                "Nombre: " + textBox1.Text + "\r\n" +
                "Actividades: " + string.Join(", ", actividades) + "\r\n" +
                "modalidad: " + modalidad;
            Rsmn.Text = resumen;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            //limpiar nombre
            textBox1.Clear();
            //desmarcar check box
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            //desmarcar radio button
            rbPresencial.Checked = false;
            rbHibrida.Checked = false;
            rblinea.Checked = false;
            //limpiar resumen
            Rsmn.Clear();
            //poner el foco en el nombre
            textBox1.Focus();
        }
    }
}

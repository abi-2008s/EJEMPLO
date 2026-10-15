using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Leer el nombre ingresado en el TextBox
            string nombre = txtNombre.Text.Trim();

            // Verificar que el usuario haya escrito su nombre
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("¡Primero escribe tu nombre!");
                return;
            }

            // Obtener la fecha seleccionada en el DateTimePicker
            DateTime fechaNacimiento = dtpNacimiento.Value;

            // Obtener la fecha actual
            DateTime hoy = DateTime.Today;

            // Evitar fechas de nacimiento futuras
            if (fechaNacimiento.Date > hoy)
            {
                MessageBox.Show("¡Todavía no has nacido! 😂");
                return;
            }

            // Calcular la edad real
            int edad = hoy.Year - fechaNacimiento.Year;

            // Si todavía no ha cumplido años este año, restar uno
            if (fechaNacimiento.Date > hoy.AddYears(-edad))
            {
                edad--;
            }

            // Crear el segundo formulario y enviarle los datos
            Form2 resultado = new Form2(nombre, edad);

            // Mostrar el segundo formulario
            resultado.ShowDialog();
        }
    }
}

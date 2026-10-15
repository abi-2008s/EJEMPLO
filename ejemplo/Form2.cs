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
    public partial class Form2 : Form
    {
        public Form2(string nombre, int edad)
        {
            InitializeComponent();

            lblResultado.Text =
            $"¡Hola, {nombre}!\n\n" +
            $"Tienes {edad} años...\n\n" +
            "¿En serio creíste que iba a revelaaar tu edad? 😂";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

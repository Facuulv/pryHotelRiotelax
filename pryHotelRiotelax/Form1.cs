using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryHotelRiotelax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Funcion con los valores inciales
        public void ValoresIniciales()
        {
            cmbPiso.Items.Clear();
            cmbHabitacion.Items.Clear();
            cmbPiso.Items.Add("Planta Baja");
            cmbPiso.Items.Add("1° Piso");
            cmbPiso.Items.Add("2° Piso");
            cmbPiso.Items.Add("3° Piso");
            cmbPiso.Items.Add("4° Piso");
            cmbPiso.Items.Add("5° Piso (Suit)");
            cmbPiso.Items.Add("6° Piso (Suit)");
            numDias.Maximum = 30;

            numDias.Value = 0;
            cmbPiso.Text = "";
            cmbHabitacion.Text = ""; 
            chkBar.Checked = false;
            chkGimnasio.Checked = false;
            chkInternet.Checked = false;
            chkSpa.Checked = false;

            lblPrecioHabitacion.Text = "";
            lblTotalDia.Text = "";
            lblServicios.Text = "";
            lblResultado.Text = "";

            total = 0;
            precioPorHabitacion = 0;
            valorDia = 0;
            extras = 0;
        }

        //Variables globales
        int total = 0;
        int precioPorHabitacion = 0;
        int valorDia = 0;
        int extras = 0;

        // Funcion para calcular y mostrar los resultados
        private void CalculodeReserva()
        {
            lblServicios.Text = "Servicios: $" + extras.ToString();
            lblTotalDia.Text = "El total por los dias ingresados es: $" + valorDia.ToString();
            lblPrecioHabitacion.Text = "El precio por habitacion por día es: $" + precioPorHabitacion.ToString();
            total = valorDia + extras;
            lblResultado.Text = "El monto final es: $" + total.ToString();
        }

        /*Boton Calcular, controlo que dias y habitacion sean distintos de nada y 0. 
          Si no se coloca un valor, MessageBox con el error en ambos casos. */
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cmbHabitacion.Text != "")
            {
                int diasMayor0 = (int)numDias.Value;
                if (diasMayor0 != 0)
                {
                    CalculodeReserva();
                }
                else
                {
                    MessageBox.Show("Error, la cantidad de dias para reservar no puede ser 0.", "¡Advertencia!");
                }
            } else
            {
                MessageBox.Show("Debe colocar un piso y una habitación.", "¡Advertencia!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ValoresIniciales();
        }

        /* Segun que piso selecciono me coloca la cant de habitaciones con un while. Ademas para los
           indices 0 a 4 se agrega "Habitacion" y para el resto "Suit". */
        private void cmbPiso_SelectedIndexChanged(object sender, EventArgs e)
        {
            int desde = 1;
            int hasta;
            cmbHabitacion.Items.Clear();
            cmbHabitacion.Text = "";
            switch (cmbPiso.SelectedIndex)
            {
                case 0:
                    hasta = 10;                  
                    break;
                case 1:
                    desde = 101;
                    hasta = 110;      
                    break;
                case 2:
                    desde = 201;
                    hasta = 210;
                    break;
                case 3:
                    desde = 301;
                    hasta = 310;
                    break;
                case 4:
                    desde = 401;
                    hasta = 410;
                    break;
                case 5:
                    desde = 501;
                    hasta = 502;
                    break;
                default:
                    desde = 601;
                    hasta = 602;
                    break;
            }
            while (desde <= hasta)
            {
                if(cmbPiso.SelectedIndex <= 4)
                {
                    cmbHabitacion.Items.Add("Habitacion " + desde);
                } else
                {
                    cmbHabitacion.Items.Add("Suit " + desde);
                }
                desde++;
            }
        }

        /* valorDia cambia segun el index de cmbPiso. Si es <= 4 el valorDia es la cant de dias * 60.
           Si es otro caso, es * 130. Agregue una variable para guardar el precio por habitacion. */
        private void numDias_ValueChanged(object sender, EventArgs e)
        {
            int dia = (int)numDias.Value;
            if (dia > 0 && dia <= 30)
            {
                if (cmbPiso.SelectedIndex <= 4)
                {
                    precioPorHabitacion = 60;
                    valorDia = dia * 60;
                }
                else
                {
                    precioPorHabitacion = 130;
                    valorDia = dia * 130;
                }
            }
        }

        /*Funcion para sumar o restar segun si el checkBox esta seleccionado o no. Si esta seleccionado,
          osea true, se suma 50 sino se resta. Los parametros son cada checkBox. */
        public void Adicionales(bool valor)
        {
            if (valor)
            {
                extras += 50;
            }
            else
            {
                extras -= 50;
            }
        }
        private void chkGimnasio_CheckedChanged(object sender, EventArgs e)
        {
            Adicionales(chkGimnasio.Checked);
        }
        private void chkBar_CheckedChanged(object sender, EventArgs e)
        {
            Adicionales(chkBar.Checked);
        }
        private void chkInternet_CheckedChanged(object sender, EventArgs e)
        {
            Adicionales(chkInternet.Checked);
        }
        private void chkSpa_CheckedChanged(object sender, EventArgs e)
        {
            Adicionales(chkSpa.Checked);
        }

        //Boton para salir del programa
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Boton para limpiar los componentes
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ValoresIniciales();
        }
    }
}

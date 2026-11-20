using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen_RentzCar_RonaldValdez
{
    public partial class FormAlquiler : Form
    {
        decimal subtotal = 0;

        void LimpiarTodo()
        {
            subtotal = 0;
            lstAlquileres.Items.Clear();

            txtCliente.Clear();
            dtpSalida.Value = DateTime.Today;
            chkCorporativo.Checked = false;
            rbtBasico.Checked = true;
            rbtSucursal.Checked = true;

            txtVehiculo.Clear();
            txtTarifa.Clear();
            nudDias.Value = 1;
            chkGps.Checked = false;

            lblSubtotal.Text = "RD$ 0.00";
            lblDescuento.Text = "RD$ 0.00";
            lblDomicilio.Text = "RD$ 0.00";
            lblItbis.Text = "RD$ 0.00";
            lblTotal.Text = "RD$ 0.00";
        }

        public FormAlquiler()
        {
            InitializeComponent();

        }

        private void FormAlquiler_Load(object sender, EventArgs e)
        {
            nudDias.Minimum = 1;
            nudDias.Maximum = 30;
            lstAlquileres.Font = new Font("Consolas", 9);
            lblEncabezado.Font = new Font("Consolas", 9);

            lblEncabezado.Text =
                "Días".PadRight(6) +
                "Vehículo".PadRight(24) +
                "Tarifa".PadLeft(10) +
                "Total".PadLeft(12);

            LimpiarTodo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtVehiculo.Text.Trim() == "")
            {
                MessageBox.Show("Escriba el vehículo.");
                return;
            }

            if (!decimal.TryParse(txtTarifa.Text, out decimal tarifa))
            {
                MessageBox.Show("Escriba una tarifa válida.");
                return;
            }

            int dias = (int)nudDias.Value;
            string vehiculo = txtVehiculo.Text.Trim();

            if (rbtCompleto.Checked)
            {
                tarifa += 300;
                vehiculo += " (Completo)";
            }

            if (chkGps.Checked)
            {
                tarifa += 100;
                vehiculo += " (GPS)";
            }

            decimal totalLinea = tarifa * dias;
            subtotal += totalLinea;

            if (vehiculo.Length > 24)
            {
                vehiculo = vehiculo.Substring(0, 24);
            }

            string fila =
                dias.ToString().PadRight(6) +
                vehiculo.PadRight(24) +
                tarifa.ToString("N2").PadLeft(10) +
                totalLinea.ToString("N2").PadLeft(12);

            lstAlquileres.Items.Add(fila);

            txtVehiculo.Clear();
            txtTarifa.Clear();
            nudDias.Value = 1;
            chkGps.Checked = false;
            txtVehiculo.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (lstAlquileres.Items.Count == 0)
            {
                MessageBox.Show("Agregue al menos un vehículo.");
                return;
            }

            decimal descuento = 0;
            if (chkCorporativo.Checked)
            {
                descuento = subtotal * 0.15m;
            }

            decimal domicilio = 0;
            if (rbtDomicilio.Checked)
            {
                domicilio = 500;
            }

            decimal baseImponible = subtotal - descuento + domicilio;
            decimal itbis = baseImponible * 0.18m;
            decimal total = baseImponible + itbis;

            lblSubtotal.Text = "RD$ " + subtotal.ToString("0.00");
            lblDescuento.Text = "RD$ " + descuento.ToString("0.00");
            lblDomicilio.Text = "RD$ " + domicilio.ToString("0.00");
            lblItbis.Text = "RD$ " + itbis.ToString("0.00");
            lblTotal.Text = "RD$ " + total.ToString("0.00");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTodo();
            txtCliente.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            {
                Close();
            }
        }
    }
}

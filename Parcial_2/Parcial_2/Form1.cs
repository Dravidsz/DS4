using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_2
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnCelsius_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInfoCelsius.Text))
            {
                MessageBox.Show("Por favor, ingrese un valor en Celsius.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            float valorCelsius =float.Parse(txtInfoCelsius.Text);
            float respCelFa = (valorCelsius * 9 / 5) + 32;
            float respKel = valorCelsius + 273;

            txtResFare1.Text = respCelFa.ToString();
            txtResCel1.Text = valorCelsius.ToString();
            txtResKel1.Text = respKel.ToString();

            lbxResponse.Items.Add($"Celsius: {valorCelsius} = Fahrenheit: {respCelFa}, Kelvin: {respKel}");
        }

        private void btnFare_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInfoFare.Text))
            {
                MessageBox.Show("Por favor, ingrese un valor en Fahrenheit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            float valorFare = float.Parse(txtInfoFare.Text);

            float operFaCel = (valorFare - 32) / 1.8f;
            float operFaKel = operFaCel + 273.15f;


            txtResFare2.Text = valorFare.ToString();
            txtResCel2.Text = operFaCel.ToString();    
            txtResKel2.Text = operFaKel.ToString();

            lbxResponse.Items.Add($"Fahrenheit: {valorFare} = Celsius: {operFaCel}, Kelvin: {operFaKel}");

        }

        private void btnKelvin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInfoKelvin.Text))
            {
                MessageBox.Show("Por favor, ingrese un valor en Kelvin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            float valorKelvin = float.Parse(txtInfoKelvin.Text);
            float operKelCel = valorKelvin - 273.15f;
            float operKelFa = (operKelCel * 9 / 5) + 32;

            txtResFare3.Text = operKelFa.ToString();
            txtResCel3.Text = operKelCel.ToString();
            txtResKel3.Text =   valorKelvin.ToString();

            lbxResponse.Items.Add($"Kelvin: {valorKelvin} = Celsius: {operKelCel}, Fahrenheit: {operKelFa}");

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtInfoCelsius.Text = "";
            txtInfoFare.Text = "";
            txtInfoKelvin.Text = "";

            txtResCel1.Text = "";
            txtResCel2.Text = "";
            txtResCel3.Text = "";

            txtResFare1.Text = "";
            txtResFare2.Text = "";
            txtResFare3.Text = "";


            txtResKel1.Text = "";
            txtResKel2.Text = "";
            txtResKel3.Text = "";

            lbxResponse.Items.Clear();
        }
    }
}

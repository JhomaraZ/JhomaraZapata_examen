﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JhomaraZapata_examen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
    {
        public Resumen(string nombre, string cuota)
        {
            InitializeComponent();
            lblNombre.Text = "" + nombre;
            txtPagoMensual.Text = "" + cuota;
        }

        private void BtnRegresar_Clicked(object sender, EventArgs e)
        {

        }
    }
}
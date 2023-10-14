using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PIxamarim
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        //Funções do botão// 
        private void Button_Clicked(object sender, EventArgs e)
        {
            //Correção de problema de apertar calcular sem iserir os dados//
            if(!string.IsNullOrEmpty(Altura.Text) && !string.IsNullOrEmpty(Peso.Text))
            {
                //Cálculo do IMC//
                var altura = double.Parse(Altura.Text);
                var peso = double.Parse(Peso.Text);
                var imc = peso / (altura * altura);
                IMC.Text = imc.ToString();


                // Caixa de Aviso //
                string resultado = "";

                if (imc < 18.5)
                {
                    resultado = "Abaixo do peso";
                }
                else if (imc >= 18.5 && imc <= 24.9)
                {
                    resultado = "Seu peso está normal";
                }
                else if (imc >= 25.0 && imc <= 29.9)
                {
                    resultado = "Pré-obesidade";
                }
                else if (imc >= 30.0 && imc <= 34.9)
                {
                    resultado = "Obesidade Grau 1";
                }
                else if (imc >= 35.0 && imc <= 39.9)
                {
                    resultado = "Obesidade Grau 2";
                }
                else
                {
                    resultado = "Obesidade Grau 3";
                }
                DisplayAlert("Resultado", resultado, "OK");
            }
            //Aviso se não colocar os dados//
            else
            {
                DisplayAlert("Dados errados", "Insira seus dados", "OK");
            }
        }
    }
}

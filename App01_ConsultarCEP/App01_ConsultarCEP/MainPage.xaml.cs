using App01_ConsultarCEP.Servico;
using System;
using Xamarin.Forms;

namespace App01_ConsultarCEP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Botao.Clicked += BuscarCEP;
        }
        
        private void BuscarCEP(object sender, EventArgs args)
        {
            var cep = CEP.Text.Trim();
            Endereco end = ViaCEPServico.BuscarEnderecoViaCEP(cep);
            Resultado.Text = string.Format("Endereco: {2} de {3} {0}, {1}", end.localidade, end.uf, end.logradouro, end.bairro); 
        }
    }
}

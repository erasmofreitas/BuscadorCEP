using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using BuscadorCEP.Serviços.Modelo;
using BuscadorCEP.Serviços;

namespace BuscadorCEP
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BOTAO.Clicked += BuscarCEP;


        }

        private void BuscarCEP(object sender, EventArgs args)
        {
            //TODO - Lógica do programa.

            //TODO - Validações.

            string cep = CEP.Text.Trim();
            Endereco end = ViaCEPServico.BuscarEnderecoViaCEP(cep);

            RESULTADO.Text = string.Format("Endereço: {2} de {3} {0}, {1}", end.localidade, end.uf, end.logradouro, end.bairro);
        }
    }
}

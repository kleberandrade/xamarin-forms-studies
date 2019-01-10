using ConsultarCepApp.Services;
using ConsultarCepApp.Services.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ConsultarCepApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            SearchCepButton.Clicked += OnSearchCep;
        }

        private void OnSearchCep(object sender, EventArgs e)
        {
            string cep = Cep.Text;
            if (IsValidCep(cep))
            {
                Address address = CepService.FindAddressByCep(cep);
                Result.Text = JsonConvert.SerializeObject(address);
            }
        }

        public bool IsValidCep(string cep)
        {
            if (String.IsNullOrEmpty(cep))
            {
                DisplayAlert("Erro", "Campo vazio", "OK");
                return false;
            }

            cep = cep.Trim().Replace("-", "");

            if (cep.Length != 8)
            {
                DisplayAlert("Erro", "Quantidade de digitos incorretos (8 digitos)", "OK");
                return false;
            }

            if (!IsNumber(cep))
            {
                DisplayAlert("Erro", "O CEP deve ser composto somente por números", "OK");
                return false;
            }

            return true;
        }

        public static bool IsNumber(string text)
        {
            return text.All(char.IsDigit);
        }
    }
}

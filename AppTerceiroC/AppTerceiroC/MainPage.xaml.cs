using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MySqlConnector;

namespace AppTerceiroC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnSalvar_Clicked(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(Conexao.strConexao);
            MySqlCommand inserirNome = new MySqlCommand(ComandoSQL.inserirNome);

            inserirNome.Parameters.AddWithValue("@nome", txtNome.Text);
            conn.Open();
            inserirNome.ExecuteNonQuery();
            conn.Close();
            txtNome.Text = "";

            await DisplayAlert("Atenção", "Nome salvo com sucesso!", "ok");
        }
    }
}

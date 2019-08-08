using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json;
using GraphQL.Client;
using System.Net.Http;
using GraphQL.Common.Request;
using GraphQL.Common.Response;
using GraphQlApp;
using GraphQlApp.Models;

namespace GraphQlApp
{

    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing() {
            base.OnAppearing();


            var client = new GraphQLClient("https://swapi.apis.guru/");
           
            GraphQLRequest graphQLRequest = new GraphQLRequest
            {
                Query = @"query{
                           allFilms {
                                films
                                {
                                title
                                director
                                }
                            }
                        }"
            };
            GraphQLResponse graphQLResponse = await client.PostAsync(graphQLRequest);
            FilmData.ItemsSource = graphQLResponse.Data.allFilms.films.ToObject<List<Film>>();
        }
    }
}

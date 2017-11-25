using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Models;
using ToDoApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms.SQLite.SQLite;

namespace ToDoApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        private readonly SQLiteConnection sqliteConnection;
        public MainPage()
        {
            InitializeComponent();

            sqliteConnection = DependencyService.Get<ISQLite>().GetConnection();
            sqliteConnection.CreateTable<TodoModel>();

            TodoList.ItemsSource = sqliteConnection.Table<TodoModel>();


        }

        private async void AddNextPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddTodo());
        }

        private void Refesh_Clicked(object sender, EventArgs e)
        {
            TodoList.ItemsSource = sqliteConnection.Table<TodoModel>();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ToDoApp.ViewModels;


namespace ToDoApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddTodo : ContentPage
    {
        public AddTodo()
        {
            InitializeComponent();
        }

        private void addTodo_Clicked(object sender, EventArgs e)

        {
            try
            {
                TodoViewMOdel todo = new TodoViewMOdel();

                String Date = EDate.Date.ToString();



                todo.InserData(ETitle.Text, Date);

                DisplayAlert("Adding Sucess", "You To added", "ok");
            }
            catch (Exception ex)
            {
                DisplayAlert("Fail", "Tray Again", "Close");

            }
        }
    }
}
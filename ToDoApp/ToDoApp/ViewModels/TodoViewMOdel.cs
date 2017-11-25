using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Models;
using Xamarin.Forms;
using XamarinForms.SQLite.SQLite;

namespace ToDoApp.ViewModels
{
    public class TodoViewMOdel
    {
        private readonly SQLiteConnection sqliteConnection;
        public TodoViewMOdel()
        {
            sqliteConnection = DependencyService.Get<ISQLite>().GetConnection();
            sqliteConnection.CreateTable<TodoModel>();

            //Insert New Todo




        }

        public void InserData(string title, string date)
        {
            sqliteConnection.Insert(new TodoModel
            {
                Title = title,
                Date = date,
            });
        }

        public  void GetData()
        {
            sqliteConnection.Table<TodoModel>();




        }
    }
}

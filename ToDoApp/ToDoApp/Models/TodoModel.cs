using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ToDoApp.Models
{
    public class TodoModel
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string Title { get; set; }

        public string Date { get; set; }

        public override string ToString()
        {
            return string.Format("Title : {0}, Date : {1}", Title, Date);
        }

    }
}

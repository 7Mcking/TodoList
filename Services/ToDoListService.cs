using System.Collections.Generic;
using TodoList.DataModel;

namespace TodoList.Services
{

    public class ToDoListService
    {
        public IEnumerable<ToDoItem> GetItems() => new[]
        {
            new ToDoItem {Description= "Walk the dog"},
            new ToDoItem {Description  = "Buy some Milk"},
            new ToDoItem {Description  = "Learn Avalonia", IsChecked = true}
            
        };

    }
}
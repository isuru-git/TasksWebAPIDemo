using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TasksWebAPI.Models;

namespace TasksWebAPI.Services
{
    public class TodoService
    {
        public  List<Todo> AllTodos()
        {
            var Todos = new List<Todo>();
            var Todo1 = new Todo
            {
                id = 1,
                Title = "Get New Books",
                Description = "Get Some Text Books",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New
            };
            Todos.Add(Todo1);
            var Todo2 = new Todo
            {
                id = 2,
                Title = "Get Bag",
                Description = "Get new bag",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.Completed
            };
            Todos.Add(Todo2);
            var Todo3 = new Todo
            {
                id = 3,
                Title = "Get shoes",
                Description = "Get new shoes",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New
            };
            Todos.Add(Todo3);
            return Todos;

        }
    }
}

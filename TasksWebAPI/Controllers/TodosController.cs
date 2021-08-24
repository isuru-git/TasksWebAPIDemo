using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TasksWebAPI.Models;
using TasksWebAPI.Services;

namespace TasksWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private TodoService _TodoService;

        public TodosController()
        {
            _TodoService = new TodoService(); 
        }
        [HttpGet("{id}")]
        public IActionResult GetTodos(int? id)
        {
            var myTodos = _TodoService.AllTodos();
            if (id is null) return  Ok(myTodos);
            myTodos = myTodos.Where (t=> t.id==id).ToList();
            return Ok(myTodos);
        }

       
    }
}

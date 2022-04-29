using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo_Items.Data.Repository;
using FakeItEasy;
using Xunit;
using ToDo_Items.Services;
using ToDo_Items.Controllers;
using Microsoft.AspNetCore.Mvc;
using ToDo_Items.Models;

namespace TodoTestProject.Controllers
{
    public class TodoControllerTest
    {
        private readonly TodoService _todoService;
        public TodoControllerTest()
        {
            _todoService= A.Fake<TodoService>();
        }
        [Fact]
        public void TodoController_ShouldGetTodoItem_NotNull()
        { 
            
            var controller = new TodoController(_todoService);
            var result= controller.Get(1);
           
            Assert.NotNull(result);
            
           
          }
        public void TodoController_ShouldCreateItems()
        {

        }

    }
}

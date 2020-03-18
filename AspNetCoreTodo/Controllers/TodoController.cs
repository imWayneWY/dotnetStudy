using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreTodo.Models;
using AspNetCoreTodo.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreTodo.Controllers
{
    public class TodoController : Controller
    {
        private readonly ITodoItemService _todoItemService;
        public TodoController(ITodoItemService todoItemService)
        {
          _todoItemService=todoItemService;
        }
        public async Task<IActionResult> Index()
        {
            // 从数据库获取to-do条目
            var items = await _todoItemService.GetIncompleteItemsAsync();

            // 把条目置于model中
            var model = new TodoViewModel()
            {
              Items = items
            };
            // 实用model渲染视图
            return View(model);
        }
    }
}

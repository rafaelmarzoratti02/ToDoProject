using Microsoft.AspNetCore.Mvc;
using ToDo.Application.Models;
using ToDo.Core.Entities;
using ToDo.Infra.Persistence;
using ToDo.Infra;

namespace TodoApi.Controllers;

[ApiController]
[Route("task")]
public class ToDoController : ControllerBase
{
    private readonly ToDoDbContext _context;

    public ToDoController(ToDoDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var items = _context.ToDoItems.ToList();
        return Ok(items);
    }
        
        [HttpPost]
        public IActionResult Create([FromBody] ToDoInputModel model)
        {
            if (model == null)
            {
                return BadRequest();
            }

            var item = ToDoInputModel.ToEntity(model);

            _context.ToDoItems.Add(item);
            _context.SaveChanges();

            return Ok(item);
        }
    }

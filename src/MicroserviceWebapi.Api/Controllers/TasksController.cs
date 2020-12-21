using System;
using System.Collections.Generic;
using System.Linq;
using MicroserviceWebapi.Model;
using MicroserviceWebapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace MicroserviceWebapi.Api.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class TasksController : ControllerBase
    {
        private readonly TaskRepository _context;

        public TasksController (TaskRepository context)
        {
            _context = context;
            if(_context.Tasks.Count() == 0) {
                _context.Tasks.Add(new Model.Task{Uuid=Guid.NewGuid(), Title="TestFrom code A", Description="Inserting this row from code"});
                _context.Tasks.Add(new Model.Task{Uuid=Guid.NewGuid(), Title="TestFrom code B", Description="Inserting this row from code"});
                _context.Tasks.Add(new Model.Task{Uuid=Guid.NewGuid(), Title="TestFrom code C", Description="Inserting this row from code"});
                _context.Tasks.Add(new Model.Task{Uuid=Guid.NewGuid(), Title="TestFrom code D", Description="Inserting this row from code"});
                _context.Tasks.Add(new Model.Task{Uuid=Guid.NewGuid(), Title="TestFrom code E", Description="Inserting this row from code"});
                _context.Tasks.Add(new Model.Task{Uuid=Guid.NewGuid(), Title="TestFrom code F", Description="Inserting this row from code"});
                _context.Tasks.Add(new Model.Task{Uuid=Guid.NewGuid(), Title="TestFrom code G", Description="Inserting this row from code"});
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public ActionResult<List<Task>> GetAll()
        {
            return _context.Tasks.ToList();
        }

        [HttpGet("{id}", Name = "GetTask")] 
        public ActionResult<List<Task>> GetById(Guid id)
        {
            var task = _context.Tasks.Find(id);
            if(task == null)
            {
                return NotFound();
            }
            else
            {
                return new List<Task>{task};
            }
        }
    }
}
using System;
using MicroserviceWebapi.Model;
using Microsoft.EntityFrameworkCore;

namespace MicroserviceWebapi.Repository
{
    public class TaskRepository : DbContext
    {
        public TaskRepository(DbContextOptions<TaskRepository> options) : base(options)
        {

        }

        public DbSet<Task> TodoItems { get; set; }
    }
}

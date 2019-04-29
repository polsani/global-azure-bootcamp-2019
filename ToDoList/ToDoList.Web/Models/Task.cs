using System;

namespace ToDoList.Web.Models
{
    public class Task
    {
        public Guid Id { get; set; }
        public string TaskName { get; set; }
        public bool Done { get; set; }
    }
}
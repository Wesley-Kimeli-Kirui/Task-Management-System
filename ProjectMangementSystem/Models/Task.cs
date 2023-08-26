using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectMangementSystem.Models
{
    public class Task
    {
        public int TaskId { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }


        public int AssignedUserId { get; set; }
        public User AssignedUser { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
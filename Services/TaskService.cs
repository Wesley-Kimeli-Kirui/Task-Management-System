using System.Linq;
using TaskManagementApp.Data;
using TaskManagementApp.Models;

namespace TaskManagementApp.Services {
    public class TaskService {
        private readonly ApplicationDbContext _context;
        public TaskService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task GetTaskById(int taskId){
            return _context.Tasks.FirstOrDefault(t => t.Id == taskId);
        }
        public void MarkTaskAsCompleted(Task task){
            task.IsCompleted = true;
            _context.SaveChanges();
        }
        public void MarkTaskAsinProgress(Task task){
            task.TaskStatus = TaskStatus.InProgress;
            _context.SaveChanges();
        }
        public void markTaskAsPending(Task task){
            task.TaskStatus = TaskStatus.Pending;
            _context.SaveChanges();
        }
    }
}
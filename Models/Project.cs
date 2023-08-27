namespace TaskManagementApp.Models {
    public class Project {
        public int Id {get; set; }
        public string name {get; set; }

        public ICollection<Task> Tasks {get; set; }
    }
}
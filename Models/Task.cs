namespace TaskManagementApp.Models {
    public class Task{
        public int Id { get; set; }
        public string title { get; set; }
        public bool IsCompleted { get; set; }

        public int AssignedUserId { get; set; }
        public User AssignedUser { get; set; }
    }
}
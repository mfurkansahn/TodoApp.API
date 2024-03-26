namespace TodoApp.API.Models
{
    public class Todo
    {
        public Guid Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }       
        public bool IsCompleted { get; set; }
        public DateTime? CompletedDate { get; set; } //Nullable = ?
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}

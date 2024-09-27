namespace BlazorAppTask1.Model
{
    public class ToDoList
    {
        public required string Description { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsEditing { get; set; }
    }
}

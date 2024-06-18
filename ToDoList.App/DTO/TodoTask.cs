namespace ToDoList.App.DTO {
    public class TodoTask {
        public string? Text { get; init; }
        public bool Completed { get; set; } = false;

        public override string ToString() => Text ?? string.Empty;
    }
}
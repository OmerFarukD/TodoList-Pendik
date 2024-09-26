namespace TodoList.Models;

// Todo tablosunun Id alanı Guid olmalı
public class Todo : Entity<Guid>
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreatedDate { get; set; }
    public string StartDate { get; set; }
    public string EndDate { get; set; }
    public string Priority { get; set; }

    public bool IsCompleted { get; set; }

    public int UserId { get; set; }
}

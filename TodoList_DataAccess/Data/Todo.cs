
namespace TodoList_DataAccess
{
    public class Todo
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Selector { get; set; } = "To Do";
        public DateTime CreatedDate { get; set; } = DateTime.Now;

    }
}

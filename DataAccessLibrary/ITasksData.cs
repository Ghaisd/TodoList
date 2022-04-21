using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public interface ItasksData
    {
        Task<List<TaskModel>> Gettasks();
        Task InsertTask(TaskModel Task);
        //Task UpdateTask(TaskModel Task);
        Task DeleteTask(TaskModel Task);
    }
}
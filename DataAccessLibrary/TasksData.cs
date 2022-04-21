using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class tasksData : ItasksData
    {
        private readonly ISqlDataAccess _db;

        public tasksData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<TaskModel>> Gettasks()
        {
            string sql = "select * from dbo.TodoList";

            return _db.LoadData<TaskModel, dynamic>(sql, new { });
        }

        public Task InsertTask(TaskModel Task)
        {
            string sql = @"insert into dbo.ToDoList (Todo, Doing, Done)
                            values (@Todo, @Doing, @Done);";

            return _db.SaveData(sql, Task);
        }
      
        //public Task UpdateTask(TaskModel Task)
        //{
        //    string sql = "update people set FirstName = @FirstName were LastName = @LastName";

        //    return _db.SaveData(sql, Task);
        //}
         public Task DeleteTask(TaskModel Task)
        {
            //string sql = "delete from dbo.ToDoList";
            string sql = "delete from dbo.ToDoList where Todo ='test';";
            //string sql = "UPDATE dbo.ToDoList SET Todo = null WHERE Todo = 'test';";
            return _db.SaveData(sql, Task);
        }

    }
}

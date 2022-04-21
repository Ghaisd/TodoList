using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList_Models;

namespace TodoList_Business.Repository.IRepository
{
    public interface ITodoRepository
    {
        public Task<TodoDTO> Create(TodoDTO objDTO);
        public Task<TodoDTO> Update(TodoDTO objDTO);
        public Task<int> Delete(int id);
        public Task<TodoDTO> Get(int id);
        public Task<IEnumerable<TodoDTO>> GetAll();

    }
}

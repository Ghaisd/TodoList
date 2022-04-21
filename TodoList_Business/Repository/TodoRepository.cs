using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList_Business.Repository.IRepository;
using TodoList_DataAccess;
using TodoList_DataAccess.Data;
using TodoList_Models;

namespace TodoList_Business.Repository
{
    public class TodoRepository : ITodoRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public TodoRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<TodoDTO> Create(TodoDTO objDTO)
        {
            var obj = _mapper.Map<TodoDTO, Todo>(objDTO);
            obj.CreatedDate = DateTime.Now;
            var addedObj = _db.Todos.Add(obj);
            await _db.SaveChangesAsync();

            return _mapper.Map<Todo, TodoDTO>(addedObj.Entity);
        }
        public async Task<int> Delete(int id)
        {
            var obj = await _db.Todos.FirstOrDefaultAsync(u => u.Id == id);

            if (obj != null)
            {
                _db.Todos.Remove(obj);
                return await _db.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<TodoDTO> Get(int id)
        {
            var obj = await _db.Todos.FirstOrDefaultAsync(u => u.Id == id);
            if (obj != null)
            {
                return _mapper.Map<Todo, TodoDTO>(obj);
            }
            return new TodoDTO();
        }

        public async Task<IEnumerable<TodoDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<Todo>, IEnumerable<TodoDTO>>(_db.Todos);
        }

        public async Task<TodoDTO> Update(TodoDTO objDTO)
        {
            var objFromDb = await _db.Todos.FirstOrDefaultAsync(u => u.Id == objDTO.Id);
            if (objFromDb != null)
            {
                objFromDb.Text = objDTO.Text;
                objFromDb.Selector = objDTO.Selector;
                _db.Todos.Update(objFromDb);
                await _db.SaveChangesAsync();
                return _mapper.Map<Todo, TodoDTO>(objFromDb);
            }
            return objDTO;
        }
    }
}

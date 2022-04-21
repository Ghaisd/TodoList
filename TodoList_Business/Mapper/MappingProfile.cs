using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList_DataAccess;
using TodoList_Models;

namespace TodoList_Business.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Todo, TodoDTO>().ReverseMap();
            //CreateMap<TodoDTO, Todo>();
        }
    }
}

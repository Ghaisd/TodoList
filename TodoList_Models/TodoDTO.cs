using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList_Models
{
    public class TodoDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a text...")]
        public string Text { get; set; }
        public string Selector { get; set; } = "To Do";

    }
}

using System.ComponentModel.DataAnnotations;

namespace BlazorDemoUI.Models
{
    public class DisplayTaskModel
    {
        //[Required]
        //[StringLength(15, ErrorMessage = "First Name is too long.")]
        //[MinLength(5, ErrorMessage = "First Name is too short.")]
        public string Todo { get; set; }

        //[Required]
        //[StringLength(15, ErrorMessage = "Last Name is too long.")]
        //[MinLength(5, ErrorMessage = "Last Name is too short.")]
        public string Doing { get; set; }

        //[Required]
        //[Done]
        public string Done { get; set; }
    }
}

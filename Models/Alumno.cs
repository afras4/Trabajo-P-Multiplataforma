using System.ComponentModel.DataAnnotations;

namespace Trabajo.Models
{
    public class Alumno
    {
        public int Id{get;set;}

        [Required]
        public string Nombre{get;set;}
        [Required]
        public int Codigo{get;set;}
        [Required]
        public string Password{get;set;}
    }

}
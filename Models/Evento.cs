using System;
using System.ComponentModel.DataAnnotations;

namespace Trabajo.Models
{
    public class Evento
    {
        public int Id{get;set;}

        [Required]
        public string Nombre{get;set;}


        [Required]
        public string Direccion{get;set;}
        public string Foto{get;set;}
        [Required]
        public string Descripcion{get;set;}
        [Required]
        public DateTime Fecha{get;set;}
        

    }
}
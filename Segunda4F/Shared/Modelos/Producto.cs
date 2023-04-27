using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segunda4F.Shared.Modelos
{
    public class Producto
    {
        [Range(1, int.MaxValue, ErrorMessage = "Debe ser un entero positivo")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe capturar el nombre")]
        [MaxLength(200, ErrorMessage = "longitud máxima 200 caracteres")]
        public string? Nombre { get; set; }
        [Range(1, 3, ErrorMessage = "Debe seleccionar")]
        public int Departamento { get; set; }
    }
}

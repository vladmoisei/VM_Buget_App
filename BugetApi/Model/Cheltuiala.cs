using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugetApi.Model
{
    public class Cheltuiala
    {
        public int CheltuialaId { get; set; }

        [Required(ErrorMessage = "Data este obligatorie.")]
        public DateTime Data { get; set; }

        [StringLength(250, ErrorMessage = "Nu poate depasi 250 de caractere. ")]
        public string NumeUtilizator { get; set; }
        public int? DepartamentId { get; set; }
        public Departament Departament { get; set; }

        [StringLength(250, ErrorMessage = "Nu poate depasi 250 de caractere. ")]
        public string Denumire { get; set; }

        [Range(0, 30000, ErrorMessage = "Suma nu poate fi mai mare de 30000 lei.")]
        public int Suma { get; set; }

        public bool IsCheltuialaObligatorie { get; set; }

        public bool IsCheltuit { get; set; }
    }
}

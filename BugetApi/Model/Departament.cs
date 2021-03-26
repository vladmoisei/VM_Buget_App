using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugetApi.Model
{
    public class Departament
    {
        public int DepartamentId { get; set; }

        [StringLength(250, ErrorMessage = "Nu poate depasi 250 de caractere. ")]
        public string Denumire { get; set; }

        [StringLength(250, ErrorMessage = "Nu poate depasi 250 de caractere. ")]
        public string NumeUtilizator { get; set; }

        public List<Cheltuiala> ListaCheltuieli { get; set; }


    }
}

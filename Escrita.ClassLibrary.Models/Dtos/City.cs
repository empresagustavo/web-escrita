using Escrita.ClassLibrary.Models.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escrita.ClassLibrary.Communs.Dtos
{
    public class City : Default
    {
        public Guid CountryId { get; set; }
        public Guid CountryStateId { get; set; }
        public string? CityName { get; set; }
    }
}

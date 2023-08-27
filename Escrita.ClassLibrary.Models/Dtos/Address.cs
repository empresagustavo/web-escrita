using Escrita.ClassLibrary.Models.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escrita.ClassLibrary.Communs.Dtos
{
    public class Address : Descritpion
    {
        public string? Road { get; set; }
        public string? StreetBlock { get; set; }
        public string? Number { get; set; }
        public string? Batch { get; set; }
        public string? Sector { get; set; }
        public string? LocationUrl { get; set; }
        public bool UseLocation { get; set; }
        public Guid? CityId { get; set; }
        public Guid? CountryStateId { get; set; }
        public Guid? CountryId { get; set; }
    }
}

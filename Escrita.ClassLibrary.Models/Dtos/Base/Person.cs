using Escrita.ClassLibrary.Models.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escrita.ClassLibrary.Communs.Dtos.Base
{
    public class Person : Descritpion
    {
        public string? Telephone { get; set; }
        public string? OtherTelephone { get; set; }
        public string? CellPhone { get; set; }
        public string? OtherCellPhone { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime? Birthday { get; set; }
    }
}

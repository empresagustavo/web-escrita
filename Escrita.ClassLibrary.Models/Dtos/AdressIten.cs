using Escrita.ClassLibrary.Models.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escrita.ClassLibrary.Communs.Dtos
{
    public class AdressIten : Default
    {
        public Guid? AdressId { get; set; }
        public Guid? PersonId { get; set; }
    }
}

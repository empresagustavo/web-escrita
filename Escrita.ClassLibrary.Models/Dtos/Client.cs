using Escrita.ClassLibrary.Communs.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escrita.ClassLibrary.Communs.Dtos
{
    public class Client : Person
    {
        public string? FathersName { get; set; }
        public string? MothersName { get; set; }
    }
}

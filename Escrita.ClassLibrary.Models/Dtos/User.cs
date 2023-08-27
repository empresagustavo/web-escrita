using Escrita.ClassLibrary.Communs.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escrita.ClassLibrary.Communs.Dtos
{
    public class User : Person
    {
        public string? UserName { get; set; }
        public string? Password { get; set; }
    }
}

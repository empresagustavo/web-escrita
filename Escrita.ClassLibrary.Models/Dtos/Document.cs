using Escrita.ClassLibrary.Models.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escrita.ClassLibrary.Communs.Dtos
{
    public class Document : Default
    {
        public string? Details { get; set; }
        public Guid? DocumentTypeId { get; set; }
        public string? FilePath { get; set; }
        public int? Number { get; set; }
    }
}

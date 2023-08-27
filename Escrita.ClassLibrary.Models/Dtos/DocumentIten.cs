using Escrita.ClassLibrary.Models.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escrita.ClassLibrary.Communs.Dtos
{
    public class DocumentIten : Default
    {
        public Guid DocumentId { get; set; }
        public Guid PersonId { get; set; }
    }
}

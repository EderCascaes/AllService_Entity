using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllService.Domain
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CriadoEm { get; set; }
        public bool Ativo { get; set; }

    }
}

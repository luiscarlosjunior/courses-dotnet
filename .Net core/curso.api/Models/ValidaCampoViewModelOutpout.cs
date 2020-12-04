using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso.api.Models
{
    public class ValidaCampoViewModelOutpout
    {
        public IEnumerable<string> Erros { get; private set; }

        public ValidaCampoViewModelOutpout(IEnumerable<string> erros)
        {
            Erros = erros;
        }
    }
}

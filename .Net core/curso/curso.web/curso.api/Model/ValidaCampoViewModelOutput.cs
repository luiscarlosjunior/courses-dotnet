using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso.api.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ValidaCampoViewModelOutput
    {
        /// <summary>
        /// Armazena os erros
        /// </summary>
        public IEnumerable<string> Erros { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="erros"></param>
        public ValidaCampoViewModelOutput(IEnumerable<string> erros)
        {
            Erros = erros;
        }
    }
}

using curso.api.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso.api.Filters
{
    /// <summary>
    /// Classe que realiza a validação através de filtros
    /// </summary>
    public class ValidacaoModelStateCustomizado : ActionFilterAttribute
    {
        /// <summary>
        /// Método que realiza a verificação dos erros
        /// </summary>
        /// <param name="context">Contexto do filtro</param>
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var validaCampoViewModel = new ValidaCampoViewModelOutput(context.ModelState.SelectMany(sm => sm.Value.Errors).Select(s => s.ErrorMessage));
                context.Result = new BadRequestObjectResult(validaCampoViewModel);
            }
        }
    }
}

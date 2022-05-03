using Clase_Layouts_PV_Valid.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clase_Layouts_PV_Valid.Validaciones
{
    /// <summary>
    /// Valida que el valor no esté dentro de la lista de dominios
    /// </summary>
    public class ExcluirDominiosAttribute : ValidationAttribute
    {
        private IEnumerable<string> _dominios { get; set; }
        private string _dominioInvalido { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dominios">Lista de dominios a excluir separados por ,</param>


        public ExcluirDominiosAttribute(string dominios)
            => _dominios = dominios.Split(',');

        public string GetErrorMessage() =>
            $"Mail con el dominio {_dominioInvalido} no está permitido.";

        protected override ValidationResult? IsValid(
            object? value, ValidationContext validationContext)
        {
            var usuario = (Usuario)validationContext.ObjectInstance;

            foreach (var dom in _dominios)
            {
                if (value.ToString().Contains(dom, System.StringComparison.OrdinalIgnoreCase))

                    _dominioInvalido = dom;
                return new ValidationResult(GetErrorMessage());
            
        }
            return ValidationResult.Success;
        }

    }
}

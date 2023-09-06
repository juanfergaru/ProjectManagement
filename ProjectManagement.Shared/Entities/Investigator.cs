using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.Shared.Entities
{
    public class Investigator
    {
        public int Id { get; set; }

        // Nombre del Investigador
        [Display(Name = "Nombre del Investigador")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "Debe proporcionar el nombre del investigador.")]
        public string NameInvestigador { get; set; } = null!;


        // Afiliación Institucional
        [Display(Name = "Afiliación Institucional")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "Debe proporcionar una afiliación institucional.")]
        public string InstitutionalAffiliation { get; set; } = null!;


        // especializacion
        [Display(Name = "Especializacion")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "Debe proporcionar una especialización.")]
        public string Specialization { get; set; } = null!;


        // Rol
        [Display(Name = "Rol")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "Debe proporcionar un rol.")]
        public string Rol { get; set; } = null!;
    }
}

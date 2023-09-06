using System.ComponentModel.DataAnnotations;

namespace ProjectManagement.Shared.Entities
{
    public class InvestigationProject
    {
        public int Id { get; set; }

        // nombre del proyecto
        [Display(Name = "Nombre Proyecto")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string NameProject { get; set; } = null!;

        // fecha inicio
        [Display(Name = "Fecha inicio")]
        [MaxLength(100, ErrorMessage = "El campo {1} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {1} es obligatorio.")]
        public string StartDate { get; set; } = null!;

        // fecha finalizacion 
        [Display(Name = "Fecha finalización")]
        [MaxLength(100, ErrorMessage = "El campo {2} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {2} es obligatorio.")]
        public string EndDate { get; set; } = null!;

        // descripcion
        [Display(Name = "Descripción")]
        [MaxLength(300, ErrorMessage = "El campo {3} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {3} es obligatorio.")]
        public string Description { get; set; } = null!;

        // area
        [Display(Name = "Area")]
        [MaxLength(20, ErrorMessage = "El campo {4} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {4} es obligatorio.")]
        public string Area { get; set; } = null!;



    }
}

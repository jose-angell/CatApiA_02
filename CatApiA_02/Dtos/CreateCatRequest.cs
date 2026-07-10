using System.ComponentModel.DataAnnotations;

namespace CatApiA_02.Dtos
{
    public class CreateCatRequest
    {
        [Required(ErrorMessage = "El nombre es un campo obligatorio")]
        public string Name { get; set; }
        [Required(ErrorMessage = "La descripción es un campo obligatorio")]
        public string Description { get; set; }
        [Required(ErrorMessage = "La fecha de nacimiento es un campo obligatorio")]
        public DateTimeOffset DateBirth { get; set; }
        [Required(ErrorMessage = "El peso es un campo obligatorio")]
        public decimal Weight { get; set; }
        [Required(ErrorMessage = "La altura es un campo obligatorio")]
        public decimal Height { get; set; }
        [Required(ErrorMessage = "La raza es un campo obligatorio")]
        public string Breed { get; set; }
    }
}

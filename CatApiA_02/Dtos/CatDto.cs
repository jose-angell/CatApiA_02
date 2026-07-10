using System.ComponentModel.DataAnnotations;

namespace CatApiA_02.Dtos
{
    public class CatDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTimeOffset DateBirth { get; set; }
        public decimal Weight { get; set; }
        public decimal Height { get; set; }
        public string Breed { get; set; }
    }
}

using CatApiA_02.Domain;
using CatApiA_02.Dtos;
using CatApiA_02.Infrastructure;

namespace CatApiA_02.Application
{
    public class CatUseCase
    {
        private readonly AppDbContext _context;
        public CatUseCase(AppDbContext context)
        {
            _context = context;
        }
        public async Task<CatDto> Crate(CreateCatRequest request)
        {
            var newCat = new Cat(request.Name, request.Description, request.DateBirth, request.Weight, request.Height, request.Breed);
            await _context.Cats.AddAsync(newCat);
            await _context.SaveChangesAsync();
            return MapToDto(newCat);
        }
        public async Task<string?> Update(Guid id, UpdateCatRequest request)
        {
            var cat = await _context.Cats.FindAsync(id);
            if(cat == null)
            {
                return $"Cat with id {id} not found";
            }
            cat.Update(request.Name, request.Description, request.DateBirth, request.Weight, request.Height, request.Breed);
            await _context.SaveChangesAsync();
            return null;
        }
        private static CatDto MapToDto(Cat cat) => new CatDto
        {
            Id = cat.Id,
            Name = cat.Name,
            Description = cat.Description,
            DateBirth = cat.DateBirth,
            Weight = cat.Weight,
            Height = cat.Height,
            Breed = cat.Breed
        };
    }
}

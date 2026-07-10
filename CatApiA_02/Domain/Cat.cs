using System.Diagnostics.Eventing.Reader;

namespace CatApiA_02.Domain
{
    public class Cat
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTimeOffset DateBirth { get; private set; }
        public decimal Weight { get; private set; }
        public decimal Height { get; private set; }
        public string Breed { get; private set; }
        private Cat()
        {
            Name = string.Empty;
            Description = string.Empty;
            Breed = string.Empty;
        }
        public Cat(string name, string description, DateTimeOffset dateBirth, decimal weight, decimal height, string breed)
        {
            var isValid = validate(name, description, dateBirth, breed);

            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            DateBirth = dateBirth;
            Weight = weight;
            Height = height;
            Breed = breed;
        }
        public void Update(string name, string description, DateTimeOffset dateBirth, decimal weight, decimal height, string breed)
        {
            var isValid = validate(name, description, dateBirth, breed);

            Name = name;
            Description = description;
            DateBirth = dateBirth;
            Weight = weight;
            Height = height;
            Breed = breed;
        }
        private bool validate(string name, string description, DateTimeOffset dateBirth, string breed)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be null or empty.", nameof(name));
            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("Description cannot be null or empty.", nameof(description));
            if (dateBirth == default)
                throw new ArgumentException("Date of birth cannot be the default value.", nameof(dateBirth));
            if (string.IsNullOrWhiteSpace(breed))
                throw new ArgumentException("Breed cannot be null or empty.", nameof(breed));
            return true;
        }
    }
}

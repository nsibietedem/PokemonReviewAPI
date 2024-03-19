namespace PokemonReviewAPI.Model
{
    public class Pokemon
    {
        public int MyProperty { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<PokemonCategory> PokemonCategories { get; set; }
        public ICollection<PokemonOwner> PokemonOwners { get; set; }

    }
}

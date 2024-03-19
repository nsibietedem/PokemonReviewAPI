namespace PokemonReviewAPI.Model
{
    public class Reviewer
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public ICollection<Review> Reviews { get; set;}

    }
}

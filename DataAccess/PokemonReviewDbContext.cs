using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using PokemonReviewAPI.Model;

namespace PokemonReviewAPI.DataAccess
{
    public class PokemonReviewDbContext: DbContext
    {
        public PokemonReviewDbContext(DbContextOptions<PokemonReviewDbContext> options):base(options) 
        {
            
        }
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Reviewer> Reviewers { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<PokemonCategory> PokemonCategories { get; set; }
        public DbSet<PokemonOwner> PokemonOwners { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PokemonCategory>()
                .HasKey(pc => new { pc.PokemonId, pc.CategoryId });
            modelBuilder.Entity<PokemonOwner>()
                .HasKey(pc => new { pc.PokemonId, pc.OwnerId });
            modelBuilder.Entity<PokemonCategory>()
                .HasOne(pc => pc.Pokemon)
                .WithMany(p => p.PokemonCategories)
                .HasForeignKey(c => c.PokemonId);
            modelBuilder.Entity<PokemonCategory>()
                .HasOne(pc => pc.Category)
                .WithMany(p => p.pokemonCategories)
                .HasForeignKey(c => c.Category.Id); 
            modelBuilder.Entity<PokemonOwner>()
                .HasOne(pc => pc.Pokemon)
                .WithMany(p => p.PokemonOwners)
                .HasForeignKey(c => c.PokemonId);
            modelBuilder.Entity<PokemonOwner>()
                .HasOne(pc => pc.Owner)
                .WithMany(p => p.PokemonOwners)
                .HasForeignKey(c => c.Owner.Id);
                



        }
    }
}

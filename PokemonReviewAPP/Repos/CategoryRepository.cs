using PokemonReviewApp.Data;
using PokemonReviewApp.Models;
using PokemonReviewAPP.Interface;

namespace PokemonReviewAPP.Repos
{
    public class CategoryRepository : ICategoryRepository
    {
        private DataContext _context;
        public CategoryRepository(DataContext context)
        {
            _context = context;
        }
        public bool CategoryExists(int id)
        {
            //Any a bool/ will return a bool within parameter
            return _context.Categories.Any(c => c.Id == id);
        }

        //public bool CreateCategory(Category category)
        //{
        //    _context.Add(category);
        //    return Save();
        //}

        //public bool DeleteCategory(Category category)
        //{
        //    _context.Remove(category);
        //    return Save();
        //}

        public ICollection<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategory(int id)
        {
            return _context.Categories.Where(e => e.Id == id).FirstOrDefault();
        }

        public ICollection<Pokemon> GetPokemonByCategory(int categoryId)
        {
            return _context.PokemonCategories.Where(e => e.CategoryId == categoryId).Select(c => c.Pokemon).ToList(); 
        }
    }
}

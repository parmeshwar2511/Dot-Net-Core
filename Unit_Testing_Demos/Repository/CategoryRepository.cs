using DAL;
using System.Collections.Generic;
using System.Linq;

public class CategoryRepository : ICategoryRepository
{
    ApplicationDbContext _context;

    public CategoryRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public List<Category> GetAll()
    {
       return _context.Categories.ToList();
    }
}
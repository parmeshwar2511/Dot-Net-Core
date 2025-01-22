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

    public void Create(Category category)
    {
        _context.Categories.Add(category);
        _context.SaveChanges();
    }

    public List<Category> GetAll()
    {
       return _context.Categories.ToList();
    }

    public Category GetById(int? id)
    {
        return _context.Categories.Find(id);
    }
}
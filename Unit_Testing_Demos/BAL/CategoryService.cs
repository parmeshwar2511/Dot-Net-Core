using System.Collections.Generic;

public class CategoryService : ICategoryService
{
    ICategoryRepository _categoryRepo;

    public CategoryService(ICategoryRepository categoryRepo)
    {
        _categoryRepo = categoryRepo;
    }

    public void Create(Category category)
    {
        _categoryRepo.Create(category);
    }

    public List<Category> GetAll()
    {
        return _categoryRepo.GetAll();
    }

    public Category GetById(int? id)
    {
        return _categoryRepo.GetById(id);
    }
}


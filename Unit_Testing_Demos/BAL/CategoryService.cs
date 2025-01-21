using System.Collections.Generic;

public class CategoryService : ICategoryService
{
    ICategoryRepository _categoryRepo;

    public CategoryService(ICategoryRepository categoryRepo)
    {
        _categoryRepo = categoryRepo;
    }

    public List<Category> GetAll()
    {
        return _categoryRepo.GetAll();
    }
}


using System.Collections.Generic;

public interface ICategoryService
{
    List<Category> GetAll();

    void Create(Category category);

    Category GetById(int? id);
}
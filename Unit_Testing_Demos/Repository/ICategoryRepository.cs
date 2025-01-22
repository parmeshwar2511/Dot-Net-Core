using System.Collections.Generic;

public interface ICategoryRepository
{
    List<Category> GetAll();

    void Create(Category category);

    Category GetById(int? id);
}
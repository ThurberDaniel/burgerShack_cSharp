using System.Collections.Generic;

namespace burgerShack.Interfaces
{
    public interface IRepo<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int Id);
        T Create(T data);
        T Update(T data);

    }
}
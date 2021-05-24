using burgerShack.Interfaces;
using burgerShack.Models;

namespace burgerShack.Repository

{
    public class BurgersRepository : IRepo<Burger>
    {
        Burger IRepo<Burger>.Create(Burger data)
        {
            throw new System.NotImplementedException();
        }

        System.Collections.Generic.IEnumerable<Burger> IRepo<Burger>.GetAll()
        {
            throw new System.NotImplementedException();
        }

        Burger IRepo<Burger>.GetById(int Id)
        {
            throw new System.NotImplementedException();
        }

        Burger IRepo<Burger>.Update(Burger data)
        {
            throw new System.NotImplementedException();
        }
    }
}
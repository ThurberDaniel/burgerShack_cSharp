using burgerShack.Enums;

namespace burgerShack.Interfaces
{
    public interface IMenuItem
    {
        int Id { get; set; }
        string Name { get; set; }
        decimal Cost { get; set; }
        int Quantity { get; set; }
        string Modifications { get; set; }
        ItemType ItemType { get; }
    }

}
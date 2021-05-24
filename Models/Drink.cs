using burgerShack.Enums;
using burgerShack.Interfaces;

namespace burgerShack.Models
{
    public class Drink : IMenuItem
    {


        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public int Quantity { get; set; }
        public string Modifications { get; set; }
        public ItemType ItemType { get => ItemType.Side; }

    }
}


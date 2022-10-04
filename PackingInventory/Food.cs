namespace PackingInventory
{
    public class Food : InventoryItem
    {
        public Food() : base(1, 0.5f)
        {
        }

        public override string ToString()
        {
            return "Food";
        }
    }
}
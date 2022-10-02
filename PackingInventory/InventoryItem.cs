namespace PackingInventory
{
    public class InventoryItem
    {
        public float Weight { get; set; }
        public float Volume { get; set; }

        public InventoryItem(float weight, float volume)
        {
            Weight = weight;
            Volume = volume;
        }

        public override string ToString()
        {
            return this.Weight + " " + this.Volume;
        }
    }
}
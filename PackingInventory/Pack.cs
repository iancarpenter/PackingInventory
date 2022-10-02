namespace PackingInventory
{
    public class Pack
    {
        public int MaxCount { get; }
        public float MaxVolume { get; }
        public float MaxWeight { get; }

        private InventoryItem[] _items;

        public int CurrentCount { get; private set; }
        public float CurrentVolume { get; private set; }
        public float CurrentWeight { get; private set; }

        public Pack(int maxCount, float maxVolume, float maxWeight)
        {
            MaxCount = maxCount;
            MaxVolume = maxVolume;
            MaxWeight = maxWeight;

            _items = new InventoryItem[maxCount];
        }
        
        public bool Add(InventoryItem item)
        {
            if (CurrentCount > MaxCount) return false;
            if (CurrentWeight + item.Weight > MaxWeight) return false;
            if (CurrentVolume + item.Volume > MaxVolume) return false;

            _items[CurrentCount] = item;
            CurrentCount++;
            CurrentVolume = item.Volume;
            CurrentWeight = item.Weight;

            return true;
        }

    }
}
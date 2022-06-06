namespace GardenApi.Models
{
    public class GardenItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsSowed { get; set; }
        public string HarvestDate { get; set; }
    }
}

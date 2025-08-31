namespace Proyecto.Models
{
    public class Gpu
    {
        public string? Model { get; set; }
        public string? Launch { get; set; }
        public string? CoreClockMHz { get; set; }
        public int MemorySizeGB { get; set; }
        public int TDPWatts { get; set; }
        public int ReleasePriceUSD { get; set; }
    }
}

namespace Proyecto1.Models;

public class Gx
{
    public int Id { get; set; }
    public string? Marca { get; set; }
    public string? Modelo { get; set; }
    public string? VRAM { get; set; }
    public int NucleosCuda { get; set; }
    public bool RayTracing { get; set; }
    public string? Imagen { get; set; }      
        
          
}

public class GxContainer
    {
        public List<Gx> GPUs { get; set; } = new List<Gx>();
    }
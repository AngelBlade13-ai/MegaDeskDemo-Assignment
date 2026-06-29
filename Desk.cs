namespace MegaDeskDemo
{
    public enum DesktopMaterial
    {
        Laminate,
        Oak,
        Rosewood,
        Veneer,
        Pine
    }

    public class Desk
    {
        public int Width { get; set; }

        public int Depth { get; set; }

        public int Drawers { get; set; }

        public DesktopMaterial SurfaceMaterial { get; set; }

        public int SurfaceArea => Width * Depth;
    }
}

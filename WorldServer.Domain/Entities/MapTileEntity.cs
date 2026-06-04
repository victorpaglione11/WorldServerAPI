
namespace WorldServer.Domain.Entities
{
    public class MapTileEntity
    {
        public long Id { get; set; }

        public int Zoom { get; set; }

        public int TileX { get; set; }

        public int TileY { get; set; }

        public string ImageFilePath { get; set; }
    }
}

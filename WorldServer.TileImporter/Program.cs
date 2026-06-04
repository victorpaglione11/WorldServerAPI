using WorldServer.Infrastructure.Persistence;

public static class ChunkMath
{
    public const int ChunkSize = 16;

    public static int GetChunkX(int tileX)
    {
        return (int)Math.Floor(
            tileX / (double)ChunkSize);
    }

    public static int GetChunkY(int tileY)
    {
        return (int)Math.Floor(
            tileY / (double)ChunkSize);
    }
}
public class TileImporter
{
    private readonly WorldDbContext db;

    private readonly HttpClient http;

    public TileImporter(
        WorldDbContext db)
    {
        this.db = db;

        http = new HttpClient();
    }
}



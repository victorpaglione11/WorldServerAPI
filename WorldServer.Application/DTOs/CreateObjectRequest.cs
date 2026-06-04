namespace WorldServer.Application.DTOs
{
public class CreateObjectRequest
{
    public string Prefab { get; set; } = "";

    public int ChunkX { get; set; }

    public int ChunkY { get; set; }

    public float LocalX { get; set; }

    public float LocalY { get; set; }

    public float LocalZ { get; set; }
}}
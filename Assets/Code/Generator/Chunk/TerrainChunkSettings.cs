using UnityEngine;

namespace TerrainGenerator
{
    public class TerrainChunkSettings
    {
        public int HeightmapResolution { get; private set; }

        public int AlphamapResolution { get; private set; }

        public int Length { get; private set; }

        public int Height { get; private set; }
        //first lines of tutorial

        public Texture2D FlatTexture { get; private set; }

        public Texture2D SteepTexture { get; private set; }

        //trying adding other setting
        public Texture2D OtherTexture { get; private set; }

        public Material TerrainMaterial { get; private set; }

        public TerrainChunkSettings(int heightmapResolution, int alphamapResolution, int length, int height, Texture2D flatTexture, Texture2D steepTexture, Texture2D OtherTexture, Material terrainMaterial)
        {
            HeightmapResolution = heightmapResolution;
            AlphamapResolution = alphamapResolution;
            Length = length;
            Height = height;
            FlatTexture = flatTexture;
            SteepTexture = steepTexture;
            TerrainMaterial = terrainMaterial;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MapGen : MonoBehaviour
{
    public Tile[] tiles; // Assign different types of tiles in the Inspector

    private int mapWidth = 100;
    private int mapHeight = 100;
    private float noiseScale = 0.2f;
    Tilemap tilemap;

    void Start()
    {
        tilemap = GetComponent<Tilemap>();
        tilemap.transform.position = Vector3.zero- new Vector3(mapWidth/2,mapHeight/2,0);
        GenerateTilemap();
    }

    void GenerateTilemap()
    {
        for (int x = 0; x < mapWidth; x++)
        {
            for (int y = 0; y < mapHeight; y++)
            {
                float perlinValue = Mathf.PerlinNoise(Random.Range(0,25) + x * noiseScale, Random.Range(0, 25) + y * noiseScale);
                Debug.Log(perlinValue * tiles.Length);
                int index = Mathf.RoundToInt(perlinValue * tiles.Length - 0.5f);
                index = Mathf.Clamp(index, 0, tiles.Length - 1); // Add this line
                Tile tile = tiles[index];
                tilemap.SetTile(new Vector3Int(x, y, 0), tile);
            }
        }
    }
}




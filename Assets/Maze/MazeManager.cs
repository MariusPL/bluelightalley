using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MazeManager : MonoBehaviour
{
    [SerializeField] private Tilemap tilemap;

    [SerializeField] private TileBase groundTile;
    [SerializeField] private TileBase voidTile;
    [SerializeField] private TileBase winTile;
    [SerializeField] private TileBase spawnTile;
    //[SerializeField] private TileBase logicTile;
    //[SerializeField] private TileBase encouragementTile;
    //[SerializeField] private TileBase compassionTile;
    //[SerializeField] private TileBase reversePsychologyTile;



    private void Start()
    {
        //GenerateGenericMaze();
        int[,] maze = new int[,] {
            {1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
            {1, 3, 0, 0, 0, 0, 0, 0, 0, 1},
            {1, 0, 1, 1, 1, 1, 1, 1, 0, 1},
            {1, 0, 1, 0, 0, 0, 0, 0, 3, 1},
            {1, 0, 1, 0, 1, 1, 0, 1, 0, 1},
            {1, 0, 1, 0, 1, 1, 0, 1, 0, 1},
            {1, 0, 0, 0, 0, 0, 0, 1, 0, 1},
            {1, 0, 1, 1, 1, 1, 1, 1, 0, 1},
            {1, 0, 0, 0, 0, 0, 0, 0, 2, 1},
            {1, 1, 1, 1, 1, 1, 1, 1, 1, 1}
        };
        GenerateMaze(maze);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void GenerateGenericMaze()
    {
        for (int x = 0; x < tilemap.size.x; x++)
        {
            for (int y = 0; y < tilemap.size.y; y++)
            {
                tilemap.SetTile(new Vector3Int(x, y, 0), groundTile);
            }
        }
    }

    public void GenerateMaze(int[,] maze)
    {
        for (int x = 0; x < maze.GetLength(0); x++)
        {
            for (int y = 0; y < maze.GetLength(1); y++)
            {
                switch (maze[x, y])
                {
                    case 0:
                        tilemap.SetTile(new Vector3Int(x, y, 0), voidTile);
                        break;
                    case 1:
                        tilemap.SetTile(new Vector3Int(x, y, 0), groundTile);
                        break; 
                    case 2:
                        tilemap.SetTile(new Vector3Int(x, y, 0), winTile);
                        break;
                    case 3:
                        tilemap.SetTile(new Vector3Int(x, y, 0), spawnTile);
                        break;
                    default:
                        tilemap.SetTile(new Vector3Int(x, y, 0), groundTile);
                        Debug.Log("Error: Invalid tile type");
                        break;
                }
            }
        }
    }


}

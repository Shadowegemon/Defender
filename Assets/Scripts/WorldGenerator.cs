using System.Collections.Generic;
using UnityEngine;

public class WorldGenerator : MonoBehaviour
{
    [SerializeField]
    private GameObject borderPrefab;

    [SerializeField]
    private int tileSize;

    private List<GameObject> tiles = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        GenerateBorder(10, 10);
    }

    private void GenerateBorder(int x, int y)
    {
        for (int i = 0; i < x; ++i)
        {
            for (int j = 0; j < x; ++j)
            {
                if (i == 0 || i == x - 1 || j == 0 || j == y - 1)
                {
                    GameObject tile = Instantiate<GameObject>(borderPrefab);

                    tile.transform.position = new Vector3(tileSize * i, tileSize * j, 0);
                    tiles.Add(tile);
                }
            }
        }


    }
}

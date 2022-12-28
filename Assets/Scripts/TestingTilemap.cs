using CodeMonkey;
using CodeMonkey.Utils;
using UnityEngine;

public class TestingTilemap : MonoBehaviour
{
    [SerializeField] private TilemapVisual tilemapVisual;

    private Tilemap tilemap;
    private Tilemap.TilemapObject.TilemapSprite tilemapSprite;

    // Start is called before the first frame update
    void Start()
    {
        tilemap = new Tilemap(20, 10, 10f, Vector3.zero);
        tilemap.SetTilemapVisual(tilemapVisual);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mouseWorldPosition = UtilsClass.GetMouseWorldPosition();
            tilemap.SetTilemapSprite(mouseWorldPosition, tilemapSprite);
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            tilemapSprite = Tilemap.TilemapObject.TilemapSprite.None;
            CMDebug.TextPopupMouse(tilemapSprite.ToString());
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            tilemapSprite = Tilemap.TilemapObject.TilemapSprite.Ground;
            CMDebug.TextPopupMouse(tilemapSprite.ToString());
        }

        if (Input.GetKeyDown(KeyCode.U))
        {
            tilemapSprite = Tilemap.TilemapObject.TilemapSprite.Path;
            CMDebug.TextPopupMouse(tilemapSprite.ToString());
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            tilemapSprite = Tilemap.TilemapObject.TilemapSprite.Dirt;
            CMDebug.TextPopupMouse(tilemapSprite.ToString());
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            tilemap.Save();
            CMDebug.TextPopupMouse("Saved!");
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            tilemap.Load();
            CMDebug.TextPopupMouse("Loaded!");
        }
    }
}

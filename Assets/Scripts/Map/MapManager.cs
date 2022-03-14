using UnityEngine;
using UnityEngine.Tilemaps;

namespace Bionogame.Map
{
    public class MapManager : MonoBehaviour
    {
        [SerializeField]
        private Tilemap _groundMap;

        [SerializeField]
        private TileBase _grass;

        private void Start()
        {
            for (int y = -20; y <= 20; y++)
            {
                for (int x = -20; x <= 20; x++)
                {
                    _groundMap.SetTile(new Vector3Int(x, y), _grass);
                }
            }
        }
    }
}
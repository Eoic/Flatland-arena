using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Map : MonoBehaviour
{
    [SerializeField] private int _width;
    [SerializeField] private int _height;
    [SerializeField] private Transform _cameraTransform;
    [SerializeField] private Tile _tilePrefab;

    private void Start() {
        Generate();        
    }

    private void Generate() {
        float halfWidth = _width / 2 - 0.5f;
        float halfHeight = _height / 2 - 0.5f;

        for (int x = 0; x < _width; x++) {
            for (int y = 0; y < _height; y++) {
                var tile = Instantiate(_tilePrefab, new Vector3(x - halfWidth, y - halfHeight), Quaternion.identity);
                var isOffset = (x % 2 == 0 && y % 2 != 0) || (x % 2 != 0 && y % 2 == 0);
                tile.Init(isOffset);
            }
        }
    }
}

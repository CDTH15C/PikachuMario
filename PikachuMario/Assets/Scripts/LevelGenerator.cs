using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {


	public Texture2D map;
	public ColorPrefabs[] levelMaps;

	// Use this for initialization
	void Start () {
		GenerateLevel ();

	}

	void GenerateLevel()
	{
		for (int x = 0; x < map.width; x++) {
			for (int y = 0; y < map.height; y++) {
				GeneratePrefab (x, y);
			}
		}
	}

	void GeneratePrefab (int x, int y)
	{
		Color pixelColor = map.GetPixel (x, y);
		if (pixelColor.a == 0) {
			return;
		} else {
			//Debug.Log (pixelColor);
			foreach (ColorPrefabs color in levelMaps) {
				if (color.color == pixelColor) {
					
					Vector2 postition = new Vector2 (x * 1.128f, y * 1.128f);
					Instantiate (color.prefab, postition, Quaternion.identity, transform);
				}
			}
		}
	}
}

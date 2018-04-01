using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        createBaseMap();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void createBaseMap()
    {

        int xStartAt = -5;
        int xEndAt = 5;
        int yStartAt = -2;
        int yEndAt = 5;

        for (int i = xStartAt; i < xEndAt; i++)
        {

            for (int j = yStartAt; j < yEndAt; j++)
            {
                Vector2 myPosition = new Vector2(i, j);
                GameObject myTile = (GameObject) GameObject.Instantiate(Resources.Load("GrassTile"), myPosition, Quaternion.identity);
                myTile.transform.SetParent(transform);
            }
        }
    }
}

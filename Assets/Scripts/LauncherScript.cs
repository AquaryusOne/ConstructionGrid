using UnityEngine;
using UnityEditor;
using System.Collections;

public class LauncherScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

		// Init Singletons
		GameManager.getInstance ();

		// Launch Base Design
		createBaseMap ();

	}

	void createBaseMap() {

		int xStartAt = -5;
		int xEndAt = 5;
		int yStartAt = -2;
		int yEndAt = 5;

		for (int i=xStartAt; i<xEndAt; i++) {
		
			for (int j = yStartAt; j <yEndAt ; j++){
				Vector2 myPosition = new Vector2 (i,j);
				GameObject.Instantiate (Resources.Load ("GrassTile"), myPosition, Quaternion.identity);
			}
		}
	}

}

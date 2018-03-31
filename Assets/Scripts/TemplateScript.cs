﻿using UnityEngine;
using System.Collections;

public class TemplateScript : MonoBehaviour {
	
	[SerializeField] 
	private GameObject myFinalObject; // tile
	
	private Vector2 myMousePosition;

	[SerializeField]
	private LayerMask myAllTilesLayer; // all tiles types are within this.

	// Update is called once per frame
	void Update () {
		
		myMousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		transform.position = new Vector2 (Mathf.Round (myMousePosition.x), Mathf.Round (myMousePosition.y));
	
		if (Input.GetMouseButtonDown(0)){

			// RayCast down to check if there are objects below
			RaycastHit2D myRayHit = Physics2D.Raycast(transform.position, Vector2.zero, Mathf.Infinity, myAllTilesLayer);

			// Check validations.
			// Basically, we're checking if the current selection is a housetemplate and the collider detected a grass field, then we can create the house
			if (myRayHit.collider != null) {
				if (myRayHit.collider.gameObject.tag == "GrassTile" && this.gameObject.tag == "HouseTemplate"){ // if its a housetile and a grasstile is there, allow it.

					// Validate if there's enough money to buy it
					if (GameManager.getInstance().attemptBuy(50) == true) {
						Instantiate(myFinalObject,transform.position, Quaternion.identity);
					}
				}
			}
			else if (myRayHit.collider == null && this.gameObject.tag == "GrassTemplate"){ // if we're trying to create a grasstile and nothing's there, allow it.
				Instantiate(myFinalObject,transform.position, Quaternion.identity);
			}
		}
	
	}


}

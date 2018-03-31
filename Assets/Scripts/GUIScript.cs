using UnityEngine;
using System.Collections;

public class GUIScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameManager.getInstance ();
	}
	
	void OnGUI() { 
		GUI.Label(new Rect(0,0,Screen.width,Screen.height), "Total Money: " + GameManager.getInstance().getTotalAmount());
	}
}

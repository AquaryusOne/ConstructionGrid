using UnityEngine;
using System.Collections;

public class HouseDetailsScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		InvokeRepeating ("generateMoney", 0.0f, 1.0f);
	}
	
	// Update is called once per frame
	void Update () {
	}

	void generateMoney() {
		transform.Rotate (Vector3.forward * -90); // show its working
		GameManager.getInstance ().increaseAmount ();
	}
}

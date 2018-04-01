using UnityEngine;
using System.Collections;

public class LauncherScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

		// Init Singletons
		GameManager.getInstance ();

        GameObject.Instantiate(Resources.Load("Map"), transform.position, Quaternion.identity);


    }

	

}

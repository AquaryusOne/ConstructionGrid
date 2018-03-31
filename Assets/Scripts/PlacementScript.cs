using UnityEngine;
using System.Collections;

public class PlacementScript : MonoBehaviour {

	private int mySelectedObjectInArray; 			// index to currently selected template

	private GameObject myCurrentlySelectedTemplate; // indicates the template object being shown with the mouse

	[SerializeField]
	private GameObject[] mySelectableTemplates; 	// contains list of templates that can be instantiated and iterated with mouse.

	private bool bIsATemplateSelected = false;		// indicates if we're in "creation mode"

	// Use this for initialization
	void Start () {	
		mySelectedObjectInArray = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
		Vector2 myMousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		Vector2 mySpawnPosition = new Vector2 (Mathf.Round (myMousePosition.x), Mathf.Round(myMousePosition.y));

		if (Input.GetKeyDown ("e") && bIsATemplateSelected == false) {
		
			myCurrentlySelectedTemplate = (GameObject) Instantiate(mySelectableTemplates[mySelectedObjectInArray], mySpawnPosition, Quaternion.identity);
			bIsATemplateSelected = true;
		}

		if (Input.GetMouseButtonDown (1) && bIsATemplateSelected == true) {
			Destroy (myCurrentlySelectedTemplate);
			bIsATemplateSelected = false;
			mySelectedObjectInArray = 0;
		}

		if (Input.GetAxis ("Mouse ScrollWheel") > 0 && bIsATemplateSelected == true) {
			mySelectedObjectInArray++;
			if(mySelectedObjectInArray > mySelectableTemplates.Length - 1) {
				mySelectedObjectInArray = 0;
			}

			Destroy (myCurrentlySelectedTemplate);
			myCurrentlySelectedTemplate = (GameObject) Instantiate(mySelectableTemplates[mySelectedObjectInArray], mySpawnPosition, Quaternion.identity);
		}
		else if (Input.GetAxis ("Mouse ScrollWheel") < 0 && bIsATemplateSelected == true) {
			mySelectedObjectInArray--;
			if(mySelectedObjectInArray < 0) {
				mySelectedObjectInArray = mySelectableTemplates.Length - 1;
			}
			
			Destroy (myCurrentlySelectedTemplate);
			myCurrentlySelectedTemplate = (GameObject) Instantiate(mySelectableTemplates[mySelectedObjectInArray], mySpawnPosition, Quaternion.identity);
		}

	}
}

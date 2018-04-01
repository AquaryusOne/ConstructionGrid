using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasButtonScript : MonoBehaviour {

    [SerializeField]
    private Button myButton;

    [SerializeField]
    private GameObject myTemplateObject;

	// Use this for initialization
	void Start () {
        myButton.onClick.AddListener(ChangeSelectedTemplate);	
	}

    private void ChangeSelectedTemplate() {
        PlacementScript myPlacementScript = GameObject.Find("PlacementManager").gameObject.GetComponent<PlacementScript>();
        myPlacementScript.changeSelectedTemplate(myTemplateObject);
    }


}

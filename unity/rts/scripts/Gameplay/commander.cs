using UnityEngine;
using System.Collections;

public class commander : MonoBehaviour {
	

	public RectTransform selectionRect;
	
	bool isSelecting=false;
	
	Vector3 selectionStartingPosition;
	// Update is called once per frame
	void Update () {
		
		if(!isSelecting)selectionRect.position = Input.mousePosition;
		
		if (Input.GetMouseButtonDown (0)) {
			
			isSelecting=true;
			selectionStartingPosition=Input.mousePosition;
			selectionRect=selectionStartingPosition;
		}
		
	}
}

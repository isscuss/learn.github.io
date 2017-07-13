using UnityEngine;
using System.Collections;

public class ss : MonoBehaviour {
	
	
	public float moveSpeed;
	public float minX;
	public float maxX;
	public float minY;
	public float maxY;
	// Update is called once per frame
	void Update () {
		//Debug.Log(Input.mousePosition);
		//Vector3 moveDir=new Vector3(0,0,0);
		Vector3 mp = Input.mousePosition;
		Vector3 moveDir = Vector3.zero;
		if (mp.x <= 0f) {
			moveDir.x=-1;
		}
		if (mp.x >= Screen.width) {
			moveDir.x=1;
		}
		if (mp.y <= 0f) {
			moveDir.z=-1;
		}
		if (mp.y >= Screen.height) {
			moveDir.z=1;
		}
		moveDir.Normalize ();
		transform.Translate(moveDir*moveSpeed*Time.deltaTime,Space.World);
		
		//边界条件
		Vector3 currentPosition = transform.position;
		currentPosition.x = Mathf.Clamp (currentPosition.x, minX, maxX);
		currentPosition.z=Mathf.Clamp(currentPosition.z,minY,maxY);
		transform.position=currentPosition;//重新赋值回去
		
	}
}
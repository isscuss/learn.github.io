using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	private NavMeshAgent agent;
	
	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		if (Input.GetMouseButtonDown (1)) {
			
			Ray ray=Camera.main.ScreenPointToRay(Input.mousePosition);
			if(Physics.Raycast(ray,out hit))
				agent.SetDestination(hit.point);
		}
		
	}
}
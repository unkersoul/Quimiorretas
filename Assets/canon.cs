	using UnityEngine;
using System.Collections;
namespace juego{
public class canon : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
			Vector3 diff;
			 float rotZ;
			
		
				diff = bichicho.posicionBicho.position- transform.position;
				//normalize difference  
				diff.Normalize();
				
				//calculate rotation
				rotZ = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
				//apply to object
				transform.rotation = Quaternion.Euler(0f, 0f, rotZ);
			}
}
}
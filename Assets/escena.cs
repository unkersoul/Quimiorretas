using UnityEngine;
using System.Collections;

namespace juego{
public class escena : MonoBehaviour {
		private bichicho bicho;
	// Use this for initialization
	void Start () {
			Instantiate (bicho, new Vector3 (1, 1,-2), Quaternion.identity);
		}
	
	// Update is called once per frame
	void Update () {
	
	}
}
}




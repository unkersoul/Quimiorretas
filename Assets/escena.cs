using UnityEngine;
using System.Collections; 

namespace juego{
public class escena : MonoBehaviour {
		private GameObject[] monster;
		private bichicho[] bicho;
	// Use this for initialization
	void Start () {

			monster = new GameObject[3];
			bicho = new bichicho[3]; 
			monster[0]  = (GameObject)Instantiate(Resources.Load("bicho-anim"));
			monster[0].transform.position = new Vector3 (0, 0, -2);
			bicho[0]=monster[0].GetComponent<bichicho> ();
			bicho[0].Pv = 0;
			monster[1]  = (GameObject)Instantiate(Resources.Load("bicho-anim"));
			monster[1].transform.position = new Vector3 (1, 0, -2);
			monster[2]  = (GameObject)Instantiate(Resources.Load("bicho-anim"));
			monster[2].transform.position = new Vector3 (2, 0, -2);


		}
	
	// Update is called once per frame
	void Update () {

	
	}
}
}



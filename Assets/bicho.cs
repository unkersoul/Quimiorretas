using UnityEngine;
using System.Collections;
namespace juego{
public class bicho : MonoBehaviour {

	public  static Transform posicionBicho;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y > -1.47) {
			transform.Translate (Vector3.right * Time.deltaTime * 2);
		} else {
		
			if (transform.position.y < -1.47){
				transform.rotation=new Quaternion(0,0,0,0);
			}
			transform.Translate (Vector3.up * Time.deltaTime * 2);
			}
			if(transform.position.x>3){
				Destroy (this.gameObject);
			}
		posicionBicho = transform;
		}
	}
}
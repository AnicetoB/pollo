using UnityEngine;
using System.Collections;

public class plataformaVidaScript : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		Debug.Log ("Se ha entrado en la zona de salud");
		//other.AddForce (new Vector2(0,fuerzaexplosion)); 
	}

	void OnTriggerStay2D(Collider2D other){
		Debug.Log ("Vida incrementando");
	}

	void OnTriggerExit2D(Collider2D other){
		Debug.Log ("Se ha salido en la zona de salud");
		//other.AddForce (new Vector2(0,fuerzaexplosion)); 
	}
	
}
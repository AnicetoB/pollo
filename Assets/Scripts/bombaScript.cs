using UnityEngine;
using System.Collections;

public class bombaScript : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		//Esta funcion sirve para detectar colisiones con el comando "Is Trigger" activado, donde other hace referencia al objeto contra el que se colisiona 
		Debug.Log ("Se ha chocado contra la bomba");
		//other.AddForce (new Vector2(0,fuerzaexplosion)); 
	}

}
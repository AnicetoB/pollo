using UnityEngine;
using System.Collections;

public class entrarPuerta1 : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		//Iniciar ();
		Application.LoadLevel ("Nivel_2");
		Debug.Log ("¡Enhorabuena, pasas al Nivel 2!");
	}
}

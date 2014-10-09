using UnityEngine;
using System.Collections;

public class entrarPuerta1 : MonoBehaviour {
	public string nivel = "nivel1";
	void OnTriggerEnter2D(Collider2D other){
		if (other.transform.tag == "Player") {
		Application.LoadLevel (nivel);
		Debug.Log ("¡Enhorabuena, pasas al siguiente nivel!");
		}
	}
}
using UnityEngine;
using System.Collections;

public class asteroideSpript : MonoBehaviour {
	public float cambiogravedad = 0.1f;
	
	void Update () {
		if (Input.GetKeyDown ("a"))	
			caeasteroide();	
		if (Input.GetKeyDown ("y"))
			gravedadinversa();
	}

	void caeasteroide (){
		rigidbody2D.gravityScale = 1;
	}

	void gravedadinversa (){
		rigidbody2D.gravityScale = cambiogravedad * -1;
	}

}
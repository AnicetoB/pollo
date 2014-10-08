using UnityEngine;
using System.Collections;

public class gameScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Escape)) //KeyCode es codigo ASCII, de modo que funcionara en todos los teclados a diferencia de "cualquiertecla"
			Reiniciar();
		}

	public void Salir(){
		Application.Quit (); //Aplication sirve para cosas generales del juego/aplicaciona
	}

	public void Reiniciar(){
		Application.LoadLevel ("Menu_principal");
	}

	public void Iniciar() {
		Application.LoadLevel ("Nivel_1");
	}
}

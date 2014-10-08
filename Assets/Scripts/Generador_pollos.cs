using UnityEngine;
using System.Collections;

public class Generador_pollos : MonoBehaviour {
	public GameObject pollonuevo;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("n")) {
			//Debug.Log ("Pulsada tecla n");
			//var pollo = (GameObject)Instantiate(pollonuevo,transform.position,transform.rotation);
		}
	}
}
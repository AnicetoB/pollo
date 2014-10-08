using UnityEngine;
using System.Collections;

public class jumpScript2 : MonoBehaviour {
	public int jumpForce = 200; //esta es la fuerza de salto
	public int moveForce = 100; //fuerza horizontal mover
	public int maxSpeed = 50; // Velocidad maxima horizontal

	public AudioClip sonidoVolar;
	public AudioClip sonidoHerido;
	public AudioClip sonidoCurado;

	private bool estaherido = false;

	//Esto es NECESARIO para poder usar y manejar las animaciones
	Animator animation;

	void Start(){
		//Al inicializar cargamos las variables de las animaciones
		animation = GetComponent <Animator> ();
	}



	void Update () {
				if (Input.GetButtonDown ("Jump"))//cuando pulsamos espacio salta
						saltar ();//mas abajo funcion explicada
		
				if (Input.GetKey ("a")) {
						mover (moveForce * -1);//multiplicamos negativo para ir a la izq
						transform.localScale = new Vector3 (-1, 1, 1);

				}
		
		
				if (Input.GetKey ("d")) 
						mover (moveForce);
				transform.localScale = new Vector3 (-1, 1, 1);
		}
		
		

	/*funcion saltar 
	 * esta funcion aplica una fuerza hacia arriba definida por jumpForce
	 * TODO: falta animacion de salto y sonido
	 */
	void saltar (){
		// aplicamos una fuerxa con rigidbody2d.addforce (r minuscula)
		if (!estaherido) {
						rigidbody2D.AddForce (new Vector2 (0, jumpForce));
						animation.SetBool ("fly", true);
				}
		// new vector2(0,jumpforce) es un vector con la x a cero y la Y a jumpforce 
	AudioSource.PlayClipAtPoint (sonidoVolar,transform.position);
	}

	void damage(){
			estaherido = true;
			animation.SetBool ("damage", true);
		}
	
	void mover(int fuerza){
				//creamos una variable para guardar la velocidad actual
				float velocity = rigidbody2D.velocity.x;
				if (Mathf.Abs (velocity) < maxSpeed)
						rigidbody2D.AddForce (Vector2.right * fuerza);
		}


		void OnCollisionEnter2D(Collision2D objetochocado) {
		animation.SetBool ("fly", false);
		if (objetochocado.gameObject.tag == "Enemy")
			 damage();
		if (objetochocado.gameObject.tag == "Sombrero") 
			curar ();
	}
	 void curar (){
		estaherido = false;
		animation.SetBool ("damage", false);

	}
}
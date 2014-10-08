using UnityEngine;
using System.Collections;

public class jumpScript : MonoBehaviour {
	public int jumpForce = 200; //Fuerza con que salta el personaje
	public int moveForce = 100; //Fuerza con la que se mueve el personaje
	public int maxSpeed = 1; //Maxima velocidad horizontal
	private bool herido = false;
	public int coin = 0;

	Animator animation;
	//Esto es necesario para poder manejar las animaciones

	void Start(){
		animation = GetComponent <Animator> ();
		//Al inicializar cargamos las variables de las animaciones
	}

	void Update () {
		//Si pulsamos espacio ("Jump") se salta
		if (Input.GetButtonDown ("Jump")) {
			//Esto desencadena la funcion de salto, desarrollada abajo
			saltar();	
			animation.SetBool ("volando", true);
		}

		if (Input.GetButtonUp ("Jump")) {
			animation.SetBool ("volando", false);
		}

		if (Input.GetKey ("left")) {//Si pulsamos izquierda ("left") se aplica una fuerza hacia la izquierda
			mover (moveForce * -1);	//Es por esto que se multiplica la variable moveForce por -1
			transform.localScale = new Vector3 (-1.3f,1.3f,1);
		}
		if (Input.GetKey ("right")) {
			mover (moveForce);
			transform.localScale = new Vector3 (1.3f, 1.3f, 1);
		}
	}
	
	/*Funcion saltar:
	 * Esta funcion aplica una fuerza hacia arriba definida por la variable jumpForce
	 * TODO:Falta animacion de salto y sonido
	 */

	void saltar(){
		if(!herido)
			rigidbody2D.AddForce (new Vector2(0,jumpForce)); 
		//Esta linea añade una accion al componente rigidbody2D, en este caso una fuerza, donde new Vector2 es un vector de 2 dimensiones, donde 0=X y jumpForce=Y
	}

	/*Funcion mover
	 * Parametros: 	fuerza -> variable que indica la fuerza que vamos a aplicar para mover
	 * Aplicamos una fuerza horizontal teniendo en cuenta no sobrepasar la velocidad maxima			
	 */

	void mover(int fuerza){
		//Creamos una variable para guardar la velocidad actual
		float velocity = rigidbody2D.velocity.x; 
		//float es una variable que posee un numero con decimales, y en ete caso es igual a la velocidad horizontal de nuestro cuerpo
		if ((fuerza < 0 & velocity > 0) || (fuerza > 0 & velocity < 0)) {
			rigidbody2D.velocity = new Vector2(0,rigidbody2D.velocity.y);
				}
		if (Mathf.Abs (velocity) < maxSpeed)
		//Mathf.Abs() nos devuelve el valor absoluto de una variable
		//Si hacemos Mathf.Abs(-10) nos devuelve 10, y Mathf(-30) nos devuelve 30
			rigidbody2D.AddForce (Vector2.right * fuerza);
			//Si la velocidad
	}

	void damage(){
		herido = true;
		animation.SetBool ("damage", true);
	}

	void curar(){
		herido = false;
		animation.SetBool ("damage", false);
	}

	void OnCollisionEnter2D(Collision2D objetochocado) {
		animation.SetBool ("volando", false);
		if (objetochocado.gameObject.tag == "Enemy")
			damage();
		if (objetochocado.gameObject.tag == "Vida") 
			curar ();
		if (objetochocado.gameObject.tag == "Coin") 
			coin = +1;
	}
}
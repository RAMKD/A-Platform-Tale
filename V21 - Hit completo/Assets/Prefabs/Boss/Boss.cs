using UnityEngine;
using System.Collections;

public class Boss : MonoBehaviour {
	
	public float 				velocidade = 0.5f;
	public Vector3				moveDirection = Vector3.zero;
 	public float				numeroHits = 0.0f;
	public bool					podeDestruir = false;
	private CharacterMotor motor;
	// Use this for initialization
	void Start () {
		
		motor = this.GetComponent<CharacterMotor>();
	}
	
	// Update is called once per frame
	void Update () {
		if (podeDestruir)
		{
			//animacao fim de fase
		}
		if (numeroHits >= 3)
		{
			podeDestruir = true;
		}	
		Vector3 direcao = Vector3.zero;
		direcao.x = velocidade*(numeroHits/2+1.0f);
		
		motor.inputMoveDirection= direcao;
	
	}
	
	public void setVelocidade()
	{
		velocidade = velocidade*-1.0f;
	}
	
	public void aumentaHit()
	{
		numeroHits++;
	}
	
}
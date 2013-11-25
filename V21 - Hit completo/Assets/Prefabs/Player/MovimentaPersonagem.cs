using UnityEngine;
using System.Collections;


public class MovimentaPersonagem : MonoBehaviour {

	private CharacterMotor motor;
	public	TriggerPe	acertaInimigo;
	public int defineAnimacao = 0;
	public bool direita = true;
	public bool hit = false;
	public bool podeHit = true;
	public float tempo = 0.0f;
	public CharacterController personagem;
	public AnimaPersonagem animaPersonagem;
	public Vector3 direcao = Vector3.zero;
	public	float	forcaEmpurrao = 0.3f;
	public int		direcaoEmpurrao = 1;
	public float	tempoHit	= 2.5f;
	
	// Use this for initialization
	void Start () 
	{
		motor = this.GetComponent<CharacterMotor>();
		personagem = this.GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		direcao = Vector3.zero;
		if (hit == false)
		{
			if (!personagem.isGrounded)
			{
				defineAnimacao = 2;
				if (Input.GetKey("a"))
				{
					direita = false;
					direcao.x -= 1.0f;
				}
				if (Input.GetKey("d"))
				{
	
					direita = true;
					direcao.x += 1.0f;
				}
				if (personagem.velocity.y<0.0f)
				{
					defineAnimacao = 4;
				}
			}
			else
			{
				defineAnimacao = 0;
				if (Input.GetKey("a") && motor.canControl)
				{
					defineAnimacao = 1;
					direita = false;
					direcao.x -= 1.0f;
				}
				if (Input.GetKey("d") && motor.canControl)
				{
					defineAnimacao = 1;
					direita = true;
					direcao.x += 1.0f;
				}
			}
			
			motor.inputMoveDirection= direcao;
			
			if (acertaInimigo.colidiuInimigo)
			{
				motor.inputJump = acertaInimigo.colidiuInimigo;
			}else
			{
				motor.inputJump = Input.GetButton("Jump");
			}
		}
		else
		{
			defineAnimacao = 5;
			if (tempo <0.3f)
			{
				podeHit = false;
				tempo += Time.deltaTime;
				direcao.x = forcaEmpurrao;
				motor.inputMoveDirection= direcao;
				
			}else 
			{
				hit = false;

			}
		}
		if (tempo >=tempoHit)
		{
			podeHit = true;
			tempo = 0.0f;
		}
		if (tempo>=0.3f && tempo<tempoHit)
		{
			tempo += Time.deltaTime;
		}
	}
	
	public void CancelaControl()
	{
		motor.canControl = false;
	}
	public void LiberaControl()
	{
		motor.canControl = true;
	}
	
}

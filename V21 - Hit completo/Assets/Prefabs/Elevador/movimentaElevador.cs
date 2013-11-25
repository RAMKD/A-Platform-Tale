using UnityEngine;
using System.Collections;

public class movimentaElevador : MonoBehaviour {
	public Vector3 velocidade = Vector3.zero;
	public CharacterController 	elevador;
	public bool 				subindo = false;
	public bool 				descendo = false;
	public int 					totalAndares = 4;
	public float[] 				alturaAndar = new float[4];
	public int 					andarAtual = 0;
	public int					andarDestino = 0;
	public TriggerElev			triggerElevTerreo;
	public TriggerElev			triggerElev1Andar;	
	public TriggerElev			triggerElev2Andar;
	public TriggerElev			triggerElev3Andar;
	public bool					entrando = false;
	public GameObject			player;
	public CharacterMotor		motor;
	public PortasElevador		portaTerreo;
	public PortasElevador		porta1Andar;
	public PortasElevador		porta2Andar;
	public PortasElevador		porta3Andar;
	public bool					portaParada = true;
	public bool					saindo		= false;
	public bool					podeSubir	= false;
	public bool					portaAberta	= false;
	// Use this for initialization
	void Start () {
		velocidade.y = 2.0f;
	}
	
	// Update is called once per frame
	void Update () 
	{
		//Comeco terreo
		if (andarAtual == 0 && (!portaTerreo.portaAberta && portaParada && entrando && podeSubir))
		{
			portaAberta = false;
		}
		
		if (!entrando && Input.GetKey("w") && triggerElevTerreo.podeEntrar && andarAtual == 0)
		{
			portaAberta = true;
			entrando = true;	
			motor.canControl = false;
			portaTerreo.portaParada = false;
		}
		if (portaTerreo.portaParada && portaTerreo.portaAberta && entrando)
		{
			podeSubir = true;
			Vector3 temp;
			temp = player.transform.position;	
			if(saindo == false)
			temp.z = 20.0f;
			if (saindo == true)
			{
				temp.z = 16.0f;
				saindo = false;
				motor.canControl = true;
				entrando = false;
				podeSubir = false;
			}
			temp.x = triggerElevTerreo.transform.position.x;
			player.transform.position = temp;
			portaTerreo.portaParada = false;
		}

		if (entrando && Input.GetKey("space") && triggerElevTerreo.podeEntrar && entrando && andarAtual == 0 && subindo == false && descendo == false)
		{
			podeSubir = false;
			portaTerreo.portaParada = false;
			saindo = true;
		}
		//Final Terreo
		
		//Comeco 1 Andar
		if (andarAtual == 1 && (!porta1Andar.portaAberta && portaParada && entrando && podeSubir))
		{
			portaAberta = false;
		}

		if (!entrando && Input.GetKey("w") && triggerElev1Andar.podeEntrar && andarAtual == 1)
		{
			portaAberta = true;
			entrando = true;	
			motor.canControl = false;
			porta1Andar.portaParada = false;
		}
		if (porta1Andar.portaParada && porta1Andar.portaAberta && entrando)
		{
			podeSubir = true;
			Vector3 temp;
			temp = player.transform.position;	
			if(saindo == false)
			temp.z = 20.0f;
			if (saindo == true)
			{
				podeSubir = false;
				temp.z = 16.0f;
				saindo = false;
				motor.canControl = true;
				entrando = false;
			}
			temp.x = triggerElev1Andar.transform.position.x;
			player.transform.position = temp;
			porta1Andar.portaParada = false;
		}
		if (entrando && Input.GetKey("space") && triggerElev1Andar.podeEntrar && entrando && andarAtual == 1 && subindo == false && descendo == false)
		{
			
			porta1Andar.portaParada = false;
			saindo = true;
		}
		//Final 1 Andar
		
		//Começo 2 Andar
		if (andarAtual == 2 && (!porta2Andar.portaAberta && portaParada && entrando && podeSubir))
		{
			portaAberta = false;
		}

		if (!entrando && Input.GetKey("w") && triggerElev2Andar.podeEntrar && andarAtual == 2)
		{
			portaAberta = true;
			entrando = true;	
			motor.canControl = false;
			porta2Andar.portaParada = false;
		}
		if (porta2Andar.portaParada && porta2Andar.portaAberta && entrando)
		{
			podeSubir = true;
			Vector3 temp;
			temp = player.transform.position;	
			if(saindo == false)
			temp.z = 20.0f;
			if (saindo == true)
			{
				podeSubir = false;
				temp.z = 16.0f;
				saindo = false;
				motor.canControl = true;
				entrando = false;
			}
			temp.x = triggerElev2Andar.transform.position.x;
			player.transform.position = temp;
			porta2Andar.portaParada = false;
		}

		if (entrando && Input.GetKey("space") && triggerElev2Andar.podeEntrar && entrando && andarAtual == 2 && subindo == false && descendo == false)
		{
			
			porta2Andar.portaParada = false;
			saindo = true;
		}
		//Final 2 Andar
		
		//Comeco 3 Andar
		if (andarAtual == 3 && (!porta3Andar.portaAberta && portaParada && entrando && podeSubir))
		{
			portaAberta = false;
		}

		if (!entrando && Input.GetKey("w") && triggerElev3Andar.podeEntrar && andarAtual == 3)
		{
			portaAberta = true;
			entrando = true;	
			motor.canControl = false;
			porta3Andar.portaParada = false;
		}
		if (porta3Andar.portaParada && porta3Andar.portaAberta && entrando)
		{
			podeSubir = true;
			Vector3 temp;
			temp = player.transform.position;	
			if(saindo == false)
			temp.z = 20.0f;
			if (saindo == true)
			{
				podeSubir = false;
				temp.z = 16.0f;
				saindo = false;
				motor.canControl = true;
				entrando = false;
			}
			temp.x = triggerElev3Andar.transform.position.x;
			player.transform.position = temp;
			porta3Andar.portaParada = false;
		}

		if (entrando && Input.GetKey("space") && triggerElev3Andar.podeEntrar && entrando && andarAtual == 3 && subindo == false && descendo == false)
		{
			
			porta3Andar.portaParada = false;
			saindo = true;
		}
		//Final 3 Andar
		
		if (Input.GetKey("w") && andarAtual<totalAndares-1 && subindo==false && descendo == false && portaAberta== false && podeSubir==true)
		{
			subindo = true;
			descendo = false;
			andarDestino = andarAtual+1;
		}
		if (Input.GetKey("s") && andarAtual>0 && subindo==false && descendo == false && !portaAberta && podeSubir)
		{
			subindo = false;
			descendo = true;
			andarDestino = andarAtual-1;
		}
		
		if (subindo == true)
		{
			float velTemp = velocidade.y*Time.deltaTime;
			if(transform.position.y + velTemp >= alturaAndar[andarDestino])
			{
				elevador.Move(new Vector3(0.0f,alturaAndar[andarDestino] - transform.position.y,0.0f));
			}
			else
			{
				elevador.Move(new Vector3(0,velTemp,0));
			}
			
			if(transform.position.y == alturaAndar[andarDestino])
			{
				subindo=false;
				andarAtual = andarDestino;
			}
		}
		
		if (descendo == true)
		{
			float velTemp = -velocidade.y*Time.deltaTime;
			if(transform.position.y - velTemp <= alturaAndar[andarDestino])
			{
				elevador.Move(new Vector3(0.0f,alturaAndar[andarDestino] - transform.position.y,0.0f));
			}
			else
			{
				elevador.Move(new Vector3(0,velTemp,0));
			}
			
			if(transform.position.y == alturaAndar[andarDestino])
			{
				descendo=false;
				andarAtual = andarDestino;
			}
		}
	
	}
}

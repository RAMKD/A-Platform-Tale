using UnityEngine;
using System.Collections;

public class PortasElevador : MonoBehaviour 
{
	public GameObject	portaDireita;
	public GameObject	portaEsquerda;
	public bool			portaAberta = false;
	public bool			portaParada = true;
	public float		velocidadePorta = 2.0f;
	public Vector3		posiInicialPortaDir;
	public Vector3		posiInicialPortaEsq;
	public Vector3		posiFinalPortaDir;
	public Vector3		posiFinalPortaEsq;
	public bool			abrePorta = false;
	public bool			fechaPorta= false;
	
	

	void Start () 
	{
		posiInicialPortaDir = portaDireita.transform.position;
		posiInicialPortaEsq = portaEsquerda.transform.position;
		posiFinalPortaDir = posiInicialPortaDir + new Vector3(0.7f,0.0f,0.0f);
		posiFinalPortaEsq = posiInicialPortaEsq - new Vector3(0.7f,0.0f,0.0f);
	}
	

	void Update () 
	{
		if (abrePorta && portaParada)
		{
			if(portaAberta)
			{
				portaAberta = false;
				portaParada = false;
			}
			else
			{
				portaAberta = true;
				portaParada = false;
			}
		}
		
		if(portaParada == false)
		{
			if(portaAberta==false)
			{
				Vector3 tempDir;
				tempDir = portaDireita.transform.position;
				tempDir.x += velocidadePorta*Time.deltaTime;
				if(tempDir.x>=posiFinalPortaDir.x)
				{
					tempDir.x=posiFinalPortaDir.x;
					portaParada = true;
				}
				portaDireita.transform.position = tempDir;
				
				Vector3 tempEsq;
				tempEsq = portaEsquerda.transform.position;
				tempEsq.x -= velocidadePorta*Time.deltaTime;
				if(tempEsq.x<=posiFinalPortaEsq.x)
				{
					tempEsq.x=posiFinalPortaEsq.x;
					portaParada = true;
					abrePorta = false;
					portaAberta = true;
				}
				portaEsquerda.transform.position = tempEsq;
				
			}
			else
			{
				Vector3 tempDir;
				tempDir = portaDireita.transform.position;
				tempDir.x -= velocidadePorta*Time.deltaTime;
				if(tempDir.x<=posiInicialPortaDir.x)
				{
					tempDir.x=posiInicialPortaDir.x;
					portaParada = true;
				}
				portaDireita.transform.position = tempDir;
				
				Vector3 tempEsq;
				tempEsq = portaEsquerda.transform.position;
				tempEsq.x += velocidadePorta*Time.deltaTime;
				if(tempEsq.x>=posiInicialPortaEsq.x)
				{
					tempEsq.x=posiInicialPortaEsq.x;
					portaParada = true;
					fechaPorta = false;
					portaAberta = false;
				}
				portaEsquerda.transform.position = tempEsq;
			}
		}
	}
}

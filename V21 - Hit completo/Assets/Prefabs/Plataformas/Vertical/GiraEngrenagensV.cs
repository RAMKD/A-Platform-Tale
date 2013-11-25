using UnityEngine;
using System.Collections;

public class GiraEngrenagensV : MonoBehaviour 
{
	public 	float				velocidadeRotaçao;
	public	ControlaVertical	elevador;
	public  int					sentido	= 1;
	
	
	// Update is called once per frame
	void Update () 
	{
		if(elevador.sobe)
		transform.Rotate(new Vector3(0.0f,velocidadeRotaçao*sentido*Time.deltaTime,0.0f));
		else
		transform.Rotate(new Vector3(0.0f,-velocidadeRotaçao*sentido*Time.deltaTime,0.0f));
	}
}

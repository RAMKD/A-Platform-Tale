using UnityEngine;
using System.Collections;

public class GiraEngrenagensH : MonoBehaviour 
{
	public 	float				velocidadeRotaçao;
	public	ControlaHorizontal	elevador;
	public  int					sentido	= 1;
	
	
	// Update is called once per frame
	void Update () 
	{
		if(elevador.dir)
		transform.Rotate(new Vector3(0.0f,velocidadeRotaçao*sentido*Time.deltaTime,0.0f));
		else
		transform.Rotate(new Vector3(0.0f,-velocidadeRotaçao*sentido*Time.deltaTime,0.0f));
	}
}

using UnityEngine;
using System.Collections;

public class ControlaVertical : MonoBehaviour 
{
	public float	alturaMaxima;
	public float	alturaMinima;
	public bool		sobe = true;
	public CharacterController	controlaPlataforma;
	public float velocidade = 2.0f;

	void Update () 
	{
		
		if(sobe)
		{
			Vector3	temp;
			temp = transform.position;
			temp.y +=velocidade*Time.deltaTime;
			transform.position = temp;
			if(temp.y>=alturaMaxima)
			{
				sobe = false;
			}
		}
		else
		{
			Vector3	temp;
			temp = transform.position;
			temp.y -=velocidade*Time.deltaTime;
			transform.position = temp;
			if(transform.position.y<=alturaMinima)
			{
				sobe = true;
			}
		}
	}
}

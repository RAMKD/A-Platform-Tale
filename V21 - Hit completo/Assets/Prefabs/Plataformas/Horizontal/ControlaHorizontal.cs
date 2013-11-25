using UnityEngine;
using System.Collections;

public class ControlaHorizontal : MonoBehaviour 
{
	public float	maxDir;
	public float	maxEsq;
	public bool		dir = true;
	public CharacterController	controlaPlataforma;
	public float velocidade = 2.0f;
	public Vector3	temp;

	void Update () 
	{
		
		if(dir)
		{
			
			temp = transform.position;
			temp.x +=velocidade*Time.deltaTime;
			transform.position = temp;
			if(temp.x>=maxDir)
			{
				dir = false;
			}
		}
		else
		{
			Vector3	temp;
			temp = transform.position;
			temp.x -=velocidade*Time.deltaTime;
			transform.position = temp;
			if(transform.position.x<=maxEsq)
			{
				dir = true;
			}
		}
	}
}

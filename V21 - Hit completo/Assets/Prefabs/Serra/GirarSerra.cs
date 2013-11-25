using UnityEngine;
using System.Collections;

public class GirarSerra : MonoBehaviour 
{
	public	float	velocidade;
	public  int		sentido;
	void Update () 
	{
		transform.Rotate(new Vector3(0,velocidade*sentido,0)*Time.deltaTime);
	}
}

using UnityEngine;
using System.Collections;

public class TesteParticulas : MonoBehaviour 
{
	public 	GameObject	particula01;
	public 	GameObject	particula02;
	public	GameObject	particula03;
	public	GameObject	particula04;
	public 	GameObject	particula05;
	public 	GameObject	particula06;
	public	GameObject	particula07;
	public	GameObject	particula08;
	public 	GameObject	particula09;
	public 	GameObject	particula10;

	public	GameObject	player;

	void Update () 
	{
		if (Input.GetKeyDown("1"))
		{
			Instantiate(particula01,player.transform.position+new Vector3(-0.2f,1.5f,1),player.transform.rotation);
		}
		if (Input.GetKeyDown("2"))
		{
			Instantiate(particula02,player.transform.position+new Vector3(0,0,-1),player.transform.rotation);
		}
		if (Input.GetKeyDown("3"))
		{
			Instantiate(particula03,player.transform.position+new Vector3(0,0,-1),player.transform.rotation);
		}
		if (Input.GetKey("4"))
		{
			Instantiate(particula04,player.transform.position+new Vector3(0,0,-1),player.transform.rotation);
		}
		if (Input.GetKeyDown("5"))
		{
			Instantiate(particula05,player.transform.position+new Vector3(0,0,2),player.transform.rotation);
		}
		if (Input.GetKeyDown("6"))
		{
			Instantiate(particula06,player.transform.position+new Vector3(0,0,2),player.transform.rotation);
		}
		if (Input.GetKeyDown("7"))
		{
			Instantiate(particula07,player.transform.position+new Vector3(0,0,-1),player.transform.rotation);
		}
		if (Input.GetKeyDown("8"))
		{
			Instantiate(particula08,player.transform.position+new Vector3(0,0,-1),player.transform.rotation);
		}
		if (Input.GetKeyDown("9"))
		{
			Instantiate(particula09,player.transform.position+new Vector3(0,0,-1),player.transform.rotation);
		}
		if (Input.GetKeyDown("0"))
		{
			Instantiate(particula10,player.transform.position+new Vector3(0,0,-1),player.transform.rotation);
		}
	
	}
}

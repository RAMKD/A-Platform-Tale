using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour 
{
	public	bool			Ativado = false;
	public GameObject[]		checkpoints;
	public Checkpoint		checkpoint;
	public GameObject		particulas;
	public float			posiX;
	public float			posiY;
	
	void Update() 
	{
		if(!Ativado)
		{
			renderer.material.SetTextureOffset("_MainTex", new Vector2(0.0f,0.0f));
		}
		else
		{
			renderer.material.SetTextureOffset("_MainTex", new Vector2(0.5f,0.0f));

		}
	}
	
	public void AtivaCheckpoint()
	{
		Ativado = true;
	}
	
	public void DesativaCheckpoint()
	{
		Ativado = false;	
	}
	
	void AchaCheckpoint()
	{
		checkpoints = GameObject.FindGameObjectsWithTag ("Checkpoint");
		for(int i=0;i<checkpoints.Length;i++)
		{
			checkpoint = checkpoints[i].GetComponent<Checkpoint>();
			checkpoint.DesativaCheckpoint();
		}
	}
	
	void OnTriggerEnter(Collider other)
	{
		if(other.tag=="Player")
		{
			if(Ativado == false)
			{
				Instantiate(particulas,transform.position+new Vector3(0,0.4f,0.5f),transform.rotation);
			}
			AchaCheckpoint();
			AtivaCheckpoint();
			PlayerPrefs.SetFloat("SPAWN_POINT_X",posiX);
			PlayerPrefs.SetFloat("SPAWN_POINT_Y",posiY);
			PlayerPrefs.SetInt("SPAWN_POINT_DIR",1);
		}
		
	}
}

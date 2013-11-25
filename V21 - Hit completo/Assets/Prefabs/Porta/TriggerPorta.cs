using UnityEngine;
using System.Collections;

public class TriggerPorta : MonoBehaviour 
{
	public ControlesMobile controlesMobile;
	public string nomeDoLevel;
	public Vector2 spawnPoint = Vector2.zero;
	
	void OnTriggerStay(Collider other) 
	{
		if(other.tag == "Player" && Input.GetKey("w"))
		{
			PlayerPrefs.SetFloat("SPAWN_POINT_X",spawnPoint.x);
			PlayerPrefs.SetFloat("SPAWN_POINT_Y",spawnPoint.y);
			PlayerPrefs.SetInt("SPAWN_POINT_DIR",1);
			
			Application.LoadLevel(nomeDoLevel);
		}

	}
	
}

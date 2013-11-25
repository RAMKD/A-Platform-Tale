using UnityEngine;
using System.Collections;

public class Util : MonoBehaviour 
{
	public void Update()
	{
		Debug.Log("teste");
	}

	public void MataPlayer(GameObject player,GameObject camera)
	{
		
			//posiciona Player na posicao do Checkpoint;
			Vector3 temp;
			temp	= player.transform.position;
			temp.x	= PlayerPrefs.GetFloat("SPAWN_POINT_X");
			temp.y  = PlayerPrefs.GetFloat("SPAWN_POINT_Y");
			temp.z	= 16.0f;
			player.transform.position = temp;
			
			//reseta vidas
			PlayerPrefs.SetInt("VIDAS",3);
		
			//posiciona Camera na posicao do Checkpoint;
			Vector3 temp2;
			temp2	= camera.transform.position;
			temp2.x	= PlayerPrefs.GetFloat("SPAWN_POINT_X");
			temp2.y  = PlayerPrefs.GetFloat("SPAWN_POINT_Y") + 1.0f;
		
			camera.transform.position = temp2;
	}

	public void HitPlayer(MovimentaPersonagem player, Vector2 direcao, float forcaEmpurrao)
	{
		if (player.podeHit)
		{
			PlayerPrefs.SetInt("VIDAS",PlayerPrefs.GetInt("VIDAS")-1);
			if (PlayerPrefs.GetInt("VIDAS") >0)
			{
				player.hit = true;
				//player.tempo = 0.0f;
				if(direcao.x == -1)
				{
					player.forcaEmpurrao = -forcaEmpurrao;
				}
				if(direcao.x == 1)
				{
					player.forcaEmpurrao =  forcaEmpurrao;
				}
			}
		}
	}
}

//mechi no codigo UTIL.CS, TriggerBarril.cs MovimentaPersonagem.cs AnimaPersonagem.cs
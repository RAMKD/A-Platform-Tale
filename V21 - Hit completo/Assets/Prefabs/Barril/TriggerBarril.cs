using UnityEngine;
using System.Collections;

public class TriggerBarril : MonoBehaviour 
{
	public	GameObject			quebraBarril;
	public  Util				util;
	public  Vector2				direcao = Vector2.zero;
	public  Vector2				posiBarril = Vector2.zero;
	public  Vector2				oldPosiBarril = Vector2.zero;
	public 	MovimentaPersonagem	player;
	public	GameObject[]		players;
	public	float				forcaEmpurrao;
	
	void Update() 
	{
		oldPosiBarril=posiBarril;
		posiBarril.x = this.transform.parent.transform.position.x;
		if(posiBarril.x>oldPosiBarril.x)
		{
			direcao.x=1.0f;
		}
		else if(posiBarril.x<oldPosiBarril.x)
		{
			direcao.x=-1.0f;
		}
		
		
	}
	
	void Start ()
	{
		players = GameObject.FindGameObjectsWithTag ("Player");
		for(int i=0;i<players.Length;i++)
		{
			if(players[i].GetComponent<MovimentaPersonagem>() != null)
			{
				player = players[i].GetComponent<MovimentaPersonagem>();
			}
		}
	}
	
	void OnTriggerEnter(Collider other) 
	{
		if(other.tag == "Player")
		{
//hit player
			util.HitPlayer(player, direcao,forcaEmpurrao);

			Instantiate(quebraBarril,transform.position,transform.rotation);
			Destroy(this.transform.parent.gameObject);
		}

	}
	
	void OnTriggerExit(Collider other)
	{
	}
}

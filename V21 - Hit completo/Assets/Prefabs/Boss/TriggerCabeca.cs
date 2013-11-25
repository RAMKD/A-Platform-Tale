using UnityEngine;
using System.Collections;

public class TriggerCabeca : MonoBehaviour {

	public 	Boss	boss;
	public	bool	colidiu;
	public  CharacterController	player;
	public GameObject			objectPlayer;
	public GameObject[]			players;
	
	void Update()
	{
		if(!player)
		{
			AchaPlayer();
			player = objectPlayer.GetComponent<CharacterController>();
		}
	}
	
	void OnTriggerEnter(Collider other) 
	{
		if(other.gameObject.tag == "Pe" && colidiu == false && player.velocity.y<0.0f)
		{
			colidiu = true;
			boss.aumentaHit();
		}
	}
	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Pe")
		{
			colidiu = false;
		}
	}
	
	void AchaPlayer()
	{
		players = GameObject.FindGameObjectsWithTag ("Player");
		for(int i=0;i<players.Length;i++)
		{
			if(players[i].name == "Player(Clone)")
			{
				objectPlayer = players[i];
			}
		}
	}
}

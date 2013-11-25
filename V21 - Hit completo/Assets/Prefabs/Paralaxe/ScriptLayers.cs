using UnityEngine;
using System.Collections;

public class ScriptLayers : MonoBehaviour 
{
	public CharacterMotor 		controlaPlayer;
	public float 				velocidade;
	public int					layer;
	public GameObject			player;
	public GameObject[]			players;
	
	void Start () 
	{
	
	}
	

	void Update () 
	{
		AchaPlayer();
		controlaPlayer = player.GetComponent<CharacterMotor>();
		velocidade = controlaPlayer.movement.velocity.x * 0.0001f * layer;
		Vector3 temp;
		temp = transform.position;
		temp.x += velocidade;
		transform.position = temp;
	}
	
	void AchaPlayer()
	{
		players = GameObject.FindGameObjectsWithTag ("Player");
		for(int i=0;i<players.Length;i++)
		{
			if(players[i].name == "Player(Clone)")
			{
				player = players[i];
			}
		}
	}
}

using UnityEngine;
using System.Collections;

public class CameraControler : MonoBehaviour 
{
	


	public float			posiFinalCamera;
	public float			posiInicialCamera;
	public float 			ratioCamera;
	public GameObject		player;
	public GameObject[]		players;
	public Vector3			distancia;
	public float 			tamanhoCameraX;
	
	public float temp2;
	
	// Use this for initialization
	void Start () 
	{
		//AchaPlayer();
		
		//determina a posicao inicial e final da camera na fase;
		ratioCamera = Camera.main.pixelWidth / Camera.main.pixelHeight;
		tamanhoCameraX   = ratioCamera * Camera.main.orthographicSize;
		
		/*Vector3 temp;
		temp = transform.position;
		temp.x = player.transform.position.x;
		temp.y = player.transform.position.y;
		transform.position = temp;*/
	
	}
	
	void Update () 
	{
		AchaPlayer();
		distancia = player.transform.position - transform.position;
		distancia.y +=1.0f;
		if(distancia.x <=0)
		{
			transform.Translate(new Vector3(distancia.x/30.0f,0.0f,0.0f));
		}
		else if(distancia.x >=0)
		{
			transform.Translate(new Vector3(distancia.x/30.0f,0.0f,0.0f));
		}
		transform.Translate(new Vector3(0.0f,distancia.y/30.0f,0.0f));
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

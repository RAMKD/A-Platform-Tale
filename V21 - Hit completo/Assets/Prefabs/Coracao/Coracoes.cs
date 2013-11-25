using UnityEngine;
using System.Collections;

public class Coracoes : MonoBehaviour 
{
	public Texture 	coracao;
	public int 		vidas = 3;
	public Vector2 	tamanhoCoracao;
	public Vector2 	tamanhoTela;
	public Util		util;
	public GameObject	player;

	void Start()
	{
		PlayerPrefs.SetInt("VIDAS",3);
		tamanhoTela = new Vector2(Screen.width,Screen.height);
		tamanhoCoracao.y = tamanhoTela.y * 0.13f;
		tamanhoCoracao.x = coracao.width/coracao.height * tamanhoCoracao.y;
	}
	
	void Update() 
	{
		if (PlayerPrefs.GetInt("VIDAS") <=0)
		{
			util.MataPlayer(player,Camera.main.gameObject);
		}
	}
	
	void OnGUI() 
	{
		vidas = PlayerPrefs.GetInt("VIDAS");
		for (int i=0;i<vidas; i++)
		{
			GUI.DrawTexture(new Rect(((Screen.width/2)-(vidas*(tamanhoCoracao.x+Screen.height*0.01f)/2))+(i*(tamanhoCoracao.x+Screen.height*0.01f))
				                      ,Screen.height*0.01f
				                      ,tamanhoCoracao.x
				                      ,tamanhoCoracao.y)
				                      ,coracao);
		}
	}

}

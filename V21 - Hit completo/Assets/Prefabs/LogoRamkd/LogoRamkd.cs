using UnityEngine;
using System.Collections;

public class LogoRamkd : MonoBehaviour 
{
	public Texture logo;
	public Vector2 tamanhoLogo;
	public Vector2 tamanhoTela;
	public Vector2 tamanhoLogoOriginal;
	public Vector2 posiInicialLogo = Vector2.zero;
	
	public float	tempoTotal = 5.0f;
	public float	Somatempo = 0.0f;
	
	public float	alpha = 0.0f;

	void Start()
	{
		PlayerPrefs.SetFloat("SPAWN_POINT_X",11.09462f);
		PlayerPrefs.SetFloat("SPAWN_POINT_Y",-1.499766f);
		PlayerPrefs.SetInt("SPAWN_POINT_DIR",1);
		tamanhoTela = new Vector2(Screen.width,Screen.height);

		tamanhoLogoOriginal = new Vector2(logo.width,logo.height);
		tamanhoLogo.y = tamanhoTela.y;
		tamanhoLogo.x = tamanhoLogoOriginal.x/tamanhoLogoOriginal.y * tamanhoLogo.y;
		posiInicialLogo.x = (-tamanhoLogo.x + tamanhoTela.x)/2;
	}

	
	// Update is called once per frame
	void Update () 
	{
		Somatempo += Time.deltaTime;
		if(Somatempo<=1)
		{
			alpha+=Time.deltaTime;
		}
		if(Somatempo>=tempoTotal-1)
		{
			alpha-=Time.deltaTime;
		}
		if(Somatempo>=tempoTotal)
		{
			Application.LoadLevel("Lobby");
		}
	}
	
	void OnGUI() 
	{
		GUI.DrawTexture(new Rect(posiInicialLogo.x,posiInicialLogo.y,tamanhoLogo.x,tamanhoLogo.y),logo);
	}
}

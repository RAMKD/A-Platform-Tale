using UnityEngine;
using System.Collections;

public class ContaMoedas : MonoBehaviour 
{
	public Texture 		moeda;
	public Texture      numeros;
	
	public float 		intervaloDeSpawn = 0.1f;
	public float		tempoDecorrido = 0.0f;
	public float		diferencaDeTempo = 0.0f;
	
	public float		tamanhoMoeda;
	public Vector2		tamanhoNumeros;
	
	public int			contaMoedas = 0;
	public int			unidades = 0;
	public int			dezenas = 0;
	public int 			centenas = 0;

	void Start () 
	{
		PlayerPrefs.SetInt("MOEDAS_U",0);
		PlayerPrefs.SetInt("MOEDAS_D",0);
		PlayerPrefs.SetInt("MOEDAS_C",0);
		PlayerPrefs.SetInt("TOTAL_MOEDAS",0);
		
		tamanhoMoeda = Screen.height * 0.12f;
		tamanhoNumeros.y = Screen.height * 0.12f;
		tamanhoNumeros.x = (numeros.width/numeros.height * tamanhoNumeros.y)/10.0f;
	}
	
	void Update () 
	{
		/*
		PlayerPrefs.SetInt("TOTAL_MOEDAS",contaMoedas);
		if(PlayerPrefs.GetInt("TOTAL_MOEDAS")<999)
		{
			SomaMoedasPeloTempo();
		}*/
		
		unidades = PlayerPrefs.GetInt("MOEDAS_U");
		dezenas  = PlayerPrefs.GetInt("MOEDAS_D");
		centenas = PlayerPrefs.GetInt("MOEDAS_C");
		

		diferencaDeTempo = Time.deltaTime;
		tempoDecorrido += diferencaDeTempo;
		
		
		
		if(PlayerPrefs.GetInt("MOEDAS_U")>9)
		{
			PlayerPrefs.SetInt("MOEDAS_U",0);
			PlayerPrefs.SetInt("MOEDAS_D",PlayerPrefs.GetInt("MOEDAS_D")+1);
		}
		if(PlayerPrefs.GetInt("MOEDAS_D")>9)
		{
			PlayerPrefs.SetInt("MOEDAS_D",0);
			PlayerPrefs.SetInt("MOEDAS_C",PlayerPrefs.GetInt("MOEDAS_C")+1);
		}
		
	}
	
	void SomaMoedasPeloTempo()
	{
		if (tempoDecorrido >= intervaloDeSpawn)
		{
			PlayerPrefs.SetInt("MOEDAS_U",PlayerPrefs.GetInt("MOEDAS_U")+1);
			tempoDecorrido = 0.0f;
			contaMoedas++;
	    }
	}
	
	void OnGUI() 
	{
		GUI.DrawTexture(new Rect(Screen.width* 0.93f
			                    ,Screen.height*0.013f
			                    ,tamanhoMoeda
			                    ,tamanhoMoeda)
			                    ,moeda);
		GUI.DrawTextureWithTexCoords(new Rect(Screen.width* 0.94f - tamanhoMoeda
			                                 ,Screen.height*0.013f
			                                 ,tamanhoNumeros.x
			                                 ,tamanhoNumeros.y)
			                                 ,numeros
			                        ,new Rect(unidades * 0.1f,0,0.1f,1.0f));
		if(centenas!=0 || dezenas>0)
		{
			GUI.DrawTextureWithTexCoords(new Rect(Screen.width* 0.955f - tamanhoMoeda*2.0f
				                                 ,Screen.height*0.013f
			    	                             ,tamanhoNumeros.x
			        	                         ,tamanhoNumeros.y)
			            	                     ,numeros
			                	        ,new Rect(dezenas * 0.1f,0,0.1f,1.0f));
		}
		if(centenas!=0)
		{
			GUI.DrawTextureWithTexCoords(new Rect(Screen.width* 0.97f - tamanhoMoeda*3.0f
				                                 ,Screen.height*0.013f
			    	                             ,tamanhoNumeros.x
			        	                         ,tamanhoNumeros.y)
			            	                     ,numeros
			                	        ,new Rect(centenas * 0.1f,0,0.1f,1.0f));
		}
	}
}


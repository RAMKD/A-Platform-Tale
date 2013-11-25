using UnityEngine;
using System.Collections;

public class ControlesMobile : MonoBehaviour 
{
	public bool pulando = false;
	public bool direita = false;
	public bool esquerda = false;
	public bool cima = false;
	public bool baixo = false;
	
	public GUITexture botaoA;
	public GUITexture botaoCima;
	public GUITexture botaoBaixo;
	public GUITexture botaoDireita;
	public GUITexture botaoEsquerda;
	
	public Vector2	  tamanhoTela;

	public Rect       rectDirecionalDir;
	public Rect       rectDirecionalEsq;
	public Rect       rectDirecionalCima;
	public Rect       rectDirecionalBaixo;
	public Rect	      rectBotaoA;
	
	public float      tamanhoBotaoA;
	public float      tamanhoDirecionais;


	// Use this for initialization
	void Start () 
	{
		tamanhoTela 	= new Vector2(Screen.width,
								      Screen.height);
		
		tamanhoBotaoA 	= tamanhoTela.y * 0.35f;
		tamanhoDirecionais = tamanhoBotaoA / 3.0f;
		
		rectBotaoA 			= new Rect 	 (tamanhoTela.x - tamanhoBotaoA - tamanhoTela.x * 0.02f,
			                              tamanhoTela.y * 0.01f,
							              tamanhoBotaoA,
								          tamanhoBotaoA);
		botaoA.guiTexture.pixelInset 	= rectBotaoA;
		
		rectDirecionalBaixo         	= new Rect  (tamanhoTela.x * 0.02f+ tamanhoDirecionais - (tamanhoDirecionais*0.1f),
			                              tamanhoTela.y * 0.01f,
							              tamanhoDirecionais * 1.2f,
								          tamanhoDirecionais * 1.2f);
		botaoBaixo.guiTexture.pixelInset 	= rectDirecionalBaixo;
		
		rectDirecionalCima           	= new Rect  (tamanhoTela.x * 0.02f+ tamanhoDirecionais - (tamanhoDirecionais*0.1f),
			                              tamanhoTela.y * 0.01f + (tamanhoDirecionais*2) - (tamanhoDirecionais * 0.2f),
							              tamanhoDirecionais * 1.2f,
								          tamanhoDirecionais * 1.2f);
		botaoCima.guiTexture.pixelInset = rectDirecionalCima;
		
		rectDirecionalEsq             	= new Rect  (tamanhoTela.x * 0.02f,
			                              tamanhoTela.y * 0.01f + tamanhoDirecionais - (tamanhoDirecionais*0.1f),
							              tamanhoDirecionais * 1.2f,
								          tamanhoDirecionais * 1.2f);
		botaoEsquerda.guiTexture.pixelInset = rectDirecionalEsq;
		
		rectDirecionalDir             	= new Rect  (tamanhoTela.x * 0.02f + (tamanhoDirecionais*1.8f),
			                              tamanhoTela.y * 0.01f + tamanhoDirecionais - (tamanhoDirecionais*0.1f),
							              tamanhoDirecionais * 1.2f,
								          tamanhoDirecionais * 1.2f);
		botaoDireita.guiTexture.pixelInset = rectDirecionalDir;
	}
	
	void LimpaBotoes()
	{
		pulando = false;
		direita = false;
		esquerda = false;
		cima = false;
		baixo = false;
	}
	// Update is called once per frame
	
	void Update () 
	{
		LimpaBotoes();
		

		
		if (Input.touchCount > 0)
		{
			foreach (Touch touch in Input.touches)
			{
				if (botaoA.HitTest(touch.position))
				{
					pulando = true;
				}
				if (botaoCima.HitTest(touch.position))
				{
					cima = true;
				}
				if (botaoBaixo.HitTest(touch.position))
				{
					baixo = true;
				}
				if (botaoDireita.HitTest(touch.position))
				{
					direita = true;
				}
				if (botaoEsquerda.HitTest(touch.position))
				{
					esquerda = true;
				}
			}
		}
	}
	
	void OnGUI()
	{
		Color textureColorAlpha = botaoA.guiTexture.color;
		textureColorAlpha.a 		    = 0.2f;
		Color textureColor = botaoA.guiTexture.color;
		textureColor.a 		            = 1.0f;
		if(!pulando)
		{
			botaoA.guiTexture.color = textureColorAlpha;
		}
		else
		{
			botaoA.guiTexture.color = textureColor;
		}
		if(!cima)
		{
			botaoCima.guiTexture.color = textureColorAlpha;
		}
		else
		{
			botaoCima.guiTexture.color = textureColor;
		}
		if(!baixo)
		{
			botaoBaixo.guiTexture.color = textureColorAlpha;
		}
		else
		{
			botaoBaixo.guiTexture.color = textureColor;
		}
		if(!direita)
		{
			botaoDireita.guiTexture.color = textureColorAlpha;
		}
		else
		{
			botaoDireita.guiTexture.color = textureColor;
		}
		if(!esquerda)
		{
			botaoEsquerda.guiTexture.color = textureColorAlpha;
		}
		else
		{
			botaoEsquerda.guiTexture.color = textureColor;
		}
	}
}

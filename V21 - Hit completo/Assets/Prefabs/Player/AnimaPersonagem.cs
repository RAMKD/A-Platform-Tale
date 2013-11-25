using UnityEngine;
using System.Collections;

public class AnimaPersonagem : MonoBehaviour {
	public bool 		zeraIndex = false;
	public int 			index = 0;
	public int 			indexBase = 0;
	public Vector2 		offset = Vector2.zero;
	public int 			indice;
	public bool 		direita = true;
	public int 			defineAnimacao = 0;
	public MovimentaPersonagem movimentaPersonagem;
	public bool mostraPersonagem = false;
	public float 		tempo = 0.0f;
	public void Update()
	{
		Anima(movimentaPersonagem.defineAnimacao, movimentaPersonagem.direita);
	}
	
	public void SpriteAnimation(int colCount,int rowCount,int rowNumber,int colNumber,int totalCells,int fps)
    {
		
		if(zeraIndex == true)
		{
			indexBase = (int)(Time.time * (float)fps);
			indexBase = indexBase % totalCells;
		}
		
    	// Calculate index
    	index = (int)(Time.time * (float)fps);
		
		index -= indexBase;
    	// Repeat when exhausting all cells
    	index = index % totalCells;
     
    	// Size of every cell
    	Vector2 size = new Vector2 (1.0f / colCount, 1.0f / rowCount);
     
    	// split into horizontal and vertical index
    	int uIndex = index % colCount;
    	int vIndex = index / colCount;
     
    	// build offset
    	// v coordinate is the bottom of the image in opengl so we need to invert.
    	offset = new Vector2 ((uIndex+colNumber) * size.x, (1.0f - size.y) - (vIndex+rowNumber) * size.y);
     	
		indice = uIndex+colNumber;

		if (mostraPersonagem == true && tempo>=0.1f && movimentaPersonagem.podeHit == false)
		{
			renderer.enabled = false;
			mostraPersonagem = false;
			tempo = 0.0f;
		}else if (mostraPersonagem == false && tempo>=0.1f && movimentaPersonagem.podeHit == false)
		{
			renderer.enabled = true;
			mostraPersonagem = true;
			tempo = 0.0f;
		}
		if (movimentaPersonagem.podeHit && mostraPersonagem == false)
		{
			renderer.enabled = true;
			mostraPersonagem = true;
		}

		tempo += Time.deltaTime;
    	renderer.material.SetTextureOffset ("_MainTex", offset);
    	renderer.material.SetTextureScale ("_MainTex", size); 
    }
	
	public void Anima(int defineAnimacao, bool direita)
	{
		if (defineAnimacao == 0)
		{
			if (direita==true)
			{
				SpriteAnimation(17,4,1,16,1,20);
			}
			if(direita == false) 
			{
				SpriteAnimation(17,4,1,0,1,20);
			}
		}
		if (defineAnimacao == 1)
		{
			if (direita==true)
			{
				SpriteAnimation(17,4,2,0,17,20);
			}
			if(direita == false) 
			{
				SpriteAnimation(17,4,3,0,17,20);
			}
		}
		if (defineAnimacao == 2)
		{
			if (direita==true)
			{
				SpriteAnimation(17,4,0,6,1,20);
			}
			if(direita == false) 
			{
				SpriteAnimation(17,4,0,0,1,20);
			}

		}
		if (defineAnimacao == 4)
		{
			if (direita==true)
			{
				SpriteAnimation(17,4,0,4,1,20);
			}
			if(direita == false) 
			{
				SpriteAnimation(17,4,0,2,1,20);
			}

		}
		if (defineAnimacao == 5)
		{
			if (direita==true)
			{
				SpriteAnimation(17,4,0,5,1,20);
			}
			if(direita == false) 
			{
				SpriteAnimation(17,4,0,1,1,20);
			}

		}
	}
}

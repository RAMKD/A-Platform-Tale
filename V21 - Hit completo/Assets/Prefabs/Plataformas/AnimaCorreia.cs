using UnityEngine;
using System.Collections;

public class AnimaCorreia : MonoBehaviour 
{
	public 	float				scrollSpeed;
	public	ControlaHorizontal	elevador;
	public  int					sentido	= 1;
	public	float				offset = 0;
	
	// Update is called once per frame
	void Update () 
	{
		renderer.material.mainTexture.wrapMode = TextureWrapMode.Repeat;
		if(elevador.dir)
		{
			offset += Time.deltaTime * scrollSpeed * sentido;
	        renderer.material.SetTextureOffset("_MainTex", new Vector2(0, offset));
		}
		else
		{
			offset -= Time.deltaTime * scrollSpeed * sentido;
	        renderer.material.SetTextureOffset("_MainTex", new Vector2(0, offset));
		}
		
	}
}

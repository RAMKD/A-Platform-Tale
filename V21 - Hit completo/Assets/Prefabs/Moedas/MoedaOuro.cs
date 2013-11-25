using UnityEngine;
using System.Collections;

public class MoedaOuro : MonoBehaviour 
{
	public Vector2 				offset;
	public int 					index = 0;
	public GameObject			animaMoeda;
	
	void Update () 
	{
	AnimaSprite(1,11,0,0,8,14);
	}
	
	private void AnimaSprite(int linhas,int colunas,int numeroLinha,int numeroColuna,int totalCelulas,int fps)
    {
    	// Calcula o index da animação
		// Index é a variavel que diz em qual frame a animação está
    	index = (int)(Time.time * (float)fps);
    	// Quando termina todas as celulas da animação o index volta a primeira posição
    	index = index % totalCelulas;
     
    	// Calcula o tamanho das celulas
    	Vector2 size = new Vector2 (1.0f / colunas, 1.0f / linhas);
     
    	// Divide o index em U e V
    	int uIndex = index % colunas;
    	int vIndex = index / colunas;
     
    	// constroi o offset
		// a coordenada V representao a posicao da parte de baixo da imagem e ela precisa ser invertida no openGl
    	offset = new Vector2 ((uIndex+numeroColuna) * size.x, (1.0f - size.y) - (vIndex+numeroLinha) * size.y);
     
    	renderer.material.SetTextureOffset ("_MainTex", offset);
    	renderer.material.SetTextureScale ("_MainTex", size);
    }
	
	void OnTriggerEnter(Collider other) 
	{
		if(other.gameObject.tag == "Player")
		{
			PlayerPrefs.SetInt("MOEDAS_U",PlayerPrefs.GetInt("MOEDAS_U")+1);
			PlayerPrefs.SetInt("TOTAL_MOEDAS",PlayerPrefs.GetInt("TOTAL_MOEDAS")+1);
			Instantiate(animaMoeda,transform.position,transform.rotation);
			Destroy(gameObject);
		}
        
    }
	
}

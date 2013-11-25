using UnityEngine;
using System.Collections;

public class SpiderAnimation : MonoBehaviour 
{
	public int		indice = 0;
	public int		index = 0;
	public int		indexBase = 0;
	
	public Vector2  offset;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		spriteanimation(14,1,0,0,14,4);
	}
	
	private void spriteanimation(int colCount,int rowCount,int rowNumber,int colNumber,int totalCells,int fps)
    {
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
		
    	renderer.material.SetTextureOffset ("_MainTex", offset);
    	renderer.material.SetTextureScale ("_MainTex", size);
    }
}

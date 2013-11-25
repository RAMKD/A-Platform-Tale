using UnityEngine;
using System.Collections;

public class SpawnPointBarril : MonoBehaviour {

	public GameObject 	barril;
	public float 		intervaloDeSpawn = 10.0f;
	public float		tempoDecorrido = 6.0f;
	public float		diferencaDeTempo = 0.0f;

	void Update () 
	{
		diferencaDeTempo = Time.deltaTime;
		tempoDecorrido += diferencaDeTempo;
		if (tempoDecorrido >= intervaloDeSpawn)
		{
			Instantiate(barril,transform.position,barril.transform.rotation);
			tempoDecorrido = 0.0f;
		}
	
	}
}

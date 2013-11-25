using UnityEngine;
using System.Collections;

public class TriggerElev: MonoBehaviour {
	public bool podeEntrar = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	

	void OnTriggerStay(Collider other) 
	{
		if(other.gameObject.tag == "Player")
		{
			podeEntrar = true;
		}
	}
	
	void OnTriggerExit(Collider other) 
	{
		if(other.gameObject.tag == "Player")
		{
			podeEntrar = false;
		}
	}
	
}

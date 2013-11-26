using UnityEngine;
using System.Collections;

public class Disquete : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		PlayerPrefs.SetInt("QTD_ITEM01",0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) 
	{
		if(other.gameObject.tag == "Player")
		{
			PlayerPrefs.SetInt("COD_ITEM01",1);
			PlayerPrefs.SetInt("QTD_ITEM01",PlayerPrefs.GetInt("QTD_ITEM01")+1);
			Destroy(gameObject);
			Debug.Log("Codigo do item: " + PlayerPrefs.GetInt("COD_ITEM01"));
			Debug.Log("Quantidade do item: " + PlayerPrefs.GetInt("QTD_ITEM01"));
		}
		
	}
}

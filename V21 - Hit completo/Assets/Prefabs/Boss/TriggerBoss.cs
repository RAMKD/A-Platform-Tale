using UnityEngine;
using System.Collections;

public class TriggerBoss : MonoBehaviour {
	

	public bool			colidiu = false;
	public Boss			boss;	
	
	void OnTriggerEnter(Collider other) 
	{
		if(other.gameObject.tag == "Trigger" && colidiu == false)
		{
			colidiu = true;
			boss.setVelocidade();
		}
		if(other.gameObject.tag=="Player" && colidiu == false)
		{
			boss.setVelocidade();
			PlayerPrefs.SetInt("VIDAS",PlayerPrefs.GetInt("VIDAS")-1);
		}
	}
	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Trigger")
		{
			colidiu = false;
		}
	}
}

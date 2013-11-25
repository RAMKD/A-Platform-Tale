using UnityEngine;
using System.Collections;

public class TriggerPe : MonoBehaviour 
{
	public bool colidiuInimigo = false;
	public CharacterMotor motor;
	public int cont = 0;
	void Start () 
	{
		motor = transform.parent.GetComponent<CharacterMotor>();
	
	}
	
	void OnTriggerEnter(Collider other)
	{
		if(other.tag=="Inimigo")
		{
			colidiuInimigo = true;
		}
	}
	void OnTriggerExit(Collider other)
	{
		if(other.tag=="Inimigo")
		{
			colidiuInimigo = false;
		}
	}
}

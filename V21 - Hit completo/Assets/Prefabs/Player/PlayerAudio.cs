using UnityEngine;
using System.Collections;

public class PlayerAudio : MonoBehaviour 
{
	
	private CharacterMotor motor;
	public AudioClip pulo;
	public CharacterController player;

	void Start () 
	{
		motor = transform.parent.GetComponent<CharacterMotor>();
		player = transform.parent.GetComponent<CharacterController>();
	}
	
	void Update () 
	{
		if(!motor.jumping.jumping && Input.GetKeyDown("space"))
		{
			audio.PlayOneShot(pulo);
		}
	}
}

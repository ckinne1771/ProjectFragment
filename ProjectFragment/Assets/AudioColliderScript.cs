using UnityEngine;
using System.Collections;

public class AudioColliderScript : MonoBehaviour {
	

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Player")
		{
			Debug.Log("collision");
			transform.gameObject.GetComponent<AudioSource>().Play();
		}
	}

	void OnTriggerExit2D(Collider2D other)
	{
		
		if(other.tag == "Player")
		{
			Debug.Log("collision");
			transform.gameObject.GetComponent<AudioSource>().Stop();
		}
}
}

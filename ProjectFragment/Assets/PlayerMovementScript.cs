using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour {
	public bool moveRight = false;
	public bool moveLeft = false;
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown (KeyCode.D))
		{
			Debug.Log ("entering if");
			moveRight = true;
		}
		if(Input.GetKeyDown(KeyCode.A))
		   {

			moveLeft = true;
		}
		if(Input.GetKeyUp (KeyCode.D))
		{
			moveRight = false;
		}
		if(Input.GetKeyUp(KeyCode.A))
		{
			moveLeft = false;
		}

		if(moveLeft==true)
		{
			transform.Translate(-6f*Time.deltaTime, 0f, 0f);
		}
		if(moveRight==true)
		{
			transform.Translate (6f*Time.deltaTime, 0f, 0f);
		}
	
	}
}

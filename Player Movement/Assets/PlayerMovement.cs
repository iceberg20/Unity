using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public Transform heroi;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey("left"))
			heroi.position =new Vector3(heroi.position.x-0.1f,heroi.position.y);
		
		if (Input.GetKey("right"))
			heroi.position =new Vector3(heroi.position.x+0.1f,heroi.position.y);

		if (Input.GetKey("up"))
			heroi.position =new Vector3(heroi.position.x, heroi.position.y+0.1f);
		
		if (Input.GetKey("down"))
			heroi.position =new Vector3(heroi.position.x, heroi.position.y-0.1f);
	}
}

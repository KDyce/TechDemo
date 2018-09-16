using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHeath : MonoBehaviour {

	public int heath;
	public bool hasDied; 
	
	// Use this for initialization
	void Start () {
		 hasDied = false;
	}
	
	void Update () {
		if (gameObject.transform.position.y < -7) {
			Debug.Log ("Player HAs Died");
		}
	}
}

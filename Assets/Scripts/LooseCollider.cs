using UnityEngine;
using System.Collections;

public class LooseCollider : MonoBehaviour {

	public LevelManager levelManager;
	
	void OnTriggerEnter2D (Collider2D trigger) {
		print ("Trigger");
		levelManager.LoadLevel("Win Screen");
	}
	
	void OnCollisionEnter2D (Collision2D collision) {
		print ("Collision");	
	}
	
}

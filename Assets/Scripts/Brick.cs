using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {
	
	public int maxHits;
	
	private int timesHit;
	private LevelManager levelManager;
	
	// Use this for initialization
	void Start () {
		timesHit = 0;
		levelManager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter2D (Collision2D col) {
		timesHit++;
		
		if (timesHit >= maxHits) {
			Destroy(gameObject);
		}
	}
	
	// TODO Remove this method once we can actually win!
	void SimulateWin () {
		levelManager.LoadNextLevel();
	}
}

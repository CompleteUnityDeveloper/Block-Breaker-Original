using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour
{	
	void OnTriggerEnter2D (Collider2D trigger)
    {
        FindObjectOfType<LevelLoader>().LoadLevel("Lose Screen");
	}
}

using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour
{	
	void OnTriggerEnter2D (Collider2D trigger)
    {
        FindObjectOfType<Level>().LoadLevel("Lose Screen");
	}
}

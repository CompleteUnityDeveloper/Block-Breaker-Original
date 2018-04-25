using UnityEngine;
using System.Collections;

// todo consider eliminating and wiring level to collider
public class LoseCollider : MonoBehaviour
{	
	void OnTriggerEnter2D (Collider2D trigger)
    {
        FindObjectOfType<Level>().LoadLevel("Lose Screen");
	}
}

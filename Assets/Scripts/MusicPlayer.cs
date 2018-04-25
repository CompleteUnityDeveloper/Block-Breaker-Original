using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour
{	
	void Start ()
    {
        int musicPlayerCount = FindObjectsOfType<MusicPlayer>().Length;
        if (musicPlayerCount > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
	}
}

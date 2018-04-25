using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour
{	
    // todo consider genericising
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

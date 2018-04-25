using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour
{
    // config parameters
    // todo consdier SO
	[SerializeField] AudioClip crack;
    [SerializeField] Sprite[] hitSprites;
    [SerializeField] GameObject smokeParticles;

    // state variables
	int timesHit;

    // cached references
    Level level;
	
	void Start ()
    {
        level = FindObjectOfType<Level>();
		// Keep track of breakable bricks
        if (tag == "Breakable")
        {
            level.RegisterBreakableBrick();
		}
		
		timesHit = 0;
	}
	
	
    void OnCollisionEnter2D()
    {
		AudioSource.PlayClipAtPoint(crack, transform.position); // todo need to tweak volume?
        if (tag == "Breakable")
        {
            HandleHit();
		}
	}
	
	void HandleHit()
    {
        int maxHits = hitSprites.Length + 1;
        timesHit++;
		if (timesHit >= maxHits)
        {
            DestroyBrick();
        }
        else
        {
			LoadSprites();
		}
	}

    private void DestroyBrick()
    {
        level.BrickDestoyed();
        PuffSmoke();
        Destroy(gameObject);
    }

    void PuffSmoke ()
    {
		GameObject smokePuff = Instantiate (smokeParticles, transform.position, Quaternion.identity) as GameObject;
        // todo parent game object
		smokePuff.GetComponent<ParticleSystem>().startColor = gameObject.GetComponent<SpriteRenderer>().color;
	}
	
	void LoadSprites ()
    {
		int spriteIndex = timesHit - 1;
		
		if (hitSprites[spriteIndex] != null)
        {
			GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
		}
        else
        {
			Debug.LogError ("Brick sprite missing");
		}
	}
}

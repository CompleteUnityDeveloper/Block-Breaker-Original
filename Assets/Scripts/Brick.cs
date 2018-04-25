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
        CountBreakableBricks();
        timesHit = 0;
    }

    private void CountBreakableBricks()
    {
        if (tag == "Breakable")
        {
            level.RegisterBreakableBrick();
        }
    }

    void OnCollisionEnter2D()
    {
		AudioSource.PlayClipAtPoint(crack, transform.position);
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
        PuffSmoke();
        level.BrickDestoyed();
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

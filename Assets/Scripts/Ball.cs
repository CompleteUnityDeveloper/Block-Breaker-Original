using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{
    [SerializeField] Vector2 launchVelocity = new Vector2(2f, 10f);
    [Range(0,1f)][SerializeField] float randomFactor = 0.2f;

	Paddle paddle;
	bool hasStarted = false;
	Vector3 paddleToBallVector;

	// Use this for initialization
	void Start ()
    {
		paddle = FindObjectOfType<Paddle>();
		paddleToBallVector = this.transform.position - paddle.transform.position;
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 velocityTweak = new Vector2(
            Random.Range(0f, randomFactor),
            Random.Range(0f, randomFactor)
        );

        if (hasStarted)
        {
            GetComponent<AudioSource>().Play();
            GetComponent<Rigidbody2D>().velocity += velocityTweak;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted)
        {
            LockBallToPaddle();
            LaunchOnMouseClick();
        }
    }

    private void LockBallToPaddle()
    {
        this.transform.position = paddle.transform.position + paddleToBallVector;
    }

    private void LaunchOnMouseClick()
    {
        // Wait for a mouse press to launch.
        if (Input.GetMouseButtonDown(0))
        {
            hasStarted = true;
            GetComponent<Rigidbody2D>().velocity = launchVelocity;
        }
    }
}

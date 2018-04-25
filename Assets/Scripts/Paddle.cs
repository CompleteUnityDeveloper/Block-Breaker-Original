using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

    // config params
    [SerializeField] bool autoLaunch = false;
	[SerializeField] float minX, maxX;
    [SerializeField] float paddleXOffset = 0.5f;
    [SerializeField] float screenWidthInBlocks = 16f;

    // state variables
    Vector2 paddlePos;

    // Update is called once per frame
    void Update()
    {
        paddlePos = new Vector2(paddleXOffset, transform.position.y);

        float rawXPos;

        if (FindObjectOfType<Game>().IsAutoPlayEnabled())
        {
            rawXPos = FindObjectOfType<Ball>().transform.position.x;
        }
        else
        {
            rawXPos = Input.mousePosition.x / Screen.width * screenWidthInBlocks;
        }
        paddlePos.x = Mathf.Clamp(rawXPos, minX, maxX);
        transform.position = paddlePos;
    }
}

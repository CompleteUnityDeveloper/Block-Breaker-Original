using UnityEngine;
using System.Collections;
using System;

public class Paddle : MonoBehaviour
{
    // config params
	[SerializeField] float minX, maxX;
    [SerializeField] float paddleXOffset = 0.5f;
    [SerializeField] float screenWidthInBlocks = 16f;

    // Update is called once per frame
    void Update() 
    {
        Vector2 paddlePos = new Vector2(paddleXOffset, transform.position.y);
        paddlePos.x = Mathf.Clamp(GetXPos(), minX, maxX);
        transform.position = paddlePos;

        Up();

    }

    private void Up()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector2 paddlePosUp = new Vector2(transform.position.x, transform.position.y + 1);
            transform.position = paddlePosUp;
            Down();
        }
    }

    private void Down()
    {
        Vector2 paddlePosDown = new Vector2(transform.position.x, transform.position.y - 1);
        transform.position = paddlePosDown;
    }

    private float GetXPos()
    {
        if (FindObjectOfType<Game>().IsAutoPlayEnabled())
        {
            return FindObjectOfType<Ball>().transform.position.x;
        }
        else
        {
            return Input.mousePosition.x / Screen.width * screenWidthInBlocks;
        }
    }
}

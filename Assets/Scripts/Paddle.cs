using UnityEngine;
using System.Collections;

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

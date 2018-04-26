using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
	// configuration parameters
    [SerializeField] bool isAutoPlayEnabled = false;
    [Range(.1f, 10f)] [SerializeField] float timeScale = 1f;

    // state variables
    [SerializeField] int score = 0; // challenge to drive UI after next section

    private void Start()
    {
        int gameCount = FindObjectsOfType<Game>().Length;
        if (gameCount > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = timeScale;
    }

    public bool IsAutoPlayEnabled()
    {
        return isAutoPlayEnabled;
    }

    public void ScorePoint()
    {
        score++;
    }

}

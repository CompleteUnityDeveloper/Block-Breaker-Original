using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelLoader : MonoBehaviour
{
	public void LoadLevel(string name)
    {
		Brick.breakableCount = 0; // todo remove static reference
        SceneManager.LoadScene(name);
	}

	public void QuitRequest()
    {
		Debug.Log ("Quit requested");
		Application.Quit ();
	}
	
	public void LoadNextLevel()
    {
		Brick.breakableCount = 0;
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        print(currentSceneIndex);
        SceneManager.LoadScene(currentSceneIndex + 1);
	}
	
	public void BrickDestoyed()
    {
		if (Brick.breakableCount <= 0)
        {
			LoadNextLevel();
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StartGame : MonoBehaviour {

	public void ToGame()
    {
        SceneManager.LoadScene(1);
    }
}

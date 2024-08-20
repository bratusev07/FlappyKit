using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class HomeController : MonoBehaviour
{

    public void ChangeScene()
    {
        SceneManager.LoadSceneAsync(0);
        if (PlayerPrefs.GetInt("BestScore") < ScoreColliderScript.score) PlayerPrefs.SetInt("BestScore", ScoreColliderScript.score);
        Debug.Log(PlayerPrefs.GetInt("BestScore"));
        ScoreColliderScript.score = 0;
    }
}

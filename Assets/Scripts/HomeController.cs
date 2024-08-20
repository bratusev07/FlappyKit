using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class HomeController : MonoBehaviour
{

    public void Start()
    {
        GameObject.Find("BestScoreText").GetComponent<TextMeshProUGUI>().text = "Best score: " + PlayerPrefs.GetInt("BestScore");
    }

    public void ChangeScene()
    {
        SceneManager.LoadSceneAsync(0);
        if (PlayerPrefs.GetInt("BestScore") < ScoreColliderScript.score) PlayerPrefs.SetInt("BestScore", ScoreColliderScript.score);
        ScoreColliderScript.score = 0;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class HomeController : MonoBehaviour
{

    public void Start()
    {
        Debug.Log(PlayerPrefs.GetInt("BestScore"));
        GameObject.Find("BestScoreText").GetComponent<TextMeshProUGUI>().text = "Best score: " + PlayerPrefs.GetInt("BestScore");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.PageUp))
        {
            SceneManager.LoadSceneAsync(0);
        }
    }


    public void ChangeScene()
    {
        SceneManager.LoadSceneAsync(0);
    }
}

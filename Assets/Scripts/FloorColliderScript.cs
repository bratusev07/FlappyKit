using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FloorColliderScript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "Player") {
            SceneManager.LoadSceneAsync(1);
            if (PlayerPrefs.GetInt("BestScore") < ScoreColliderScript.score) PlayerPrefs.SetInt("BestScore", ScoreColliderScript.score);
            ScoreColliderScript.score = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player") {
            SceneManager.LoadSceneAsync(1);
            if (PlayerPrefs.GetInt("BestScore") < ScoreColliderScript.score) PlayerPrefs.SetInt("BestScore", ScoreColliderScript.score);
            ScoreColliderScript.score = 0;
        }
    }
}

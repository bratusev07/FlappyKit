using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreColliderScript : MonoBehaviour
{

    public static int score = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            score++;
            GameObject.Find("ScoresText").GetComponent<TextMeshProUGUI>().text = score + "";
        }
    }
}

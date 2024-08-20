using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapToStartScript : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch userTouch = Input.GetTouch(0);
            if (userTouch.phase == TouchPhase.Began)
            {
                Time.timeScale = 1f;
                Destroy(gameObject);
            }
        }
    }
}

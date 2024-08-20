using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTunelScript : MonoBehaviour
{
    void Update()
    {
        if (gameObject.transform.position.x <= -6.3) Destroy(gameObject);
    }
}

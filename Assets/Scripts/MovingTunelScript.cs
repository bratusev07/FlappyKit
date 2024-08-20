using UnityEngine;

public class MovingTunelScript : MonoBehaviour
{
    private float speed;
    public void SetSpeed(float moveSpeed)
    {
        speed = moveSpeed;
    }

    private void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime); // Движение влево
    }
}

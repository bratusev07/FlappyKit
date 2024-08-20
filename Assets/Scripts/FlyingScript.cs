using UnityEngine;

public class FlyingScript : MonoBehaviour
{

    [SerializeField]
    private float startMoveSpeed = 0.1f;
    [SerializeField]
    private float angel;
    [SerializeField]
    private float speed;
    private Quaternion topTargetRotation;
    private Quaternion botTargetRotation;
    private Vector3 direction;
    private Quaternion initialRotation;

    void Start()
    {
        topTargetRotation = Quaternion.Euler(0, 0, angel);
        botTargetRotation = Quaternion.Euler(0, 0, -angel);
        initialRotation = transform.rotation;
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch userTouch = Input.GetTouch(0);
            if (userTouch.phase == TouchPhase.Began)
            {
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, startMoveSpeed, 0), ForceMode2D.Impulse);
            }
        }
    }

    private float targetRotation = 0;
    private void FixedUpdate()
    {
        float tempSpeed = direction.y * Time.fixedDeltaTime * speed;
        targetRotation += tempSpeed;
        if (direction.y < 0) targetRotation += tempSpeed/3f;
        if (targetRotation > 31) targetRotation = 30;
        if (targetRotation < -31) targetRotation = -31;
        direction = GetComponent<Rigidbody2D>().velocity.normalized;
        gameObject.transform.rotation = Quaternion.Euler(0, 0, targetRotation);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "top_collider")
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, -startMoveSpeed, 0), ForceMode2D.Impulse);
        }
    }
}

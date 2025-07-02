using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;

    private Touch touch;
    private float speedModifier;

    // Start is called before the first frame update
    void Start()
    {
        speedModifier = 0.01f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //Adding forwardForce to game object

        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(
                     transform.position.x + touch.deltaPosition.x * speedModifier,
                      transform.position.y,
                       transform.position.z + touch.deltaPosition.y * speedModifier);

            }
        }

        if (rb.position.y < 0f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}

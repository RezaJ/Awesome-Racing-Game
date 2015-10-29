using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    public float speed = 20f;
    public float turnSpeed = 5f;
    private bool up = false;
    private bool down = false;
    private bool right;
    private bool left;

    // Use this for initialization
    void Start () {
        rigidBody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update () {
        up = Input.GetKey(KeyCode.UpArrow);
        down = Input.GetKey(KeyCode.DownArrow);
        left = Input.GetKey(KeyCode.LeftArrow);
        right = Input.GetKey(KeyCode.RightArrow);
    }

    void FixedUpdate () {

        // rotate car
        if (left)
            transform.Rotate(Vector3.forward, turnSpeed * rigidBody.velocity.magnitude);

        if (right)
            transform.Rotate(Vector3.forward, -turnSpeed * rigidBody.velocity.magnitude);

        // add force
        if (up) {
            rigidBody.AddForce(transform.up * speed);
        } else if (down) {
            rigidBody.AddForce(-transform.up * speed);
        }
    }
}

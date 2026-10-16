using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody rb;
    public Vector3 direction;
    public float speed = 5f;
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        direction = Vector3.zero;

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            direction += new Vector3(0, 0, 1);
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            direction += new Vector3(0, 0, -1);
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            direction += new Vector3(-1, 0, 0);
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            direction += new Vector3(1, 0, 0);
        }

        direction = direction.normalized;
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + direction * Time.fixedDeltaTime * speed);
    }
}
using UnityEngine;
using System.Collections;

public class PlayerControll : MonoBehaviour
{
    public float speed;
    public float breakdrag;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }


    void Update()
    {
       Vector3 force = new Vector3(Input.GetAxis("Horizontal") * speed, 0, Input.GetAxis("Vertical") * speed);
        rb.AddForce(force);

        if (Input.GetKey(KeyCode.Space))
            rb.drag += .1f;

        else rb.drag = 0;

    }
}

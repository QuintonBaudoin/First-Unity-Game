using UnityEngine;
using System.Collections;

public class AiLogic : MonoBehaviour
{
    public float speed;
    Vector2 m_speed;
    Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        m_speed.x = speed * Random.Range(-2, 2);
        m_speed.y = speed * Random.Range(-2, 2);
        rb.AddForce(m_speed.x , 0, m_speed.y);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

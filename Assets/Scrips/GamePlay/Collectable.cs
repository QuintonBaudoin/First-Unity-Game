using UnityEngine;
using System.Collections;

public class Collectable : MonoBehaviour
{
    public Vector3 rot;

    public GameObject go_Spwnr;
    public GameObject go_Enemy;
    public GameObject Text_Score;
    


    private Rigidbody rb;
    private Vector3 pos;
   

    // Use this for initialization
    void Start()
    {
      
        pos.x = Random.Range(-4f, 4f);
        pos.z = Random.Range(-4f, 4f);
        pos.y = 0.5f;
        GetComponent<Transform>().position = pos;

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddTorque(rot);

     
    }

    void OnTriggerEnter(Collider c)
    {   
        if(c.gameObject.CompareTag("Player")) // if the collider is owned by the player, then we want to do the respawn thingy
        {
            pos.x = Random.Range(-4, 4);
            pos.z = Random.Range(-4, 4);
            pos.y = 0.5f;
            GetComponent<Transform>().position = pos;

            Text_Score.GetComponent<Score>().score += 1;

            go_Enemy.GetComponent<EnemySpawn>().SpawnEnemy();

        }
        
    }
}

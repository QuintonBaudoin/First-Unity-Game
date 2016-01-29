using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour
{
    public GameObject go_Spawner;
    public GameObject Text_lives;
    public GameObject go_Enemy;

    Vector3 m_temp;

    // Use this for initialization
    void Start()
    {
        m_temp = go_Spawner.GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnEnemy()
    {
        m_temp.x = Random.Range(-4f, 4f);
        m_temp.z = Random.Range(-4f, 4f);
        m_temp.y = .5f;
        Instantiate(go_Enemy, m_temp, go_Spawner.GetComponent<Transform>().rotation);


        
    }

    void OnTriggerEnter(Collider c)
    {
       if(c.gameObject.CompareTag("Player"))
       {
           Text_lives.GetComponent<Lives>().lives -= 1;
           if (Text_lives.GetComponent<Lives>().lives <= 0)
           {
             

           }
       }

    }

}

using UnityEngine;
using System.Collections;

public class CollectableSpawner : MonoBehaviour
{
    public GameObject go_Obj;
    public GameObject go_Spwnr;


    Vector3 m_temp;
   
    // Use this for initialization
    void Start()
    {
        m_temp = go_Spwnr.GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {

        m_temp.x = Random.Range(-4f, 4f);
        m_temp.z = Random.Range(-4f, 4f);

        
      
        Instantiate(go_Obj, m_temp, go_Spwnr.GetComponent<Transform>().rotation);


    }
}

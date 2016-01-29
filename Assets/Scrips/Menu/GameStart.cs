using UnityEngine;
using System.Collections;

public class GameStart : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
           Application.LoadLevel("GamePlay");
        }


    }


}

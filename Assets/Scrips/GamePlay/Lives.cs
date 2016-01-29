using UnityEngine;
using System.Collections;

public class Lives : MonoBehaviour
{
    internal int lives;

    // Use this for initialization
    void Start()
    {
        lives = 3;


        GetComponent<TextMesh>().text = lives.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMesh>().text = lives.ToString();

        if(lives <= 0)
        {

            Destroy(GameObject.FindGameObjectWithTag("Player"));
            GetComponent<TextMesh>().text = "GameOver: <~>Press Space<~> ";
            
            if(Input.GetKey(KeyCode.Space))
                Application.LoadLevel("Menu");
        }

    }
}

using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour
{

    internal int score;

    // Use this for initialization
    void Start()
    {
        score = 0;


        GetComponent<TextMesh>().text = score.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMesh>().text = score.ToString();
    }


}

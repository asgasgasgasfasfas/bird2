using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score = 0;
    public static int BastScore = 0;
    public static int item1 = 0;
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {   
      
        // score = score + 1;
        GetComponent<Text>().text = score.ToString();
       // GetComponent<Text>().text = item1.ToString();


    }
}

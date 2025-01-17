using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerJump : MonoBehaviour
{
    [SerializeField]
    private float jumppower = 3f;

    Rigidbody2D rigidbody2D;
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody2D.velocity = Vector3.up*jumppower;
        }
        

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(Score.score > Score.BastScore)
        {
            Score.BastScore = Score.score;  
        }
        SceneManager.LoadScene("GameOver");

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    [SerializeField]
    private float speed = 3f;
    [SerializeField]
    private Vector3 MoveDirection =  Vector3.left;
    
    
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += MoveDirection*speed*Time.deltaTime;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    [SerializeField]
    private GameObject PipePrb;
    [SerializeField]
    private GameObject item;
    
    [SerializeField]
    private float var = 1;
    private float timer = 0;
    private Vector3 lastPipePosition;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; // 6fps = 6/1 초 
        //Debug.Log(timer);

        if(timer > var)
        {

            GameObject pi= Instantiate(PipePrb);
            lastPipePosition = new Vector3(5.63f, Random.Range(-1.99f, 4.69f), 0);
            lastPipePosition  = pi.transform.position;

            if (Random.Range(1, 4) <= 2)
            {
                GameObject it = Instantiate(item);
                it.transform.position = lastPipePosition;
            }

             
            timer = 0;
            Destroy(pi, 10.0f);
        }

        
    }
}

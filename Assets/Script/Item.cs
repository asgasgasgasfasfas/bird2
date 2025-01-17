using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        { Debug.Log("아이템 획득!");

            // 아이템을 사라지게 함
            Destroy(gameObject);
        }
    }
}


using UnityEngine;

public class GroundMove : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    [SerializeField]
    private float scrollRange = 7.21f;
    [SerializeField]
    private float moveSpeed = 3.0f;
    [SerializeField]
    private Vector3 moveDirection = Vector3.left;

    private void Update()
    {
        transform.position += moveDirection * moveSpeed * Time.deltaTime;

        if (transform.position.x <= -scrollRange)
        {
            transform.position = transform.position + Vector3.right * scrollRange*2;
        }
    }
}

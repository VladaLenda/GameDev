using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float speed = 5f;
    private Vector3 direction;
    private bool isRaising;

    void Start()
    {
        direction = Vector3.up;
        isRaising = false;
    }

    void Update()
    {
        if (isRaising)
        {
            transform.Translate(direction * speed * Time.deltaTime);
        }
    }

    public void OnMouseClick()
    {
        isRaising = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            isRaising = false;
        }
    }
}
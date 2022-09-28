using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeBall : MonoBehaviour
{
    public float MoveSpeed;
    private Vector3 direction;
    public GameObject Ball;
    

    // directie variable


    void Start()
    {
        direction = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0);
        direction = direction.normalized;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * MoveSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D Collision)
    {
        if (Collision.gameObject.CompareTag("Wall"))
        {
            direction = Vector3.Reflect(direction, Collision.contacts[0].normal);
        }
        if (Collision.gameObject.CompareTag("Paddle"))
        {
            direction = Vector3.Reflect(direction, Collision.contacts[0].normal);
            MoveSpeed += 0.5f;
        }


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Goal"))
        {
            ResetBall();
            MoveSpeed = 6;
            Ball.SetActive(false);
        }
        if (collision.gameObject.CompareTag("Goal2"))
        {
            ResetBall();
            MoveSpeed = 6;
            Ball.SetActive(false);
            
        }
    }
    private void ResetBall()
    {
        transform.position = new Vector3(0, 1, 0);
        direction = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0);
        direction = direction.normalized;
    }


}

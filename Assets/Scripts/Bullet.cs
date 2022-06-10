using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float bulletSpeed = 5f;
    float xSpeed;
    Rigidbody2D myRigidBody;
    PlayerMovements player;

    
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        player = FindObjectOfType<PlayerMovements>();
        xSpeed = player.transform.localScale.x * bulletSpeed; //localscale goes 1 or -1
    }

    
    void Update()
    {
        myRigidBody.velocity = new Vector2 (xSpeed, 0f);
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
       if(other.tag == "Enemy")
       {
           Destroy(other.gameObject);
       }
       
       Destroy(gameObject); 
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        Destroy(gameObject);
    }
}

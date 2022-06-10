using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    [SerializeField] AudioClip coinPickUpSFX;
    [SerializeField] int pointForCoins = 100;

    bool wasCollected;

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player" && !wasCollected)
        {   
            wasCollected = true;
            AudioSource.PlayClipAtPoint(coinPickUpSFX, Camera.main.transform.position);
            FindObjectOfType<GameSession>().IncreaseScore(pointForCoins);
            Destroy(gameObject);
        }
    }

}

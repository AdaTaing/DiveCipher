using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_manager : MonoBehaviour
{
    [SerializeField] private GameObject deathExplosion;

    private void OnTriggerEnter(Collider collisionInfo)
    {
        if(collisionInfo.gameObject.tag == "Obstacle")
        {
            Instantiate(deathExplosion, transform.position, transform.rotation);
            
            FindObjectOfType<game_manager>().EndGame();
            Destroy(this.gameObject);
        }
    }
}

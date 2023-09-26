using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger_spawner : MonoBehaviour
{
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private GameObject[] nextObstacle = new GameObject[5];
    [SerializeField] private float spawnDist = 150f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider collisonInfo)
    {
        if(collisonInfo.gameObject.tag == "Player")
        {
            Debug.Log("entered");
            float randNum = Random.Range(1, 6);
            switch (randNum)
            {
                case 1:
                    Instantiate(nextObstacle[0], spawnPoint.position + Vector3.down * spawnDist, transform.rotation);
                    return;
                case 2:
                    Instantiate(nextObstacle[1], spawnPoint.position + Vector3.down * spawnDist, transform.rotation);
                    return;
                case 3:
                    Instantiate(nextObstacle[2], spawnPoint.position + Vector3.down * spawnDist, transform.rotation);
                    return;
                case 4:
                    Instantiate(nextObstacle[3], spawnPoint.position + Vector3.down * spawnDist, transform.rotation);
                    return;
                case 5:
                    Instantiate(nextObstacle[4], spawnPoint.position + Vector3.down * spawnDist, transform.rotation);
                    return;
            }
        }
    }
}

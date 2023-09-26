using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle_destory : MonoBehaviour
{
    private void OnTriggerEnter(Collider collisionInfo)
    {
        if(collisionInfo.gameObject.tag == "Player")
        {
            Destroy(transform.parent.gameObject);
        }
    }
}

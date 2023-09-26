using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class points : MonoBehaviour
{
    [SerializeField] private float spd;

    private void Awake()
    {
        spd = Random.Range(25f, 36f);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0, spd * Time.deltaTime, 0);
    }
    private void OnTriggerEnter(Collider collisionInfo)
    {
        if(collisionInfo.gameObject.tag == "Player" || collisionInfo.gameObject.tag == "Projectile")
        {
            FindObjectOfType<game_manager>().AddPoints();
            Destroy(this.gameObject);
        }
    }
}

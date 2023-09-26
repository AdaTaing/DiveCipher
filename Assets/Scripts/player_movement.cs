using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    [SerializeField] private float spd = 2f;
    [SerializeField] private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-spd * Time.deltaTime, 0, 0, ForceMode.Impulse);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(spd * Time.deltaTime, 0, 0, ForceMode.Impulse);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle_mover : MonoBehaviour
{
    [SerializeField] private float obstSpd = 35f;
    // Update is called once per frame
    void Update()
    {
       this.transform.Translate(0, obstSpd * Time.deltaTime, 0);
    }
}

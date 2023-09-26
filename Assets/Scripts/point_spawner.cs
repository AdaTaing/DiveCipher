using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class point_spawner : MonoBehaviour
{
    [SerializeField] private GameObject point;
    private void Awake()
    {
       Instantiate(point, transform.position, transform.rotation);
    }
}

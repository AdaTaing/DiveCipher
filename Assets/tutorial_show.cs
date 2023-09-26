using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class tutorial_show : MonoBehaviour
{
    [SerializeField] private GameObject movementTut;

    private void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            movementTut.SetActive(false);
        }
    }
}

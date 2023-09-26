using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    public void DisplayScore(float score)
    {
        scoreText.text = score.ToString("0");
    }
}

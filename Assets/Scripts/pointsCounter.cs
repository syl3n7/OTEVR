using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
using TMPro;

public class pointCounter : MonoBehaviour
{
    [SerializeField] private TMP_Text text;
    private int points = 0;

    public void AddPoints()
    {
        points++;
    }

    private void Update()
    {
        text.text = "Points: " + points;
    }
}

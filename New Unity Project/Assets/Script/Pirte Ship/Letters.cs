using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Letters : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "word")
        {
            AddLetters();
            ControllerScript.GainXP(1);
        }


        void AddLetters()
        {
            ScoreCount++;
            ScoreText.text = ScoreCount.ToString();
        }

    }
}
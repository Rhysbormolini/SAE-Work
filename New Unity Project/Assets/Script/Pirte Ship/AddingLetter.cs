﻿using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class AddingLetter : MonoBehaviour
{
    public int LetterCount;
    public Text LetterText;
    char[] wordArray = new char[13] {'T', 'H', 'E', 'B', 'L', 'A', 'C', 'K', 'P', 'E', 'A', 'R', 'L'};
    string Penis;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "word")
        {
            AddLetters();
            Destroy(other.gameObject);
        }


        void AddLetters()
        {
            LetterCount++;
            for (int i = 0; i < wordArray.Length; i++)
            {
                Penis = wordArray[LetterCount-1].ToString();
            }
            LetterText.text += Penis;
        }

    }
}

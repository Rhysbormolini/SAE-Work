using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int ScoreCount;
    public Text ScoreText;
    private characterController ControllerScript;

   

    // Start is called before the first frame update
    void Start()
    {
        ControllerScript = GetComponent<characterController>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            AddScore();
            ControllerScript.GainXP(1);
        }

        else if (other.tag == "MegaCoin")
        {
            AddScore();
            ControllerScript.GainXP(5);
        }
    }

    void AddScore()
    {
        ScoreCount++;
        ScoreText.text = ScoreCount.ToString();
    }
        
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int ScoreCount;
    public Text ScoreText;
    public int targetScore = 23;
    private characterController ControllerScript;

   

    // Start is called before the first frame update
    void Start()
    {
        ControllerScript = GetComponent<characterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // check the number of coins that have been collected 
        if (ScoreCount == this.targetScore)
        {
            // output that the number of target coins have been collected 
            Debug.Log("Player had collected " + this.targetScore + " Coins");

            // deactivate componentso that it stops checking the score each update 
            this.gameObject.SetActive(false);
        }
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

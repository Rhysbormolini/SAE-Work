using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class characterController : MonoBehaviour

{

    public float speed = 7;
    public float jumpHeight = 5f;

    public float currentMoveSpeed;
    public float currentjumpHeight;

    public float xp = 0;	// Amount of XP the player has
    public float xpForNextLevel = 5;   //Xp needed to level up, the higher the level, the harder it gets. 
    public int level = 0;   // Level of the player
    public Text LevelCounter;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        SetXpForNextLevel();
        SetCurrentMoveSpeed();
        SetCurrentjumpHeight();
        LevelCounter.text = "Level: " + level;
    }

    void SetXpForNextLevel()
    {
        xpForNextLevel = (5f + (level * level * 0.3f));
        Debug.Log("xpForNextLevel " + xpForNextLevel);
    }



    void SetCurrentMoveSpeed()
    {
        currentMoveSpeed = this.speed + (this.speed * 0.1f * level);
        Debug.Log("currentMoveSpeed = " + currentMoveSpeed);
    }

    void SetCurrentjumpHeight()
    {
        currentjumpHeight = this.jumpHeight + (this.jumpHeight * (level * 0.1f));
        Debug.Log("currentjumpHeight = " + currentjumpHeight);
    }


    void LevelUp()
    {
        xp = 0f;
        level++;
        LevelCounter.text = "Level: " + level;
        SetXpForNextLevel();
        SetCurrentMoveSpeed();
        SetCurrentjumpHeight();

    }


    //a function to make the player gain the ammount of Xp the you tell it. 
    public void GainXP(int xpToGain)
    {
        xp += xpToGain;
        Debug.Log("Gained " + xpToGain + " XP, Current Xp = " + xp + ", XP needed to reach next Level = " + xpForNextLevel);
    }


    // Update is called once per frame
    void Update()
    {
        {
            //Test the GainXp function by pressing the x button. 
            if (Input.GetKeyDown(KeyCode.X) == true) { GainXP(1); }


            //LevelUp when the appropriate conditions are met.
            if (xp >= xpForNextLevel)
            {
                LevelUp();
            }



            float translation = Input.GetAxis("Vertical") * currentMoveSpeed;
            float straffe = Input.GetAxis("Horizontal") * currentMoveSpeed;
            translation *= Time.deltaTime;
            straffe *= Time.deltaTime;

            transform.Translate(straffe, 0, translation);

            if (Input.GetKeyDown("escape"))
                Cursor.lockState = CursorLockMode.None;

            if (Input.GetKey(KeyCode.Space) == true && Mathf.Abs(this.GetComponent<Rigidbody>().velocity.y) < 0.01f)
            {
                this.GetComponent<Rigidbody>().velocity += Vector3.up * this.currentjumpHeight;
            }
        }
    }
}
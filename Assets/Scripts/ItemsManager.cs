using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemsManager : MonoBehaviour
{
    public static ItemsManager instance;
    private int doubleJumpCounter;
    public int dashCounter;
    private int ballModeDropBombsCounter;

    private void Awake()
    {
        instance = this;
    }

    public void AddDoubleJump()
    {
        if (doubleJumpCounter < 5)
        {
            doubleJumpCounter++;
            UIManager.instance.AddDoubleJumpScore();
        }
        if (doubleJumpCounter >= 5)
        {
            GameObject.Find("Player").GetComponent<PlayerExtrasTracker>().CanDoubleJump = true;
            print("DoubleJump Activated");
        }
    }

    public void AddDash()
    {
        if (dashCounter < 6)
        {
            dashCounter++;
            UIManager.instance.AddDashScore();
        }
        if(dashCounter >= 6)
        {
            GameObject.Find("Player").GetComponent<PlayerExtrasTracker>().CanDash = true;
        }
    }

    public void AddBallModeDropBombs()
    {
        if (ballModeDropBombsCounter < 10)
        {
            ballModeDropBombsCounter++;
            UIManager.instance.AddBallModeDropBombScore();
        }
        if (ballModeDropBombsCounter >= 10)
        {
            GameObject.Find("Player").GetComponent<PlayerExtrasTracker>().CanEnterBallMode = true;
            GameObject.Find("Player").GetComponent<PlayerExtrasTracker>().CanDropBombs = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    private int addDoubleJumpScore;
    private int addDashScore;
    private int addBallModeDropBombsScore;

    private void Awake()
    {
        instance = this;
    }

    public void AddDoubleJumpScore()
    {
        addDoubleJumpScore++;
    }
    public void AddDashScore()
    {
        addDashScore++;
    }
    public void AddBallModeDropBombScore()
    {
        addBallModeDropBombsScore++;
    }

    private void OnGUI()
    {
        GUILayout.Label("Double Jump Score: " + addDoubleJumpScore.ToString());
        GUILayout.Label("Dash Score: " + addDashScore.ToString());
        GUILayout.Label("Ball Mode Drop Bombs Score: " + addBallModeDropBombsScore.ToString());
    }

}

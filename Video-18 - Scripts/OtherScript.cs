using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherScript : MonoBehaviour
{
    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>(); // Getting reference to Gamemanager Script
        gameManager.forceFieldDuration = 9; // Trying to change thje value of ForcefieldDuration in GameManager script | Will give error because its above 8

    }
}
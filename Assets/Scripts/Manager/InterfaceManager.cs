using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class InterfaceManager : MonoBehaviour
{
    [SerializeField]
    private Button joinPlayerOne;

    [SerializeField] private Button joinPlayerTwo;

    // Completed: Add PlayerTwoButton reference

    [SerializeField]
    private SplitKeyboardPlayerInputManager playerInputManager;
    // Start is called before the first frame update
    void Start()
    {
        joinPlayerOne.onClick.AddListener(() => JoinPlayerOne());
        //Completed Listen for player two click event
        joinPlayerTwo.onClick.AddListener(() => JoinPlayerTwo());
    }

    private void JoinPlayerOne()
    {
        playerInputManager.JoinPlayer(0, "Keyboard&Mouse");
        //TODO flip text to say "Leave Player One"
        //TODO on click after player has joined, remove player
    }

    //TODO Invoke JoinPlayer passing a playerIndex value and targeting a control scheme
    private void JoinPlayerTwo()
    {
        Debug.Log("Player2 has joined");
        //TODO flip text after player has joined to say "Leave Player Two"
        //TODO on click after player has joined, remove player
    }

}

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
        if (PlayerInput.GetPlayerByIndex(0) == null)
        {
            playerInputManager.JoinPlayer(0, "Keyboard&Mouse");
            //Completed flip text to say "Leave Player One"
            joinPlayerOne.GetComponentInChildren<Text>().text = "Leave Player One";
        }
        else    //Completed on click after player has joined, remove player
        {
            playerInputManager.LeavePlayer(0);
            joinPlayerOne.GetComponentInChildren<Text>().text = "Join Player One";
        }
    }

    //TODO Invoke JoinPlayer passing a playerIndex value and targeting a control scheme
    private void JoinPlayerTwo()
    {
        if (PlayerInput.GetPlayerByIndex(1) == null)
        {
            playerInputManager.JoinPlayer(1, "PlayerTwo");
            //TODO flip text after player has joined to say "Leave Player Two"
            joinPlayerTwo.GetComponentInChildren<Text>().text = "Leave Player Two";
        }
        else    //TODO on click after player has joined, remove player 
        {
            playerInputManager.LeavePlayer(1);
            joinPlayerTwo.GetComponentInChildren<Text>().text = "Join Player Two";
        }
    }

}

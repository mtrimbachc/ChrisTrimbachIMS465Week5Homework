using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SplitKeyboardPlayerInputManager : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab;

    private Dictionary<int, PlayerInput> existingPlayerInputs = new Dictionary<int, PlayerInput>();
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void JoinPlayer(int playerIndex, string controlScheme)
    {
        if (!existingPlayerInputs.ContainsKey(playerIndex))
        {
            var playerInput = PlayerInput.Instantiate(prefab, controlScheme: controlScheme, playerIndex: playerIndex, pairWithDevice: Keyboard.current);
            playerInput.SwitchCurrentControlScheme(controlScheme);
            existingPlayerInputs.Add(playerIndex, playerInput);
            SendMessage("OnPlayerJoined", playerInput);
        }
    }

    //Completed remove player from game and free up playerIndex in existingPlayerInputs
    // Player is removed in PlayerManager by destroying its gameObject
    public void LeavePlayer(int playerIndex)
    {
        var playerInput = existingPlayerInputs[playerIndex];

        existingPlayerInputs.Remove(playerIndex);
        Debug.Log(existingPlayerInputs.Count);
        SendMessage("OnPlayerLeft", playerInput);
    }
}

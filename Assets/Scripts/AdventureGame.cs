using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    string[] DaysOfTheWeek = { "Monday","Tuesday", "Wednesday","Thursday","Friday", "Saturday","Sunday"};

    State state;


    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
        Debug.Log(DaysOfTheWeek[1]);
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var nextStates = state.GetNextStates();

        for (int index = 0; index < nextStates.Length; index++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1+ index))
            {
                state = nextStates[index];

            }
        }

       


        textComponent.text = state.GetStateStory();
    }
}

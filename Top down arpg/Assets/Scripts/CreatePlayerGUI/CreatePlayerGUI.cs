using UnityEngine;
using System.Collections;

public class CreatePlayerGUI : MonoBehaviour {

    public enum CreatePlayerStates
    {
        CLASSSELECTION, //display  class types
        STATALLOCATION, //allocate stats
        FINALSETUP      //add name and misc
    }

    private DisplayCreatePlayerFunction displayFunction = new DisplayCreatePlayerFunction();
    private CreatePlayerStates currentState;
    
	void Start () {
        currentState = CreatePlayerStates.CLASSSELECTION;
	}
	
	void Update () {
        switch (currentState) {
            case (CreatePlayerStates.CLASSSELECTION):

                break;
            case (CreatePlayerStates.STATALLOCATION):

                break;
            case (CreatePlayerStates.FINALSETUP):

                break;
        }
	}

    void OnGUI()
    {
        if (currentState == CreatePlayerStates.CLASSSELECTION)
        {
            displayFunction.DisplayClassSelection();
        }
        if (currentState == CreatePlayerStates.STATALLOCATION)
        {
            displayFunction.DisplayStatAllocation();
        }
        if (currentState == CreatePlayerStates.FINALSETUP)
        {
            displayFunction.DisplayFinalSetup();
        }
    }
}

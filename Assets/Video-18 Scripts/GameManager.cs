using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public string playerName; // Can be accessed and changed from anyscript in the project | Public variables are already serialized
    private string playerName2; // Can only be accessed from within THIS script and no where else, including the inspector | Private variables NOT serialized
    [SerializeField] private string playerName3; // Can see this in the inspector but its hidden everywhere else in the game
    [SerializeField] private int stepOne, stepTwo, stepThree; // Can serialize multiple variables of the same type on one line

    public int forceFieldDuration3 { get; } = 5; // Can be only READ from anywhere in the game, including in this script | READONLY
    public int forcefieldDuration4 { get; private set; } = 5; // Can be only READ from anywhere in the game BUT can be changed from within THIS script

    // ----- GET | SET Example --------------------------------------------------------------------------------------------|
    private int p_forceFieldDuration = 5; // Can only be accessed from within THIS script and no where else              
    public int forceFieldDuration // Can be accessed and changed from anyscript in the project but has access rules below
    {
        get { return p_forceFieldDuration; }
        set
        {
            if (value > 8) // if greater than 8 then don't change it
            {
                Debug.Log("Duration cannot be above 8. Try between 1 and 8");
                Debug.Log("Duration remains at:" + p_forceFieldDuration);
            }
            else
            {
                p_forceFieldDuration = value; // if less than 8 then change p_forceFieldDuration to the value
                Debug.Log("Value successfully changed and is now: " + p_forceFieldDuration);
            }
        }
    }
    // ---------------------------------------------------------------------------------------------------------------------|
}




using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goapPlanner : MonoBehaviour
{
    public allPrequisites setOfPrereqs;
    public ListOfActions setOfActions;
    Action currentAction;
    bool planningKill;



    private void Start()
    {
        setOfPrereqs = new allPrequisites();
        setOfActions = new ListOfActions(this);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !planningKill)
        {
            setOfPrereqs = new allPrequisites();
            setOfActions = new ListOfActions(this); // reset the variables so we plan from the start

            currentAction = new KillDavid(this); // start planning from get kill david
            planningKill = true;

            if (currentAction.ExecuteAction(this))
            {
                Debug.Log("You killed David!");
            }
        }
    }
}

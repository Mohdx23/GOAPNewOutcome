using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Action
{
    public string aEffect; //the action effect
    public string[] reqEffect; //the required effect we want. ex : (Action) find david = effect will be david found.

    protected Prerequisite preReqNeeded; //the preqequisite we need to execute the action.
    protected Prerequisite[] availablePrereqs; //prereqs we can do to match with the actions to get us our goal.
    public virtual bool ExecuteAction(goapPlanner gPlanner) //execute action func
    {
        for (int i = 0; i < availablePrereqs.Length; i++)  //so we if we have prereqs available.
        {
            if (!availablePrereqs[i].preReqMatched) //if none have been met.
            {
                foreach (Action action in gPlanner.setOfActions.possibleActions)  //then we go through each action in our set of actions that we have in the action list
                {
                    if (action.aEffect == reqEffect[i]) //then if the action matches up with the effect ex : david found david killed
                    {
                        if (action.ExecuteAction(gPlanner)) //we execute.
                        {
                            goto GotPrerequisite; 
                        }
                    }
                }

                
                return false; 

            }

        GotPrerequisite: 
            continue;
        }

        gPlanner.StartCoroutine(Execute(gPlanner)); //then we have a coroutine for our planner to execute what the action is supposed to do
        preReqNeeded.preReqMatched = true; //then we here we make this true because the pre-req has been met.

        return true;
    }

    protected abstract IEnumerator Execute(goapPlanner gBase); 

}

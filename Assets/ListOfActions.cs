using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListOfActions
{
    public List<Action> possibleActions = new List<Action>(); //here we create a list of the possbile actions we want to take .

    KillDavid killDavid;
    DavidFound davidFound;
    KnifeAcquired knifeAcquired;
    GotMoney gotMoney;
    public ListOfActions(goapPlanner gBase) //we pass in the planner class and then we add the possible actions which we listed in the possible actions.
    {

        killDavid = new KillDavid(gBase);
        possibleActions.Add(killDavid);

        davidFound = new DavidFound(gBase);
        possibleActions.Add(davidFound);

        knifeAcquired = new KnifeAcquired(gBase);
        possibleActions.Add(knifeAcquired);

        gotMoney = new GotMoney(gBase);
        possibleActions.Add(gotMoney);

    }


}

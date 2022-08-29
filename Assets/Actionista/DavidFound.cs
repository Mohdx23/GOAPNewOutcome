using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DavidFound : Action
{
    public DavidFound(goapPlanner gBase)
    {
        this.aEffect = "David Found";
        this.reqEffect = new string[] { "Got Knife" };

        this.preReqNeeded = gBase.setOfPrereqs.davidFound;
        this.availablePrereqs = new Prerequisite[] { gBase.setOfPrereqs.knifeAcquired };
    }

    protected override IEnumerator Execute(goapPlanner gBase)
    {
        Debug.Log("Finding David");
        yield return null;
    }
}

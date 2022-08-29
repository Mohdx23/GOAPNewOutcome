using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeAcquired : Action
{
    public KnifeAcquired(goapPlanner gBase)
    {
        this.aEffect = "Got Knife";
        this.reqEffect = new string[] { "Got Money" };

        this.preReqNeeded = gBase.setOfPrereqs.knifeAcquired;
        this.availablePrereqs = new Prerequisite[] { gBase.setOfPrereqs.GotMoney };

        
    }

    protected override IEnumerator Execute(goapPlanner gBase)
    {
        Debug.Log("Acquired the knife");
        yield return null;
    }
}

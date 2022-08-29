using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GotMoney : Action
{
    public GotMoney(goapPlanner gBase)
    {
        this.aEffect = "Got Money";
        this.reqEffect = new string[] { "None" };

        this.preReqNeeded = gBase.setOfPrereqs.GotMoney;
        this.availablePrereqs = new Prerequisite[] { gBase.setOfPrereqs.noPreReqs };
    }

    protected override IEnumerator Execute(goapPlanner gBase)
    {
        Debug.Log("Cha Ching!");
        yield return null;
    }
}

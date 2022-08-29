using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillDavid : Action
{
    public KillDavid(goapPlanner gBase)
    {
        this.aEffect = "David Killed";
        this.reqEffect = new string[] { "David Found" };

        this.preReqNeeded = gBase.setOfPrereqs.killDavid;
        this.availablePrereqs = new Prerequisite[] { gBase.setOfPrereqs.davidFound };
    }

    protected override IEnumerator Execute(goapPlanner gBase)
    {
        Debug.Log("Killing David");
        yield return null;
    }
}

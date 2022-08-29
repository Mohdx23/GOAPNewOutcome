using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prerequisite
{
    public bool preReqMatched;
}
public class allPrequisites
{
    public HashSet<Prerequisite> allPrereqs;
    public Prerequisite noPreReqs;

    public Prerequisite killDavid = new Prerequisite();  //this is our final goal.

    public Prerequisite davidFound = new Prerequisite();
    public Prerequisite knifeAcquired = new Prerequisite();
    public Prerequisite GotMoney = new Prerequisite();
  
    public allPrequisites()
    {
        noPreReqs = new Prerequisite();
        noPreReqs.preReqMatched = true;

        allPrereqs = new HashSet<Prerequisite>();
        allPrereqs.Add(noPreReqs);
        allPrereqs.Add(killDavid);
        allPrereqs.Add(davidFound);
        allPrereqs.Add(knifeAcquired);
        allPrereqs.Add(GotMoney);
       
    }

}





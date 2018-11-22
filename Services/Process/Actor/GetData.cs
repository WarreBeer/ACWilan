using System;
using BM = ACWilan.Models.Business;
using BC = ACWilan.BusinessComponents;

namespace ACWilan.Services.Process.Actor
{
    public class GetData
    {
        public BM.Party.Actor RetrieveActorByActorID(Guid actorID)
        {
            BC.IActor actorBC = new BC.Actor();
            BM.Party.Actor actor = actorBC.Detail(actorID);
            return actor;
        }
    }
}

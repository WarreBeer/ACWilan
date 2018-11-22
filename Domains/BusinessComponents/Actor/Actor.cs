using System;
using BM = ACWilan.Models.Business;
namespace ACWilan.BusinessComponents
{
    public class Actor: IActor
    {
        public BM.Party.Actor Detail(Guid actorID)
        {
            return new BM.Party.Actor();
        }
    }
}

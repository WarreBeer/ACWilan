using System;
using BM = ACWilan.Models.Business;
namespace ACWilan.BusinessComponents
{
    public interface IActor
    {
        BM.Party.Actor Detail(Guid actorID);
    }
}

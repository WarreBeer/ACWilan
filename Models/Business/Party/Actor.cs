using System;
namespace ACWilan.Models.Business.Party
{
    public class Actor
    {
        #region Constructors

        public Actor()
        {
        }

        #endregion

        #region Properties


        [Newtonsoft.Json.JsonProperty("Id")]
        public string Id { get; set; }

        [Microsoft.WindowsAzure.MobileServices.Version]
        public string AzureVersion { get; set; }

        public string FullName { get; set; }


        #endregion
    }
}

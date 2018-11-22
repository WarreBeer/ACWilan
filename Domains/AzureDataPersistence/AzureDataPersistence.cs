using System;
using Microsoft.WindowsAzure.MobileServices;

namespace AzureDataPersistence
{
    public class AzureDataPersistence
    {
        public MobileServiceClient MobileService { get; set; }
        IMobileServiceSyncTable coffeeTable;

        public async Task Initialize()
        {
        }

        public async Task<IEnumerable> GetActors()
        {
        }

        public async Task AddActor(string fullName)
        {
        }

        public async Task SyncActor()
        {
        }
    }
}

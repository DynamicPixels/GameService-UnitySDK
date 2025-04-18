using System;
using System.Threading.Tasks;
using DynamicPixels.GameService.Services.Synchronise.Repositories;

namespace DynamicPixels.GameService.Services.Synchronise
{
    public class SynchroniseService : ISynchronise
    {
        private ISynchroniseRepositories _repository;

        public SynchroniseService()
        {
            _repository = new SynchroniseRepository();
        }

        public Task<DateTime> GetServerTime()
        {
            return _repository.GetServerTime();
        }
    }
}
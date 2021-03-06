using System;
using System.Threading.Tasks;
using CrossAggregateValidation.Domain;

namespace CrossAggregateValidation.Tests.Application
{
    internal class UserByEmailIndexStub : IUserByEmailIndex
    {
        private IndexResult _result;

        public Task<IndexResult> AddAsync(string email, Guid userId)
        {
            return Task.FromResult(_result);
        }

        public void SetResult(IndexResult indexResult)
        {
            _result = indexResult;
        }
    }
}
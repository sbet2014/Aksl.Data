using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace Aksl.Data
{
    public class RestRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        #region Members
        private string _apiUri;
        private Func<string> _apiUriFactory;
        #endregion

        #region Constructors
        public RestRepository(string apiUri)
        {
            _apiUri = apiUri ?? throw new ArgumentNullException(nameof(apiUri));
        }

        public RestRepository(Func<string> apiUriFactory)
        {
            _apiUriFactory = apiUriFactory ?? throw new ArgumentNullException(nameof(apiUriFactory));
            _apiUri = _apiUriFactory();
        }
        #endregion

        #region Properties
        public DbSet<TEntity> Entities => throw new NotImplementedException();

        public IQueryable<TEntity> Table => throw new NotImplementedException();

        public IQueryable<TEntity> TableNoTracking => throw new NotImplementedException();

        public Task<IEnumerable<TEntity>> BulkInsertAsync(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Methods
        public Task DeleteAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetByIdAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task InsertAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task InsertAsync(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}

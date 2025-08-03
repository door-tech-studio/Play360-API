using Microsoft.EntityFrameworkCore;
using play_360.EF.Models;

namespace play_360.EF.GenericCrudDBOperations
{
    public class GenericRepository<TDbConext, TEntity> 
        where TEntity : EntityFrameWorkModel 
        where TDbConext : DbContext
    {
        private readonly TDbConext _DBContext;

        public GenericRepository(TDbConext Play360Context) 
        {
            _DBContext = Play360Context;
            _DBContext.Set<TEntity>();
        }
        public async Task<int> AddAndReturnRecordId<TModel>(TEntity entity)
        {
            await _DBContext.AddAsync(entity);
            await _DBContext.SaveChangesAsync();
            return entity.Id;
        }
    }
}

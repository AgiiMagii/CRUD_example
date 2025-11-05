using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace EntityExample.Lib
{
    public class Repository
    {
        private DbContext _dbContext;
        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<TEntity> GetEntities<TEntity>() where TEntity : class
        {
            try
            {
                return _dbContext.Set<TEntity>().ToList();
            }
            catch { throw; }
        }
        public TEntity AddEntity<TEntity>(TEntity entity) where TEntity : class
        {
            try
            {
                var addedEntity = _dbContext.Set<TEntity>().Add(entity);
                _dbContext.SaveChanges();
                return addedEntity;
            }
            catch { throw; }
        }
        public void UpdateEntity<TEntity>(TEntity entity) where TEntity : class
        {
            try
            {
                _dbContext.Entry(entity).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
            catch { throw; }
        }
        public void GetEntityById<TEntity>(int id) where TEntity : class
        {
            try
            {
                _dbContext.Set<TEntity>().Find(id);
            }
            catch { throw; }
        }
        public void DeleteEntity<TEntity>(TEntity entity) where TEntity : class
        {
            try
            {
                _dbContext.Set<TEntity>().Remove(entity);
                _dbContext.SaveChanges();
            }
            catch { throw; }
        }
        public List<T> ExecuteStoredProcedure<T>(string storedProcedureName, params SqlParameter[] parameters) where T : class
        {
            try
            {
                string sqlCommand = storedProcedureName;
                if (parameters != null && parameters.Length > 0)
                {
                    var parameterNames = string.Join(", ", parameters.Select(p => p.ParameterName));
                    sqlCommand = $"{storedProcedureName} {parameterNames}";
                }
                return _dbContext.Database.SqlQuery<T>(sqlCommand, parameters).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error executing stored procedure '{storedProcedureName}': {ex.Message}", ex);
            }
        }
    }
}

using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public interface IGenericRepository
    {
        List<IEntity> GetAllWithCondition(IEntity entity);
        void Save(IEntity entity);
        void Update(IEntity entity);
        void Delete(IEntity entity);
        List<IEntity> GetAll(IEntity e);
        int GetNewId(IEntity e);
        void OpenConnection();
        void CloseConnection();
        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}

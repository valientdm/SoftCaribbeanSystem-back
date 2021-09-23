using Microsoft.Data.SqlClient;
using SoftCaribbeanSystem.Common.Exceptions;
using SoftCaribbeanSystem.Infraestructure.Base.Context;
using SoftCaribbeanSystem.Model.Base.Entity;
using SoftCaribbeanSystem.Model.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftCaribbeanSystem.Infraestructure.Base.Repository
{
    public abstract class Repository<T> : IRepository<T> where T : Entity
    {
        private MyDbContext _myDbContext;


        public Repository(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }
        public void Add(T entity)
        {
            try
            {
                _myDbContext.Add(entity);
                _myDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new EntityException(ex.Message, ex);
            }
        }

        public virtual void Delete(int id)
        {
            try
            {
                var entity = _myDbContext.Set<T>().FirstOrDefault(x => x.Id == id);

                if (entity != null)
                {
                    _myDbContext.Remove(entity);
                    _myDbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new EntityException(ex.Message, ex);
            }   
        }

        public virtual IList<T> FindAll()
        {
            try
            {
                return _myDbContext.Set<T>().ToList();
            }
            catch (Exception ex)
            {
                throw new EntityException(ex.Message, ex);
            }
            
        }

        public virtual T FindById(int id)
        {
            try
            {
                return _myDbContext.Set<T>().FirstOrDefault(x => x.Id == id);
            }
            catch (Exception ex)
            {
                throw new EntityException(ex.Message, ex);
            }
            
        }

        public virtual void Update(T entity)
        {
            try
            {
                _myDbContext.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _myDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new EntityException(ex.Message, ex);
            }
        }

        public virtual T FindBy(Func<T, bool> predicate)
        {
            try
            {
                return _myDbContext.Set<T>().FirstOrDefault(predicate);
            }
            catch (Exception ex)
            {
                throw new EntityException(ex.Message, ex);
            }
            
        }
    }
}
﻿using CORE.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace CORE.DataAccess.EntityFramework
{
   public  class EfEntityRepositoryBase<TEntity,TContext>:IEntityRepository<TEntity>
        where TEntity:class,IEntity,new()
       where TContext:DbContext,new()

    {

        public void Add(TEntity Entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(Entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();



            }
        }

        public void Delete(TEntity Entity)
        {
            using (TContext context = new TContext())
            {
                var DeletedEntity = context.Entry(Entity);
                DeletedEntity.State = EntityState.Deleted;
                context.SaveChanges();



            }


        }

        public TEntity get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);



            }
        }



        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();



            }

        }

        public void Update(TEntity Entity)
        {
            using (TContext context = new TContext())
            {
                var UpdatedEntity = context.Entry(Entity);
                UpdatedEntity.State = EntityState.Modified;
                context.SaveChanges();



            }
        }
    }
}

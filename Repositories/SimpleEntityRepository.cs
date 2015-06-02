using System;
using System.Collections.Generic;
using System.Linq;
using Sitecore.Data;
using Sitecore.EntityServiceBoilerplate.Models;
using Sitecore.Services.Core;

namespace Sitecore.EntityServiceBoilerplate.Repositories
{
    public class SimpleEntityRepository : IRepository<SimpleEntity>
    {
        private static Dictionary<ID, SimpleEntity> _storage;

        static SimpleEntityRepository()
        {
            _storage = new Dictionary<ID, SimpleEntity>();
            var newId = NewId();
            _storage.Add(newId, new SimpleEntity()
            {
                Description = "Some description la-la-la",
                Id = newId.ToString(),
                SomeInt = 228,
                Title = "Title title",
            });

            newId = NewId();
            _storage.Add(newId, new SimpleEntity()
            {
                Description = "Another description la-la-la",
                Id = newId.ToString(),
                SomeInt = 88,
                Title = "2 Title 2 title 2 ",
            });
        }

        protected static ID ParseId(string id)
        {
            var sID = ID.Null;

            ID.TryParse(id, out sID);

            return sID;
        }

        protected static ID NewId()
        {
            return ID.NewID;
        }

        SimpleEntity IRepository<SimpleEntity>.FindById(string id)
        {
            var qId = ParseId(id);

            if (_storage.ContainsKey(qId))
                return _storage[qId];

            return null;
        }

        public void Add(SimpleEntity entity)
        {
            var newid = NewId();
            entity.Id = newid.ToString();
            _storage.Add(newid, entity);
        }

        public bool Exists(SimpleEntity entity)
        {
            var id = ParseId(entity.Id);
            return _storage.ContainsKey(id);
        }

        public void Update(SimpleEntity entity)
        {
            var id = ParseId(entity.Id);
            
            if (_storage.ContainsKey(id))
            {
                _storage[id] = entity;
                return;
            }

            _storage.Add(id, entity);
        }

        public void Delete(SimpleEntity entity)
        {
            var id = ParseId(entity.Id);
            
            if (_storage.ContainsKey(id))
            {
                _storage.Remove(id);
            }

        }

        IQueryable<SimpleEntity> IRepository<SimpleEntity>.GetAll()
        {
            return _storage.Values.AsQueryable();
        }

       
    }
}
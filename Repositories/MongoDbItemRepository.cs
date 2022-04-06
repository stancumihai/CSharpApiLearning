using System;
using System.Collections.Generic;
using Application.Entities;

namespace Application.Repositories
{
    public class MongoDbItemRepository : IItemsRepository
    {

        public MongoDbItemRepository(){
            
        }

        public void CreateItem(Item item)
        {
            throw new NotImplementedException();
        }

        public void DeleteItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public Item GetItemById(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> GetItems()
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
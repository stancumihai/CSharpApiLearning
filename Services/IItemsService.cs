using System;
using System.Collections.Generic;
using Application.Entities;

namespace Application.Services
{
     public interface IItemsService
    {
        void CreateItem(Item item);
        void DeleteItem(Guid id);
        Item GetItemById(Guid id);
        IEnumerable<Item> GetItems();
        void UpdateItem(Item item);
    }
}
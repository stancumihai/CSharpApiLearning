using System;
using System.Collections.Generic;
using Application.Entities;

namespace Application.Services
{
   

    public class ItemsService : IItemsService
    {
        private IItemsRepository itemsRepository;

        public ItemsService(IItemsRepository itemsRepository)
        {
            this.itemsRepository = itemsRepository;
        }

        public Item GetItemById(Guid id)
        {
            return itemsRepository.GetItemById(id);
        }
        public IEnumerable<Item> GetItems()
        {
            return itemsRepository.GetItems();
        }
        public void CreateItem(Item item)
        {
            itemsRepository.CreateItem(item);
        }

        public void UpdateItem(Item item)
        {
            itemsRepository.UpdateItem(item);
        }

        public void DeleteItem(Guid id)
        {
            itemsRepository.DeleteItem(id);
        }
    }
}
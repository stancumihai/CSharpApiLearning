using System;
using System.Collections.Generic;
using Application.Entities;

public interface IItemsRepository
{
    Item GetItemById(Guid id);
    IEnumerable<Item> GetItems();
    void CreateItem(Item item);

    void UpdateItem(Item item);

    void DeleteItem(Guid id);
}
using System;
using System.Collections.Generic;
using Application.Entities;
using Application.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Application.Dtos;
using Application.Services;

namespace Application.Controllers
{
    [ApiController]
    [Route("items")]
    // [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly IItemsService itemsService;

        public ItemController(IItemsService itemsService){
            this.itemsService = itemsService;
        }

        [HttpGet]
        public IEnumerable<ItemDto> GetItems(){
            var items = itemsService.GetItems().Select( item => Extensions.AsDto(item));
            return items;
        }

        [HttpGet("{id}")]
        // Action result lets me return multiple types
        public ActionResult<ItemDto> GetItem(Guid id){
            var item  = itemsService.GetItemById(id);
            if(item == null){
                return NotFound();
            }
            return item.AsDto();
        }
        [HttpPost]
        public ActionResult<ItemCreateDto> CreateItem(ItemCreateDto itemDto){
            Item item = new(){
                Id = Guid.NewGuid(),
                Name = itemDto.Name,
                Price = itemDto.Price,
                CreatedDate = DateTimeOffset.UtcNow
            };

            itemsService.CreateItem(item);
            return CreatedAtAction(nameof(GetItem) , new {id = item.Id} , item.AsDto());    
        }

        [HttpPut("{id}")]
        public ActionResult UpdateItem(Guid id , ItemUpdateDto itemDto){
            var existingItem = itemsService.GetItemById(id);
            if(existingItem == null){
                return NotFound();
            }
            Item updatedItem = existingItem with {
                Name = itemDto.Name,
                Price = itemDto.Price
            };
            itemsService.UpdateItem(updatedItem);
            return NoContent();
        }

        [HttpDelete ("{id}")]
        public ActionResult DeleteItem(Guid id){
            var existingItem = itemsService.GetItemById(id);
            if(existingItem == null){
                return NotFound();
            }
            itemsService.DeleteItem(id);
            return NoContent();
        }
    }
}
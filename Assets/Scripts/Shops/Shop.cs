using GameDevTV.Inventories;
using RPG.Control;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Shops
{
    public class Shop : MonoBehaviour, IRaycastable
    {
        public class ShopItem
        {
            InventoryItem item;
            int availability;
            float price;
            int quantityInTransaction;
        }

        public event Action onChange;

        public IEnumerable<ShopItem> GetFilteredItems() { return null; }
        public void SelectFilter(ItemCategory category) {}
        public ItemCategory GetFilter() { return ItemCategory.None; }
        public void SelectMode(bool isBuying) {}
        public bool IsBuyingMode() { return true; }
        public bool CanTransact() { return true; }
        public void ConfirmTransaction() {}
        public float TransactionTotal() { return 0; }
        public void AddToTransaction(InventoryItem item, int quantity) {}

        public CursorType GetCursorType()
        {
            return CursorType.Shop;
        }

        public bool HandleRaycast(PlayerController callingController)
        {
            if(Input.GetMouseButtonDown(0))
            {
                callingController.GetComponent<Shopper>().SetActiveShop(this);
            }
            return true;
        }
    }
}


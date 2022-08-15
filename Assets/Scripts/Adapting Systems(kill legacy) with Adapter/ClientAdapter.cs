using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Adapter
{
    public class ClientAdapter : MonoBehaviour
    {
        private InventorySystem _inventorySystem;
        private IInventory _inventorySystemAdapter;

        public InventoryItem item;

        void Start()
        {
            _inventorySystem = new InventorySystem();
            _inventorySystemAdapter = new InventorySystemAdapter();
        }

        void OnGUI()
        {
            //Собственно весь смак адаптера
            if (GUILayout.Button("Add item (no adapter)"))
                _inventorySystem.AddItem(item);

            if (GUILayout.Button("Add item (with adapter)"))
                _inventorySystemAdapter.
                    AddItem(item, SaveLocation.Both);
        }
    }
}
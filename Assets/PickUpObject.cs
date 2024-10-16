using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class PickUpObject : MonoBehaviour
{
    InventoryManager inventoryManager;
    //public GameObject veggie;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseDown()
    {
        Destroy(gameObject);
     
    }

    private void OnDisable()
    {
        AddInventory();
    }

    public void AddInventory()
    {
        InventoryManager.instance.items.Add(gameObject);
    }

    public void RemoveInventory()
    {
        InventoryManager.instance.items.Remove(gameObject);
    }
       
    
}

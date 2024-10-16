using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public List <GameObject> items = new List <GameObject> ();
    public static InventoryManager instance;
    PickUpObject pick;



    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this; 
        }
    }
        
        
        
        
        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse1))
        {
            foreach(GameObject item in items)
            {
                item.SetActive(false);
            }
        }

        if (items.Count > 0)
        {
            int rand = Random.Range(0, items.Count);
            items[rand].SetActive(true);
            items[rand].GetComponent<PickUpObject>();
            pick.RemoveInventory();
        }
    }
}

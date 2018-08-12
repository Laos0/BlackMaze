using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour {

    public Inventory inventory;
    

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "light")
        {
            LightType lightType = col.gameObject.GetComponent<Item>().lightType;

            if (inventory.add(lightType))
            {
                Destroy(col.gameObject);
            }

            //Debug.Log("hit");
          
        }
    }

    
}

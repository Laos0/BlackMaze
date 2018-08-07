using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowItem : MonoBehaviour {

    public Inventory inventory;
   

    public int counter;

    private void Start()
    {
        counter = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            GameObject lightGO = inventory.removeActiveLight();
            if(lightGO != null)
            {
                lightGO.GetComponent<Rigidbody>().AddForce(transform.forward * 100);
            }
        }
    }


}

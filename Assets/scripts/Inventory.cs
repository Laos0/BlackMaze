using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

// public Image[] imageArray;
// List<LightType> lights;
public LightType[] lights;
public GameObject candle;
public GameObject torch;
public GameObject lantern;
public GameObject lightCon;


public int activeIndex;
public int slotCounter;

void Start()
{
    slotCounter = 0;
    activeIndex = 0;
    //lights = new List<LightType>();

}

public bool add(LightType lightType)
{
    //lights.Add(lightType);
       
    if(slotCounter < lights.Length)
    {
        lights[slotCounter] = lightType;
        slotCounter++;
        return true;
    }
    else if(slotCounter <= lights.Length)
    {
        //****** check this one later for the array*****
        slotCounter = 0;

        // ither == null or lightType.NONE
            

        do
        {
            if (lights[slotCounter] != null)
            {
                slotCounter++;

                if(lights[slotCounter] == null)
                {
                    lights[slotCounter] = lightType;
                }
            }
        } while (slotCounter <= lights.Length);

            return true;
    }
  
    return false;
}

public GameObject removeActiveLight()
{
//inven[activeIndex];
LightType light = lights[activeIndex];
lights[activeIndex] = LightType.NONE;
GameObject lightGO = null;


        // NEED TO FIX ALL INSTANTIATES
        
    if (light == LightType.CANDLE)
    {
        lights[activeIndex] = LightType.CANDLE;
        lightGO = Instantiate(candle,transform.position, Quaternion.Euler(0,0,0)) as GameObject;
        lightGO.GetComponent<Rigidbody>().AddForce(transform.forward);
        

        if (activeIndex <= lights.Length)
        {
            lights[activeIndex] = LightType.NONE;
            activeIndex++;
        }

    }
    else if (light == LightType.LANTERN)
    {
        lights[activeIndex] = LightType.LANTERN;
        lightGO = Instantiate(lantern, transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        lightGO.GetComponent<Rigidbody>().AddForce(transform.forward);

            if (activeIndex <= lights.Length)
        {
            lights[activeIndex] = LightType.NONE;
            activeIndex++;
        }

}
    else if (light == LightType.TORCH)
    {
        lights[activeIndex] = LightType.TORCH;
        lightGO = Instantiate(torch, transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        lightGO.GetComponent<Rigidbody>().AddForce(transform.forward);

            if (activeIndex <= lights.Length)
        {
            lights[activeIndex] = LightType.NONE;
            activeIndex++;
        }

}

    if (lightGO != null)
    {
        lightGO.transform.SetParent(lightCon.transform);
    }

      

        

return lightGO;
        

}







}

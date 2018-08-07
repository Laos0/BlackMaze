using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

    // public Image[] imageArray;
   // List<LightType> lights;
    public LightType[] lights;
    

    public int activeIndex;
    public int slotCounter;

    void Start()
    {
        slotCounter = 0;
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
        else if(slotCounter >= lights.Length)
        {

        }
  
        return false;
    }

    public void removeActiveLight()
    {
        //inven[activeIndex];
    }







}

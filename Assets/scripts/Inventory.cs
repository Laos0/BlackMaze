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

    public GameObject removeActiveLight()
    {
        //inven[activeIndex];
       LightType light = lights[activeIndex];
        lights[activeIndex] = LightType.NONE;
        GameObject lightGO = null;

        if (light == LightType.CANDLE)
        {
            lightGO = Instantiate(candle);
                
        }
        else if (light == LightType.LANTERN)
        {
            lightGO = Instantiate(lantern, transform);
                
        }
        else if (light == LightType.TORCH)
        {
            lightGO = Instantiate(torch, transform);
                
        }

        if(lightGO != null)
        {
            lightGO.transform.SetParent(lightCon.transform);
        }

        return lightGO;
        

    }







}

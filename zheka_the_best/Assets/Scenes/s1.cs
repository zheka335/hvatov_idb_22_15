using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script : MonoBehaviour
{
   public GameObject Testobj;

   public void ChangeActive()
   {
        
        if(Testobj.activeSelf)
        {
            Testobj.SetActive(false);
        }
        else
        {
            Testobj.SetActive(true);
        }
   }
 
}

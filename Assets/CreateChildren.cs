using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateChildren : MonoBehaviour
{
   public GameObject childPrefab;


   private IEnumerator Start()
   {
      for(int i = 0; i < 200; i++)
      {
         GameObject child = Instantiate(childPrefab, transform);
         //delay 
         yield return new WaitForSeconds(0.01f);
         child.transform.position = new Vector3(0, 0, 0);
      }
   }
}

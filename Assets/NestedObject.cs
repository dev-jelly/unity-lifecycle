using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NestedObject : MonoBehaviour
{
  public void Awake()
  {
    Debug.Log("Awake : " + gameObject.name);
  }
  
  public IEnumerator Start()
  {
    
    Debug.Log("Start : " + gameObject.name);
    yield return new WaitForSeconds(5);
    gameObject.name = "WOW That is a New Names";
  }

  public void OnEnable()
  {
    Debug.Log("OnEnable : " + gameObject.name);
  }


  // public void Update()
  // {
  //   Debug.Log("Update : " + gameObject.name);
  // }

  public void OnDisable()
  {
    Debug.Log("OnDisable : " + gameObject.name);
  }
  
  public void OnDestroy()
  {
    Debug.Log("OnDestroy : " + gameObject.name);
  }
  
  public void OnApplicationQuit()
  {
    Debug.Log("OnApplicationQuit : " + gameObject.name);
  }
  
  
}

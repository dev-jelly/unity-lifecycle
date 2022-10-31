using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectB : MonoBehaviour
{
    
    public String title = "Object B";

    private ObjectA objectA;

    void Awake()
    {
            objectA = GameObject.FindWithTag("ObjectA").GetComponent<ObjectA>();
            // Debug.Log(objectA.objectB.objectA.title);
    }
    
    // Start is called before the first frame update
    // IEnumerator Start()
    // {
    //     yield return new WaitForSeconds(5);
    //     Debug.Log("5초가 지났다..");
    //     
    //     // Do something after 5 seconds
    // }

    // Update is called once per frame
    void Update()
    {
        
    }
}

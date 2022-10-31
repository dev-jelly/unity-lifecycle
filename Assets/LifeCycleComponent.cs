using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycleComponent : MonoBehaviour
{
    private ulong allUpdate = 0;
    private ulong update = 0;
    private ulong fixedUpdate = 0;
    private ulong lateUpdate = 0;
    
    
    private void Awake()
    {
        Debug.Log("Awake");
    }
    
    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }
    
    private void Reset()
    {
        Debug.Log("Reset");
    }

    
    private void Start()
    {
        Debug.Log("Start");
    }

    //
    // private void FixedUpdate()
    // {
    //     Debug.Log($"AllUpdate: {allUpdate++} FixedUpdate: {fixedUpdate++}");
    // }
    //
    // private void Update()
    // {
    //     Debug.Log("AllUpdate: " + allUpdate++ + " Update: " + update++);
    // }
    //
    // private void LateUpdate()
    // {
    //     Debug.Log("AllUpdate: " + allUpdate++ + " LateUpdate: " + lateUpdate++);
    // }
    
    
    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }
    
    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }
    
    private void OnApplicationQuit()
    {
        Debug.Log("OnApplicationQuit");
    }
    
    private void OnApplicationPause(bool pause)
    {
        Debug.Log("OnApplicationPause" + pause);
    }
    
    private void OnApplicationFocus(bool focus)
    {
        Debug.Log("OnApplicationFocus" + focus);
    }
    
}

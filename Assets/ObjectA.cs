
using System;
using UnityEngine;

public class ObjectA : MonoBehaviour
{
   public ObjectB objectB;
   
   public string title = "Object A";

   private void Awake()
   {
      objectB = GameObject.FindWithTag("ObjectB").gameObject.GetComponent<ObjectB>();
      
      Debug.Log(objectB.title);
   }
   
   // Start is called before the first frame update
   // void Start()
   // {
   //      
   // }
   //
   // // Update is called once per frame
   // void Update()
   // {
   //      
   // }
   private void OnDisable()
   {
      //
   }
}

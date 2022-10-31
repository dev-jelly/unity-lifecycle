using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class JellyBall : MonoBehaviour
{
    public void Update()
    {
        
        GetComponentInParent<TMP_Text>().text = "Jelly's ball";
    }
}

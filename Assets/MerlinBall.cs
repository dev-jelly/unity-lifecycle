using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MerlinBall : MonoBehaviour
{

    public void Update()
    {
        GetComponentInParent<TMP_Text>().text = "Merlin's ball";
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Ajura : MonoBehaviour
{
 

    // Update is called once per frame
    void Update()
    {
        GetComponentInParent<TMP_Text>().text = "Ajura";

    }
}

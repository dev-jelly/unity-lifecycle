using UnityEngine;

public class DisabledComponent : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Disabled Component Awake"); 
    }
    
    private void Start()
    {
        Debug.Log("Disabled Component Start"); 
    }

    private void OnEnable()
    {
        Debug.Log("Disabled Component OnEnable");
    }

    private void OnDisable()
    {
        Debug.Log("Disabled Component OnDisable"); 
    }
    
}

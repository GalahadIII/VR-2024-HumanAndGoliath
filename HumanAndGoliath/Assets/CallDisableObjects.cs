using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallDisableObjects : MonoBehaviour
{

    [SerializeField]
    private List<GameObject> toDisable = new List<GameObject>();

    public void Disable(){
        foreach (GameObject gameObject in toDisable)
        {
            gameObject.SetActive(false);
        }
    }

    public void Enable(){
        foreach (GameObject gameObject in toDisable)
        {
            gameObject.SetActive(false);
        }
    }

    public void Toggle(){
        foreach (GameObject gameObject in toDisable)
        {
            gameObject.SetActive(!gameObject.activeSelf);
        }
    }

}

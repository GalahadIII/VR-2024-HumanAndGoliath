using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OrbInteract : MonoBehaviour, IInteractable
{
    [SerializeField]
    private int sceneId = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Interact()
    {
        SceneManager.LoadScene(sceneId);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plank3 : MonoBehaviour, IInteractible
{
    [SerializeField] public GameObject plank;
    [SerializeField] public bool plankTaken = false;
    [SerializeField] private string _prompt;
    public string InteractionPrompt => _prompt;
    public bool Interact(Interactor interactor)
    {
        Debug.Log("Got the Plank3");
        plankTaken = true;
        plank.SetActive(false);
        return true;
    }
}

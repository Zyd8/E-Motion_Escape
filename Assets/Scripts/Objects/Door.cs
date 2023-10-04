using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour, IInteractible
{
    [SerializeField] public GameObject door;

    [SerializeField] public bool isOpened = false;
    [SerializeField] private string _prompt;
    public string InteractionPrompt => _prompt;

    public bool Interact(Interactor interactor)
    {
        string currentSceneName = SceneManager.GetActiveScene().name;

        if (currentSceneName == "MainScene")
        {
            Debug.Log("Opening Door for MainScene");
            StartCoroutine(OpenDoor());
        }
        else if (currentSceneName == "IceRoomScene")
        {
            Debug.Log("Opening Door for IceRoomScene");
            StartCoroutine(OpenDoorIceRoom());
        }
        else
        {
            Debug.LogWarning("Scene not recognized for door interaction.");
        }

        return true;
    }

    IEnumerator OpenDoor()
    {
        isOpened = true;
        door.GetComponent<Animator>().Play("DoorOpen");
        yield return new WaitForSeconds(5.0f);
    }

    IEnumerator OpenDoorIceRoom()
    {
        isOpened = true;
        door.GetComponent<Animator>().Play("DoorIceRoomOpen");
        yield return new WaitForSeconds(5.0f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatBuilder : MonoBehaviour
{
    [SerializeField] public Plank plank;
    [SerializeField] public Paddle paddle;

    [SerializeField] public BoatVisibility boatVisible;
    void Update()
    {
        if (plank.plankTaken == true && paddle.paddleTaken == true)
        {
            boatVisible.isVisible = true;
        }
    }
}

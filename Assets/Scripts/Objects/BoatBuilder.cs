using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatBuilder : MonoBehaviour
{
    [SerializeField] public Plank plank;
    [SerializeField] public Plank2 plank2;
    [SerializeField] public Plank3 plank3;
    [SerializeField] public Paddle paddle;

    [SerializeField] public BoatVisibility boatVisible;
    void Update()
    {
        if (plank.plankTaken == true &&
            plank2.plankTaken == true && 
            plank3.plankTaken == true &&
            paddle.paddleTaken == true)
        {
            boatVisible.isVisible = true;
        }
    }
}

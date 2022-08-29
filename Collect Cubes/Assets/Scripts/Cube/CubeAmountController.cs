using System.Collections.Generic;
using UnityEngine;


public class CubeAmountController : MonoBehaviour
{

    public List<GameObject> cubeList = new List<GameObject>();
    [SerializeField] private UIController uiController;



    public void SetCubeAmount()
    {
        if (cubeList.Count <= 0)
        {
            uiController.SetNextLevel();
        }
    }
}

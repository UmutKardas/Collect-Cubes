using UnityEngine;

public class UIController : MonoBehaviour
{

    [SerializeField] private GameObject soGood;
    [SerializeField] private GameObject nextLevelButton;



    public void SetNextLevel()
    {
        soGood.SetActive(true);
        nextLevelButton.SetActive(true);
    }
}

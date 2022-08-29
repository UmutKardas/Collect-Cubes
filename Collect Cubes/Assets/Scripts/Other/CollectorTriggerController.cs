using UnityEngine;
using Kardas;

public class CollectorTriggerController : MonoBehaviour
{

    [SerializeField] private CubeAmountController cubeAmountController;



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(TAG.CUBE))
        {
            other.gameObject.AddComponent<CubeMovementController>();
            other.gameObject.AddComponent<CubeMaterialController>();
            other.gameObject.tag = TAG.CHILDCUBE;
            cubeAmountController.cubeList.Remove(other.gameObject);
            cubeAmountController.SetCubeAmount();
        }
    }
}

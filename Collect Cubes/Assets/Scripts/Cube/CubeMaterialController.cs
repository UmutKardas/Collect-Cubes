using UnityEngine;

public class CubeMaterialController : MonoBehaviour
{

    private Material cubeMaterial;



    void Start()
    {
        SetCubeMaterial();
    }



    private void SetCubeMaterial()
    {
        cubeMaterial = GetComponent<MeshRenderer>().material;
        cubeMaterial.color = Color.yellow;
    }
}

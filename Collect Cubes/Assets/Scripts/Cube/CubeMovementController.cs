using UnityEngine;
using Kardas;

public class CubeMovementController : MonoBehaviour
{

    private Rigidbody childcubeRigidbody;
    private GameObject collectorGameobject;
    private float movementSpeed = 30f;



    private void Start()
    {
        SetFindGameObject();
        SetFreezeRotation();
    }



    private void SetFindGameObject()
    {
        collectorGameobject = GameObject.FindGameObjectWithTag(TAG.COLLECTOR);
        childcubeRigidbody = this.gameObject.GetComponent<Rigidbody>();
    }



    private void SetFreezeRotation()
    {
        childcubeRigidbody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
    }



    private void FixedUpdate()
    {
        SetCubeMovement();
    }



    private void SetCubeMovement()
    {
        childcubeRigidbody.velocity = collectorGameobject.transform.position * movementSpeed * Time.fixedDeltaTime;
    }



    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag(TAG.WALL) || other.gameObject.CompareTag(TAG.AREA))
        {
            movementSpeed = 0;
        }
    }
}

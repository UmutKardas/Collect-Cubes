using UnityEngine;

public class PickerMovementController : MonoBehaviour
{

    [SerializeField] private PickerInputController pickerInputController;
    [SerializeField] private Rigidbody pickerRigidbody;
    [SerializeField] private float pickerMovementSpeed;



    void FixedUpdate()
    {
        SetPickerMovement();
    }



    private void SetPickerMovement()
    {
        pickerRigidbody.velocity = new Vector3(pickerInputController.pickerVector.x * pickerMovementSpeed * Time.fixedDeltaTime,
        pickerRigidbody.velocity.y,
        pickerInputController.pickerVector.z * pickerMovementSpeed * Time.fixedDeltaTime);
    }
}

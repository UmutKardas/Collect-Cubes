using UnityEngine;

public class PickerInputController : MonoBehaviour
{

    [HideInInspector] public Vector3 pickerVector;



    void Update()
    {
        SetPickerVector();
    }



    private void SetPickerVector()
    {
        pickerVector.x = Input.GetAxisRaw("Horizontal");
        pickerVector.z = Input.GetAxisRaw("Vertical");
    }
}

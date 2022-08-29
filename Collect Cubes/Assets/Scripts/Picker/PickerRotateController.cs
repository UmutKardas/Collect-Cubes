using UnityEngine;

public class PickerRotateController : MonoBehaviour
{

    [SerializeField] private PickerInputController pickerInputController;
    [SerializeField] private float lerpValue;



    void Update()
    {
        SetHeroRotate();
    }



    public void SetHeroRotate()
    {
        if (pickerInputController.pickerVector.x > 0f)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(90, -90f, 0), lerpValue * Time.deltaTime);
        }

        else if (pickerInputController.pickerVector.x < 0f)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(90, 90f, 0), lerpValue * Time.deltaTime);
        }

        else if (pickerInputController.pickerVector.z > 0f)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(90, -180, 0), lerpValue * Time.deltaTime);
        }

        else if (pickerInputController.pickerVector.x > 0f && pickerInputController.pickerVector.z > 0f)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 35f, 0), lerpValue * Time.deltaTime);
        }

        else if (pickerInputController.pickerVector.z < 0f)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(90, 0f, 0), lerpValue * Time.deltaTime);
        }

    }
}
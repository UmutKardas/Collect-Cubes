using System.Collections.Generic;
using UnityEngine;
using Kardas;

public class PickerCollisionController : MonoBehaviour
{

    public List<BoxCollider> pickerBox = new List<BoxCollider>();



    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag(TAG.CHILDCUBE))
        {
            foreach (var box in pickerBox)
            {
                box.isTrigger = true;
            }
        }
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(TAG.CUBE) || other.gameObject.CompareTag(TAG.AREA))
        {
            foreach (var box in pickerBox)
            {
                box.isTrigger = false;
            }
        }
    }
}
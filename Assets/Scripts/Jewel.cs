using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jewel : MonoBehaviour
{
    [SerializeField]
    GameObject jewel_position, jewel_model;

    public void remove_jewel()
    {
        if (jewel_position.transform.childCount == 1)
        {
            Destroy(jewel_position.transform.GetChild(0).gameObject);
        }
    }

    public void place_jewel()
    {
        remove_jewel();
        Instantiate(jewel_model, jewel_position.transform.position, jewel_position.transform.rotation, jewel_position.transform);
    }
}

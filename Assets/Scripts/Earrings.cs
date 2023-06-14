using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earrings : Jewel
{
    [SerializeField]
    GameObject jewel_position_2;

    public void remove_earrings()
    {
        remove_jewel();
        if (jewel_position_2.transform.childCount == 1)
        {
            Destroy(jewel_position_2.transform.GetChild(0).gameObject);
        }
    }

    public void place_earrings()
    {
        remove_earrings();
        place_jewel();
        Instantiate(jewel_model, jewel_position_2.transform.position, jewel_position_2.transform.rotation, jewel_position_2.transform);
    }
}

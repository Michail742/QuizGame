using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instatiate : MonoBehaviour
{
    public Transform prefab;
    GameObject playable;
    
    void Start()
    {
        Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.identity);
        playable.SetActive(true);
    }

    
}

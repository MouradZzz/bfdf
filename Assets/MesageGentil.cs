using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MesageGentil : MonoBehaviour
{
    public GameObject r;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(r, Vector3.one, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

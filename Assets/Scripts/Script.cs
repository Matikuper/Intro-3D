using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public GameObject cubePrefab;

    // Start is called before the first frame update
    void Start()
    {
        clonarCubo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clonarCubo()
    {
        Instantiate(cubePrefab);
    }
}

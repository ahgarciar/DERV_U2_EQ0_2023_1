using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    //Mirar a = look at
    [SerializeField] Transform obj_a_Mirar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform se refiere al componente Transform del objeto que tiene al script
        transform.LookAt(obj_a_Mirar);
    }
}

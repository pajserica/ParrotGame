using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    Transform trs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(trs)
            Debug.Log(trs.position);
        
    }

    public void Move(Transform _transform){
        trs = _transform;
    }
}

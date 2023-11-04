using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingAbility : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float abilitySpeed;
    [SerializeField] float destroyAfter;

    // Start is called before the first frame update
    void Start()
    {
        if(!(rb = gameObject.GetComponent<Rigidbody>())){
            Debug.Log("add Rigidbody to" + this);
            return;
        }
        
        rb.velocity = Vector3.forward * abilitySpeed;
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("DestroySelf", destroyAfter);
    }

    public void OnTriggerEnter(Collider coll){
        if(coll.tag != "Enemy")
            DestroySelf();
    }

    private void DestroySelf(){
        Destroy(this.gameObject);
    }
}

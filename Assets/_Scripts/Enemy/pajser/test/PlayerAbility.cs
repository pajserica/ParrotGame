using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAbility : MonoBehaviour
{
    [SerializeField] float damage = 10;
    void OnTriggerEnter(Collider coll){
        var dmgThis = coll.GetComponent<IDamagable>();
        if(dmgThis != null){
        // Debug.Log(dmgThis);
            dmgThis.TakeDamage(damage, this.transform);
        }
   }
}

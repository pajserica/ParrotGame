using UnityEngine;

public class TriggerEnemy : MonoBehaviour
{
    EnemyController ctrlScript;

    private void Awake()
    {
        ctrlScript = transform.parent.GetComponent<EnemyController>();
        print(ctrlScript.gameObject.name);
    }

    void OnTriggerEnter(Collider coll)
    {
        ctrlScript.GetInfo(coll.transform);
    }
}

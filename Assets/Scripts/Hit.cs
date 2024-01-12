using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class Hit : MonoBehaviour
{
    [SerializeField] private GameObject counter;
    [SerializeField] private GameObject v;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Target")
        {
            ContactPoint contact = collision.contacts[0];
            Quaternion rotation = Quaternion.FromToRotation(Vector3.up, contact.normal);
            Vector3 position = contact.point;
            Instantiate(v, position, rotation);
            counter.GetComponent<pointCounter>().AddPoints();
            Destroy(gameObject, 0.3f);
        }
    }
}

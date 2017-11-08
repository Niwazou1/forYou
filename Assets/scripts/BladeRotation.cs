using UnityEngine;
using System.Collections;

public class BladeRotation : MonoBehaviour {

    public float speed = 100.0f;
    void Update ()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }
}
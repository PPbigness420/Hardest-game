
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target;  
    void Update()
    {
        transform.position = target.position - transform.forward * 5;
    }
}

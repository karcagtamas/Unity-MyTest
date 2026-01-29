using UnityEngine;

public class RayCasting : MonoBehaviour
{
    public static float distanceFromTarget;

    [SerializeField] float toTarget;

    void Update()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out RaycastHit hit))
        {
            toTarget = hit.distance;
            distanceFromTarget = hit.distance;
        }
    }
}

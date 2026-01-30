using System.Collections;
using UnityEngine;

public class PathFollow : MonoBehaviour
{
    [SerializeField] int xPos = -1;
    [SerializeField] int zPos = -20;
    [SerializeField] GameObject destination;
    [SerializeField] int position = 1;
    [SerializeField] bool resetMove;

    void Start()
    {
        destination.transform.position = new Vector3(xPos, 2, zPos);
        position += 1;
        StartCoroutine(NextDestination());
    }

    void Update()
    {
        transform.LookAt(destination.transform);
        transform.position = Vector3.MoveTowards(transform.position, destination.transform.position, 0.05f);

        if (!resetMove)
        {
            resetMove = true;
            StartCoroutine(NextDestination());
        }
    }

    IEnumerator NextDestination()
    {
        if (position == 1)
        {
            yield return new WaitForSeconds(3);
            xPos = -1;
            zPos = -20;
            destination.transform.position = new Vector3(xPos, 2, zPos);
            position += 1;
            resetMove = true;
        }

        if (position == 2)
        {
            yield return new WaitForSeconds(3);
            xPos = 6;
            zPos = -18;
            destination.transform.position = new Vector3(xPos, 2, zPos);
            position += 1;
            resetMove = true;
        }

        if (position == 3)
        {
            yield return new WaitForSeconds(3);
            xPos = 7;
            zPos = -26;
            destination.transform.position = new Vector3(xPos, 2, zPos);
            position = 1;
            resetMove = false;
        }
    }
}

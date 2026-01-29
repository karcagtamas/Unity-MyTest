using UnityEngine;

public class OpenChest : MonoBehaviour
{
    [SerializeField] float internalDistance = float.MaxValue;
    [SerializeField] bool chestOpen;
    [SerializeField] GameObject chest;

    void Update()
    {
        internalDistance = RayCasting.distanceFromTarget;

        if (!chestOpen && internalDistance < 2f)
        {
            if (Input.GetKeyDown(KeyCode.O))
            {
                chestOpen = true;
                chest.GetComponent<Animator>().Play("TopSwing");
            }
        }
    }
}

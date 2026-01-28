using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] int myNumber;
    [SerializeField] string myName;
    [SerializeField] bool myChoice;

    int myOtherNumber;

    [SerializeField] GameObject myGate;

    void Start()
    {
        myNumber = 7;
        myChoice = true;
    }

    void Update()
    {
        if (myNumber == 7 && myChoice)
        {
            myName = "Tamas";
            myGate.SetActive(true);
        }
        else
        {
            myName = "Bela";
            myGate.SetActive(false);
        }
    }
}

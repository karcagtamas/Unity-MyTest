using System.Collections;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] int myNumber;
    [SerializeField] string myName;
    [SerializeField] bool myChoice;

    int myOtherNumber;

    [SerializeField] GameObject myGate;

    [SerializeField] GameObject name1;
    [SerializeField] GameObject name2;
    [SerializeField] GameObject gateButton;
    [SerializeField] GameObject hiddenSphere;

    [SerializeField] GameObject fadeIn;
    [SerializeField] GameObject fadeOut;

    void Start()
    {
        myNumber = 7;
        myChoice = true;

        StartCoroutine(MySequence());
    }

    void Update()
    {
        if (myNumber == 7 && myChoice)
        {
            myName = "Tamas";
            //myGate.SetActive(true);

            name1.GetComponent<TMPro.TMP_Text>().text = $"My Number: {myNumber} My Name: {myName}";
            name2.GetComponent<TMPro.TMP_Text>().text = "_____________";
        }
        else
        {
            myName = "Bela";
            //myGate.SetActive(false);

            name1.GetComponent<TMPro.TMP_Text>().text = "Tamas is inactive";
            name2.GetComponent<TMPro.TMP_Text>().text = "Bela is active";
        }

        if (myNumber == 0)
        {
            name1.GetComponent<TMPro.TMP_Text>().text = "";
            name2.GetComponent<TMPro.TMP_Text>().text = "";
        }
    }

    public void OpenGate()
    {
        myGate.GetComponent<Animator>().Play("GateSwing");
    }

    public void HideGateButton()
    {
        gateButton.SetActive(false);
    }

    IEnumerator MySequence()
    {
        yield return new WaitForSeconds(0.5f);
        fadeIn.SetActive(false);
        myGate.GetComponent<Animator>().Play("GateSwing");
        yield return new WaitForSeconds(4);
        gateButton.SetActive(false);
        yield return new WaitForSeconds(2);
        hiddenSphere.SetActive(true);
        yield return new WaitForSeconds(2);
        fadeOut.SetActive(true);
    }
}

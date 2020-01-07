using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class interactionScript : MonoBehaviour
{
    public Text NameOut;
    public Text CountOut;
    public Button Namebtn;
    public Button Countbtn;
    public InputField NameIn;
    public int CountNumber = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetName()
    {
        NameOut.text = NameIn.text;

    }

    public void CountUp()
    {
        CountNumber++;
        CountOut.text = CountNumber.ToString();
    }

}

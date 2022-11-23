using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HelloWorld : MonoBehaviour
{
    public TextMeshProUGUI text;
    public Button m_YourFirstButton;
    public TMP_InputField input;
    // Start is called before the first frame update
    void Start()
    {
        text.text = "Hello World";
        m_YourFirstButton.onClick.AddListener(() => ButtonClicked());
    }

    void ButtonClicked()
    {
        text.text = input.text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
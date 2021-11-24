using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataLeak : MonoBehaviour
{
    [SerializeField] GameObject dataStreamTextObject;
    UnityEngine.UI.Text dataStreamText;
    int countdownDelay = 50;

    // Start is called before the first frame update
    void Start()
    {
        dataStreamText = dataStreamTextObject.GetComponent<UnityEngine.UI.Text>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        countdownDelay--;

        if (countdownDelay <= 0)
        {
            dataStreamText.text = Random.Range(0, 2) == 0 ? "0" + dataStreamText.text : "1" + dataStreamText.text;
            countdownDelay = 50;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataLeak : MonoBehaviour
{
    [SerializeField] GameObject dataStreamTextObject, TapeObject;
    UnityEngine.UI.Text dataStreamText;
    int countdownDelay = 3;
    bool hasWon;

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
            dataStreamText.text = hasWon ? " " + dataStreamText.text.Remove(dataStreamText.text.Length - 1) 
            : Random.Range(0, 2) + dataStreamText.text.Remove(dataStreamText.text.Length - 1);

            countdownDelay = 3;
        }

        if (hasWon || !Input.GetMouseButton(0) || !Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out RaycastHit hit))
            return;

        if (hit.transform.gameObject != TapeObject)
            return;

        TapeObject.transform.position = new Vector3(hit.point.x, hit.point.y, TapeObject.transform.position.z);

        hasWon = TapeObject.transform.position.y >= -10
            && TapeObject.transform.position.y <= -1
            && TapeObject.transform.position.x >= 24
            && TapeObject.transform.position.y <= 34;
    }
}

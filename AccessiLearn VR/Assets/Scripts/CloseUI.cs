using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseUI : MonoBehaviour
{
    public Button yourButton;
    public GameObject box;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

    }

    // Update is called once per frame
    void TaskOnClick()
    {
        box.SetActive(false);

    }
}

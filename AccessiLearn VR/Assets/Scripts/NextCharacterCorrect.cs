using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NextCharacterCorrect : MonoBehaviour
{
    public Button yourButton;
    public GameObject box1;
    public GameObject box2;
    public GameObject character;
    public GameObject currChar;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

    }

    // Update is called once per frame
    void TaskOnClick()
    {
        box1.SetActive(false);
        box2.SetActive(false);
        character.SetActive(true);
        currChar.SetActive(false);
    }
}


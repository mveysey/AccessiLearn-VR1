using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NextCharacterIncorrect : MonoBehaviour
{
    public Button yourButton;
    public GameObject box;
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
        box.SetActive(false);
        character.SetActive(true);
        currChar.SetActive(false);

    }
}

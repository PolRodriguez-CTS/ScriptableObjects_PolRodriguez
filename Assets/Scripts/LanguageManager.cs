using UnityEngine;
using UnityEngine.UI;

public class LanguageManager : MonoBehaviour
{
    [SerializeField] private LanguageConfig[] languages;
    

    public Text firstText;
    //public string firstTextValue;

    public Text secondText;
    //public string secondTextValue;

    public Text thirdText;
    //public string thirdTextValue;

    public Text fourthText;
    //public string fourthTextValue;


    void Start()
    {
        firstText.text = languages[0].texto1;
        secondText.text = languages[0].texto2;
        thirdText.text = languages[0].texto3;
        fourthText.text = languages[0].texto4;
    }

    public void TranslateTo(int languageIndex)
    {
        firstText.text = languages[languageIndex].texto1;
        secondText.text = languages[languageIndex].texto2;
        thirdText.text = languages[languageIndex].texto3;
        fourthText.text = languages[languageIndex].texto4;
    }
}

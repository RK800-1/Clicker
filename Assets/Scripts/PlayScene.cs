using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/// <summary>
/// This class is responsible for
/// the scene management +
/// game behaviour
/// </summary>
public class PlayScene : MonoBehaviour
{
    [SerializeField] int TotalBugsFixed;
    [SerializeField] Text AmountOfMoney;

    private void Start()
    {
        TotalBugsFixed = PlayerPrefs.GetInt("TotalBugsFixed");
    }

    public void FixBugBtnClick()
    {
        TotalBugsFixed++;
        PlayerPrefs.SetInt("TotalBugsFixed", TotalBugsFixed);
    }

    public void To_Shop()
    {
        SceneManager.LoadScene(1);
    }

    public void To_Profile()
    {
        SceneManager.LoadScene(2);
    }

    public void To_About()
    {
        SceneManager.LoadScene(3);
    }

    void FixedUpdate()
    {
        AmountOfMoney.text = TotalBugsFixed.ToString();
    }
}

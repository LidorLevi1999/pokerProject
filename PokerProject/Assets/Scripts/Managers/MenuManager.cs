using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Managers;
using Models;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance;
    public Dropdown dropdown;
    public Button PlayButton;
    void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
        dropdown.ClearOptions();
        List<int> l = new List<int>() { 1,2,3,4,5,6,7};
        dropdown.AddOptions(l.Select(o => o.ToString()).ToList());
    }
    public void OnPlayButtonClicked()
    {
        for (int i = 0; i < dropdown.value; i++)
            GameManager.Instance.PlayersList.Add(new Player());
        GameManager.Instance.Rivals = dropdown.value + 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

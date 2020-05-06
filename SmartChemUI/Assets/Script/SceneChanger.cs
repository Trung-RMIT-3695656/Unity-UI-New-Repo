using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    public void changeToSelectChapter()
    {
        SceneManager.LoadScene("Scene Container/Select Chapter");
    }
    public void changeToRoadMap()
    {
        SceneManager.LoadScene("Scene Container/RoadMap(SelectChapter)");
    }
    public void changeToBattleUI()
    {
        SceneManager.LoadScene("Scene Container/Battle UI");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loadscene : MonoBehaviour
{
    // Start is called before the first frame update
    int currentsceneindex;
    void Start()
    {
        currentsceneindex = SceneManager.GetActiveScene().buildIndex;
        if(currentsceneindex==0)
        {
            StartCoroutine(Waitfortheload());
        }
    }
    public void restartscene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(currentsceneindex);
    }
    public void mainmenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Main Screen");
    }
    IEnumerator Waitfortheload()
    {
        yield return new WaitForSeconds(5);
        loadnext();
    }

    public void loadnext()
    {
    
        SceneManager.LoadScene(currentsceneindex+1);
    }
    public void quit()
    {
        Application.Quit();
    }
    public void optionsmenu()
    {
        SceneManager.LoadScene("Options Screen");
    }
    public void startseq()
    {
      /*  if(PlayerPrefsController.GetFirst() == 0)
        {
            SceneManager.LoadScene("Level1");
        }
        else
        {*/
            SceneManager.LoadScene("MainGame");
       // }
    }
    public void DefenderInfo()
    {
        SceneManager.LoadScene("DefenderInfo");
    }
    public void AttackerInfo()
    {
        SceneManager.LoadScene("AttackerInfo");
    }
}

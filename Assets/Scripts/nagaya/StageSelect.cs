using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelect : MonoBehaviour
{
    public Button Stage1_1;
    public Button Stage1_2;
    public Button Stage1_3;
    public Button Stage1_4;
    public Button Stage1_5;

    public Button Cancel;

//  public GameObject Stage1;


    //　ポーズした時に表示するUI
    [SerializeField]
    private GameObject Stage1UI;

    // 今の位置を入れておく変数
    [SerializeField] private int NowPosition;
    



    // Start is called before the first frame update
    void Start()
    {
//       Stage1_1.Select;

//       Stage1UI.SetActive(false);

        
    }

    // Update is called once per frame
    void Update()
    {
//        if(GetKeyDown(KeyCode.UpArrow))
//        {
//            button -= 1;   
//        }
//        else if(GetKeyDown(KeyCode.DownArrow))
//        {
//            button += 1;
//        }
    }

    public void onButtonStage1_1()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void onButtonStage1_2()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void onButtonStage1_3()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void onButtonStage1_4()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void onButtonStage1_5()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void onButtonCancel()
    {
        Stage1UI.SetActive(false);
    }
}

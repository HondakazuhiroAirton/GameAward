using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

public class Cursoll : MonoBehaviour
{
    // ゲームオブジェクト配列で管理
    public GameObject[] iti;

    // 今の位置を入れておく変数
    [SerializeField] private int NowPosition;
    [SerializeField] private GameObject cursol;
    
     GameObject triangle;

    public GameObject Worldsel;
    public GameObject World1;
    public GameObject World2;
    public GameObject World3;
    public GameObject World4;

    private Button Stage1_1;
    private Button Stage2_1;
    private Button Stage3_1;
    private Button Stage4_1;

    public GameObject Return;

    private bool isPanel;


    void Start()
    {

        cursol = GameObject.Find("Triangle");
        triangle = GameObject.Find("/UICanvas/Triangle");

        // 最初はステージ1
        NowPosition = 1;
        this.transform.position = iti[NowPosition].transform.position;

        isPanel = true;
    }

    void Awake()
    {
        World1.SetActive(false);
        World2.SetActive(false);
        World3.SetActive(false);
        World4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
      //
        if (Input.GetKeyDown(KeyCode.RightArrow)||Input.GetKeyDown(KeyCode.D))
        {
            NowPosition += 1;  
            if (NowPosition >= 5/*<-マジックナンバー ワールドの合計の数-1を入れたい*/)   NowPosition = 4;
            this.transform.position = iti[NowPosition].transform.position;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))  
        {
            NowPosition -= 1;
            if (NowPosition < 0) NowPosition = 0;/*<-マジックナンバー ワールドの合計の数-1を入れたい*/
            this.transform.position = iti[NowPosition].transform.position;
        }
        


    }

   public void WorldButton()
   {
    
        if (Input.GetKeyDown(KeyCode.Return))
        {

            if (NowPosition==0)
            {
                SceneManager.LoadScene("nagaya");
            }
            else if (NowPosition == 1)
            {
                World1.SetActive(true);
                //ボタンの読み込み
                Stage1_1 = GameObject.Find("1-1").GetComponent<Button>();
                Stage1_1.Select();
                Worldsel.SetActive(false);
                isPanel = false;
//              UnityEditor.EditorApplication.isPaused = true;
            }
            else if(NowPosition==2)
            {
                World2.SetActive(true);
                Stage2_1 = GameObject.Find("2-1").GetComponent<Button>();
                Stage2_1.Select();
                Worldsel.SetActive(false);
            }
            else if(NowPosition==3)
            {
                World3.SetActive(true);
                Stage3_1 = GameObject.Find("3-1").GetComponent<Button>();
                Stage3_1.Select();
                Worldsel.SetActive(false);
            }
            else if(NowPosition==4)
            {
                World4.SetActive(true);
                Stage4_1 = GameObject.Find("4-1").GetComponent<Button>();
                Stage4_1.Select();
                Worldsel.SetActive(false);
            }
        }

       // if(isPanel)
       // {
       //     triangle.GetComponent<Cursoll>().enabled = false;
       // }
       // else
       // {
       //     triangle.GetComponent<Cursoll>().enabled = true;
       // }

   }
}

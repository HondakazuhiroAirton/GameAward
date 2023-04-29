using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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

<<<<<<< HEAD
    
=======
    private bool isPanel;

>>>>>>> develop

    void Start()
    {

        cursol = GameObject.Find("Triangle");
<<<<<<< HEAD
        worldSelector = GameObject.Find("/UICanvas/WorldSelector");
        script = worldSelector.GetComponent<WorldSelector>();
      
=======
        triangle = GameObject.Find("/UICanvas/Triangle");

>>>>>>> develop
        // 最初はステージ1
        NowPosition = 1;
        this.transform.position = iti[NowPosition].transform.position;

        isPanel = true;
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        if (Input.GetKeyDown(KeyCode.RightArrow))
=======
      //
        if (Input.GetKeyDown(KeyCode.RightArrow)||Input.GetKeyDown(KeyCode.D))
>>>>>>> develop
        {
            NowPosition += 1;
            if (NowPosition > 4/*<-マジックナンバー ワールドの合計の数-1を入れたい*/)   NowPosition = 0;

            this.transform.position = iti[NowPosition].transform.position;
            
        }
<<<<<<< HEAD
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
=======
        else if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))  
>>>>>>> develop
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
<<<<<<< HEAD

                UnityEditor.EditorApplication.isPaused = true;
=======
                //ボタンの読み込み
                Stage1_1 = GameObject.Find("1-1").GetComponent<Button>();
                Stage1_1.Select();
                Worldsel.SetActive(false);
                isPanel = false;
//              UnityEditor.EditorApplication.isPaused = true;
>>>>>>> develop
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

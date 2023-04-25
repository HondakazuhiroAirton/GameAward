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

    GameObject worldSelector;
    GameObject Cursol;

    WorldSelector script;

    public GameObject World1;
    public GameObject World2;
    public GameObject World3;
    public GameObject World4;

    public GameObject Return;

    

    void Start()
    {

        cursol = GameObject.Find("Triangle");
        worldSelector = GameObject.Find("/UICanvas/WorldSelector");
        script = worldSelector.GetComponent<WorldSelector>();

        // 最初はステージ1
        NowPosition = 1;
        this.transform.position = iti[NowPosition].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            NowPosition += 1;
            if (NowPosition > 4/*<-マジックナンバー ワールドの合計の数-1を入れたい*/)   NowPosition = 0;
            this.transform.position = iti[NowPosition].transform.position;
            if (NowPosition <= 0)
            {
            }
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            NowPosition -= 1;
            if (NowPosition < 0) NowPosition = 4;/*<-マジックナンバー ワールドの合計の数-1を入れたい*/
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

                UnityEditor.EditorApplication.isPaused = true;
            }
            else if(NowPosition==2)
            {
                World2.SetActive(true);
            }
            else if(NowPosition==3)
            {
                World3.SetActive(true);
            }
            else if(NowPosition==4)
            {
                World4.SetActive(true);
            }
        }

   }
}

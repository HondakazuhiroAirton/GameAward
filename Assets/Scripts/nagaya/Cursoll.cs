using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using TMPro;

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

    private GameObject worldSelector;

    private WorldSelector script;

    private GameObject audioManage;
    private AudioSource se;
    public AudioClip Cursolse;
    public AudioManager SEscript;
    public AudioClip Selectse;
    public AudioClip Cancelse;


    private bool panelflag = true;

    private int btime = 0;
    private bool bflag = false;

    //ゲームパッド
    [SerializeField] PlayerInput input;

    Fade fade;

    //説明用
    TextMeshProUGUI textComponent;

    void Start()
    {

        cursol = GameObject.Find("Triangle");

        worldSelector = GameObject.Find("/UICanvas/WorldSelector");
        script = worldSelector.GetComponent<WorldSelector>();

        triangle = GameObject.Find("/UICanvas/Triangle");

        audioManage = GameObject.Find("AudioManage");
        se = audioManage.GetComponent<AudioSource>();
        SEscript = audioManage.GetComponent<AudioManager>();

        panelflag = true;

        // 最初はワールド1
        NowPosition = 1;
        this.transform.position = iti[NowPosition].transform.position;


        //ゲームパッド
        input = this.GetComponent<PlayerInput>();
        fade = GameObject.Find("Image").GetComponent<Fade>();

        textComponent = GameObject.Find("setumei").GetComponent<TextMeshProUGUI>();
        textComponent.text = "world1";
    }

    // Update is called once per frame
    void Update()
    {
        btime--;
        if (btime <= 0)
        {
            btime = 0;
            bflag = true;
        }

        if (panelflag)
        {

            if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
            {
                se.PlayOneShot(Cursolse, 0.03f);

                NowPosition += 1;
                if (NowPosition > 4/*<-マジックナンバー ワールドの合計の数-1を入れたい*/) NowPosition = 0;
                this.transform.position = iti[NowPosition].transform.position;

            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
            {
                se.PlayOneShot(Cursolse, 0.03f);

                NowPosition -= 1;
                if (NowPosition < 0) NowPosition = 4;/*<-マジックナンバー ワールドの合計の数-1を入れたい*/
                this.transform.position = iti[NowPosition].transform.position;

            }

            if (Input.GetKeyDown(KeyCode.Return))
            {
                if (fade.Fadeflag() == false) return;
                WorldButton();

            }

            if (NowPosition == 0)
            {
                textComponent.text = "Title";
            }
            else if (NowPosition == 1)
            {
                textComponent.text = "world1";
            }
            else if (NowPosition == 2)
            {
                textComponent.text = "world2";
            }
            else if (NowPosition == 3)
            {
                textComponent.text = "world3";
            }
            else if (NowPosition == 4)
            {
                textComponent.text = "world4";
            }
        }
    }

    public void WorldButton()
    {


        if (NowPosition == 0)
        {
            panelflag = false;
            SEscript.playselectSE();
        }
        else if (NowPosition == 1)
        {
            if (fade.Fadeflag()) return;

            SEscript.playselectSE();

            World1.SetActive(true);
            //UnityEditor.EditorApplication.isPaused = true;
            Stage1_1 = GameObject.Find("1-1").GetComponent<Button>();
            Stage1_1.Select();
            Worldsel.SetActive(false);
            panelflag = false;
            btime = 10;
            bflag = false;

        }
        else if (NowPosition == 2)
        {
            SEscript.playselectSE();

            World2.SetActive(true);
            Stage2_1 = GameObject.Find("2-1").GetComponent<Button>();
            Stage2_1.Select();
            Worldsel.SetActive(false);
            panelflag = false;
            btime = 10;
            bflag = false;
        }
        else if (NowPosition == 3)
        {
            SEscript.playselectSE();

            World3.SetActive(true);
            Stage3_1 = GameObject.Find("3-1").GetComponent<Button>();
            Stage3_1.Select();
            Worldsel.SetActive(false);
            panelflag = false;
            btime = 10;
            bflag = false;
        }
        else if (NowPosition == 4)
        {
            SEscript.playselectSE();

            World4.SetActive(true);
            Stage4_1 = GameObject.Find("4-1").GetComponent<Button>();
            Stage4_1.Select();
            Worldsel.SetActive(false);
            panelflag = false;
            btime = 10;
            bflag = false;
        }



    }

    public void OnLeft(InputAction.CallbackContext context)
    {
        if (panelflag)
        {
            if (context.phase == InputActionPhase.Performed)
            {
                se.PlayOneShot(Cursolse, 0.03f);

                NowPosition -= 1;
                if (NowPosition < 0) NowPosition = 4;/*<-マジックナンバー ワールドの合計の数-1を入れたい*/
                this.transform.position = iti[NowPosition].transform.position;
            }
        }
    }


    public void OnRight(InputAction.CallbackContext context)
    {
        
            if (panelflag)
            {
                if (context.phase == InputActionPhase.Performed)
                {
                    se.PlayOneShot(Cursolse, 0.03f);

                    NowPosition += 1;
                    if (NowPosition > 4/*<-マジックナンバー ワールドの合計の数-1を入れたい*/) NowPosition = 0;
                    this.transform.position = iti[NowPosition].transform.position;
                }
            }
    }

    public void OnUp(InputAction.CallbackContext context)
    {

        if (panelflag == false)
        {
            if (context.phase == InputActionPhase.Performed)
            {
                se.PlayOneShot(Cursolse, 0.03f);
            }
        }
    }
    public void OnDown(InputAction.CallbackContext context)
    {

        if (panelflag == false)
        {
            if (context.phase == InputActionPhase.Performed)
            {
                se.PlayOneShot(Cursolse, 0.03f);
            }
        }
    }

    public void OnSelect(InputAction.CallbackContext context)
    {

        if (fade.Fadeflag() == false)
        {
            Debug.Log("おした！！");
            if (panelflag)
            {
                if (context.phase == InputActionPhase.Performed)
                {
                    WorldButton();
                }
            }
        }
    }

    public void Updateflag()
    {
        panelflag = true;
    }

    public bool Bflag()
    {
        return bflag;
    }
}




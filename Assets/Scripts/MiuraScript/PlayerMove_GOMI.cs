using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Effekseer;

public class PlayerMove_GOMI : MonoBehaviour
{
    // publicゾーン**************************************************************
    public float speed; //プレイヤーのスピード 

    // ビームの情報達********************************
    // ビームの横幅が1秒間に大きくなる基準
    public float BeamExpansion = 100.0f;
    // ビームの最大の長さ
    public float BeamMax = 30.0f;
    // ビームの長さが1秒間に大きくなる基準
    public float BeamExpansionDistance = 1f;
    // ビームの長さの基準
    public float BeamDistanceKijun;
    // ビーム使用量の基準
    public float UseKijun = 10;

    //ワープフラグ用
    public bool Up;
    public bool Down;
    public bool Right;
    public bool Left;

    // privateゾーン*************************************************************
    // 移動バー
    private GameObject wallUp;
    private GameObject wallDown;
    private GameObject wallLeft;
    private GameObject wallRight;

    // バーの情報達**************************************
    private Vector3 Upos;        //上の位置
    private Vector3 UScale;      //上のスケール
    private Vector3 Dpos;        //下の位置
    private Vector3 DScale;      //下のスケール
    private Vector3 Rpos;        //右の位置
    private Vector3 RScale;      //右のスケール
    private Vector3 Lpos;        //左の位置
    private Vector3 LScale;      //左のスケール

    private float URpos;
    private float ULpos;
    private float DRpos;
    private float DLpos;
    private float RRpos;
    private float RLpos;
    private float LRpos;
    private float LLpos;

    private Vector3 pos; // プレイヤーのポジション取得
    private Vector3 Scale; // プレイヤーの大きさ取得


    // ビームの情報達********************************
    // プレイヤーデータ保存用オブジェクト取得
    private GameObject PlayerDate;
    // Geter/Seter用スクリプト保存
    private PlayerClass PlayerClassScript;

    // プレハブ格納用
    private GameObject BeamParticleManagerPrefab;

    // チャージした時間を格納する変数(必要)
    public float ChargeTime = 0.0f;



    //********************************************************************************

    void Start()
    {


        // 各種バー取得
        wallUp = GameObject.Find("UP");
        wallDown = GameObject.Find("Down");
        wallLeft = GameObject.Find("Left");
        wallRight = GameObject.Find("Right");

        //WallUpの端取得
        Upos = wallUp.gameObject.transform.position;
        UScale = wallUp.gameObject.transform.localScale;
        URpos = Upos.x + UScale.x / 2;
        ULpos = Upos.x - UScale.x / 2;

        //WallDownの端取得
        Dpos = wallDown.gameObject.transform.position;
        DScale = wallDown.gameObject.transform.localScale;
        DRpos = Dpos.x + DScale.x / 2;
        DLpos = Dpos.x - DScale.x / 2;

        //WallRightの端取得
        Rpos = wallRight.gameObject.transform.position;
        RScale = wallRight.gameObject.transform.localScale;
        RRpos = Rpos.y + RScale.y / 2;
        RLpos = Rpos.y - RScale.y / 2;

        //WallLeftの端取得
        Lpos = wallLeft.gameObject.transform.position;
        LScale = wallLeft.gameObject.transform.localScale;
        LRpos = Lpos.y + LScale.y / 2;
        LLpos = Lpos.y - LScale.y / 2;

        this.gameObject.transform.position = new Vector3(Upos.x, Upos.y, Upos.z - 1);


        //wall色変更
        wallUp.GetComponent<Renderer>().material.color = Color.red;
        wallDown.GetComponent<Renderer>().material.color = Color.red;
        wallRight.GetComponent<Renderer>().material.color = Color.red;
        wallLeft.GetComponent<Renderer>().material.color = Color.red;

        SetWallFlag(0, true);
        SetWallFlag(1, true);
        SetWallFlag(2, false);
        SetWallFlag(3, true);

        //0402_三浦瞬追記****************************************************************

        // チャージした時間を貯める
        ChargeTime = 0.0f;

        // 基準値初期化
        BeamDistanceKijun = 10.0f;

        // ビームをResourcesから取得
        BeamParticleManagerPrefab = Resources.Load<GameObject>("BeamParticleManager");

        // 巨大ビームをResourcesから取得
        //BigBeamPrefabs = Resources.Load<GameObject>("BigBeam");

        // ビーム残量へのアクセス
        //PlayerDateもってくる
        PlayerDate = GameObject.Find("PlayerDate");

        //Geter / Seter使用用スクリプト保持
        PlayerClassScript = PlayerDate.GetComponent<PlayerClass>();

        //ビーム残量を100 % に設定
        PlayerClassScript.SetAmount(100);
       
    }


    void Update()
    {
        //プレイヤーの座標取得
        pos = this.gameObject.transform.position;
        //プレイヤーのスケール取得
        Scale = this.gameObject.transform.localScale;

        // qボタンを押していると遅くなる
        float DownSpeed = 1.0f;
        if (Input.GetKey("q"))
        {
            DownSpeed = 0.1f;
        }


        //<<<上のライン移動>>>
        if (pos.y == Upos.y)
        {

            pos.y = Upos.y;

            //ライン外にいかない処理
            if (pos.x >= URpos - Scale.x / 2)
            {
                pos.x = URpos - Scale.x / 2;
            }
            else if (pos.x <= ULpos + Scale.x / 2)
            {
                pos.x = ULpos + Scale.x / 2;
            }

            //d入力で右向きに動く
            if (Input.GetKey("d"))
            {
                this.gameObject.transform.position = new Vector3(pos.x + speed * DownSpeed, pos.y, pos.z);
            }
            //a入力で左向きに動く
            else if (Input.GetKey("a"))
            {
                this.gameObject.transform.position = new Vector3(pos.x - speed * DownSpeed, pos.y, pos.z);
            }

        }
        // <<<下のライン移動>>>
        if (pos.y == Dpos.y)
        {

            pos.y = Dpos.y;

            //ライン外にいかない処理
            if (pos.x >= DRpos - Scale.x / 2)
            {
                pos.x = DRpos - Scale.x / 2;
            }
            else if (pos.x <= DLpos + Scale.x / 2)
            {
                pos.x = DLpos + Scale.x / 2;
            }

            //d入力で右向きに動く
            if (Input.GetKey("d"))
            {
                this.gameObject.transform.position = new Vector3(pos.x + speed * DownSpeed, pos.y, pos.z);
            }
            //a入力で左向きに動く
            else if (Input.GetKey("a"))
            {
                this.gameObject.transform.position = new Vector3(pos.x - speed * DownSpeed, pos.y, pos.z);
            }

        }
        // <<<右のライン移動>>>
        if (pos.x == Rpos.x)
        {

            pos.x = Rpos.x;

            //ライン外にいかない処理
            if (pos.y >= RRpos - Scale.y / 2)
            {
                pos.y = RRpos - Scale.y / 2;
            }
            else if (pos.y <= RLpos + Scale.y / 2)
            {
                pos.y = RLpos + Scale.y / 2;
            }

            //w入力で上向きに動く
            if (Input.GetKey("w"))
            {
                this.gameObject.transform.position = new Vector3(pos.x, pos.y + speed * DownSpeed, pos.z);
            }
            //s入力で下向きに動く
            else if (Input.GetKey("s"))
            {
                this.gameObject.transform.position = new Vector3(pos.x, pos.y - speed * DownSpeed, pos.z);
            }

        }
        //<<<左のライン移動>>>
        if (pos.x == Lpos.x)
        {

            pos.x = Lpos.x;

            //ライン外にいかない処理
            if (pos.y >= LRpos - Scale.y / 2)
            {
                pos.y = LRpos - Scale.y / 2;
            }
            else if (pos.y <= LLpos + Scale.y / 2)
            {
                pos.y = LLpos + Scale.y / 2;
            }

            //w入力で上向きに動く
            if (Input.GetKey("w"))
            {
                this.gameObject.transform.position = new Vector3(pos.x, pos.y + speed * DownSpeed, pos.z);
            }
            //s入力で下向きに動く
            else if (Input.GetKey("s"))
            {
                this.gameObject.transform.position = new Vector3(pos.x, pos.y - speed * DownSpeed, pos.z);
            }

        }

        //ワープ
        if (Up == true)
        {
            //色変更
            wallUp.GetComponent<Renderer>().material.color = Color.green;
            if (Input.GetKey("1"))//上
            {
                this.gameObject.transform.position = new Vector3(Upos.x, Upos.y, Upos.z - 1);
                this.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
            }
        }
        if (Down == true)
        {
            //色変更
            wallDown.GetComponent<Renderer>().material.color = Color.green;
            if (Input.GetKey("2"))//下
            {
                this.gameObject.transform.position = new Vector3(Dpos.x, Dpos.y, Dpos.z - 1);
                this.gameObject.transform.rotation = Quaternion.Euler(0, 0, 180);
            }
        }
        if (Right == true)
        {
            //色変更
            wallRight.GetComponent<Renderer>().material.color = Color.green;
            if (Input.GetKey("3"))//右
            {
                this.gameObject.transform.position = new Vector3(Rpos.x, Rpos.y, Rpos.z - 1);
                this.gameObject.transform.rotation = Quaternion.Euler(0, 0, -90);
            }
        }
        if (Left == true)
        {
            //色変更
            wallLeft.GetComponent<Renderer>().material.color = Color.green;
            if (Input.GetKey("4"))//左
            {
                this.gameObject.transform.position = new Vector3(Lpos.x, Lpos.y, Lpos.z - 1);
                this.gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
            }
        }

        //0329_三浦瞬追記****************************************************************
        // ビーム発射処理*************************************************************
        if (Input.GetKey(KeyCode.Space)) // キーコードは変更してね(*^^*)
        {
            // 毎フレーム時間を計測する
            ChargeTime = ChargeTime + Time.deltaTime /*補正値掛ける??*/;

            // 最大値は多分こんな感じでつくる
            if (ChargeTime >= 30.0f)
            {
                ChargeTime = 30.0f;
            }

            // チャージ中の各種値表示
            //Debug.Log("ChargeTimeは"+ChargeTime);
            //Debug.Log("サイズは"+ ChargeTime * BeamExpansion);
            //Debug.Log("飛距離は"+ ChargeTime * BeamExpansionDistance + BeamDistanceKijun);
            //Debug.Log("ビーム消費量は"+ChargeTime);
        }

        if (Input.GetKeyUp(KeyCode.Space)) // Downと同じキーコードにしてね
        {
            // 計測した時間から各種値を計算する

            // チャージした時間によってビームの大きさが変わるサイズ変更用の変数
            // 1.サイズを計算する
            float BoxCastScale = ChargeTime * BeamExpansion;

            // 2.最大飛距離距離を計算する
            BeamMax = ChargeTime * BeamExpansionDistance + BeamDistanceKijun;

            // 最大値補正
            if (BeamMax >= 50.0f)
            {
                BeamMax = 50.0f;
            }

            // 3.消費エネルギーの計算
            // 消費量を計算
            float use = 3 /*最小使用量が3*/ + ChargeTime * UseKijun;

            // 最大量を決める
            if (use >= 10)
            {
                use = 10;
            }

            // 減らす
            // ビーム残量取得
            float tempCharge = PlayerClassScript.GetAmount();

            // 残量があれば
            if ((tempCharge = tempCharge - use) > 0)
            {
                // ビーム残量を減らして
                tempCharge = tempCharge - use;
                // プレイヤーデータオブジェクトのビーム残量(Amount)を更新する
                PlayerClassScript.SetAmount(tempCharge);

                // ビームマネージャーの中のBoxCastを取得
                GameObject BoxCast = BeamParticleManagerPrefab.gameObject.transform.GetChild(1).gameObject;

                // 取得したBoxCastのBoxCastスクリプト内(Scale)の大きさを変更する
                BoxCast.transform.localScale = new Vector3(BoxCastScale, BoxCastScale, BoxCastScale);

                // プレイヤーの角度をBeamParticleに代入する
                // BeamParticle取得
                GameObject BeamParticleManager = BeamParticleManagerPrefab.gameObject.transform.GetChild(0).gameObject;

                // プレイヤーのZ軸を参考にする
                float PlayerAngle = this.transform.localEulerAngles.z;

                // BeamEffectScriptをキャッシュ************************************************
                BeamParticleScript script = BeamParticleManager.GetComponent<BeamParticleScript>();

                // BeamParticleのEffect角度を更新する
                script.PlayerAngle = PlayerAngle;

                // BeamParticleの角度を変更する
                script.Angle = PlayerAngle - 90;

                // BeamParticleのBeamMaxを変更する
                script.BeamMax = BeamMax;

                // プレハブを指定位置に生成
                Instantiate(BeamParticleManagerPrefab, this.transform.position, gameObject.transform.localRotation);
                // チャージ時間を戻す
                ChargeTime = 0.0f;
            }
        }

        // ビーム発射処理(ここまで)*************************************************************

        // 巨大ビーム発射処理(ここから)*************************************************************
        if (Input.GetKeyUp(KeyCode.K)) // Downと同じキーコードにしてね
        {
            // プレハブを指定位置に生成
            //Instantiate(BigBeamPrefabs, this.transform.position, gameObject.transform.localRotation);
        }

    }
    //wall使用フラグ
    void SetWallFlag(int num, bool flag)
    {
        switch (num)
        {
            case 0: { Up = flag; break; }
            case 1: { Down = flag; break; }
            case 2: { Right = flag; break; }
            case 3: { Left = flag; break; }

        }

    }
}
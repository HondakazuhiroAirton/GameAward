using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;
using TMPro;

public class PlayerMove_MIURA : MonoBehaviour
{
    // publicゾーン**************************************************************
    public float speed; //プレイヤーのスピード 

    // ビームの最大溜め時間*************************
    public float MaxChargeTime = 8;// 少数第2位まで入力されると怪しい

    //ワープフラグ用
    public bool Up;
    public bool Down;
    public bool Right;
    public bool Left;

    // ビームのインターバル
    public int Interbal = 60;

    // privateゾーン*************************************************************
    // ビームの1段階の時間*************************
    private int OneChargeFrame;
    // ビーム最大溜め時間
    private float MaxFrame;

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

    // ビームの情報達
    // Lv0
    private float Lv0_Scale;
    private float Lv0_Distance;
    private float Lv0_Use;
    // Lv1
    private float Lv1_Scale;
    private float Lv1_Distance;
    private float Lv1_Use;
    // Lv2
    private float Lv2_Scale;
    private float Lv2_Distance;
    private float Lv2_Use;
    // Lv3
    private float Lv3_Scale;
    private float Lv3_Distance;
    private float Lv3_Use;
    // Lv4
    private float Lv4_Scale;
    private float Lv4_Distance;
    private float Lv4_Use;

    // ビームの情報達********************************
    // プレイヤーデータ保存用オブジェクト取得
    private GameObject PlayerDate;
    // Geter/Seter用スクリプト保存
    private beamlife PlayerClassScript;
    // Charge用キラキラパーティクルシステムオブジェクト取得
    private GameObject beamCharge;
    private charge beamChargeScript;

    // ビームマネージャーの中のBoxCastを取得
    private GameObject BoxCast;

    // BeamParticle取得
    GameObject BeamParticleManager;
    // BeamEffectScript
    BeamParticleScript script;
    // プレハブ格納用
    private GameObject BeamParticleManagerPrefab;

    // チャージした時間を格納する変数(必要)
    private int ChargeTime = 0;

    // 巨大ビームプレハブ格納
    private GameObject BigBeamPrefabs;

    // ビームのインターバルのマックス値
    private int interbalMax;

    // このオブジェクトのアニメーター
    private Animator animator;

    //********************************************************************************

    //ゲームパッド
    [SerializeField] PlayerInput input;
    private bool _isPressed;
    private bool _ismoveR;
    private bool _ismoveL;
    private bool _ismoveU;
    private bool _ismoveD;

    void Start()
    {
        // アニメーターを取得
        animator = this.GetComponent<Animator>();

        // ビームチャージパーティクルシステム取得
        beamCharge = GameObject.Find("beamcharge");
        // そこのスクリプト取得
        beamChargeScript = beamCharge.GetComponent<charge>();

        // ビーム溜め時間計算********************************************
        // 入力された最大溜め時間の単位を秒からフレームに変更
        MaxFrame = MaxChargeTime * 60;

        // 少数第2位まで入力されると怪しい
        // 1個あたりの溜め時間に変換
        OneChargeFrame = (int)MaxFrame / 5;

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

        this.gameObject.transform.position = new Vector3(Upos.x, Upos.y, Upos.z);

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
        ChargeTime = 0;
        // ビームをResourcesから取得
        BeamParticleManagerPrefab = Resources.Load<GameObject>("BeamParticleManager");

        // 巨大ビームをResourcesから取得
        BigBeamPrefabs = Resources.Load<GameObject>("BigBeam");

        // ビームマネージャーの中のBoxCastを取得
        BoxCast = BeamParticleManagerPrefab.gameObject.transform.GetChild(1).gameObject;

        // BeamParticle取得
        BeamParticleManager = BeamParticleManagerPrefab.gameObject.transform.GetChild(0).gameObject;
        // BeamEffectScriptをキャッシュ
        script = BeamParticleManager.GetComponent<BeamParticleScript>();

        // ビーム残量へのアクセス
        //PlayerDateもってくる
        PlayerDate = GameObject.Find("PD");

        //Geter / Seter使用用スクリプト保持
        PlayerClassScript = PlayerDate.GetComponent<beamlife>();

        //ビーム残量を100 % に設定
        PlayerClassScript.SetAmount(100);

        // ビーム初期化
        Lv0_Scale = 0.4f;
        Lv0_Distance = 1.8f;
        Lv0_Use = 3.0f;

        Lv1_Scale = 0.5f;
        Lv1_Distance = 2.0f;
        Lv1_Use = 5.0f;

        Lv2_Scale = 0.8f;
        Lv2_Distance = 3.0f;
        Lv2_Use = 8.0f;

        Lv3_Scale = 1.2f;
        Lv3_Distance = 4.0f;
        Lv3_Use = 15.0f;

        Lv4_Scale = 1.5f;
        Lv4_Distance = 5.0f;
        Lv4_Use = 30.0f;

        // ビームのインターバルのマックス値を保存
        interbalMax = Interbal;

        //ゲームパッド
        input = this.GetComponent<PlayerInput>();

        _isPressed = false;
        //移動フラグ
        _ismoveR = false;
        _ismoveL = false;
        _ismoveU = false;
        _ismoveD = false;
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
            if (Input.GetKey("d") || _ismoveR == true)
            {
                this.gameObject.transform.position = new Vector3(pos.x + speed * DownSpeed, pos.y, pos.z);
            }
            //a入力で左向きに動く
            else if (Input.GetKey("a") || _ismoveL == true)
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
            if (Input.GetKey("d") || _ismoveR == true)
            {
                this.gameObject.transform.position = new Vector3(pos.x + speed * DownSpeed, pos.y, pos.z);
            }
            //a入力で左向きに動く
            else if (Input.GetKey("a") || _ismoveL == true)
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
            if (Input.GetKey("w") || _ismoveU == true)
            {
                this.gameObject.transform.position = new Vector3(pos.x, pos.y + speed * DownSpeed, pos.z);
            }
            //s入力で下向きに動く
            else if (Input.GetKey("s") || _ismoveD == true)
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
            if (Input.GetKey("w") || _ismoveU == true)
            {
                this.gameObject.transform.position = new Vector3(pos.x, pos.y + speed * DownSpeed, pos.z);
            }
            //s入力で下向きに動く
            else if (Input.GetKey("s") || _ismoveD == true)
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
                this.gameObject.transform.position = new Vector3(Upos.x, Upos.y, Upos.z );
                this.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
            }
        }
        if (Down == true)
        {
            //色変更
            wallDown.GetComponent<Renderer>().material.color = Color.green;
            if (Input.GetKey("2"))//下
            {
                this.gameObject.transform.position = new Vector3(Dpos.x, Dpos.y, Dpos.z );
                this.gameObject.transform.rotation = Quaternion.Euler(0, 0, 180);
            }
        }
        if (Right == true)
        {
            //色変更
            wallRight.GetComponent<Renderer>().material.color = Color.green;
            if (Input.GetKey("3"))//右
            {
                this.gameObject.transform.position = new Vector3(Rpos.x, Rpos.y, Rpos.z);
                this.gameObject.transform.rotation = Quaternion.Euler(0, 0, -90);
            }
        }
        if (Left == true)
        {
            //色変更
            wallLeft.GetComponent<Renderer>().material.color = Color.green;
            if (Input.GetKey("4"))//左
            {
                this.gameObject.transform.position = new Vector3(Lpos.x, Lpos.y, Lpos.z);
                this.gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
            }
        }

        //0329_三浦瞬追記****************************************************************


        // アニメーター通常状態はFalse
        animator.SetBool("fCharge", false);

        // インターバルの時間を減らす
        Interbal--;
        if (Interbal < 0)// インターバルが0以下になったら補正する
        {
            Interbal = 0;
        }

        // ビーム発射処理*************************************************************
        if (Input.GetKey(KeyCode.Space) || _isPressed == true) // キーコードは変更してね(*^^*)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // チャージエフェクト開始
                beamChargeScript.Play();
            }

            // アニメーターぐるぐる状態はTrue
            animator.SetBool("fCharge",true);

  

            // 毎フレーム1足すことによって時間を図る
            ChargeTime = ChargeTime + 1; 

            // 最大値設定 ←バグるならこの変か？？？？
            if (ChargeTime >= MaxFrame)
            {
                ChargeTime = (int)(MaxFrame + 1);
            }
            
            // 時間によって変わる(閾値)
            if (0 <= ChargeTime && ChargeTime < OneChargeFrame) // 1段階目
            {
                Debug.Log("1段階目のチャージ");
            }
            else if (OneChargeFrame <= ChargeTime && ChargeTime < 2 * OneChargeFrame)// 2段階目
            {
                Debug.Log("2段階目のチャージ");
            }
            else if (2 * OneChargeFrame <= ChargeTime && ChargeTime < 3 * OneChargeFrame)// 3段階目
            {
                Debug.Log("3段階目のチャージ");
            }
            else if (3 * OneChargeFrame <= ChargeTime && ChargeTime < 4 * OneChargeFrame)// 4段階目
            {
                Debug.Log("4段階目のチャージ");
            }
            else if (4 * OneChargeFrame <= ChargeTime)// 5段階目
            {
                Debug.Log("5段階目のチャージ");
            }
        }

        if (Input.GetKeyUp(KeyCode.Space) && (Interbal <= 0) ) // Downと同じキーコードにしてね
        {
            // インターバルを設定する
            Interbal = interbalMax;

            // チャージエフェクトストップ
            beamChargeScript.Stop();

            // 計測した時間から各種値を計算する
            float use = 0;
            float BoxCastScale = 0;
            float Distance = 0;
            int BeamLevel = 0;
            // チャージした時間によってビームの大きさが変わるサイズ変更用の変数

            // 時間によって変わる(閾値)
            if (0 <= ChargeTime && ChargeTime < OneChargeFrame) // 無チャージ
            {
                // 1.サイズを入れる
                BoxCastScale = Lv0_Scale;
                // 2.最大飛距離距離を入れる
                Distance = Lv0_Distance;
                // 3.消費エネルギーを決める
                use = Lv0_Use;
                // ビームの種類を教える
                BeamLevel = 0;
            }
            else if(OneChargeFrame <= ChargeTime && ChargeTime < 2 * OneChargeFrame)// 1階目
            {
                // 1.サイズを入れる
                BoxCastScale = Lv1_Scale;
                // 2.最大飛距離距離を入れる
                Distance = Lv1_Distance;
                // 3.消費エネルギーを決める
                use = Lv1_Use;
                // ビームの種類を教える
                BeamLevel = 1;
            }
            else if (2 * OneChargeFrame <= ChargeTime && ChargeTime < 3 * OneChargeFrame)// 2段階目
            {
                // 1.サイズを入れる
                BoxCastScale = Lv2_Scale;
                // 2.最大飛距離距離を入れる
                Distance = Lv2_Distance;
                // 3.消費エネルギーを決める
                use = Lv2_Use;
                // ビームの種類を教える
                BeamLevel = 2;
            }
            else if (3 * OneChargeFrame <= ChargeTime && ChargeTime < 4 * OneChargeFrame)// 3段階目
            {
                // 1.サイズを入れる
                BoxCastScale = Lv3_Scale;
                // 2.最大飛距離距離を入れる
                Distance = Lv3_Distance;
                // 3.消費エネルギーを決める
                use = Lv3_Use;
                // ビームの種類を教える
                BeamLevel = 3;
            }
            else if (4 * OneChargeFrame <= ChargeTime )// 4段階目
            {
                // 1.サイズを入れる
                BoxCastScale = Lv4_Scale;
                // 2.最大飛距離距離を入れる
                Distance = Lv4_Distance;
                // 3.消費エネルギーを決める
                use = Lv4_Use;
                // ビームの種類を教える
                BeamLevel = 4;
            }

            // 減らす
            // ビーム残量取得
            float tempCharge = PlayerClassScript.GetAmount();

            float tmp = tempCharge - use;

            // 残量があれば
            if (tmp  > 0)
            {
                // ビーム残量を減らして
                tempCharge = tempCharge - use;
                Debug.Log("使用量" + use);
                Debug.Log("ビーム残り" +tempCharge);

                // プレイヤーデータオブジェクトのビーム残量(Amount)を更新する
                PlayerClassScript.SetAmount(tempCharge);

                Debug.Log("メーターの中身" + PlayerClassScript.GetAmount());

                // プレイヤーの角度をBeamParticleに代入する
                // プレイヤーのZ軸を参考にする
                float PlayerAngle = this.transform.localEulerAngles.z;

                // BeamParticleのEffect角度を更新する
                script.PlayerAngle = PlayerAngle;

                // BeamParticleの角度を変更する
                script.Angle = PlayerAngle - 90;

                // BoxCastの幅を変更する
                BoxCast.transform.localScale = new Vector3(BoxCastScale, BoxCastScale, BoxCastScale);

                // BeamParticleのBeamMax(飛距離)を変更する
                script.BeamMax = Distance;

                // BeamParticleのチャージ段階を渡す
                script.NowBeamLevel = BeamLevel;

                // プレハブを指定位置に生成
                Instantiate(BeamParticleManagerPrefab, this.transform.position, gameObject.transform.localRotation);
                // チャージ時間を戻す
                ChargeTime = 0;


            }
        }

        // ビーム発射処理(ここまで)*****************************************************************

        // 巨大ビーム発射処理(ここから)*************************************************************
        if (Input.GetKeyUp(KeyCode.K)) // Downと同じキーコードにしてね
        {
            // プレハブを指定位置に生成
            Instantiate(BigBeamPrefabs, this.transform.position, gameObject.transform.localRotation);
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


    public void OnAttck(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Canceled)
        {
            // チャージエフェクトストップ
            beamChargeScript.Stop();

            // 計測した時間から各種値を計算する
            float use = 0;
            float BoxCastScale = 0;
            float Distance = 0;
            int BeamLevel = 0;
            // チャージした時間によってビームの大きさが変わるサイズ変更用の変数

            // 時間によって変わる(閾値)
            if (0 <= ChargeTime && ChargeTime < OneChargeFrame) // 無チャージ
            {
                // 1.サイズを入れる
                BoxCastScale = Lv0_Scale;
                // 2.最大飛距離距離を入れる
                Distance = Lv0_Distance;
                // 3.消費エネルギーを決める
                use = Lv0_Use;
                // ビームの種類を教える
                BeamLevel = 0;
            }
            else if (OneChargeFrame <= ChargeTime && ChargeTime < 2 * OneChargeFrame)// 1階目
            {
                // 1.サイズを入れる
                BoxCastScale = Lv1_Scale;
                // 2.最大飛距離距離を入れる
                Distance = Lv1_Distance;
                // 3.消費エネルギーを決める
                use = Lv1_Use;
                // ビームの種類を教える
                BeamLevel = 1;
            }
            else if (2 * OneChargeFrame <= ChargeTime && ChargeTime < 3 * OneChargeFrame)// 2段階目
            {
                // 1.サイズを入れる
                BoxCastScale = Lv2_Scale;
                // 2.最大飛距離距離を入れる
                Distance = Lv2_Distance;
                // 3.消費エネルギーを決める
                use = Lv2_Use;
                // ビームの種類を教える
                BeamLevel = 2;
            }
            else if (3 * OneChargeFrame <= ChargeTime && ChargeTime < 4 * OneChargeFrame)// 3段階目
            {
                // 1.サイズを入れる
                BoxCastScale = Lv3_Scale;
                // 2.最大飛距離距離を入れる
                Distance = Lv3_Distance;
                // 3.消費エネルギーを決める
                use = Lv3_Use;
                // ビームの種類を教える
                BeamLevel = 3;
            }
            else if (4 * OneChargeFrame <= ChargeTime)// 4段階目
            {
                // 1.サイズを入れる
                BoxCastScale = Lv4_Scale;
                // 2.最大飛距離距離を入れる
                Distance = Lv4_Distance;
                // 3.消費エネルギーを決める
                use = Lv4_Use;
                // ビームの種類を教える
                BeamLevel = 4;
            }

            // 減らす
            // ビーム残量取得
            float tempCharge = PlayerClassScript.GetAmount();

            float tmp = tempCharge - use;

            // 残量があれば
            if (tmp > 0)
            {
                // ビーム残量を減らして
                tempCharge = tempCharge - use;
                Debug.Log("使用量" + use);
                Debug.Log("ビーム残り" + tempCharge);

                // プレイヤーデータオブジェクトのビーム残量(Amount)を更新する
                PlayerClassScript.SetAmount(tempCharge);

                Debug.Log("メーターの中身" + PlayerClassScript.GetAmount());

                // プレイヤーの角度をBeamParticleに代入する
                // プレイヤーのZ軸を参考にする
                float PlayerAngle = this.transform.localEulerAngles.z;

                // BeamParticleのEffect角度を更新する
                script.PlayerAngle = PlayerAngle;

                // BeamParticleの角度を変更する
                script.Angle = PlayerAngle - 90;

                // BoxCastの幅を変更する
                BoxCast.transform.localScale = new Vector3(BoxCastScale, BoxCastScale, BoxCastScale);

                // BeamParticleのBeamMax(飛距離)を変更する
                script.BeamMax = Distance;

                // BeamParticleのチャージ段階を渡す
                script.NowBeamLevel = BeamLevel;

                // プレハブを指定位置に生成
                Instantiate(BeamParticleManagerPrefab, this.transform.position, gameObject.transform.localRotation);
                // チャージ時間を戻す
                ChargeTime = 0;


            }
            Debug.Log("ビームうった！！");
        }
    }

    public void OnAccumulate(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Performed:
                // ボタンが押された時の処理
                _isPressed = true;
                break;

            case InputActionPhase.Canceled:
                // ボタンが離された時の処理
                _isPressed = false;
                break;
        }
        if (context.phase == InputActionPhase.Performed)
        {
            // チャージエフェクト開始
            beamChargeScript.Play();
        }
    }

    public void OnWarpUP(InputAction.CallbackContext context)
    {
        //ワープ
        if (Up == true)
        {
            //色変更
            wallUp.GetComponent<Renderer>().material.color = Color.green;


            this.gameObject.transform.position = new Vector3(Upos.x, Upos.y, Upos.z);
            this.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);

        }
        Debug.Log("上にワープする！");
    }
    public void OnWarpDown(InputAction.CallbackContext context)
    {
        if (Down == true)
        {
            //色変更
            wallDown.GetComponent<Renderer>().material.color = Color.green;

            this.gameObject.transform.position = new Vector3(Dpos.x, Dpos.y, Dpos.z);
            this.gameObject.transform.rotation = Quaternion.Euler(0, 0, 180);

        }
        Debug.Log("下にワープする！");
    }
    public void OnWarpRight(InputAction.CallbackContext context)
    {
        if (Right == true)
        {
            //色変更
            wallRight.GetComponent<Renderer>().material.color = Color.green;

            this.gameObject.transform.position = new Vector3(Rpos.x, Rpos.y, Rpos.z);
            this.gameObject.transform.rotation = Quaternion.Euler(0, 0, -90);

        }
    }
    public void OnWarpLeft(InputAction.CallbackContext context)
    {
        if (Left == true)
        {
            //色変更
            wallLeft.GetComponent<Renderer>().material.color = Color.green;

            this.gameObject.transform.position = new Vector3(Lpos.x, Lpos.y, Lpos.z);
            this.gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);

        }
    }

    public void OnLmove(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Performed:
                // ボタンが押された時の処理
                _ismoveL = true;
                break;

            case InputActionPhase.Canceled:
                // ボタンが離された時の処理
                _ismoveL = false;
                break;
        }
        Debug.Log("左に動く！");
    }
    public void OnRmove(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Performed:
                // ボタンが押された時の処理
                _ismoveR = true;
                break;

            case InputActionPhase.Canceled:
                // ボタンが離された時の処理
                _ismoveR = false;
                break;
        }
        Debug.Log("右に動く！");
    }
    public void OnUmove(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Performed:
                // ボタンが押された時の処理
                _ismoveU = true;
                break;

            case InputActionPhase.Canceled:
                // ボタンが離された時の処理
                _ismoveU = false;
                break;
        }
        Debug.Log("上に動く！");
    }
    public void OnDmove(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Performed:
                // ボタンが押された時の処理
                _ismoveD = true;
                break;

            case InputActionPhase.Canceled:
                // ボタンが離された時の処理
                _ismoveD = false;
                break;
        }
        Debug.Log("下に動く！");
    }

}
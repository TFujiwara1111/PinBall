using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    //ボールが見える可能性のあるz軸の最大値
    private float visiblePosZ = -6.5f;

    //ゲームオーバーを表示するテキスト
    private GameObject gameoverText;

    //ポイントを表示するテキストを宣言
    private GameObject pointText;

    //変数を初期化する。
    int score=0;

    //Use this for initialization
        void Start()
    {
        //シーンの中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");

        //ポイントテキストのオブジェクトの取得
        this.pointText = GameObject.Find("PointText");

    }

    // Update is called once per frame
    void Update()
    {
        //ボールが画面から出たとき
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverTextにゲームオーバーを表示
            this.gameoverText.GetComponent<Text>().text = "やるやん";
        }
        //pointTextに点数を表示
        pointText.GetComponent<Text>().text = score + "点";
    }

    void OnCollisionEnter(Collision other)

    { 
        if (other.gameObject.tag == "SmallStarTag")
        {
            score +=1;
        }
        else if(other.gameObject.tag == "LargeStarTag")
        {
            score +=10;
        }
    }
}

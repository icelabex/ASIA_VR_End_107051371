using UnityEngine;
using UnityEngine.UI;

public class ScoreManager :MonoBehaviour
{
    [Header("ScoreUI")]
    public Text textScore;
    [Header("Reputation")]
    public int score;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Trash")
        {
            AddScore();
            // ifで物が入った時に下記クラスの加点実行
        }
    }

    //点数の追加　下記のクォーツはヘッダーの呼び出し
    private void AddScore()
    {
        score += 5;
        //なぜかscoreだけをtextとして変換できなかったので””を使用
        textScore.text = ""+score;
    }
}
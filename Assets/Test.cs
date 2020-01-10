using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{

    private int hp = 100;   // 体力
    private int mp = 53;   // 魔力
    private int power = 25; // 攻撃力

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

    // 魔法用の関数
    public void Magic()
    {

        if (mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }

    }
    
}

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {

        Debug.Log("***************[Output Array]***************");

        // 要素数5の配列を初期化する
        int[] points = new int[5];

        // 配列の各要素に値を代入する
        points[0] = 111;
        points[1] = 222;
        points[2] = 333;
        points[3] = 444;
        points[4] = 555;

        // 配列の要素をすべて表示する
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(points[i]);
        }

        // 配列の要素をすべて表示する
        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(points[i]);
        }

        Debug.Log("***************[Boss Battle]***************");

        //■Bossが魔法を使う

        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);

        for (int i = 0; i < 11; i++)
        {
            lastboss.Magic();
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

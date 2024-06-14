//=========================================
//プレイヤークラス
//2024/6/14
//三宅歩人
//=========================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGE2
{
    internal class Player
    {
        private string name = "";               //名前
        private int hp;                         //HP
        private int atk;                        //攻撃力
        private const int MAX_PLAYER = 2;       //登録する最大人数


        //プレイヤー情報作成関数
        public void CreatePlayer()
        {
            Console.Write("名前を入力してください＞");
            name = Console.ReadLine();
            //hpとatkはstringからint型に変換
            Console.Write("HPを入力してください＞");
            int.TryParse(Console.ReadLine(), out hp);
            Console.Write("攻撃力を入力してください＞");
            int.TryParse(Console.ReadLine(), out atk);
            Console.Clear();
        }

        //プレイヤー情報表示関数
        public void ShowPlayer()
        {
            //表示する
            Console.WriteLine("名前：{0}、HP：{1}、攻撃力：{2}", name, hp, atk);
        }
    }
}
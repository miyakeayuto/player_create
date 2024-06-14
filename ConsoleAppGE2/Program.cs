//=========================================
//開発技法
//2024/6/14
//三宅歩人
//=========================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGE2
{
    internal class Program
    {
        private const int MAX_PLAYER = 2;           //プレイヤーの最大数

        static void Main(string[] args)
        {
            Player[] players = new Player[MAX_PLAYER];

            //人数分プレイヤークラスの配列をインスタンス
            for (int i = 0; i < MAX_PLAYER; i++)
            {
                players[i] = new Player();
            }

            //人数分登録関数を呼ぶ
            for (int i = 0;i < MAX_PLAYER;i++)
            {
                Console.WriteLine("{0}人目の登録", i + 1);
                players[i].CreatePlayer();
            }

            //人数分表示関数を呼ぶ
            for(int i = 0;i < MAX_PLAYER; i++)
            {
                Console.WriteLine("{0}人目", i + 1);
                players[i].ShowPlayer();
                Console.WriteLine();
            }

            //キー入力待ち
            Console.WriteLine("ENTERを押して終了");
            Console.ReadLine();
        }
    }
}

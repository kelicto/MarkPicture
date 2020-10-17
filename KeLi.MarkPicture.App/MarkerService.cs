/*
 * MIT License
 *
 * Copyright(c) 2020 KeLi
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

/*
             ,---------------------------------------------------,              ,---------,
        ,----------------------------------------------------------,          ,"        ,"|
      ,"                                                         ,"|        ,"        ,"  |
     +----------------------------------------------------------+  |      ,"        ,"    |
     |  .----------------------------------------------------.  |  |     +---------+      |
     |  | C:\>FILE -INFO                                     |  |  |     | -==----'|      |
     |  |                                                    |  |  |     |         |      |
     |  |                                                    |  |  |/----|`---=    |      |
     |  |              Author: KeLi                          |  |  |     |         |      |
     |  |              Email: kelicto@protonmail.com         |  |  |     |         |      |
     |  |              Creation Time: 04/19/2020 01:00:00 PM |  |  |     |         |      |
     |  | C:\>_                                              |  |  |     | -==----'|      |
     |  |                                                    |  |  |   ,/|==== ooo |      ;
     |  |                                                    |  |  |  // |(((( [66]|    ,"
     |  `----------------------------------------------------'  |," .;'| |((((     |  ,"
     +----------------------------------------------------------+  ;;  | |         |,"
        /_)_________________________________________________(_/  //'   | +---------+
           ___________________________/___  `,
          /  oooooooooooooooo  .o.  oooo /,   \,"-----------
         / ==ooooooooooooooo==.o.  ooo= //   ,`\--{)B     ,"
        /_==__==========__==_ooo__ooo=_/'   /___________,"
*/

using System;
using System.Linq;
using System.Threading;

using static System.DateTime;

namespace KeLi.MarkPicture.App
{
    public class MarkerService
    {
        public static void SetMarkPicture(char[] art, bool falg = false)
        {
            var colors = ((ConsoleColor[])Enum.GetValues(typeof(ConsoleColor))).ToList();

            colors.Remove(ConsoleColor.Black);

            foreach (var item in art)
            {
                var rand = new Random((int)(Now.Ticks & 0xffffffffL) | (int)(Now.Ticks >> 32));

                Console.ForegroundColor = colors[rand.Next(colors.Count)];

                while (Console.ForegroundColor == ConsoleColor.Black)
                {
                    rand = new Random((int)(Now.Ticks & 0xffffffffL) | (int)(Now.Ticks >> 32));

                    Console.ForegroundColor = colors[rand.Next(colors.Count)];
                }

                Console.Write(item);

                if (falg)
                    Thread.Sleep(5);
            }
        }

        public static char[] GetLoveArt(out int width, out int height)
        {
            width = 31;

            height = 9;

            string str = null;

            str += @"                               ";
            str += @"    @@@        @@@        @@@  ";
            str += @"  @     @    @     @    @     @";
            str += @"  @       @@         @@       @";
            str += @"   @       I  LO$VE  U       @ ";
            str += @"     @          @          @   ";
            str += @"       @      @   @      @     ";
            str += @"         @  @       @  @       ";
            str += @"           @         @        ";

            return str.ToCharArray();
        }

        public static char[] GetHelloWorldArt(out int width, out int height)
        {
            width = 82;

            height = 7;

            string str = null;

            str += @"                                                                                  ";
            str += @"  B    @. BOJ1. B.   MG    PB5UOB       M@  .@i  @0 5@1UE@  F@v1@, MG   .@u50@:  @";
            str += @"  @,   B. @i    @    MO   FB    XB       B  @M@  B 7@    U@ XG  @u MO   .B    @. B";
            str += @"  BPU1u@  B8JS  @    MN   BF     @       B5 B B YM @N     B Y@J@j  Oq   .@    BL @";
            str += @"  @    B. @:    @.   BB   i@:   @N        @B; iB@  :@:   B8 G@ .@: BM   .B   F@  L";
            str += @"  B    B  qGXZi BEqZ 7Mq0v :GG087  @      2@   @F   .OEZGL  v2  .@ 7MqN7 @XNXJ   M";
            str += @"                                  :v                                             ";

            return str.ToCharArray();
        }

        public static char[] GetBiWangArt(out int width, out int height)
        {
            width = 87;

            height = 16;

            string str = null;

            str += @"                                                                                       ";
            str += @"    .     BB        BB:         @B.    QSh0h0h0h0hzh0hzDz                              ";
            str += @"   vB@3   B@        BB:         v@B1  ,DhTl7lxTxTxT7lLISh    GB@BBBBBBB@bSBBBBB@BBBBB  ";
            str += @"     OBB  @B B@B@BBB@B@B@B@B@h    EB@.   ::YYlLTxT77;;       DBBBB@BBB@BBB@B@BBBBBBBE  ";
            str += @"        ,0BB  ,     E@:     ,      7T    BB...:.:..,hBz                 BB             ";
            str += @"     .CBBB@B        bB                   B@::;:;:;::hB1                 @B             ";
            str += @"  .BBBBY  B@  BBBBB@B@BBB@BBh ,BB@E@     ZhiYYLYYY7iJD:                 BB             ";
            str += @"   DL     BB  TBY,,. ,,....:   033BB,  .::::::.,,::::::;                BB             ";
            str += @"              .BB                 B@   1BBYxVYzBBvTTllB@      B@BBBBB@BBB@BBBBBBBBBB   ";
            str += @"  BBBB@BBB@B@B@BBBBB@BBBBBBBBD    BB   JBY    ,Bb     BB      .;::::::,:BB:..:::::::   ";
            str += @"            vBBBB:      ,3v ,     BB   VBBEBBEBBBOB@BOB@                B@             ";
            str += @"          iBBI  GBY   YBBBG       BB   VB:     Bh     BB                BB             ";
            str += @"      iQBBB@     :BBBBO:          BB   JBBE@BBBBB@BBBEBB                BB             ";
            str += @"  cB@B@B:iBJ    :l lBB@v        ;B@BB, .5.            II               ,@B,          , ";
            str += @"  ;B2,   vBB0BB@BB   ,C@BBBBB, BB@  B@BBCvvYLY7vYYLYYi;3Q@ ;B@BBBBB@B@BBBBBBBBBBBBBBBBU";
            str += @"         E@B@I:          ,v0T  ET     ihDB@BBB@B@BBB@B@BBO  :.........,.,,,..........:";

            return str.ToCharArray();
        }

        public static char[] Get520Art(out int width, out int height)
        {
            width = 89;

            height = 10;

            string str = null;

            str += @"                                                                                         ";
            str += @"   MB@B@B@B@   MB@8E@@Br     nB@0@B8       v@B@     :B@B8D@BS      i9@B           XB@i   ";
            str += @"   9@cylYYU.   B@,   B@B,   EB@   @B@   r@B@B@B     1@D   X@B8  ;B@B@B@          BB@@i   ";
            str += @"   9@                @@@   .B@O   1@Bv  Lv .@@D           S@@;  ic  B@B         @bfB@:   ";
            str += @"   B@7cwn.          @B@    U@BC   LB@0     :@@G        iL@Bm        @B@       ,@8 C@B:   ";
            str += @"   .sYc0B@BU       @BC     C@@m   7@B8     :@BD       ,EG@@Mv      ,B@@      ;@L  qB@, : ";
            str += @"         B@B.    i@B       7@BX   YB@Y     ;B@G           r@BD      @B@     .@BMG9B@BDB@,";
            str += @"   Y.    @B@,   p@7    Mr   B@B   9@B      .@B9     ;y     B@B      B@B        ,, MB@;   ";
            str += @"  vB@s,,0@@s   B@B@B@B@BC   iB@C,y@B:    ::@B@Bv:,  @@B;,:@@B,   :;M@B@l;.        B@Bf   ";
            str += @"   iUDMG8v     OYYnUUsUw,     rGE9v     .q02nlsXSv  ,rpDMGX.     0qXyLYp0Y       rwLYC. ";

            return str.ToArray();
        }

        public static char[] GetKissArt(out int width, out int height)
        {
            width = 42;

            height = 14;

            string str = null;

            str += @"                                          ";
            str += @"             .,,,,,,,,,,.                 ";
            str += @"           ,;;;;;;;;;;;;;;,               ";
            str += @"         ,;;;;;;;;;;;)));;(((,,;;;,,_     ";
            str += @"        ,;;;;;;;;;;'      |)))))))))))\\  ";
            str += @"        ;;;;;;/ )''    - /,)))((((((((((\ ";
            str += @"        ;;;;' \        ~|\  ))))))))))))))";
            str += @"        /     /         |   ((((((((((((((";
            str += @"      /'      \      _/~'    ')|()))))))))";
            str += @"    /'         `\   />     o_/)))(((((((( ";
            str += @"   /          /' `~~(____ /  ())))))))))) ";
            str += @"  |     ---,   \        \     ((((((((((  ";
            str += @"            `\   \~-_____|      ))))))))  ";
            str += @"              `\  |      |_.---.  \      ";

            return str.ToArray();
        }

        public static char[] GetNeverBugArt(out int width, out int height)
        {
            width = 47;

            height = 21;

            string str = null;

            str += @"                                               ";
            str += @"                     _ooOoo_                   ";
            str += @"                    o8888888o                  ";
            str += @"                    88' . '88                  ";
            str += @"                    (| -_- |)                  ";
            str += @"                    O\  =  /O                  ";
            str += @"                 ____/'---'\____               ";
            str += @"               .'  \\|     |//  '.             ";
            str += @"              /  \\|||  :  |||//  \            ";
            str += @"             /  _||||| -:- |||||-  \           ";
            str += @"             |   | \\\  -  /// |   |           ";
            str += @"             | \_|  ''\---/''  |   |           ";
            str += @"             \ .-\___  ---  ___/-. /           ";
            str += @"           ___-. .'  /--.--\  '. .-___         ";
            str += @"        .''''<  '.___\_<|>_/___.'  >''''.      ";
            str += @"       | | :  -- \-.;-\ _ /-;.-/ - - : | |     ";
            str += @"       \  \ --.   \_ __\ /__ _/   .-- /  /     ";
            str += @"  ======'-.____--.___\_____/___.--____.-'======";
            str += @"                     '=---='                   ";
            str += @"  ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^";
            str += @"             Buddha Bless, Never Bug          ";

            return str.ToArray();
        }
    }
}
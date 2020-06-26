﻿using System;
using System.Collections;
using System.Text;
using System.Text.RegularExpressions;

namespace EntFrm.Framework.Utility
{
    /// <summary>
    /// 汉字转拼音类
    /// </summary>
    public class PinYinHelper
    {

        /// <summary>
        /// 获取中文全拼
        /// </summary>
        public static string GetPinYinValue1(string Chstr)
        {

            int[] iA = new int[]

             {

                 -20319 ,-20317 ,-20304 ,-20295 ,-20292 ,-20283 ,-20265 ,-20257 ,-20242 ,-20230

                 ,-20051 ,-20036 ,-20032 ,-20026 ,-20002 ,-19990 ,-19986 ,-19982 ,-19976 ,-19805

                 ,-19784 ,-19775 ,-19774 ,-19763 ,-19756 ,-19751 ,-19746 ,-19741 ,-19739 ,-19728

                 ,-19725 ,-19715 ,-19540 ,-19531 ,-19525 ,-19515 ,-19500 ,-19484 ,-19479 ,-19467

                 ,-19289 ,-19288 ,-19281 ,-19275 ,-19270 ,-19263 ,-19261 ,-19249 ,-19243 ,-19242

                 ,-19238 ,-19235 ,-19227 ,-19224 ,-19218 ,-19212 ,-19038 ,-19023 ,-19018 ,-19006

                 ,-19003 ,-18996 ,-18977 ,-18961 ,-18952 ,-18783 ,-18774 ,-18773 ,-18763 ,-18756

                 ,-18741 ,-18735 ,-18731 ,-18722 ,-18710 ,-18697 ,-18696 ,-18526 ,-18518 ,-18501

                 ,-18490 ,-18478 ,-18463 ,-18448 ,-18447 ,-18446 ,-18239 ,-18237 ,-18231 ,-18220

                 ,-18211 ,-18201 ,-18184 ,-18183 ,-18181 ,-18012 ,-17997 ,-17988 ,-17970 ,-17964

                 ,-17961 ,-17950 ,-17947 ,-17931 ,-17928 ,-17922 ,-17759 ,-17752 ,-17733 ,-17730

                 ,-17721 ,-17703 ,-17701 ,-17697 ,-17692 ,-17683 ,-17676 ,-17496 ,-17487 ,-17482

                 ,-17468 ,-17454 ,-17433 ,-17427 ,-17417 ,-17202 ,-17185 ,-16983 ,-16970 ,-16942

                 ,-16915 ,-16733 ,-16708 ,-16706 ,-16689 ,-16664 ,-16657 ,-16647 ,-16474 ,-16470

                 ,-16465 ,-16459 ,-16452 ,-16448 ,-16433 ,-16429 ,-16427 ,-16423 ,-16419 ,-16412

                 ,-16407 ,-16403 ,-16401 ,-16393 ,-16220 ,-16216 ,-16212 ,-16205 ,-16202 ,-16187

                 ,-16180 ,-16171 ,-16169 ,-16158 ,-16155 ,-15959 ,-15958 ,-15944 ,-15933 ,-15920

                 ,-15915 ,-15903 ,-15889 ,-15878 ,-15707 ,-15701 ,-15681 ,-15667 ,-15661 ,-15659

                 ,-15652 ,-15640 ,-15631 ,-15625 ,-15454 ,-15448 ,-15436 ,-15435 ,-15419 ,-15416

                 ,-15408 ,-15394 ,-15385 ,-15377 ,-15375 ,-15369 ,-15363 ,-15362 ,-15183 ,-15180

                 ,-15165 ,-15158 ,-15153 ,-15150 ,-15149 ,-15144 ,-15143 ,-15141 ,-15140 ,-15139

                 ,-15128 ,-15121 ,-15119 ,-15117 ,-15110 ,-15109 ,-14941 ,-14937 ,-14933 ,-14930

                 ,-14929 ,-14928 ,-14926 ,-14922 ,-14921 ,-14914 ,-14908 ,-14902 ,-14894 ,-14889

                 ,-14882 ,-14873 ,-14871 ,-14857 ,-14678 ,-14674 ,-14670 ,-14668 ,-14663 ,-14654

                 ,-14645 ,-14630 ,-14594 ,-14429 ,-14407 ,-14399 ,-14384 ,-14379 ,-14368 ,-14355

                 ,-14353 ,-14345 ,-14170 ,-14159 ,-14151 ,-14149 ,-14145 ,-14140 ,-14137 ,-14135

                 ,-14125 ,-14123 ,-14122 ,-14112 ,-14109 ,-14099 ,-14097 ,-14094 ,-14092 ,-14090

                 ,-14087 ,-14083 ,-13917 ,-13914 ,-13910 ,-13907 ,-13906 ,-13905 ,-13896 ,-13894

                 ,-13878 ,-13870 ,-13859 ,-13847 ,-13831 ,-13658 ,-13611 ,-13601 ,-13406 ,-13404

                 ,-13400 ,-13398 ,-13395 ,-13391 ,-13387 ,-13383 ,-13367 ,-13359 ,-13356 ,-13343

                 ,-13340 ,-13329 ,-13326 ,-13318 ,-13147 ,-13138 ,-13120 ,-13107 ,-13096 ,-13095

                 ,-13091 ,-13076 ,-13068 ,-13063 ,-13060 ,-12888 ,-12875 ,-12871 ,-12860 ,-12858

                 ,-12852 ,-12849 ,-12838 ,-12831 ,-12829 ,-12812 ,-12802 ,-12607 ,-12597 ,-12594

                 ,-12585 ,-12556 ,-12359 ,-12346 ,-12320 ,-12300 ,-12120 ,-12099 ,-12089 ,-12074

                 ,-12067 ,-12058 ,-12039 ,-11867 ,-11861 ,-11847 ,-11831 ,-11798 ,-11781 ,-11604

                 ,-11589 ,-11536 ,-11358 ,-11340 ,-11339 ,-11324 ,-11303 ,-11097 ,-11077 ,-11067

                 ,-11055 ,-11052 ,-11045 ,-11041 ,-11038 ,-11024 ,-11020 ,-11019 ,-11018 ,-11014

                 ,-10838 ,-10832 ,-10815 ,-10800 ,-10790 ,-10780 ,-10764 ,-10587 ,-10544 ,-10533

                 ,-10519 ,-10331 ,-10329 ,-10328 ,-10322 ,-10315 ,-10309 ,-10307 ,-10296 ,-10281

                 ,-10274 ,-10270 ,-10262 ,-10260 ,-10256 ,-10254

             };

            string[] sA = new string[]

         {

             "a","ai","an","ang","ao"



             ,"ba","bai","ban","bang","bao","bei","ben","beng","bi","bian","biao","bie","bin"

             ,"bing","bo","bu"



             ,"ca","cai","can","cang","cao","ce","ceng","cha","chai","chan","chang","chao","che"

             ,"chen","cheng","chi","chong","chou","chu","chuai","chuan","chuang","chui","chun"

             ,"chuo","ci","cong","cou","cu","cuan","cui","cun","cuo"



             ,"da","dai","dan","dang","dao","de","deng","di","dian","diao","die","ding","diu"

             ,"dong","dou","du","duan","dui","dun","duo"



             ,"e","en","er"



             ,"fa","fan","fang","fei","fen","feng","fo","fou","fu"



             ,"ga","gai","gan","gang","gao","ge","gei","gen","geng","gong","gou","gu","gua","guai"

             ,"guan","guang","gui","gun","guo"



             ,"ha","hai","han","hang","hao","he","hei","hen","heng","hong","hou","hu","hua","huai"

             ,"huan","huang","hui","hun","huo"



             ,"ji","jia","jian","jiang","jiao","jie","jin","jing","jiong","jiu","ju","juan","jue"

             ,"jun"



             ,"ka","kai","kan","kang","kao","ke","ken","keng","kong","kou","ku","kua","kuai","kuan"

             ,"kuang","kui","kun","kuo"



             ,"la","lai","lan","lang","lao","le","lei","leng","li","lia","lian","liang","liao","lie"

             ,"lin","ling","liu","long","lou","lu","lv","luan","lue","lun","luo"



             ,"ma","mai","man","mang","mao","me","mei","men","meng","mi","mian","miao","mie","min"

             ,"ming","miu","mo","mou","mu"



             ,"na","nai","nan","nang","nao","ne","nei","nen","neng","ni","nian","niang","niao","nie"

             ,"nin","ning","niu","nong","nu","nv","nuan","nue","nuo"



             ,"o","ou"



             ,"pa","pai","pan","pang","pao","pei","pen","peng","pi","pian","piao","pie","pin","ping"

             ,"po","pu"



             ,"qi","qia","qian","qiang","qiao","qie","qin","qing","qiong","qiu","qu","quan","que"

             ,"qun"



             ,"ran","rang","rao","re","ren","reng","ri","rong","rou","ru","ruan","rui","run","ruo"



             ,"sa","sai","san","sang","sao","se","sen","seng","sha","shai","shan","shang","shao","she"

             ,"shen","sheng","shi","shou","shu","shua","shuai","shuan","shuang","shui","shun","shuo","si"

             ,"song","sou","su","suan","sui","sun","suo"



             ,"ta","tai","tan","tang","tao","te","teng","ti","tian","tiao","tie","ting","tong","tou","tu"

             ,"tuan","tui","tun","tuo"



             ,"wa","wai","wan","wang","wei","wen","weng","wo","wu"



             ,"xi","xia","xian","xiang","xiao","xie","xin","xing","xiong","xiu","xu","xuan","xue","xun"



             ,"ya","yan","yang","yao","ye","yi","yin","ying","yo","yong","you","yu","yuan","yue","yun"



             ,"za","zai","zan","zang","zao","ze","zei","zen","zeng","zha","zhai","zhan","zhang","zhao"

             ,"zhe","zhen","zheng","zhi","zhong","zhou","zhu","zhua","zhuai","zhuan","zhuang","zhui"

             ,"zhun","zhuo","zi","zong","zou","zu","zuan","zui","zun","zuo"

         };

            byte[] B = new byte[2];

            string s = "";

            char[] c = Chstr.ToCharArray();

            for (int j = 0; j < c.Length; j++)
            {

                B = System.Text.Encoding.Default.GetBytes(c[j].ToString());

                if ((int)(B[0]) <= 160 && (int)(B[0]) >= 0)
                {

                    s += c[j];

                }

                else
                {

                    for (int i = (iA.Length - 1); i >= 0; i--)
                    {

                        if (iA[i] <= (int)(B[0]) * 256 + (int)(B[1]) - 65536)
                        {

                            s += sA[i];

                            break;

                        }

                    }

                }

            }
            return s;
        }


        //定义拼音区编码数组
        private static int[] getValue = new int[]
            {
                -20319,-20317,-20304,-20295,-20292,-20283,-20265,-20257,-20242,-20230,-20051,-20036,
                -20032,-20026,-20002,-19990,-19986,-19982,-19976,-19805,-19784,-19775,-19774,-19763,
                -19756,-19751,-19746,-19741,-19739,-19728,-19725,-19715,-19540,-19531,-19525,-19515,
                -19500,-19484,-19479,-19467,-19289,-19288,-19281,-19275,-19270,-19263,-19261,-19249,
                -19243,-19242,-19238,-19235,-19227,-19224,-19218,-19212,-19038,-19023,-19018,-19006,
                -19003,-18996,-18977,-18961,-18952,-18783,-18774,-18773,-18763,-18756,-18741,-18735,
                -18731,-18722,-18710,-18697,-18696,-18526,-18518,-18501,-18490,-18478,-18463,-18448,
                -18447,-18446,-18239,-18237,-18231,-18220,-18211,-18201,-18184,-18183, -18181,-18012,
                -17997,-17988,-17970,-17964,-17961,-17950,-17947,-17931,-17928,-17922,-17759,-17752,
                -17733,-17730,-17721,-17703,-17701,-17697,-17692,-17683,-17676,-17496,-17487,-17482,
                -17468,-17454,-17433,-17427,-17417,-17202,-17185,-16983,-16970,-16942,-16915,-16733,
                -16708,-16706,-16689,-16664,-16657,-16647,-16474,-16470,-16465,-16459,-16452,-16448,
                -16433,-16429,-16427,-16423,-16419,-16412,-16407,-16403,-16401,-16393,-16220,-16216,
                -16212,-16205,-16202,-16187,-16180,-16171,-16169,-16158,-16155,-15959,-15958,-15944,
                -15933,-15920,-15915,-15903,-15889,-15878,-15707,-15701,-15681,-15667,-15661,-15659,
                -15652,-15640,-15631,-15625,-15454,-15448,-15436,-15435,-15419,-15416,-15408,-15394,
                -15385,-15377,-15375,-15369,-15363,-15362,-15183,-15180,-15165,-15158,-15153,-15150,
                -15149,-15144,-15143,-15141,-15140,-15139,-15128,-15121,-15119,-15117,-15110,-15109,
                -14941,-14937,-14933,-14930,-14929,-14928,-14926,-14922,-14921,-14914,-14908,-14902,
                -14894,-14889,-14882,-14873,-14871,-14857,-14678,-14674,-14670,-14668,-14663,-14654,
                -14645,-14630,-14594,-14429,-14407,-14399,-14384,-14379,-14368,-14355,-14353,-14345,
                -14170,-14159,-14151,-14149,-14145,-14140,-14137,-14135,-14125,-14123,-14122,-14112,
                -14109,-14099,-14097,-14094,-14092,-14090,-14087,-14083,-13917,-13914,-13910,-13907,
                -13906,-13905,-13896,-13894,-13878,-13870,-13859,-13847,-13831,-13658,-13611,-13601,
                -13406,-13404,-13400,-13398,-13395,-13391,-13387,-13383,-13367,-13359,-13356,-13343,
                -13340,-13329,-13326,-13318,-13147,-13138,-13120,-13107,-13096,-13095,-13091,-13076,
                -13068,-13063,-13060,-12888,-12875,-12871,-12860,-12858,-12852,-12849,-12838,-12831,
                -12829,-12812,-12802,-12607,-12597,-12594,-12585,-12556,-12359,-12346,-12320,-12300,
                -12120,-12099,-12089,-12074,-12067,-12058,-12039,-11867,-11861,-11847,-11831,-11798,
                -11781,-11604,-11589,-11536,-11358,-11340,-11339,-11324,-11303,-11097,-11077,-11067,
                -11055,-11052,-11045,-11041,-11038,-11024,-11020,-11019,-11018,-11014,-10838,-10832,
                -10815,-10800,-10790,-10780,-10764,-10587,-10544,-10533,-10519,-10331,-10329,-10328,
                -10322,-10315,-10309,-10307,-10296,-10281,-10274,-10270,-10262,-10260,-10256,-10254
            };

        //定义拼音数组
        private static string[] getName = new string[]
            {
                "A","Ai","An","Ang","Ao","Ba","Bai","Ban","Bang","Bao","Bei","Ben",
                "Beng","Bi","Bian","Biao","Bie","Bin","Bing","Bo","Bu","Ba","Cai","Can",
                "Cang","Cao","Ce","Ceng","Cha","Chai","Chan","Chang","Chao","Che","Chen","Cheng",
                "Chi","Chong","Chou","Chu","Chuai","Chuan","Chuang","Chui","Chun","Chuo","Ci","Cong",
                "Cou","Cu","Cuan","Cui","Cun","Cuo","Da","Dai","Dan","Dang","Dao","De",
                "Deng","Di","Dian","Diao","Die","Ding","Diu","Dong","Dou","Du","Duan","Dui",
                "Dun","Duo","E","En","Er","Fa","Fan","Fang","Fei","Fen","Feng","Fo",
                "Fou","Fu","Ga","Gai","Gan","Gang","Gao","Ge","Gei","Gen","Geng","Gong",
                "Gou","Gu","Gua","Guai","Guan","Guang","Gui","Gun","Guo","Ha","Hai","Han",
                "Hang","Hao","He","Hei","Hen","Heng","Hong","Hou","Hu","Hua","Huai","Huan",
                "Huang","Hui","Hun","Huo","Ji","Jia","Jian","Jiang","Jiao","Jie","Jin","Jing",
                "Jiong","Jiu","Ju","Juan","Jue","Jun","Ka","Kai","Kan","Kang","Kao","Ke",
                "Ken","Keng","Kong","Kou","Ku","Kua","Kuai","Kuan","Kuang","Kui","Kun","Kuo",
                "La","Lai","Lan","Lang","Lao","Le","Lei","Leng","Li","Lia","Lian","Liang",
                "Liao","Lie","Lin","Ling","Liu","Long","Lou","Lu","Lv","Luan","Lue","Lun",
                "Luo","Ma","Mai","Man","Mang","Mao","Me","Mei","Men","Meng","Mi","Mian",
                "Miao","Mie","Min","Ming","Miu","Mo","Mou","Mu","Na","Nai","Nan","Nang",
                "Nao","Ne","Nei","Nen","Neng","Ni","Nian","Niang","Niao","Nie","Nin","Ning",
                "Niu","Nong","Nu","Nv","Nuan","Nue","Nuo","O","Ou","Pa","Pai","Pan",
                "Pang","Pao","Pei","Pen","Peng","Pi","Pian","Piao","Pie","Pin","Ping","Po",
                "Pu","Qi","Qia","Qian","Qiang","Qiao","Qie","Qin","Qing","Qiong","Qiu","Qu",
                "Quan","Que","Qun","Ran","Rang","Rao","Re","Ren","Reng","Ri","Rong","Rou",
                "Ru","Ruan","Rui","Run","Ruo","Sa","Sai","San","Sang","Sao","Se","Sen",
                "Seng","Sha","Shai","Shan","Shang","Shao","She","Shen","Sheng","Shi","Shou","Shu",
                "Shua","Shuai","Shuan","Shuang","Shui","Shun","Shuo","Si","Song","Sou","Su","Suan",
                "Sui","Sun","Suo","Ta","Tai","Tan","Tang","Tao","Te","Teng","Ti","Tian",
                "Tiao","Tie","Ting","Tong","Tou","Tu","Tuan","Tui","Tun","Tuo","Wa","Wai",
                "Wan","Wang","Wei","Wen","Weng","Wo","Wu","Xi","Xia","Xian","Xiang","Xiao",
                "Xie","Xin","Xing","Xiong","Xiu","Xu","Xuan","Xue","Xun","Ya","Yan","Yang",
                "Yao","Ye","Yi","Yin","Ying","Yo","Yong","You","Yu","Yuan","Yue","Yun",
                "Za", "Zai","Zan","Zang","Zao","Ze","Zei","Zen","Zeng","Zha","Zhai","Zhan",
                "Zhang","Zhao","Zhe","Zhen","Zheng","Zhi","Zhong","Zhou","Zhu","Zhua","Zhuai","Zhuan",
                "Zhuang","Zhui","Zhun","Zhuo","Zi","Zong","Zou","Zu","Zuan","Zui","Zun","Zuo"
           };

        /// <summary>
        /// 汉字转换成全拼的拼音
        /// </summary>
        /// <param name="Chstr">汉字字符串</param>
        /// <returns>转换后的拼音字符串</returns>
        public static string GetPinYinValue2(string Chstr)
        {
            Regex reg = new Regex("^[\u4e00-\u9fa5]$");//验证是否输入汉字
            byte[] arr = new byte[2];
            string pystr = "";
            int asc = 0, M1 = 0, M2 = 0;
            char[] mChar = Chstr.ToCharArray();//获取汉字对应的字符数组
            for (int j = 0; j < mChar.Length; j++)
            {
                //如果输入的是汉字
                if (reg.IsMatch(mChar[j].ToString()))
                {
                    arr = System.Text.Encoding.Default.GetBytes(mChar[j].ToString());
                    M1 = (short)(arr[0]);
                    M2 = (short)(arr[1]);
                    asc = M1 * 256 + M2 - 65536;
                    if (asc > 0 && asc < 160)
                    {
                        pystr += mChar[j];
                    }
                    else
                    {
                        switch (asc)
                        {
                            case -9254:
                                pystr += "Zhen"; break;
                            case -8985:
                                pystr += "Qian"; break;
                            case -5463:
                                pystr += "Jia"; break;
                            case -8274:
                                pystr += "Ge"; break;
                            case -5448:
                                pystr += "Ga"; break;
                            case -5447:
                                pystr += "La"; break;
                            case -4649:
                                pystr += "Chen"; break;
                            case -5436:
                                pystr += "Mao"; break;
                            case -5213:
                                pystr += "Mao"; break;
                            case -3597:
                                pystr += "Die"; break;
                            case -5659:
                                pystr += "Tian"; break;
                            default:
                                for (int i = (getValue.Length - 1); i >= 0; i--)
                                {
                                    if (getValue[i] <= asc) //判断汉字的拼音区编码是否在指定范围内
                                    {
                                        pystr += getName[i];//如果不超出范围则获取对应的拼音
                                        break;
                                    }
                                }
                                break;
                        }
                    }
                }
                else//如果不是汉字
                {
                    pystr += mChar[j].ToString();//如果不是汉字则返回
                }
            }
            return pystr;//返回获取到的汉字拼音
        }

        ///// <summary>
        ///// 取汉字拼音的首字母
        ///// </summary>
        ///// <param name="Chstr">汉字</param>
        ///// <returns>首字母</returns>
        //public static string GetPinYinCode(string Chstr)
        //{
        //    int i = 0;
        //    ushort key = 0;
        //    string strResult = string.Empty;

        //    Encoding unicode = Encoding.Unicode;
        //    Encoding gbk = Encoding.GetEncoding(936);
        //    byte[] unicodeBytes = unicode.GetBytes(Chstr);
        //    byte[] gbkBytes = Encoding.Convert(unicode, gbk, unicodeBytes);
        //    while (i < gbkBytes.Length)
        //    {
        //        if (gbkBytes[i] <= 127)
        //        {
        //            strResult = strResult + (char)gbkBytes[i];
        //            i++;
        //        }
        //        #region 生成汉字拼音简码,取拼音首字母
        //        else
        //        {
        //            key = (ushort)(gbkBytes[i] * 256 + gbkBytes[i + 1]);
        //            if (key >= '\uB0A1' && key <= '\uB0C4')
        //            {
        //                strResult = strResult + "A";
        //            }
        //            else if (key >= '\uB0C5' && key <= '\uB2C0')
        //            {
        //                strResult = strResult + "B";
        //            }
        //            else if (key >= '\uB2C1' && key <= '\uB4ED')
        //            {
        //                strResult = strResult + "C";
        //            }
        //            else if (key >= '\uB4EE' && key <= '\uB6E9')
        //            {
        //                strResult = strResult + "D";
        //            }
        //            else if (key >= '\uB6EA' && key <= '\uB7A1')
        //            {
        //                strResult = strResult + "E";
        //            }
        //            else if (key >= '\uB7A2' && key <= '\uB8C0')
        //            {
        //                strResult = strResult + "F";
        //            }
        //            else if (key >= '\uB8C1' && key <= '\uB9FD')
        //            {
        //                strResult = strResult + "G";
        //            }
        //            else if (key >= '\uB9FE' && key <= '\uBBF6')
        //            {
        //                strResult = strResult + "H";
        //            }
        //            else if (key >= '\uBBF7' && key <= '\uBFA5')
        //            {
        //                strResult = strResult + "J";
        //            }
        //            else if (key >= '\uBFA6' && key <= '\uC0AB')
        //            {
        //                strResult = strResult + "K";
        //            }
        //            else if (key >= '\uC0AC' && key <= '\uC2E7')
        //            {
        //                strResult = strResult + "L";
        //            }
        //            else if (key >= '\uC2E8' && key <= '\uC4C2')
        //            {
        //                strResult = strResult + "M";
        //            }
        //            else if (key >= '\uC4C3' && key <= '\uC5B5')
        //            {
        //                strResult = strResult + "N";
        //            }
        //            else if (key >= '\uC5B6' && key <= '\uC5BD')
        //            {
        //                strResult = strResult + "O";
        //            }
        //            else if (key >= '\uC5BE' && key <= '\uC6D9')
        //            {
        //                strResult = strResult + "P";
        //            }
        //            else if (key >= '\uC6DA' && key <= '\uC8BA')
        //            {
        //                strResult = strResult + "Q";
        //            }
        //            else if (key >= '\uC8BB' && key <= '\uC8F5')
        //            {
        //                strResult = strResult + "R";
        //            }
        //            else if (key >= '\uC8F6' && key <= '\uCBF9')
        //            {
        //                strResult = strResult + "S";
        //            }
        //            else if (key >= '\uCBFA' && key <= '\uCDD9')
        //            {
        //                strResult = strResult + "T";
        //            }
        //            else if (key >= '\uCDDA' && key <= '\uCEF3')
        //            {
        //                strResult = strResult + "W";
        //            }
        //            else if (key >= '\uCEF4' && key <= '\uD188')
        //            {
        //                strResult = strResult + "X";
        //            }
        //            else if (key >= '\uD1B9' && key <= '\uD4D0')
        //            {
        //                strResult = strResult + "Y";
        //            }
        //            else if (key >= '\uD4D1' && key <= '\uD7F9')
        //            {
        //                strResult = strResult + "Z";
        //            }
        //            else
        //            {
        //                strResult = strResult + "?";
        //            }
        //            i = i + 2;
        //        }
        //        #endregion
        //    }
        //    return strResult;
        //}

        private static Hashtable second_class_HZ = new Hashtable();
        /// <summary>
        /// 提取汉字首字母
        /// </summary>
        /// <param name="strText">需要转换的字</param>
        /// <returns>转换结果</returns>
        public static string GetPinYinCode(string strText)
        {
            if (second_class_HZ.Count == 0)
            {
                init_hastable();//首次使用该过程需要初始化特殊二类汉字字库。
            }

            int len = strText.Length;
            string myStr = "";
            for (int i = 0; i < len; i++)
            {
                myStr += getSpell(strText.Substring(i, 1));
            }
            return myStr;
        }
        /// <summary>
        /// 获取单个汉字的首拼音
        /// </summary>
        /// <param name="myChar">需要转换的字符</param>
        /// <returns>转换结果</returns>
        private static string getSpell(string myChar)
        {
            byte[] arrCN = System.Text.Encoding.Default.GetBytes(myChar);
            if (arrCN.Length > 1)
            {
                int area = (short)arrCN[0];
                int pos = (short)arrCN[1];
                int code = (area << 8) + pos;
                int[] areacode = { 45217, 45253, 45761, 46318, 46826, 47010, 47297, 47614, 48119,
          48119, 49062, 49324, 49896, 50371, 50614, 50622, 50906, 51387, 51446, 52218,
          52698, 52698, 52698, 52980, 53689, 54481 };
                for (int i = 0; i < 26; i++)
                {
                    int max = 55290;
                    if (i != 25) max = areacode[i + 1];
                    if (areacode[i] <= code && code < max)
                    {
                        return System.Text.Encoding.Default.GetString(new byte[] { (byte)(65 + i) });
                    }
                }
                if (second_class_HZ.Contains(myChar))
                    return Convert.ToString(second_class_HZ[myChar]);
                return "_";
            }
            else return myChar;
        }
        private static void init_hastable()
        {
            second_class_HZ.Add("谙", "A");
            second_class_HZ.Add("坳", "A");
            second_class_HZ.Add("埯", "A");
            second_class_HZ.Add("捱", "A");
            second_class_HZ.Add("揞", "A");
            second_class_HZ.Add("吖", "A");
            second_class_HZ.Add("嗷", "A");
            second_class_HZ.Add("嗄", "A");
            second_class_HZ.Add("嗳", "A");
            second_class_HZ.Add("嗌", "A");
            second_class_HZ.Add("岙", "A");
            second_class_HZ.Add("犴", "A");
            second_class_HZ.Add("庵", "A");
            second_class_HZ.Add("廒", "A");
            second_class_HZ.Add("遨", "A");
            second_class_HZ.Add("媪", "A");
            second_class_HZ.Add("嫒", "A");
            second_class_HZ.Add("骜", "A");
            second_class_HZ.Add("瑷", "A");
            second_class_HZ.Add("桉", "A");
            second_class_HZ.Add("獒", "A");
            second_class_HZ.Add("暧", "A");
            second_class_HZ.Add("砹", "A");
            second_class_HZ.Add("铵", "A");
            second_class_HZ.Add("锕", "A");
            second_class_HZ.Add("锿", "A");
            second_class_HZ.Add("鹌", "A");
            second_class_HZ.Add("聱", "A");
            second_class_HZ.Add("螯", "A");
            second_class_HZ.Add("霭", "A");
            second_class_HZ.Add("鏊", "A");
            second_class_HZ.Add("鳌", "A");
            second_class_HZ.Add("鏖", "A");
            second_class_HZ.Add("黯", "A");
            second_class_HZ.Add("匕", "B");
            second_class_HZ.Add("孛", "B");
            second_class_HZ.Add("匾", "B");
            second_class_HZ.Add("俾", "B");
            second_class_HZ.Add("傧", "B");
            second_class_HZ.Add("勹", "B");
            second_class_HZ.Add("亳", "B");
            second_class_HZ.Add("禀", "B");
            second_class_HZ.Add("阪", "B");
            second_class_HZ.Add("陂", "B");
            second_class_HZ.Add("邴", "B");
            second_class_HZ.Add("邶", "B");
            second_class_HZ.Add("弁", "B");
            second_class_HZ.Add("畚", "B");
            second_class_HZ.Add("坌", "B");
            second_class_HZ.Add("坂", "B");
            second_class_HZ.Add("苄", "B");
            second_class_HZ.Add("茇", "B");
            second_class_HZ.Add("荜", "B");
            second_class_HZ.Add("荸", "B");
            second_class_HZ.Add("菝", "B");
            second_class_HZ.Add("萆", "B");
            second_class_HZ.Add("葆", "B");
            second_class_HZ.Add("蓓", "B");
            second_class_HZ.Add("蒡", "B");
            second_class_HZ.Add("薜", "B");
            second_class_HZ.Add("捭", "B");
            second_class_HZ.Add("摒", "B");
            second_class_HZ.Add("卟", "B");
            second_class_HZ.Add("吡", "B");
            second_class_HZ.Add("呗", "B");
            second_class_HZ.Add("哔", "B");
            second_class_HZ.Add("啵", "B");
            second_class_HZ.Add("嘣", "B");
            second_class_HZ.Add("岜", "B");
            second_class_HZ.Add("豳", "B");
            second_class_HZ.Add("狴", "B");
            second_class_HZ.Add("饽", "B");
            second_class_HZ.Add("庳", "B");
            second_class_HZ.Add("忭", "B");
            second_class_HZ.Add("悖", "B");
            second_class_HZ.Add("愎", "B");
            second_class_HZ.Add("汴", "B");
            second_class_HZ.Add("浜", "B");
            second_class_HZ.Add("滗", "B");
            second_class_HZ.Add("濞", "B");
            second_class_HZ.Add("灞", "B");
            second_class_HZ.Add("宀", "B");
            second_class_HZ.Add("逋", "B");
            second_class_HZ.Add("弼", "B");
            second_class_HZ.Add("妣", "B");
            second_class_HZ.Add("婊", "B");
            second_class_HZ.Add("婢", "B");
            second_class_HZ.Add("嬖", "B");
            second_class_HZ.Add("孢", "B");
            second_class_HZ.Add("骠", "B");
            second_class_HZ.Add("缏", "B");
            second_class_HZ.Add("缤", "B");
            second_class_HZ.Add("玢", "B");
            second_class_HZ.Add("璧", "B");
            second_class_HZ.Add("槟", "B");
            second_class_HZ.Add("檗", "B");
            second_class_HZ.Add("殡", "B");
            second_class_HZ.Add("瓿", "B");
            second_class_HZ.Add("甏", "B");
            second_class_HZ.Add("晡", "B");
            second_class_HZ.Add("贲", "B");
            second_class_HZ.Add("掰", "B");
            second_class_HZ.Add("擘", "B");
            second_class_HZ.Add("膑", "B");
            second_class_HZ.Add("飑", "B");
            second_class_HZ.Add("飙", "B");
            second_class_HZ.Add("飚", "B");
            second_class_HZ.Add("煲", "B");
            second_class_HZ.Add("煸", "B");
            second_class_HZ.Add("砭", "B");
            second_class_HZ.Add("碚", "B");
            second_class_HZ.Add("碥", "B");
            second_class_HZ.Add("礴", "B");
            second_class_HZ.Add("畀", "B");
            second_class_HZ.Add("钚", "B");
            second_class_HZ.Add("钣", "B");
            second_class_HZ.Add("钯", "B");
            second_class_HZ.Add("钸", "B");
            second_class_HZ.Add("钹", "B");
            second_class_HZ.Add("铋", "B");
            second_class_HZ.Add("锛", "B");
            second_class_HZ.Add("镔", "B");
            second_class_HZ.Add("镖", "B");
            second_class_HZ.Add("镳", "B");
            second_class_HZ.Add("秕", "B");
            second_class_HZ.Add("鸨", "B");
            second_class_HZ.Add("鹁", "B");
            second_class_HZ.Add("鹎", "B");
            second_class_HZ.Add("疒", "B");
            second_class_HZ.Add("瘢", "B");
            second_class_HZ.Add("瘭", "B");
            second_class_HZ.Add("癍", "B");
            second_class_HZ.Add("窆", "B");
            second_class_HZ.Add("裱", "B");
            second_class_HZ.Add("裨", "B");
            second_class_HZ.Add("褙", "B");
            second_class_HZ.Add("褓", "B");
            second_class_HZ.Add("褊", "B");
            second_class_HZ.Add("蝙", "B");
            second_class_HZ.Add("笾", "B");
            second_class_HZ.Add("筚", "B");
            second_class_HZ.Add("箅", "B");
            second_class_HZ.Add("篦", "B");
            second_class_HZ.Add("簸", "B");
            second_class_HZ.Add("舭", "B");
            second_class_HZ.Add("舨", "B");
            second_class_HZ.Add("襞", "B");
            second_class_HZ.Add("粑", "B");
            second_class_HZ.Add("醭", "B");
            second_class_HZ.Add("蹩", "B");
            second_class_HZ.Add("趵", "B");
            second_class_HZ.Add("跛", "B");
            second_class_HZ.Add("跸", "B");
            second_class_HZ.Add("踣", "B");
            second_class_HZ.Add("龅", "B");
            second_class_HZ.Add("鐾", "B");
            second_class_HZ.Add("鲅", "B");
            second_class_HZ.Add("鳊", "B");
            second_class_HZ.Add("鳔", "B");
            second_class_HZ.Add("鞴", "B");
            second_class_HZ.Add("髀", "B");
            second_class_HZ.Add("髌", "B");
            second_class_HZ.Add("魃", "B");
            second_class_HZ.Add("髟", "B");
            second_class_HZ.Add("鬓", "B");
            second_class_HZ.Add("亍", "C");
            second_class_HZ.Add("丞", "C");
            second_class_HZ.Add("厝", "C");
            second_class_HZ.Add("刂", "C");
            second_class_HZ.Add("伥", "C");
            second_class_HZ.Add("伧", "C");
            second_class_HZ.Add("侪", "C");
            second_class_HZ.Add("俦", "C");
            second_class_HZ.Add("傺", "C");
            second_class_HZ.Add("汆", "C");
            second_class_HZ.Add("冁", "C");
            second_class_HZ.Add("谄", "C");
            second_class_HZ.Add("谌", "C");
            second_class_HZ.Add("谶", "C");
            second_class_HZ.Add("陲", "C");
            second_class_HZ.Add("刍", "C");
            second_class_HZ.Add("鬯", "C");
            second_class_HZ.Add("坼", "C");
            second_class_HZ.Add("埕", "C");
            second_class_HZ.Add("墀", "C");
            second_class_HZ.Add("艹", "C");
            second_class_HZ.Add("苌", "C");
            second_class_HZ.Add("苁", "C");
            second_class_HZ.Add("茌", "C");
            second_class_HZ.Add("茺", "C");
            second_class_HZ.Add("莼", "C");
            second_class_HZ.Add("菖", "C");
            second_class_HZ.Add("萃", "C");
            second_class_HZ.Add("蒇", "C");
            second_class_HZ.Add("蔟", "C");
            second_class_HZ.Add("抻", "C");
            second_class_HZ.Add("搋", "C");
            second_class_HZ.Add("撺", "C");
            second_class_HZ.Add("叱", "C");
            second_class_HZ.Add("呲", "C");
            second_class_HZ.Add("哧", "C");
            second_class_HZ.Add("啐", "C");
            second_class_HZ.Add("啜", "C");
            second_class_HZ.Add("啻", "C");
            second_class_HZ.Add("嗔", "C");
            second_class_HZ.Add("嗤", "C");
            second_class_HZ.Add("嘈", "C");
            second_class_HZ.Add("嘬", "C");
            second_class_HZ.Add("噌", "C");
            second_class_HZ.Add("嚓", "C");
            second_class_HZ.Add("岑", "C");
            second_class_HZ.Add("嵯", "C");
            second_class_HZ.Add("彳", "C");
            second_class_HZ.Add("徂", "C");
            second_class_HZ.Add("徜", "C");
            second_class_HZ.Add("猝", "C");
            second_class_HZ.Add("猹", "C");
            second_class_HZ.Add("舛", "C");
            second_class_HZ.Add("饬", "C");
            second_class_HZ.Add("廛", "C");
            second_class_HZ.Add("忖", "C");
            second_class_HZ.Add("忏", "C");
            second_class_HZ.Add("忡", "C");
            second_class_HZ.Add("怅", "C");
            second_class_HZ.Add("怆", "C");
            second_class_HZ.Add("怵", "C");
            second_class_HZ.Add("怊", "C");
            second_class_HZ.Add("恻", "C");
            second_class_HZ.Add("惝", "C");
            second_class_HZ.Add("惆", "C");
            second_class_HZ.Add("悴", "C");
            second_class_HZ.Add("憧", "C");
            second_class_HZ.Add("憷", "C");
            second_class_HZ.Add("阊", "C");
            second_class_HZ.Add("汊", "C");
            second_class_HZ.Add("涔", "C");
            second_class_HZ.Add("淙", "C");
            second_class_HZ.Add("漕", "C");
            second_class_HZ.Add("潺", "C");
            second_class_HZ.Add("澶", "C");
            second_class_HZ.Add("宸", "C");
            second_class_HZ.Add("遄", "C");
            second_class_HZ.Add("孱", "C");
            second_class_HZ.Add("羼", "C");
            second_class_HZ.Add("屮", "C");
            second_class_HZ.Add("姹", "C");
            second_class_HZ.Add("娼", "C");
            second_class_HZ.Add("婵", "C");
            second_class_HZ.Add("媸", "C");
            second_class_HZ.Add("嫦", "C");
            second_class_HZ.Add("骖", "C");
            second_class_HZ.Add("骢", "C");
            second_class_HZ.Add("骣", "C");
            second_class_HZ.Add("绌", "C");
            second_class_HZ.Add("巛", "C");
            second_class_HZ.Add("琮", "C");
            second_class_HZ.Add("琛", "C");
            second_class_HZ.Add("璀", "C");
            second_class_HZ.Add("璁", "C");
            second_class_HZ.Add("璨", "C");
            second_class_HZ.Add("杈", "C");
            second_class_HZ.Add("杵", "C");
            second_class_HZ.Add("枨", "C");
            second_class_HZ.Add("枞", "C");
            second_class_HZ.Add("柽", "C");
            second_class_HZ.Add("楮", "C");
            second_class_HZ.Add("棰", "C");
            second_class_HZ.Add("楱", "C");
            second_class_HZ.Add("槌", "C");
            second_class_HZ.Add("榇", "C");
            second_class_HZ.Add("槎", "C");
            second_class_HZ.Add("榱", "C");
            second_class_HZ.Add("樗", "C");
            second_class_HZ.Add("檫", "C");
            second_class_HZ.Add("殂", "C");
            second_class_HZ.Add("辍", "C");
            second_class_HZ.Add("辏", "C");
            second_class_HZ.Add("昶", "C");
            second_class_HZ.Add("晁", "C");
            second_class_HZ.Add("觇", "C");
            second_class_HZ.Add("毳", "C");
            second_class_HZ.Add("氅", "C");
            second_class_HZ.Add("氚", "C");
            second_class_HZ.Add("敕", "C");
            second_class_HZ.Add("脞", "C");
            second_class_HZ.Add("腠", "C");
            second_class_HZ.Add("塍", "C");
            second_class_HZ.Add("膪", "C");
            second_class_HZ.Add("焯", "C");
            second_class_HZ.Add("爨", "C");
            second_class_HZ.Add("祠", "C");
            second_class_HZ.Add("禅", "C");
            second_class_HZ.Add("砗", "C");
            second_class_HZ.Add("碜", "C");
            second_class_HZ.Add("礤", "C");
            second_class_HZ.Add("眵", "C");
            second_class_HZ.Add("瞠", "C");
            second_class_HZ.Add("钏", "C");
            second_class_HZ.Add("钗", "C");
            second_class_HZ.Add("铖", "C");
            second_class_HZ.Add("铛", "C");
            second_class_HZ.Add("铳", "C");
            second_class_HZ.Add("锉", "C");
            second_class_HZ.Add("锸", "C");
            second_class_HZ.Add("镞", "C");
            second_class_HZ.Add("镩", "C");
            second_class_HZ.Add("镲", "C");
            second_class_HZ.Add("矬", "C");
            second_class_HZ.Add("鸱", "C");
            second_class_HZ.Add("鹑", "C");
            second_class_HZ.Add("鹚", "C");
            second_class_HZ.Add("痤", "C");
            second_class_HZ.Add("瘥", "C");
            second_class_HZ.Add("瘛", "C");
            second_class_HZ.Add("瘳", "C");
            second_class_HZ.Add("衩", "C");
            second_class_HZ.Add("裎", "C");
            second_class_HZ.Add("褚", "C");
            second_class_HZ.Add("褫", "C");
            second_class_HZ.Add("皴", "C");
            second_class_HZ.Add("耖", "C");
            second_class_HZ.Add("虿", "C");
            second_class_HZ.Add("蚩", "C");
            second_class_HZ.Add("蛏", "C");
            second_class_HZ.Add("蜍", "C");
            second_class_HZ.Add("蝽", "C");
            second_class_HZ.Add("螭", "C");
            second_class_HZ.Add("螬", "C");
            second_class_HZ.Add("蟾", "C");
            second_class_HZ.Add("笞", "C");
            second_class_HZ.Add("篪", "C");
            second_class_HZ.Add("舂", "C");
            second_class_HZ.Add("舡", "C");
            second_class_HZ.Add("艚", "C");
            second_class_HZ.Add("艟", "C");
            second_class_HZ.Add("粲", "C");
            second_class_HZ.Add("糍", "C");
            second_class_HZ.Add("豉", "C");
            second_class_HZ.Add("酲", "C");
            second_class_HZ.Add("鹾", "C");
            second_class_HZ.Add("蹙", "C");
            second_class_HZ.Add("踔", "C");
            second_class_HZ.Add("踟", "C");
            second_class_HZ.Add("踹", "C");
            second_class_HZ.Add("蹉", "C");
            second_class_HZ.Add("蹰", "C");
            second_class_HZ.Add("蹴", "C");
            second_class_HZ.Add("躔", "C");
            second_class_HZ.Add("龀", "C");
            second_class_HZ.Add("龊", "C");
            second_class_HZ.Add("雠", "C");
            second_class_HZ.Add("鲳", "C");
            second_class_HZ.Add("魑", "C");
            second_class_HZ.Add("黜", "C");
            second_class_HZ.Add("黪", "C");
            second_class_HZ.Add("氐", "D");
            second_class_HZ.Add("丶", "D");
            second_class_HZ.Add("亻", "D");
            second_class_HZ.Add("仃", "D");
            second_class_HZ.Add("儋", "D");
            second_class_HZ.Add("籴", "D");
            second_class_HZ.Add("诋", "D");
            second_class_HZ.Add("诒", "D");
            second_class_HZ.Add("谛", "D");
            second_class_HZ.Add("谠", "D");
            second_class_HZ.Add("卩", "D");
            second_class_HZ.Add("邸", "D");
            second_class_HZ.Add("凼", "D");
            second_class_HZ.Add("坫", "D");
            second_class_HZ.Add("坻", "D");
            second_class_HZ.Add("垤", "D");
            second_class_HZ.Add("垌", "D");
            second_class_HZ.Add("埭", "D");
            second_class_HZ.Add("堞", "D");
            second_class_HZ.Add("芏", "D");
            second_class_HZ.Add("荻", "D");
            second_class_HZ.Add("萏", "D");
            second_class_HZ.Add("菪", "D");
            second_class_HZ.Add("蔸", "D");
            second_class_HZ.Add("耷", "D");
            second_class_HZ.Add("揲", "D");
            second_class_HZ.Add("甙", "D");
            second_class_HZ.Add("叨", "D");
            second_class_HZ.Add("咚", "D");
            second_class_HZ.Add("咄", "D");
            second_class_HZ.Add("哒", "D");
            second_class_HZ.Add("哚", "D");
            second_class_HZ.Add("啖", "D");
            second_class_HZ.Add("啶", "D");
            second_class_HZ.Add("喋", "D");
            second_class_HZ.Add("嗒", "D");
            second_class_HZ.Add("嘟", "D");
            second_class_HZ.Add("嗲", "D");
            second_class_HZ.Add("嘀", "D");
            second_class_HZ.Add("噔", "D");
            second_class_HZ.Add("帱", "D");
            second_class_HZ.Add("岽", "D");
            second_class_HZ.Add("岱", "D");
            second_class_HZ.Add("峒", "D");
            second_class_HZ.Add("嶝", "D");
            second_class_HZ.Add("巅", "D");
            second_class_HZ.Add("夂", "D");
            second_class_HZ.Add("忉", "D");
            second_class_HZ.Add("怛", "D");
            second_class_HZ.Add("沌", "D");
            second_class_HZ.Add("沲", "D");
            second_class_HZ.Add("沱", "D");
            second_class_HZ.Add("渎", "D");
            second_class_HZ.Add("澹", "D");
            second_class_HZ.Add("宕", "D");
            second_class_HZ.Add("迨", "D");
            second_class_HZ.Add("妲", "D");
            second_class_HZ.Add("娣", "D");
            second_class_HZ.Add("骀", "D");
            second_class_HZ.Add("绐", "D");
            second_class_HZ.Add("缍", "D");
            second_class_HZ.Add("玎", "D");
            second_class_HZ.Add("玷", "D");
            second_class_HZ.Add("玳", "D");
            second_class_HZ.Add("柢", "D");
            second_class_HZ.Add("椟", "D");
            second_class_HZ.Add("棣", "D");
            second_class_HZ.Add("椴", "D");
            second_class_HZ.Add("殚", "D");
            second_class_HZ.Add("戥", "D");
            second_class_HZ.Add("赕", "D");
            second_class_HZ.Add("觌", "D");
            second_class_HZ.Add("氘", "D");
            second_class_HZ.Add("氡", "D");
            second_class_HZ.Add("牍", "D");
            second_class_HZ.Add("牒", "D");
            second_class_HZ.Add("胨", "D");
            second_class_HZ.Add("胴", "D");
            second_class_HZ.Add("腚", "D");
            second_class_HZ.Add("炖", "D");
            second_class_HZ.Add("煅", "D");
            second_class_HZ.Add("怼", "D");
            second_class_HZ.Add("憝", "D");
            second_class_HZ.Add("砀", "D");
            second_class_HZ.Add("砘", "D");
            second_class_HZ.Add("砥", "D");
            second_class_HZ.Add("硐", "D");
            second_class_HZ.Add("碓", "D");
            second_class_HZ.Add("碇", "D");
            second_class_HZ.Add("碲", "D");
            second_class_HZ.Add("礅", "D");
            second_class_HZ.Add("磴", "D");
            second_class_HZ.Add("盹", "D");
            second_class_HZ.Add("眈", "D");
            second_class_HZ.Add("睇", "D");
            second_class_HZ.Add("町", "D");
            second_class_HZ.Add("钭", "D");
            second_class_HZ.Add("钿", "D");
            second_class_HZ.Add("铎", "D");
            second_class_HZ.Add("铞", "D");
            second_class_HZ.Add("铤", "D");
            second_class_HZ.Add("铥", "D");
            second_class_HZ.Add("铫", "D");
            second_class_HZ.Add("锝", "D");
            second_class_HZ.Add("镝", "D");
            second_class_HZ.Add("镦", "D");
            second_class_HZ.Add("镫", "D");
            second_class_HZ.Add("瓞", "D");
            second_class_HZ.Add("鸫", "D");
            second_class_HZ.Add("疔", "D");
            second_class_HZ.Add("疸", "D");
            second_class_HZ.Add("瘅", "D");
            second_class_HZ.Add("癜", "D");
            second_class_HZ.Add("癫", "D");
            second_class_HZ.Add("窦", "D");
            second_class_HZ.Add("裆", "D");
            second_class_HZ.Add("裰", "D");
            second_class_HZ.Add("褡", "D");
            second_class_HZ.Add("耋", "D");
            second_class_HZ.Add("耵", "D");
            second_class_HZ.Add("聃", "D");
            second_class_HZ.Add("蚪", "D");
            second_class_HZ.Add("蠹", "D");
            second_class_HZ.Add("笃", "D");
            second_class_HZ.Add("笪", "D");
            second_class_HZ.Add("箪", "D");
            second_class_HZ.Add("篼", "D");
            second_class_HZ.Add("簖", "D");
            second_class_HZ.Add("簟", "D");
            second_class_HZ.Add("簦", "D");
            second_class_HZ.Add("羝", "D");
            second_class_HZ.Add("纛", "D");
            second_class_HZ.Add("酊", "D");
            second_class_HZ.Add("趸", "D");
            second_class_HZ.Add("踮", "D");
            second_class_HZ.Add("蹀", "D");
            second_class_HZ.Add("踱", "D");
            second_class_HZ.Add("貂", "D");
            second_class_HZ.Add("鲷", "D");
            second_class_HZ.Add("鲽", "D");
            second_class_HZ.Add("靼", "D");
            second_class_HZ.Add("鞑", "D");
            second_class_HZ.Add("骶", "D");
            second_class_HZ.Add("髑", "D");
            second_class_HZ.Add("黛", "D");
            second_class_HZ.Add("黩", "D");
            second_class_HZ.Add("噩", "E");
            second_class_HZ.Add("佴", "E");
            second_class_HZ.Add("诶", "E");
            second_class_HZ.Add("谔", "E");
            second_class_HZ.Add("垩", "E");
            second_class_HZ.Add("苊", "E");
            second_class_HZ.Add("莪", "E");
            second_class_HZ.Add("萼", "E");
            second_class_HZ.Add("蒽", "E");
            second_class_HZ.Add("摁", "E");
            second_class_HZ.Add("呃", "E");
            second_class_HZ.Add("唔", "E");
            second_class_HZ.Add("嗯", "E");
            second_class_HZ.Add("愕", "E");
            second_class_HZ.Add("阏", "E");
            second_class_HZ.Add("迩", "E");
            second_class_HZ.Add("屙", "E");
            second_class_HZ.Add("婀", "E");
            second_class_HZ.Add("珥", "E");
            second_class_HZ.Add("轭", "E");
            second_class_HZ.Add("腭", "E");
            second_class_HZ.Add("铒", "E");
            second_class_HZ.Add("锇", "E");
            second_class_HZ.Add("锷", "E");
            second_class_HZ.Add("鸸", "E");
            second_class_HZ.Add("鹗", "E");
            second_class_HZ.Add("颚", "E");
            second_class_HZ.Add("鲕", "E");
            second_class_HZ.Add("鳄", "E");
            second_class_HZ.Add("匚", "F");
            second_class_HZ.Add("俸", "F");
            second_class_HZ.Add("偾", "F");
            second_class_HZ.Add("匐", "F");
            second_class_HZ.Add("凫", "F");
            second_class_HZ.Add("邡", "F");
            second_class_HZ.Add("郛", "F");
            second_class_HZ.Add("酆", "F");
            second_class_HZ.Add("垡", "F");
            second_class_HZ.Add("芙", "F");
            second_class_HZ.Add("芾", "F");
            second_class_HZ.Add("苻", "F");
            second_class_HZ.Add("茯", "F");
            second_class_HZ.Add("莩", "F");
            second_class_HZ.Add("菔", "F");
            second_class_HZ.Add("葑", "F");
            second_class_HZ.Add("蕃", "F");
            second_class_HZ.Add("蘩", "F");
            second_class_HZ.Add("拊", "F");
            second_class_HZ.Add("呋", "F");
            second_class_HZ.Add("唪", "F");
            second_class_HZ.Add("幞", "F");
            second_class_HZ.Add("幡", "F");
            second_class_HZ.Add("犭", "F");
            second_class_HZ.Add("狒", "F");
            second_class_HZ.Add("怫", "F");
            second_class_HZ.Add("悱", "F");
            second_class_HZ.Add("沣", "F");
            second_class_HZ.Add("淝", "F");
            second_class_HZ.Add("滏", "F");
            second_class_HZ.Add("瀵", "F");
            second_class_HZ.Add("艴", "F");
            second_class_HZ.Add("妃", "F");
            second_class_HZ.Add("孚", "F");
            second_class_HZ.Add("驸", "F");
            second_class_HZ.Add("绂", "F");
            second_class_HZ.Add("绋", "F");
            second_class_HZ.Add("绯", "F");
            second_class_HZ.Add("枋", "F");
            second_class_HZ.Add("梵", "F");
            second_class_HZ.Add("桴", "F");
            second_class_HZ.Add("棼", "F");
            second_class_HZ.Add("榧", "F");
            second_class_HZ.Add("赙", "F");
            second_class_HZ.Add("攵", "F");
            second_class_HZ.Add("腓", "F");
            second_class_HZ.Add("斐", "F");
            second_class_HZ.Add("燔", "F");
            second_class_HZ.Add("扉", "F");
            second_class_HZ.Add("祓", "F");
            second_class_HZ.Add("砜", "F");
            second_class_HZ.Add("砝", "F");
            second_class_HZ.Add("砩", "F");
            second_class_HZ.Add("黻", "F");
            second_class_HZ.Add("黼", "F");
            second_class_HZ.Add("畈", "F");
            second_class_HZ.Add("罘", "F");
            second_class_HZ.Add("钫", "F");
            second_class_HZ.Add("镄", "F");
            second_class_HZ.Add("稃", "F");
            second_class_HZ.Add("馥", "F");
            second_class_HZ.Add("痱", "F");
            second_class_HZ.Add("蚨", "F");
            second_class_HZ.Add("蜉", "F");
            second_class_HZ.Add("蜚", "F");
            second_class_HZ.Add("蝠", "F");
            second_class_HZ.Add("蝮", "F");
            second_class_HZ.Add("缶", "F");
            second_class_HZ.Add("篚", "F");
            second_class_HZ.Add("舫", "F");
            second_class_HZ.Add("翡", "F");
            second_class_HZ.Add("麸", "F");
            second_class_HZ.Add("趺", "F");
            second_class_HZ.Add("跗", "F");
            second_class_HZ.Add("蹯", "F");
            second_class_HZ.Add("霏", "F");
            second_class_HZ.Add("鲂", "F");
            second_class_HZ.Add("鲋", "F");
            second_class_HZ.Add("鲱", "F");
            second_class_HZ.Add("鲼", "F");
            second_class_HZ.Add("鳆", "F");
            second_class_HZ.Add("鼢", "F");
            second_class_HZ.Add("丐", "G");
            second_class_HZ.Add("亘", "G");
            second_class_HZ.Add("鬲", "G");
            second_class_HZ.Add("睾", "G");
            second_class_HZ.Add("嘏", "G");
            second_class_HZ.Add("匦", "G");
            second_class_HZ.Add("卦", "G");
            second_class_HZ.Add("刿", "G");
            second_class_HZ.Add("佝", "G");
            second_class_HZ.Add("伽", "G");
            second_class_HZ.Add("倌", "G");
            second_class_HZ.Add("馘", "G");
            second_class_HZ.Add("衮", "G");
            second_class_HZ.Add("诂", "G");
            second_class_HZ.Add("诖", "G");
            second_class_HZ.Add("诟", "G");
            second_class_HZ.Add("诰", "G");
            second_class_HZ.Add("陔", "G");
            second_class_HZ.Add("郜", "G");
            second_class_HZ.Add("哿", "G");
            second_class_HZ.Add("圪", "G");
            second_class_HZ.Add("坩", "G");
            second_class_HZ.Add("垓", "G");
            second_class_HZ.Add("埚", "G");
            second_class_HZ.Add("塥", "G");
            second_class_HZ.Add("苷", "G");
            second_class_HZ.Add("茛", "G");
            second_class_HZ.Add("莞", "G");
            second_class_HZ.Add("菰", "G");
            second_class_HZ.Add("藁", "G");
            second_class_HZ.Add("廾", "G");
            second_class_HZ.Add("尬", "G");
            second_class_HZ.Add("尴", "G");
            second_class_HZ.Add("掴", "G");
            second_class_HZ.Add("掼", "G");
            second_class_HZ.Add("擀", "G");
            second_class_HZ.Add("呙", "G");
            second_class_HZ.Add("呷", "G");
            second_class_HZ.Add("呱", "G");
            second_class_HZ.Add("咣", "G");
            second_class_HZ.Add("哏", "G");
            second_class_HZ.Add("哽", "G");
            second_class_HZ.Add("嗝", "G");
            second_class_HZ.Add("帼", "G");
            second_class_HZ.Add("岣", "G");
            second_class_HZ.Add("崮", "G");
            second_class_HZ.Add("崞", "G");
            second_class_HZ.Add("犷", "G");
            second_class_HZ.Add("猓", "G");
            second_class_HZ.Add("庋", "G");
            second_class_HZ.Add("赓", "G");
            second_class_HZ.Add("汩", "G");
            second_class_HZ.Add("泔", "G");
            second_class_HZ.Add("淦", "G");
            second_class_HZ.Add("涫", "G");
            second_class_HZ.Add("澉", "G");
            second_class_HZ.Add("宄", "G");
            second_class_HZ.Add("遘", "G");
            second_class_HZ.Add("妫", "G");
            second_class_HZ.Add("媾", "G");
            second_class_HZ.Add("尕", "G");
            second_class_HZ.Add("尜", "G");
            second_class_HZ.Add("纥", "G");
            second_class_HZ.Add("绀", "G");
            second_class_HZ.Add("绠", "G");
            second_class_HZ.Add("绲", "G");
            second_class_HZ.Add("缑", "G");
            second_class_HZ.Add("缟", "G");
            second_class_HZ.Add("珙", "G");
            second_class_HZ.Add("枸", "G");
            second_class_HZ.Add("桄", "G");
            second_class_HZ.Add("栝", "G");
            second_class_HZ.Add("桧", "G");
            second_class_HZ.Add("梏", "G");
            second_class_HZ.Add("椁", "G");
            second_class_HZ.Add("槔", "G");
            second_class_HZ.Add("槁", "G");
            second_class_HZ.Add("橄", "G");
            second_class_HZ.Add("轱", "G");
            second_class_HZ.Add("戤", "G");
            second_class_HZ.Add("旮", "G");
            second_class_HZ.Add("旰", "G");
            second_class_HZ.Add("杲", "G");
            second_class_HZ.Add("炅", "G");
            second_class_HZ.Add("晷", "G");
            second_class_HZ.Add("赅", "G");
            second_class_HZ.Add("觏", "G");
            second_class_HZ.Add("牯", "G");
            second_class_HZ.Add("牿", "G");
            second_class_HZ.Add("搿", "G");
            second_class_HZ.Add("虢", "G");
            second_class_HZ.Add("肱", "G");
            second_class_HZ.Add("胍", "G");
            second_class_HZ.Add("胱", "G");
            second_class_HZ.Add("膈", "G");
            second_class_HZ.Add("臌", "G");
            second_class_HZ.Add("彀", "G");
            second_class_HZ.Add("毂", "G");
            second_class_HZ.Add("戆", "G");
            second_class_HZ.Add("矸", "G");
            second_class_HZ.Add("硌", "G");
            second_class_HZ.Add("磙", "G");
            second_class_HZ.Add("瞽", "G");
            second_class_HZ.Add("罡", "G");
            second_class_HZ.Add("罟", "G");
            second_class_HZ.Add("盥", "G");
            second_class_HZ.Add("钆", "G");
            second_class_HZ.Add("钴", "G");
            second_class_HZ.Add("锆", "G");
            second_class_HZ.Add("锢", "G");
            second_class_HZ.Add("镉", "G");
            second_class_HZ.Add("皈", "G");
            second_class_HZ.Add("鸪", "G");
            second_class_HZ.Add("鸹", "G");
            second_class_HZ.Add("鹳", "G");
            second_class_HZ.Add("疳", "G");
            second_class_HZ.Add("痼", "G");
            second_class_HZ.Add("袼", "G");
            second_class_HZ.Add("聒", "G");
            second_class_HZ.Add("虼", "G");
            second_class_HZ.Add("蚣", "G");
            second_class_HZ.Add("蛄", "G");
            second_class_HZ.Add("蜾", "G");
            second_class_HZ.Add("蝈", "G");
            second_class_HZ.Add("笱", "G");
            second_class_HZ.Add("筻", "G");
            second_class_HZ.Add("篝", "G");
            second_class_HZ.Add("簋", "G");
            second_class_HZ.Add("舸", "G");
            second_class_HZ.Add("艮", "G");
            second_class_HZ.Add("酐", "G");
            second_class_HZ.Add("酤", "G");
            second_class_HZ.Add("觚", "G");
            second_class_HZ.Add("觥", "G");
            second_class_HZ.Add("鲑", "G");
            second_class_HZ.Add("鲠", "G");
            second_class_HZ.Add("鲧", "G");
            second_class_HZ.Add("鲴", "G");
            second_class_HZ.Add("鳏", "G");
            second_class_HZ.Add("鳜", "G");
            second_class_HZ.Add("鞲", "G");
            second_class_HZ.Add("鹘", "G");
            second_class_HZ.Add("骼", "G");
            second_class_HZ.Add("劐", "H");
            second_class_HZ.Add("黉", "H");
            second_class_HZ.Add("訇", "H");
            second_class_HZ.Add("冱", "H");
            second_class_HZ.Add("讧", "H");
            second_class_HZ.Add("诃", "H");
            second_class_HZ.Add("诙", "H");
            second_class_HZ.Add("诨", "H");
            second_class_HZ.Add("隍", "H");
            second_class_HZ.Add("邗", "H");
            second_class_HZ.Add("奂", "H");
            second_class_HZ.Add("劾", "H");
            second_class_HZ.Add("壑", "H");
            second_class_HZ.Add("堠", "H");
            second_class_HZ.Add("茴", "H");
            second_class_HZ.Add("荟", "H");
            second_class_HZ.Add("荭", "H");
            second_class_HZ.Add("萑", "H");
            second_class_HZ.Add("菡", "H");
            second_class_HZ.Add("蒿", "H");
            second_class_HZ.Add("蕙", "H");
            second_class_HZ.Add("蕻", "H");
            second_class_HZ.Add("薨", "H");
            second_class_HZ.Add("薅", "H");
            second_class_HZ.Add("藿", "H");
            second_class_HZ.Add("蘅", "H");
            second_class_HZ.Add("撖", "H");
            second_class_HZ.Add("擐", "H");
            second_class_HZ.Add("攉", "H");
            second_class_HZ.Add("咴", "H");
            second_class_HZ.Add("唿", "H");
            second_class_HZ.Add("喙", "H");
            second_class_HZ.Add("嗬", "H");
            second_class_HZ.Add("嗥", "H");
            second_class_HZ.Add("嗨", "H");
            second_class_HZ.Add("嚆", "H");
            second_class_HZ.Add("嚯", "H");
            second_class_HZ.Add("囫", "H");
            second_class_HZ.Add("圜", "H");
            second_class_HZ.Add("岵", "H");
            second_class_HZ.Add("後", "H");
            second_class_HZ.Add("徨", "H");
            second_class_HZ.Add("猢", "H");
            second_class_HZ.Add("獾", "H");
            second_class_HZ.Add("夥", "H");
            second_class_HZ.Add("馄", "H");
            second_class_HZ.Add("怙", "H");
            second_class_HZ.Add("惚", "H");
            second_class_HZ.Add("隳", "H");
            second_class_HZ.Add("闳", "H");
            second_class_HZ.Add("阍", "H");
            second_class_HZ.Add("阖", "H");
            second_class_HZ.Add("沆", "H");
            second_class_HZ.Add("泓", "H");
            second_class_HZ.Add("洹", "H");
            second_class_HZ.Add("洄", "H");
            second_class_HZ.Add("浍", "H");
            second_class_HZ.Add("浒", "H");
            second_class_HZ.Add("浣", "H");
            second_class_HZ.Add("湟", "H");
            second_class_HZ.Add("溷", "H");
            second_class_HZ.Add("潢", "H");
            second_class_HZ.Add("滹", "H");
            second_class_HZ.Add("漶", "H");
            second_class_HZ.Add("濠", "H");
            second_class_HZ.Add("瀚", "H");
            second_class_HZ.Add("灏", "H");
            second_class_HZ.Add("寰", "H");
            second_class_HZ.Add("逅", "H");
            second_class_HZ.Add("逭", "H");
            second_class_HZ.Add("遑", "H");
            second_class_HZ.Add("彗", "H");
            second_class_HZ.Add("骅", "H");
            second_class_HZ.Add("绗", "H");
            second_class_HZ.Add("缋", "H");
            second_class_HZ.Add("缳", "H");
            second_class_HZ.Add("珩", "H");
            second_class_HZ.Add("珲", "H");
            second_class_HZ.Add("琥", "H");
            second_class_HZ.Add("璜", "H");
            second_class_HZ.Add("桦", "H");
            second_class_HZ.Add("桁", "H");
            second_class_HZ.Add("槲", "H");
            second_class_HZ.Add("轷", "H");
            second_class_HZ.Add("昊", "H");
            second_class_HZ.Add("曷", "H");
            second_class_HZ.Add("晖", "H");
            second_class_HZ.Add("晗", "H");
            second_class_HZ.Add("肓", "H");
            second_class_HZ.Add("胲", "H");
            second_class_HZ.Add("觳", "H");
            second_class_HZ.Add("烀", "H");
            second_class_HZ.Add("焓", "H");
            second_class_HZ.Add("煳", "H");
            second_class_HZ.Add("灬", "H");
            second_class_HZ.Add("戽", "H");
            second_class_HZ.Add("扈", "H");
            second_class_HZ.Add("祜", "H");
            second_class_HZ.Add("恚", "H");
            second_class_HZ.Add("砉", "H");
            second_class_HZ.Add("盍", "H");
            second_class_HZ.Add("钬", "H");
            second_class_HZ.Add("铧", "H");
            second_class_HZ.Add("铪", "H");
            second_class_HZ.Add("锪", "H");
            second_class_HZ.Add("锾", "H");
            second_class_HZ.Add("镬", "H");
            second_class_HZ.Add("皓", "H");
            second_class_HZ.Add("瓠", "H");
            second_class_HZ.Add("鹄", "H");
            second_class_HZ.Add("鹕", "H");
            second_class_HZ.Add("鹱", "H");
            second_class_HZ.Add("瘊", "H");
            second_class_HZ.Add("癀", "H");
            second_class_HZ.Add("耠", "H");
            second_class_HZ.Add("顸", "H");
            second_class_HZ.Add("颃", "H");
            second_class_HZ.Add("颌", "H");
            second_class_HZ.Add("颔", "H");
            second_class_HZ.Add("颢", "H");
            second_class_HZ.Add("虍", "H");
            second_class_HZ.Add("虺", "H");
            second_class_HZ.Add("蚝", "H");
            second_class_HZ.Add("蚶", "H");
            second_class_HZ.Add("蟥", "H");
            second_class_HZ.Add("蟪", "H");
            second_class_HZ.Add("蠖", "H");
            second_class_HZ.Add("笏", "H");
            second_class_HZ.Add("篁", "H");
            second_class_HZ.Add("篌", "H");
            second_class_HZ.Add("糇", "H");
            second_class_HZ.Add("翮", "H");
            second_class_HZ.Add("醐", "H");
            second_class_HZ.Add("醢", "H");
            second_class_HZ.Add("踝", "H");
            second_class_HZ.Add("斛", "H");
            second_class_HZ.Add("鲎", "H");
            second_class_HZ.Add("鲩", "H");
            second_class_HZ.Add("鳇", "H");
            second_class_HZ.Add("骺", "H");
            second_class_HZ.Add("鬟", "H");
            second_class_HZ.Add("麾", "H");
            second_class_HZ.Add("鼾", "H");
            second_class_HZ.Add("丌", "J");
            second_class_HZ.Add("亟", "J");
            second_class_HZ.Add("乩", "J");
            second_class_HZ.Add("厥", "J");
            second_class_HZ.Add("刭", "J");
            second_class_HZ.Add("剞", "J");
            second_class_HZ.Add("劂", "J");
            second_class_HZ.Add("佶", "J");
            second_class_HZ.Add("佼", "J");
            second_class_HZ.Add("倨", "J");
            second_class_HZ.Add("偈", "J");
            second_class_HZ.Add("儆", "J");
            second_class_HZ.Add("僭", "J");
            second_class_HZ.Add("僬", "J");
            second_class_HZ.Add("僦", "J");
            second_class_HZ.Add("讦", "J");
            second_class_HZ.Add("讵", "J");
            second_class_HZ.Add("诘", "J");
            second_class_HZ.Add("谏", "J");
            second_class_HZ.Add("谫", "J");
            second_class_HZ.Add("谲", "J");
            second_class_HZ.Add("卺", "J");
            second_class_HZ.Add("阱", "J");
            second_class_HZ.Add("陉", "J");
            second_class_HZ.Add("郏", "J");
            second_class_HZ.Add("鄄", "J");
            second_class_HZ.Add("矍", "J");
            second_class_HZ.Add("廴", "J");
            second_class_HZ.Add("墼", "J");
            second_class_HZ.Add("艽", "J");
            second_class_HZ.Add("芨", "J");
            second_class_HZ.Add("芰", "J");
            second_class_HZ.Add("苣", "J");
            second_class_HZ.Add("苴", "J");
            second_class_HZ.Add("莒", "J");
            second_class_HZ.Add("茭", "J");
            second_class_HZ.Add("茳", "J");
            second_class_HZ.Add("荩", "J");
            second_class_HZ.Add("菁", "J");
            second_class_HZ.Add("堇", "J");
            second_class_HZ.Add("菅", "J");
            second_class_HZ.Add("葭", "J");
            second_class_HZ.Add("蒺", "J");
            second_class_HZ.Add("蒹", "J");
            second_class_HZ.Add("蕨", "J");
            second_class_HZ.Add("蕺", "J");
            second_class_HZ.Add("拮", "J");
            second_class_HZ.Add("挢", "J");
            second_class_HZ.Add("捃", "J");
            second_class_HZ.Add("掎", "J");
            second_class_HZ.Add("掬", "J");
            second_class_HZ.Add("搛", "J");
            second_class_HZ.Add("叽", "J");
            second_class_HZ.Add("咭", "J");
            second_class_HZ.Add("哜", "J");
            second_class_HZ.Add("唧", "J");
            second_class_HZ.Add("喈", "J");
            second_class_HZ.Add("啾", "J");
            second_class_HZ.Add("嗟", "J");
            second_class_HZ.Add("噘", "J");
            second_class_HZ.Add("噍", "J");
            second_class_HZ.Add("噤", "J");
            second_class_HZ.Add("噱", "J");
            second_class_HZ.Add("囝", "J");
            second_class_HZ.Add("岌", "J");
            second_class_HZ.Add("岬", "J");
            second_class_HZ.Add("崛", "J");
            second_class_HZ.Add("嵴", "J");
            second_class_HZ.Add("徼", "J");
            second_class_HZ.Add("狷", "J");
            second_class_HZ.Add("獍", "J");
            second_class_HZ.Add("獗", "J");
            second_class_HZ.Add("馑", "J");
            second_class_HZ.Add("廑", "J");
            second_class_HZ.Add("憬", "J");
            second_class_HZ.Add("阄", "J");
            second_class_HZ.Add("丬", "J");
            second_class_HZ.Add("泾", "J");
            second_class_HZ.Add("浃", "J");
            second_class_HZ.Add("洎", "J");
            second_class_HZ.Add("洚", "J");
            second_class_HZ.Add("涓", "J");
            second_class_HZ.Add("湔", "J");
            second_class_HZ.Add("骞", "J");
            second_class_HZ.Add("蹇", "J");
            second_class_HZ.Add("謇", "J");
            second_class_HZ.Add("迥", "J");
            second_class_HZ.Add("迦", "J");
            second_class_HZ.Add("迳", "J");
            second_class_HZ.Add("遽", "J");
            second_class_HZ.Add("彐", "J");
            second_class_HZ.Add("屐", "J");
            second_class_HZ.Add("屦", "J");
            second_class_HZ.Add("弪", "J");
            second_class_HZ.Add("妗", "J");
            second_class_HZ.Add("姣", "J");
            second_class_HZ.Add("婧", "J");
            second_class_HZ.Add("婕", "J");
            second_class_HZ.Add("孑", "J");
            second_class_HZ.Add("孓", "J");
            second_class_HZ.Add("骥", "J");
            second_class_HZ.Add("纟", "J");
            second_class_HZ.Add("绛", "J");
            second_class_HZ.Add("缙", "J");
            second_class_HZ.Add("缣", "J");
            second_class_HZ.Add("缰", "J");
            second_class_HZ.Add("畿", "J");
            second_class_HZ.Add("玑", "J");
            second_class_HZ.Add("珏", "J");
            second_class_HZ.Add("珈", "J");
            second_class_HZ.Add("琚", "J");
            second_class_HZ.Add("瑾", "J");
            second_class_HZ.Add("枧", "J");
            second_class_HZ.Add("柩", "J");
            second_class_HZ.Add("桕", "J");
            second_class_HZ.Add("桀", "J");
            second_class_HZ.Add("桊", "J");
            second_class_HZ.Add("桷", "J");
            second_class_HZ.Add("楗", "J");
            second_class_HZ.Add("椐", "J");
            second_class_HZ.Add("楫", "J");
            second_class_HZ.Add("榘", "J");
            second_class_HZ.Add("榉", "J");
            second_class_HZ.Add("槿", "J");
            second_class_HZ.Add("橛", "J");
            second_class_HZ.Add("橘", "J");
            second_class_HZ.Add("殛", "J");
            second_class_HZ.Add("戋", "J");
            second_class_HZ.Add("戛", "J");
            second_class_HZ.Add("戟", "J");
            second_class_HZ.Add("戢", "J");
            second_class_HZ.Add("戬", "J");
            second_class_HZ.Add("赆", "J");
            second_class_HZ.Add("赍", "J");
            second_class_HZ.Add("觊", "J");
            second_class_HZ.Add("觐", "J");
            second_class_HZ.Add("牮", "J");
            second_class_HZ.Add("犟", "J");
            second_class_HZ.Add("犄", "J");
            second_class_HZ.Add("犋", "J");
            second_class_HZ.Add("犍", "J");
            second_class_HZ.Add("毽", "J");
            second_class_HZ.Add("敫", "J");
            second_class_HZ.Add("肼", "J");
            second_class_HZ.Add("胛", "J");
            second_class_HZ.Add("胫", "J");
            second_class_HZ.Add("腈", "J");
            second_class_HZ.Add("腱", "J");
            second_class_HZ.Add("飓", "J");
            second_class_HZ.Add("齑", "J");
            second_class_HZ.Add("旌", "J");
            second_class_HZ.Add("爝", "J");
            second_class_HZ.Add("扃", "J");
            second_class_HZ.Add("恝", "J");
            second_class_HZ.Add("矶", "J");
            second_class_HZ.Add("碣", "J");
            second_class_HZ.Add("礓", "J");
            second_class_HZ.Add("睑", "J");
            second_class_HZ.Add("羁", "J");
            second_class_HZ.Add("蠲", "J");
            second_class_HZ.Add("钅", "J");
            second_class_HZ.Add("钜", "J");
            second_class_HZ.Add("铗", "J");
            second_class_HZ.Add("锏", "J");
            second_class_HZ.Add("锔", "J");
            second_class_HZ.Add("锩", "J");
            second_class_HZ.Add("镌", "J");
            second_class_HZ.Add("镓", "J");
            second_class_HZ.Add("镢", "J");
            second_class_HZ.Add("嵇", "J");
            second_class_HZ.Add("稷", "J");
            second_class_HZ.Add("皎", "J");
            second_class_HZ.Add("鸠", "J");
            second_class_HZ.Add("鹣", "J");
            second_class_HZ.Add("鹪", "J");
            second_class_HZ.Add("鹫", "J");
            second_class_HZ.Add("疖", "J");
            second_class_HZ.Add("痂", "J");
            second_class_HZ.Add("瘕", "J");
            second_class_HZ.Add("瘠", "J");
            second_class_HZ.Add("窭", "J");
            second_class_HZ.Add("衿", "J");
            second_class_HZ.Add("袷", "J");
            second_class_HZ.Add("裥", "J");
            second_class_HZ.Add("裾", "J");
            second_class_HZ.Add("皲", "J");
            second_class_HZ.Add("矜", "J");
            second_class_HZ.Add("耩", "J");
            second_class_HZ.Add("颉", "J");
            second_class_HZ.Add("虮", "J");
            second_class_HZ.Add("蚧", "J");
            second_class_HZ.Add("蛱", "J");
            second_class_HZ.Add("蛟", "J");
            second_class_HZ.Add("笈", "J");
            second_class_HZ.Add("笄", "J");
            second_class_HZ.Add("笕", "J");
            second_class_HZ.Add("笳", "J");
            second_class_HZ.Add("筠", "J");
            second_class_HZ.Add("袈", "J");
            second_class_HZ.Add("羯", "J");
            second_class_HZ.Add("糨", "J");
            second_class_HZ.Add("暨", "J");
            second_class_HZ.Add("翦", "J");
            second_class_HZ.Add("糸", "J");
            second_class_HZ.Add("赳", "J");
            second_class_HZ.Add("趄", "J");
            second_class_HZ.Add("豇", "J");
            second_class_HZ.Add("醮", "J");
            second_class_HZ.Add("醵", "J");
            second_class_HZ.Add("趼", "J");
            second_class_HZ.Add("跏", "J");
            second_class_HZ.Add("跻", "J");
            second_class_HZ.Add("跤", "J");
            second_class_HZ.Add("跽", "J");
            second_class_HZ.Add("踺", "J");
            second_class_HZ.Add("踽", "J");
            second_class_HZ.Add("蹶", "J");
            second_class_HZ.Add("觖", "J");
            second_class_HZ.Add("霁", "J");
            second_class_HZ.Add("龃", "J");
            second_class_HZ.Add("隽", "J");
            second_class_HZ.Add("雎", "J");
            second_class_HZ.Add("鲒", "J");
            second_class_HZ.Add("鲚", "J");
            second_class_HZ.Add("鲛", "J");
            second_class_HZ.Add("鲣", "J");
            second_class_HZ.Add("鲫", "J");
            second_class_HZ.Add("鞯", "J");
            second_class_HZ.Add("鞫", "J");
            second_class_HZ.Add("骱", "J");
            second_class_HZ.Add("髻", "J");
            second_class_HZ.Add("鬏", "J");
            second_class_HZ.Add("麂", "J");
            second_class_HZ.Add("麇", "J");
            second_class_HZ.Add("馗", "K");
            second_class_HZ.Add("匮", "K");
            second_class_HZ.Add("刳", "K");
            second_class_HZ.Add("剀", "K");
            second_class_HZ.Add("蒯", "K");
            second_class_HZ.Add("伉", "K");
            second_class_HZ.Add("佧", "K");
            second_class_HZ.Add("侉", "K");
            second_class_HZ.Add("侃", "K");
            second_class_HZ.Add("倥", "K");
            second_class_HZ.Add("夔", "K");
            second_class_HZ.Add("诓", "K");
            second_class_HZ.Add("诳", "K");
            second_class_HZ.Add("邝", "K");
            second_class_HZ.Add("郐", "K");
            second_class_HZ.Add("圹", "K");
            second_class_HZ.Add("垲", "K");
            second_class_HZ.Add("堀", "K");
            second_class_HZ.Add("芤", "K");
            second_class_HZ.Add("莰", "K");
            second_class_HZ.Add("蒈", "K");
            second_class_HZ.Add("蒉", "K");
            second_class_HZ.Add("蔻", "K");
            second_class_HZ.Add("夼", "K");
            second_class_HZ.Add("揆", "K");
            second_class_HZ.Add("叩", "K");
            second_class_HZ.Add("咔", "K");
            second_class_HZ.Add("哐", "K");
            second_class_HZ.Add("哙", "K");
            second_class_HZ.Add("喹", "K");
            second_class_HZ.Add("喟", "K");
            second_class_HZ.Add("喾", "K");
            second_class_HZ.Add("嗑", "K");
            second_class_HZ.Add("岢", "K");
            second_class_HZ.Add("崆", "K");
            second_class_HZ.Add("狯", "K");
            second_class_HZ.Add("忾", "K");
            second_class_HZ.Add("恺", "K");
            second_class_HZ.Add("恪", "K");
            second_class_HZ.Add("悝", "K");
            second_class_HZ.Add("悃", "K");
            second_class_HZ.Add("愦", "K");
            second_class_HZ.Add("闶", "K");
            second_class_HZ.Add("阃", "K");
            second_class_HZ.Add("阚", "K");
            second_class_HZ.Add("溘", "K");
            second_class_HZ.Add("逵", "K");
            second_class_HZ.Add("尻", "K");
            second_class_HZ.Add("骒", "K");
            second_class_HZ.Add("纩", "K");
            second_class_HZ.Add("绔", "K");
            second_class_HZ.Add("缂", "K");
            second_class_HZ.Add("珂", "K");
            second_class_HZ.Add("琨", "K");
            second_class_HZ.Add("栲", "K");
            second_class_HZ.Add("轲", "K");
            second_class_HZ.Add("戡", "K");
            second_class_HZ.Add("暌", "K");
            second_class_HZ.Add("贶", "K");
            second_class_HZ.Add("犒", "K");
            second_class_HZ.Add("氪", "K");
            second_class_HZ.Add("胩", "K");
            second_class_HZ.Add("脍", "K");
            second_class_HZ.Add("龛", "K");
            second_class_HZ.Add("眍", "K");
            second_class_HZ.Add("睽", "K");
            second_class_HZ.Add("瞌", "K");
            second_class_HZ.Add("瞰", "K");
            second_class_HZ.Add("钪", "K");
            second_class_HZ.Add("钶", "K");
            second_class_HZ.Add("铐", "K");
            second_class_HZ.Add("铠", "K");
            second_class_HZ.Add("铿", "K");
            second_class_HZ.Add("锎", "K");
            second_class_HZ.Add("锞", "K");
            second_class_HZ.Add("锟", "K");
            second_class_HZ.Add("锴", "K");
            second_class_HZ.Add("稞", "K");
            second_class_HZ.Add("疴", "K");
            second_class_HZ.Add("窠", "K");
            second_class_HZ.Add("裉", "K");
            second_class_HZ.Add("聩", "K");
            second_class_HZ.Add("颏", "K");
            second_class_HZ.Add("蚵", "K");
            second_class_HZ.Add("蛞", "K");
            second_class_HZ.Add("蝰", "K");
            second_class_HZ.Add("蝌", "K");
            second_class_HZ.Add("筘", "K");
            second_class_HZ.Add("箜", "K");
            second_class_HZ.Add("篑", "K");
            second_class_HZ.Add("醌", "K");
            second_class_HZ.Add("跬", "K");
            second_class_HZ.Add("鲲", "K");
            second_class_HZ.Add("骷", "K");
            second_class_HZ.Add("髁", "K");
            second_class_HZ.Add("髋", "K");
            second_class_HZ.Add("髡", "K");
            second_class_HZ.Add("剌", "L");
            second_class_HZ.Add("仂", "L");
            second_class_HZ.Add("俪", "L");
            second_class_HZ.Add("俚", "L");
            second_class_HZ.Add("倮", "L");
            second_class_HZ.Add("偻", "L");
            second_class_HZ.Add("脔", "L");
            second_class_HZ.Add("蠃", "L");
            second_class_HZ.Add("羸", "L");
            second_class_HZ.Add("冫", "L");
            second_class_HZ.Add("冽", "L");
            second_class_HZ.Add("诔", "L");
            second_class_HZ.Add("郦", "L");
            second_class_HZ.Add("酃", "L");
            second_class_HZ.Add("坜", "L");
            second_class_HZ.Add("垅", "L");
            second_class_HZ.Add("垆", "L");
            second_class_HZ.Add("埒", "L");
            second_class_HZ.Add("塄", "L");
            second_class_HZ.Add("墚", "L");
            second_class_HZ.Add("苈", "L");
            second_class_HZ.Add("茏", "L");
            second_class_HZ.Add("苓", "L");
            second_class_HZ.Add("荦", "L");
            second_class_HZ.Add("莅", "L");
            second_class_HZ.Add("莨", "L");
            second_class_HZ.Add("蒌", "L");
            second_class_HZ.Add("蓠", "L");
            second_class_HZ.Add("蒗", "L");
            second_class_HZ.Add("蔹", "L");
            second_class_HZ.Add("蔺", "L");
            second_class_HZ.Add("蓼", "L");
            second_class_HZ.Add("藜", "L");
            second_class_HZ.Add("奁", "L");
            second_class_HZ.Add("尥", "L");
            second_class_HZ.Add("捋", "L");
            second_class_HZ.Add("捩", "L");
            second_class_HZ.Add("摞", "L");
            second_class_HZ.Add("撸", "L");
            second_class_HZ.Add("叻", "L");
            second_class_HZ.Add("呖", "L");
            second_class_HZ.Add("呤", "L");
            second_class_HZ.Add("咧", "L");
            second_class_HZ.Add("唠", "L");
            second_class_HZ.Add("啉", "L");
            second_class_HZ.Add("啷", "L");
            second_class_HZ.Add("唳", "L");
            second_class_HZ.Add("喱", "L");
            second_class_HZ.Add("喽", "L");
            second_class_HZ.Add("嘞", "L");
            second_class_HZ.Add("嘹", "L");
            second_class_HZ.Add("噜", "L");
            second_class_HZ.Add("囵", "L");
            second_class_HZ.Add("囹", "L");
            second_class_HZ.Add("岚", "L");
            second_class_HZ.Add("崂", "L");
            second_class_HZ.Add("崃", "L");
            second_class_HZ.Add("嵝", "L");
            second_class_HZ.Add("嶙", "L");
            second_class_HZ.Add("徕", "L");
            second_class_HZ.Add("猁", "L");
            second_class_HZ.Add("猡", "L");
            second_class_HZ.Add("獠", "L");
            second_class_HZ.Add("廪", "L");
            second_class_HZ.Add("愣", "L");
            second_class_HZ.Add("懔", "L");
            second_class_HZ.Add("闾", "L");
            second_class_HZ.Add("阆", "L");
            second_class_HZ.Add("泐", "L");
            second_class_HZ.Add("泷", "L");
            second_class_HZ.Add("泸", "L");
            second_class_HZ.Add("泠", "L");
            second_class_HZ.Add("泺", "L");
            second_class_HZ.Add("洌", "L");
            second_class_HZ.Add("浏", "L");
            second_class_HZ.Add("涞", "L");
            second_class_HZ.Add("渌", "L");
            second_class_HZ.Add("溧", "L");
            second_class_HZ.Add("漤", "L");
            second_class_HZ.Add("漯", "L");
            second_class_HZ.Add("潋", "L");
            second_class_HZ.Add("漉", "L");
            second_class_HZ.Add("濑", "L");
            second_class_HZ.Add("澧", "L");
            second_class_HZ.Add("濂", "L");
            second_class_HZ.Add("寮", "L");
            second_class_HZ.Add("逦", "L");
            second_class_HZ.Add("逯", "L");
            second_class_HZ.Add("遛", "L");
            second_class_HZ.Add("遴", "L");
            second_class_HZ.Add("邋", "L");
            second_class_HZ.Add("娈", "L");
            second_class_HZ.Add("娌", "L");
            second_class_HZ.Add("嫠", "L");
            second_class_HZ.Add("嫘", "L");
            second_class_HZ.Add("骊", "L");
            second_class_HZ.Add("骝", "L");
            second_class_HZ.Add("绫", "L");
            second_class_HZ.Add("绺", "L");
            second_class_HZ.Add("缡", "L");
            second_class_HZ.Add("缧", "L");
            second_class_HZ.Add("缭", "L");
            second_class_HZ.Add("珑", "L");
            second_class_HZ.Add("珞", "L");
            second_class_HZ.Add("琏", "L");
            second_class_HZ.Add("璐", "L");
            second_class_HZ.Add("枥", "L");
            second_class_HZ.Add("栊", "L");
            second_class_HZ.Add("栌", "L");
            second_class_HZ.Add("柃", "L");
            second_class_HZ.Add("栎", "L");
            second_class_HZ.Add("栳", "L");
            second_class_HZ.Add("栾", "L");
            second_class_HZ.Add("棂", "L");
            second_class_HZ.Add("椤", "L");
            second_class_HZ.Add("椋", "L");
            second_class_HZ.Add("楝", "L");
            second_class_HZ.Add("榄", "L");
            second_class_HZ.Add("榈", "L");
            second_class_HZ.Add("橹", "L");
            second_class_HZ.Add("檑", "L");
            second_class_HZ.Add("檩", "L");
            second_class_HZ.Add("殓", "L");
            second_class_HZ.Add("轳", "L");
            second_class_HZ.Add("轹", "L");
            second_class_HZ.Add("辂", "L");
            second_class_HZ.Add("辘", "L");
            second_class_HZ.Add("辚", "L");
            second_class_HZ.Add("瓴", "L");
            second_class_HZ.Add("旯", "L");
            second_class_HZ.Add("赉", "L");
            second_class_HZ.Add("氇", "L");
            second_class_HZ.Add("胧", "L");
            second_class_HZ.Add("胪", "L");
            second_class_HZ.Add("脶", "L");
            second_class_HZ.Add("膂", "L");
            second_class_HZ.Add("臁", "L");
            second_class_HZ.Add("膦", "L");
            second_class_HZ.Add("斓", "L");
            second_class_HZ.Add("旒", "L");
            second_class_HZ.Add("熘", "L");
            second_class_HZ.Add("戾", "L");
            second_class_HZ.Add("砺", "L");
            second_class_HZ.Add("砻", "L");
            second_class_HZ.Add("砬", "L");
            second_class_HZ.Add("睐", "L");
            second_class_HZ.Add("瞵", "L");
            second_class_HZ.Add("詈", "L");
            second_class_HZ.Add("罱", "L");
            second_class_HZ.Add("罹", "L");
            second_class_HZ.Add("钌", "L");
            second_class_HZ.Add("铑", "L");
            second_class_HZ.Add("铹", "L");
            second_class_HZ.Add("铼", "L");
            second_class_HZ.Add("锂", "L");
            second_class_HZ.Add("锊", "L");
            second_class_HZ.Add("锍", "L");
            second_class_HZ.Add("锒", "L");
            second_class_HZ.Add("镂", "L");
            second_class_HZ.Add("镏", "L");
            second_class_HZ.Add("镙", "L");
            second_class_HZ.Add("镥", "L");
            second_class_HZ.Add("镧", "L");
            second_class_HZ.Add("稆", "L");
            second_class_HZ.Add("稂", "L");
            second_class_HZ.Add("鸬", "L");
            second_class_HZ.Add("鸾", "L");
            second_class_HZ.Add("鹂", "L");
            second_class_HZ.Add("鹨", "L");
            second_class_HZ.Add("鹩", "L");
            second_class_HZ.Add("鹭", "L");
            second_class_HZ.Add("疠", "L");
            second_class_HZ.Add("疬", "L");
            second_class_HZ.Add("痨", "L");
            second_class_HZ.Add("瘌", "L");
            second_class_HZ.Add("瘘", "L");
            second_class_HZ.Add("瘰", "L");
            second_class_HZ.Add("癃", "L");
            second_class_HZ.Add("癞", "L");
            second_class_HZ.Add("裢", "L");
            second_class_HZ.Add("裣", "L");
            second_class_HZ.Add("褛", "L");
            second_class_HZ.Add("褴", "L");
            second_class_HZ.Add("耒", "L");
            second_class_HZ.Add("耢", "L");
            second_class_HZ.Add("耧", "L");
            second_class_HZ.Add("聆", "L");
            second_class_HZ.Add("蛎", "L");
            second_class_HZ.Add("蛉", "L");
            second_class_HZ.Add("蜊", "L");
            second_class_HZ.Add("螂", "L");
            second_class_HZ.Add("蝼", "L");
            second_class_HZ.Add("蠊", "L");
            second_class_HZ.Add("蠡", "L");
            second_class_HZ.Add("笠", "L");
            second_class_HZ.Add("篥", "L");
            second_class_HZ.Add("簏", "L");
            second_class_HZ.Add("籁", "L");
            second_class_HZ.Add("舻", "L");
            second_class_HZ.Add("粝", "L");
            second_class_HZ.Add("粼", "L");
            second_class_HZ.Add("翎", "L");
            second_class_HZ.Add("趔", "L");
            second_class_HZ.Add("酹", "L");
            second_class_HZ.Add("醪", "L");
            second_class_HZ.Add("醴", "L");
            second_class_HZ.Add("跞", "L");
            second_class_HZ.Add("踉", "L");
            second_class_HZ.Add("躏", "L");
            second_class_HZ.Add("躐", "L");
            second_class_HZ.Add("靓", "L");
            second_class_HZ.Add("雳", "L");
            second_class_HZ.Add("雒", "L");
            second_class_HZ.Add("銮", "L");
            second_class_HZ.Add("鎏", "L");
            second_class_HZ.Add("鲈", "L");
            second_class_HZ.Add("鲡", "L");
            second_class_HZ.Add("鲢", "L");
            second_class_HZ.Add("鲮", "L");
            second_class_HZ.Add("鳓", "L");
            second_class_HZ.Add("鳢", "L");
            second_class_HZ.Add("髅", "L");
            second_class_HZ.Add("魉", "L");
            second_class_HZ.Add("鬣", "L");
            second_class_HZ.Add("麟", "L");
            second_class_HZ.Add("黧", "L");
            second_class_HZ.Add("芈", "M");
            second_class_HZ.Add("仫", "M");
            second_class_HZ.Add("侔", "M");
            second_class_HZ.Add("袤", "M");
            second_class_HZ.Add("冥", "M");
            second_class_HZ.Add("谟", "M");
            second_class_HZ.Add("谧", "M");
            second_class_HZ.Add("邙", "M");
            second_class_HZ.Add("劢", "M");
            second_class_HZ.Add("勐", "M");
            second_class_HZ.Add("坶", "M");
            second_class_HZ.Add("墁", "M");
            second_class_HZ.Add("茉", "M");
            second_class_HZ.Add("苜", "M");
            second_class_HZ.Add("茆", "M");
            second_class_HZ.Add("苠", "M");
            second_class_HZ.Add("茗", "M");
            second_class_HZ.Add("荬", "M");
            second_class_HZ.Add("莓", "M");
            second_class_HZ.Add("蓦", "M");
            second_class_HZ.Add("甍", "M");
            second_class_HZ.Add("瞢", "M");
            second_class_HZ.Add("蘼", "M");
            second_class_HZ.Add("扪", "M");
            second_class_HZ.Add("呒", "M");
            second_class_HZ.Add("咩", "M");
            second_class_HZ.Add("咪", "M");
            second_class_HZ.Add("哞", "M");
            second_class_HZ.Add("唛", "M");
            second_class_HZ.Add("喵", "M");
            second_class_HZ.Add("嘧", "M");
            second_class_HZ.Add("幔", "M");
            second_class_HZ.Add("峁", "M");
            second_class_HZ.Add("岷", "M");
            second_class_HZ.Add("嵋", "M");
            second_class_HZ.Add("犸", "M");
            second_class_HZ.Add("猕", "M");
            second_class_HZ.Add("猸", "M");
            second_class_HZ.Add("馍", "M");
            second_class_HZ.Add("懵", "M");
            second_class_HZ.Add("闵", "M");
            second_class_HZ.Add("沐", "M");
            second_class_HZ.Add("沔", "M");
            second_class_HZ.Add("汨", "M");
            second_class_HZ.Add("泖", "M");
            second_class_HZ.Add("泯", "M");
            second_class_HZ.Add("浼", "M");
            second_class_HZ.Add("渑", "M");
            second_class_HZ.Add("湎", "M");
            second_class_HZ.Add("湄", "M");
            second_class_HZ.Add("漭", "M");
            second_class_HZ.Add("溟", "M");
            second_class_HZ.Add("宓", "M");
            second_class_HZ.Add("邈", "M");
            second_class_HZ.Add("弭", "M");
            second_class_HZ.Add("嫫", "M");
            second_class_HZ.Add("嬷", "M");
            second_class_HZ.Add("缈", "M");
            second_class_HZ.Add("缗", "M");
            second_class_HZ.Add("缦", "M");
            second_class_HZ.Add("缪", "M");
            second_class_HZ.Add("玟", "M");
            second_class_HZ.Add("珉", "M");
            second_class_HZ.Add("瑁", "M");
            second_class_HZ.Add("杩", "M");
            second_class_HZ.Add("杪", "M");
            second_class_HZ.Add("楣", "M");
            second_class_HZ.Add("殁", "M");
            second_class_HZ.Add("昴", "M");
            second_class_HZ.Add("暝", "M");
            second_class_HZ.Add("牦", "M");
            second_class_HZ.Add("耄", "M");
            second_class_HZ.Add("毪", "M");
            second_class_HZ.Add("脒", "M");
            second_class_HZ.Add("腼", "M");
            second_class_HZ.Add("朦", "M");
            second_class_HZ.Add("旄", "M");
            second_class_HZ.Add("焖", "M");
            second_class_HZ.Add("熳", "M");
            second_class_HZ.Add("祢", "M");
            second_class_HZ.Add("愍", "M");
            second_class_HZ.Add("懋", "M");
            second_class_HZ.Add("懑", "M");
            second_class_HZ.Add("淼", "M");
            second_class_HZ.Add("硭", "M");
            second_class_HZ.Add("礞", "M");
            second_class_HZ.Add("眄", "M");
            second_class_HZ.Add("眇", "M");
            second_class_HZ.Add("眸", "M");
            second_class_HZ.Add("瞀", "M");
            second_class_HZ.Add("瞑", "M");
            second_class_HZ.Add("钔", "M");
            second_class_HZ.Add("钼", "M");
            second_class_HZ.Add("镅", "M");
            second_class_HZ.Add("镆", "M");
            second_class_HZ.Add("镘", "M");
            second_class_HZ.Add("秣", "M");
            second_class_HZ.Add("鹋", "M");
            second_class_HZ.Add("鹛", "M");
            second_class_HZ.Add("瘼", "M");
            second_class_HZ.Add("袂", "M");
            second_class_HZ.Add("耱", "M");
            second_class_HZ.Add("颟", "M");
            second_class_HZ.Add("虻", "M");
            second_class_HZ.Add("蛑", "M");
            second_class_HZ.Add("蜢", "M");
            second_class_HZ.Add("蝥", "M");
            second_class_HZ.Add("螨", "M");
            second_class_HZ.Add("蟒", "M");
            second_class_HZ.Add("蟆", "M");
            second_class_HZ.Add("蟊", "M");
            second_class_HZ.Add("蠓", "M");
            second_class_HZ.Add("蠛", "M");
            second_class_HZ.Add("篾", "M");
            second_class_HZ.Add("艋", "M");
            second_class_HZ.Add("艨", "M");
            second_class_HZ.Add("敉", "M");
            second_class_HZ.Add("酩", "M");
            second_class_HZ.Add("貊", "M");
            second_class_HZ.Add("貘", "M");
            second_class_HZ.Add("霾", "M");
            second_class_HZ.Add("黾", "M");
            second_class_HZ.Add("鍪", "M");
            second_class_HZ.Add("鳗", "M");
            second_class_HZ.Add("鳘", "M");
            second_class_HZ.Add("鞔", "M");
            second_class_HZ.Add("魅", "M");
            second_class_HZ.Add("髦", "M");
            second_class_HZ.Add("麽", "M");
            second_class_HZ.Add("縻", "M");
            second_class_HZ.Add("麋", "M");
            second_class_HZ.Add("廿", "N");
            second_class_HZ.Add("孬", "N");
            second_class_HZ.Add("鼐", "N");
            second_class_HZ.Add("乜", "N");
            second_class_HZ.Add("佞", "N");
            second_class_HZ.Add("伲", "N");
            second_class_HZ.Add("侬", "N");
            second_class_HZ.Add("傩", "N");
            second_class_HZ.Add("讷", "N");
            second_class_HZ.Add("陧", "N");
            second_class_HZ.Add("坭", "N");
            second_class_HZ.Add("垴", "N");
            second_class_HZ.Add("埝", "N");
            second_class_HZ.Add("艿", "N");
            second_class_HZ.Add("茑", "N");
            second_class_HZ.Add("萘", "N");
            second_class_HZ.Add("蘖", "N");
            second_class_HZ.Add("拗", "N");
            second_class_HZ.Add("捺", "N");
            second_class_HZ.Add("搦", "N");
            second_class_HZ.Add("攮", "N");
            second_class_HZ.Add("咛", "N");
            second_class_HZ.Add("呶", "N");
            second_class_HZ.Add("哝", "N");
            second_class_HZ.Add("喏", "N");
            second_class_HZ.Add("喃", "N");
            second_class_HZ.Add("嗫", "N");
            second_class_HZ.Add("囔", "N");
            second_class_HZ.Add("囡", "N");
            second_class_HZ.Add("狃", "N");
            second_class_HZ.Add("猊", "N");
            second_class_HZ.Add("猱", "N");
            second_class_HZ.Add("馕", "N");
            second_class_HZ.Add("忸", "N");
            second_class_HZ.Add("怩", "N");
            second_class_HZ.Add("甯", "N");
            second_class_HZ.Add("弩", "N");
            second_class_HZ.Add("妞", "N");
            second_class_HZ.Add("胬", "N");
            second_class_HZ.Add("嬲", "N");
            second_class_HZ.Add("孥", "N");
            second_class_HZ.Add("驽", "N");
            second_class_HZ.Add("瑙", "N");
            second_class_HZ.Add("柰", "N");
            second_class_HZ.Add("楠", "N");
            second_class_HZ.Add("辇", "N");
            second_class_HZ.Add("昵", "N");
            second_class_HZ.Add("曩", "N");
            second_class_HZ.Add("肭", "N");
            second_class_HZ.Add("脲", "N");
            second_class_HZ.Add("腩", "N");
            second_class_HZ.Add("旎", "N");
            second_class_HZ.Add("恧", "N");
            second_class_HZ.Add("恁", "N");
            second_class_HZ.Add("硇", "N");
            second_class_HZ.Add("睨", "N");
            second_class_HZ.Add("钕", "N");
            second_class_HZ.Add("铌", "N");
            second_class_HZ.Add("铙", "N");
            second_class_HZ.Add("锘", "N");
            second_class_HZ.Add("镎", "N");
            second_class_HZ.Add("黏", "N");
            second_class_HZ.Add("衲", "N");
            second_class_HZ.Add("耨", "N");
            second_class_HZ.Add("聍", "N");
            second_class_HZ.Add("颞", "N");
            second_class_HZ.Add("蛲", "N");
            second_class_HZ.Add("蝻", "N");
            second_class_HZ.Add("臬", "N");
            second_class_HZ.Add("衄", "N");
            second_class_HZ.Add("袅", "N");
            second_class_HZ.Add("赧", "N");
            second_class_HZ.Add("蹑", "N");
            second_class_HZ.Add("鲇", "N");
            second_class_HZ.Add("鲵", "N");
            second_class_HZ.Add("鲶", "N");
            second_class_HZ.Add("讴", "O");
            second_class_HZ.Add("噢", "O");
            second_class_HZ.Add("怄", "O");
            second_class_HZ.Add("瓯", "O");
            second_class_HZ.Add("耦", "O");
            second_class_HZ.Add("丕", "P");
            second_class_HZ.Add("丿", "P");
            second_class_HZ.Add("叵", "P");
            second_class_HZ.Add("剽", "P");
            second_class_HZ.Add("仳", "P");
            second_class_HZ.Add("俜", "P");
            second_class_HZ.Add("俳", "P");
            second_class_HZ.Add("匍", "P");
            second_class_HZ.Add("裒", "P");
            second_class_HZ.Add("冖", "P");
            second_class_HZ.Add("谝", "P");
            second_class_HZ.Add("陴", "P");
            second_class_HZ.Add("邳", "P");
            second_class_HZ.Add("郫", "P");
            second_class_HZ.Add("鄱", "P");
            second_class_HZ.Add("圮", "P");
            second_class_HZ.Add("埤", "P");
            second_class_HZ.Add("堋", "P");
            second_class_HZ.Add("鼙", "P");
            second_class_HZ.Add("芘", "P");
            second_class_HZ.Add("苤", "P");
            second_class_HZ.Add("葩", "P");
            second_class_HZ.Add("蒎", "P");
            second_class_HZ.Add("匏", "P");
            second_class_HZ.Add("拚", "P");
            second_class_HZ.Add("掊", "P");
            second_class_HZ.Add("擗", "P");
            second_class_HZ.Add("哌", "P");
            second_class_HZ.Add("辔", "P");
            second_class_HZ.Add("嘌", "P");
            second_class_HZ.Add("嘭", "P");
            second_class_HZ.Add("噗", "P");
            second_class_HZ.Add("噼", "P");
            second_class_HZ.Add("帔", "P");
            second_class_HZ.Add("彷", "P");
            second_class_HZ.Add("狍", "P");
            second_class_HZ.Add("庀", "P");
            second_class_HZ.Add("庖", "P");
            second_class_HZ.Add("怦", "P");
            second_class_HZ.Add("爿", "P");
            second_class_HZ.Add("泮", "P");
            second_class_HZ.Add("淠", "P");
            second_class_HZ.Add("湓", "P");
            second_class_HZ.Add("溥", "P");
            second_class_HZ.Add("滂", "P");
            second_class_HZ.Add("濮", "P");
            second_class_HZ.Add("逄", "P");
            second_class_HZ.Add("姘", "P");
            second_class_HZ.Add("娉", "P");
            second_class_HZ.Add("媲", "P");
            second_class_HZ.Add("嫔", "P");
            second_class_HZ.Add("嫖", "P");
            second_class_HZ.Add("骈", "P");
            second_class_HZ.Add("纰", "P");
            second_class_HZ.Add("缥", "P");
            second_class_HZ.Add("珀", "P");
            second_class_HZ.Add("璞", "P");
            second_class_HZ.Add("枇", "P");
            second_class_HZ.Add("杷", "P");
            second_class_HZ.Add("枰", "P");
            second_class_HZ.Add("榀", "P");
            second_class_HZ.Add("殍", "P");
            second_class_HZ.Add("甓", "P");
            second_class_HZ.Add("攴", "P");
            second_class_HZ.Add("牝", "P");
            second_class_HZ.Add("犏", "P");
            second_class_HZ.Add("氆", "P");
            second_class_HZ.Add("氕", "P");
            second_class_HZ.Add("胼", "P");
            second_class_HZ.Add("脬", "P");
            second_class_HZ.Add("旆", "P");
            second_class_HZ.Add("睥", "P");
            second_class_HZ.Add("瞟", "P");
            second_class_HZ.Add("罴", "P");
            second_class_HZ.Add("钋", "P");
            second_class_HZ.Add("钷", "P");
            second_class_HZ.Add("铍", "P");
            second_class_HZ.Add("锫", "P");
            second_class_HZ.Add("镤", "P");
            second_class_HZ.Add("镨", "P");
            second_class_HZ.Add("皤", "P");
            second_class_HZ.Add("疱", "P");
            second_class_HZ.Add("癖", "P");
            second_class_HZ.Add("袢", "P");
            second_class_HZ.Add("襻", "P");
            second_class_HZ.Add("颦", "P");
            second_class_HZ.Add("蚍", "P");
            second_class_HZ.Add("蜱", "P");
            second_class_HZ.Add("螃", "P");
            second_class_HZ.Add("螵", "P");
            second_class_HZ.Add("蟛", "P");
            second_class_HZ.Add("蟠", "P");
            second_class_HZ.Add("笸", "P");
            second_class_HZ.Add("筢", "P");
            second_class_HZ.Add("翩", "P");
            second_class_HZ.Add("醅", "P");
            second_class_HZ.Add("蹁", "P");
            second_class_HZ.Add("蹒", "P");
            second_class_HZ.Add("蹼", "P");
            second_class_HZ.Add("貔", "P");
            second_class_HZ.Add("霈", "P");
            second_class_HZ.Add("鲆", "P");
            second_class_HZ.Add("亓", "Q");
            second_class_HZ.Add("劁", "Q");
            second_class_HZ.Add("俅", "Q");
            second_class_HZ.Add("倩", "Q");
            second_class_HZ.Add("佥", "Q");
            second_class_HZ.Add("诎", "Q");
            second_class_HZ.Add("诠", "Q");
            second_class_HZ.Add("诮", "Q");
            second_class_HZ.Add("谯", "Q");
            second_class_HZ.Add("阡", "Q");
            second_class_HZ.Add("邛", "Q");
            second_class_HZ.Add("郄", "Q");
            second_class_HZ.Add("劬", "Q");
            second_class_HZ.Add("凵", "Q");
            second_class_HZ.Add("巯", "Q");
            second_class_HZ.Add("圻", "Q");
            second_class_HZ.Add("芊", "Q");
            second_class_HZ.Add("芑", "Q");
            second_class_HZ.Add("芩", "Q");
            second_class_HZ.Add("芡", "Q");
            second_class_HZ.Add("芪", "Q");
            second_class_HZ.Add("苘", "Q");
            second_class_HZ.Add("茕", "Q");
            second_class_HZ.Add("茜", "Q");
            second_class_HZ.Add("荞", "Q");
            second_class_HZ.Add("荃", "Q");
            second_class_HZ.Add("荠", "Q");
            second_class_HZ.Add("荨", "Q");
            second_class_HZ.Add("萁", "Q");
            second_class_HZ.Add("萋", "Q");
            second_class_HZ.Add("葜", "Q");
            second_class_HZ.Add("葺", "Q");
            second_class_HZ.Add("蕖", "Q");
            second_class_HZ.Add("蕲", "Q");
            second_class_HZ.Add("蘧", "Q");
            second_class_HZ.Add("掮", "Q");
            second_class_HZ.Add("揿", "Q");
            second_class_HZ.Add("吣", "Q");
            second_class_HZ.Add("嗪", "Q");
            second_class_HZ.Add("嘁", "Q");
            second_class_HZ.Add("噙", "Q");
            second_class_HZ.Add("圊", "Q");
            second_class_HZ.Add("屺", "Q");
            second_class_HZ.Add("岍", "Q");
            second_class_HZ.Add("岐", "Q");
            second_class_HZ.Add("岖", "Q");
            second_class_HZ.Add("峤", "Q");
            second_class_HZ.Add("衢", "Q");
            second_class_HZ.Add("犰", "Q");
            second_class_HZ.Add("悭", "Q");
            second_class_HZ.Add("悛", "Q");
            second_class_HZ.Add("惬", "Q");
            second_class_HZ.Add("愀", "Q");
            second_class_HZ.Add("慊", "Q");
            second_class_HZ.Add("憔", "Q");
            second_class_HZ.Add("阒", "Q");
            second_class_HZ.Add("阕", "Q");
            second_class_HZ.Add("阙", "Q");
            second_class_HZ.Add("戕", "Q");
            second_class_HZ.Add("汔", "Q");
            second_class_HZ.Add("淇", "Q");
            second_class_HZ.Add("湫", "Q");
            second_class_HZ.Add("溱", "Q");
            second_class_HZ.Add("搴", "Q");
            second_class_HZ.Add("褰", "Q");
            second_class_HZ.Add("逑", "Q");
            second_class_HZ.Add("逡", "Q");
            second_class_HZ.Add("遒", "Q");
            second_class_HZ.Add("妾", "Q");
            second_class_HZ.Add("嫱", "Q");
            second_class_HZ.Add("骐", "Q");
            second_class_HZ.Add("绮", "Q");
            second_class_HZ.Add("绻", "Q");
            second_class_HZ.Add("缱", "Q");
            second_class_HZ.Add("缲", "Q");
            second_class_HZ.Add("琪", "Q");
            second_class_HZ.Add("琦", "Q");
            second_class_HZ.Add("璩", "Q");
            second_class_HZ.Add("杞", "Q");
            second_class_HZ.Add("桤", "Q");
            second_class_HZ.Add("椠", "Q");
            second_class_HZ.Add("楸", "Q");
            second_class_HZ.Add("樯", "Q");
            second_class_HZ.Add("槭", "Q");
            second_class_HZ.Add("檠", "Q");
            second_class_HZ.Add("樵", "Q");
            second_class_HZ.Add("檎", "Q");
            second_class_HZ.Add("辁", "Q");
            second_class_HZ.Add("戗", "Q");
            second_class_HZ.Add("耆", "Q");
            second_class_HZ.Add("赇", "Q");
            second_class_HZ.Add("觑", "Q");
            second_class_HZ.Add("挈", "Q");
            second_class_HZ.Add("氍", "Q");
            second_class_HZ.Add("肷", "Q");
            second_class_HZ.Add("朐", "Q");
            second_class_HZ.Add("欹", "Q");
            second_class_HZ.Add("炝", "Q");
            second_class_HZ.Add("祛", "Q");
            second_class_HZ.Add("祺", "Q");
            second_class_HZ.Add("悫", "Q");
            second_class_HZ.Add("愆", "Q");
            second_class_HZ.Add("憩", "Q");
            second_class_HZ.Add("硗", "Q");
            second_class_HZ.Add("碛", "Q");
            second_class_HZ.Add("磬", "Q");
            second_class_HZ.Add("磲", "Q");
            second_class_HZ.Add("畎", "Q");
            second_class_HZ.Add("钤", "Q");
            second_class_HZ.Add("铨", "Q");
            second_class_HZ.Add("锓", "Q");
            second_class_HZ.Add("锖", "Q");
            second_class_HZ.Add("锲", "Q");
            second_class_HZ.Add("锵", "Q");
            second_class_HZ.Add("镪", "Q");
            second_class_HZ.Add("鸲", "Q");
            second_class_HZ.Add("癯", "Q");
            second_class_HZ.Add("穹", "Q");
            second_class_HZ.Add("襁", "Q");
            second_class_HZ.Add("覃", "Q");
            second_class_HZ.Add("颀", "Q");
            second_class_HZ.Add("虔", "Q");
            second_class_HZ.Add("虬", "Q");
            second_class_HZ.Add("蚯", "Q");
            second_class_HZ.Add("蛩", "Q");
            second_class_HZ.Add("蛐", "Q");
            second_class_HZ.Add("蛴", "Q");
            second_class_HZ.Add("蜣", "Q");
            second_class_HZ.Add("蜻", "Q");
            second_class_HZ.Add("蜞", "Q");
            second_class_HZ.Add("蜷", "Q");
            second_class_HZ.Add("螓", "Q");
            second_class_HZ.Add("蠼", "Q");
            second_class_HZ.Add("罄", "Q");
            second_class_HZ.Add("筇", "Q");
            second_class_HZ.Add("筌", "Q");
            second_class_HZ.Add("箐", "Q");
            second_class_HZ.Add("箧", "Q");
            second_class_HZ.Add("箝", "Q");
            second_class_HZ.Add("衾", "Q");
            second_class_HZ.Add("裘", "Q");
            second_class_HZ.Add("羟", "Q");
            second_class_HZ.Add("糗", "Q");
            second_class_HZ.Add("綦", "Q");
            second_class_HZ.Add("綮", "Q");
            second_class_HZ.Add("麴", "Q");
            second_class_HZ.Add("跫", "Q");
            second_class_HZ.Add("跄", "Q");
            second_class_HZ.Add("跷", "Q");
            second_class_HZ.Add("蹊", "Q");
            second_class_HZ.Add("謦", "Q");
            second_class_HZ.Add("瞿", "Q");
            second_class_HZ.Add("銎", "Q");
            second_class_HZ.Add("鲭", "Q");
            second_class_HZ.Add("鳅", "Q");
            second_class_HZ.Add("鳍", "Q");
            second_class_HZ.Add("鞒", "Q");
            second_class_HZ.Add("髂", "Q");
            second_class_HZ.Add("鬈", "Q");
            second_class_HZ.Add("麒", "Q");
            second_class_HZ.Add("黢", "Q");
            second_class_HZ.Add("黥", "Q");
            second_class_HZ.Add("鼽", "Q");
            second_class_HZ.Add("仞", "R");
            second_class_HZ.Add("偌", "R");
            second_class_HZ.Add("芮", "R");
            second_class_HZ.Add("苒", "R");
            second_class_HZ.Add("荛", "R");
            second_class_HZ.Add("荏", "R");
            second_class_HZ.Add("蓐", "R");
            second_class_HZ.Add("蕤", "R");
            second_class_HZ.Add("薷", "R");
            second_class_HZ.Add("嚅", "R");
            second_class_HZ.Add("嵘", "R");
            second_class_HZ.Add("狨", "R");
            second_class_HZ.Add("饪", "R");
            second_class_HZ.Add("洳", "R");
            second_class_HZ.Add("溽", "R");
            second_class_HZ.Add("濡", "R");
            second_class_HZ.Add("娆", "R");
            second_class_HZ.Add("缛", "R");
            second_class_HZ.Add("枘", "R");
            second_class_HZ.Add("桡", "R");
            second_class_HZ.Add("榕", "R");
            second_class_HZ.Add("轫", "R");
            second_class_HZ.Add("肜", "R");
            second_class_HZ.Add("朊", "R");
            second_class_HZ.Add("禳", "R");
            second_class_HZ.Add("睿", "R");
            second_class_HZ.Add("铷", "R");
            second_class_HZ.Add("稔", "R");
            second_class_HZ.Add("穰", "R");
            second_class_HZ.Add("衽", "R");
            second_class_HZ.Add("襦", "R");
            second_class_HZ.Add("颥", "R");
            second_class_HZ.Add("蚋", "R");
            second_class_HZ.Add("蚺", "R");
            second_class_HZ.Add("蝾", "R");
            second_class_HZ.Add("箬", "R");
            second_class_HZ.Add("糅", "R");
            second_class_HZ.Add("蹂", "R");
            second_class_HZ.Add("鞣", "R");
            second_class_HZ.Add("髯", "R");
            second_class_HZ.Add("卅", "S");
            second_class_HZ.Add("丨", "S");
            second_class_HZ.Add("啬", "S");
            second_class_HZ.Add("厍", "S");
            second_class_HZ.Add("厮", "S");
            second_class_HZ.Add("仨", "S");
            second_class_HZ.Add("俟", "S");
            second_class_HZ.Add("倏", "S");
            second_class_HZ.Add("佘", "S");
            second_class_HZ.Add("夙", "S");
            second_class_HZ.Add("兕", "S");
            second_class_HZ.Add("凇", "S");
            second_class_HZ.Add("讪", "S");
            second_class_HZ.Add("诜", "S");
            second_class_HZ.Add("谂", "S");
            second_class_HZ.Add("谇", "S");
            second_class_HZ.Add("谡", "S");
            second_class_HZ.Add("谥", "S");
            second_class_HZ.Add("鄯", "S");
            second_class_HZ.Add("劭", "S");
            second_class_HZ.Add("叟", "S");
            second_class_HZ.Add("厶", "S");
            second_class_HZ.Add("塾", "S");
            second_class_HZ.Add("埏", "S");
            second_class_HZ.Add("垧", "S");
            second_class_HZ.Add("埘", "S");
            second_class_HZ.Add("埽", "S");
            second_class_HZ.Add("芟", "S");
            second_class_HZ.Add("荪", "S");
            second_class_HZ.Add("莳", "S");
            second_class_HZ.Add("荽", "S");
            second_class_HZ.Add("莘", "S");
            second_class_HZ.Add("菘", "S");
            second_class_HZ.Add("菽", "S");
            second_class_HZ.Add("葚", "S");
            second_class_HZ.Add("蓍", "S");
            second_class_HZ.Add("蒴", "S");
            second_class_HZ.Add("蔌", "S");
            second_class_HZ.Add("薮", "S");
            second_class_HZ.Add("摅", "S");
            second_class_HZ.Add("搠", "S");
            second_class_HZ.Add("搡", "S");
            second_class_HZ.Add("弑", "S");
            second_class_HZ.Add("咝", "S");
            second_class_HZ.Add("哂", "S");
            second_class_HZ.Add("唢", "S");
            second_class_HZ.Add("唼", "S");
            second_class_HZ.Add("唰", "S");
            second_class_HZ.Add("嗖", "S");
            second_class_HZ.Add("嗉", "S");
            second_class_HZ.Add("嗦", "S");
            second_class_HZ.Add("嗍", "S");
            second_class_HZ.Add("嗾", "S");
            second_class_HZ.Add("噻", "S");
            second_class_HZ.Add("崧", "S");
            second_class_HZ.Add("嵊", "S");
            second_class_HZ.Add("嵩", "S");
            second_class_HZ.Add("彡", "S");
            second_class_HZ.Add("狩", "S");
            second_class_HZ.Add("狲", "S");
            second_class_HZ.Add("狻", "S");
            second_class_HZ.Add("猞", "S");
            second_class_HZ.Add("飧", "S");
            second_class_HZ.Add("饣", "S");
            second_class_HZ.Add("馊", "S");
            second_class_HZ.Add("馓", "S");
            second_class_HZ.Add("忄", "S");
            second_class_HZ.Add("忪", "S");
            second_class_HZ.Add("悚", "S");
            second_class_HZ.Add("愫", "S");
            second_class_HZ.Add("闩", "S");
            second_class_HZ.Add("氵", "S");
            second_class_HZ.Add("汜", "S");
            second_class_HZ.Add("沭", "S");
            second_class_HZ.Add("泗", "S");
            second_class_HZ.Add("涑", "S");
            second_class_HZ.Add("淞", "S");
            second_class_HZ.Add("渖", "S");
            second_class_HZ.Add("涮", "S");
            second_class_HZ.Add("溲", "S");
            second_class_HZ.Add("滠", "S");
            second_class_HZ.Add("澍", "S");
            second_class_HZ.Add("澌", "S");
            second_class_HZ.Add("潸", "S");
            second_class_HZ.Add("潲", "S");
            second_class_HZ.Add("濉", "S");
            second_class_HZ.Add("邃", "S");
            second_class_HZ.Add("妁", "S");
            second_class_HZ.Add("姒", "S");
            second_class_HZ.Add("姗", "S");
            second_class_HZ.Add("姝", "S");
            second_class_HZ.Add("娑", "S");
            second_class_HZ.Add("嬗", "S");
            second_class_HZ.Add("孀", "S");
            second_class_HZ.Add("驷", "S");
            second_class_HZ.Add("骟", "S");
            second_class_HZ.Add("纾", "S");
            second_class_HZ.Add("绱", "S");
            second_class_HZ.Add("绶", "S");
            second_class_HZ.Add("缌", "S");
            second_class_HZ.Add("缫", "S");
            second_class_HZ.Add("杓", "S");
            second_class_HZ.Add("桫", "S");
            second_class_HZ.Add("榫", "S");
            second_class_HZ.Add("槊", "S");
            second_class_HZ.Add("殇", "S");
            second_class_HZ.Add("轼", "S");
            second_class_HZ.Add("晟", "S");
            second_class_HZ.Add("贳", "S");
            second_class_HZ.Add("挲", "S");
            second_class_HZ.Add("毵", "S");
            second_class_HZ.Add("毹", "S");
            second_class_HZ.Add("胂", "S");
            second_class_HZ.Add("脎", "S");
            second_class_HZ.Add("腧", "S");
            second_class_HZ.Add("臊", "S");
            second_class_HZ.Add("膻", "S");
            second_class_HZ.Add("歃", "S");
            second_class_HZ.Add("飒", "S");
            second_class_HZ.Add("飕", "S");
            second_class_HZ.Add("殳", "S");
            second_class_HZ.Add("炻", "S");
            second_class_HZ.Add("熵", "S");
            second_class_HZ.Add("燧", "S");
            second_class_HZ.Add("礻", "S");
            second_class_HZ.Add("祀", "S");
            second_class_HZ.Add("磉", "S");
            second_class_HZ.Add("眚", "S");
            second_class_HZ.Add("眭", "S");
            second_class_HZ.Add("睃", "S");
            second_class_HZ.Add("睢", "S");
            second_class_HZ.Add("瞍", "S");
            second_class_HZ.Add("畲", "S");
            second_class_HZ.Add("钐", "S");
            second_class_HZ.Add("铄", "S");
            second_class_HZ.Add("铈", "S");
            second_class_HZ.Add("铩", "S");
            second_class_HZ.Add("铯", "S");
            second_class_HZ.Add("锶", "S");
            second_class_HZ.Add("锼", "S");
            second_class_HZ.Add("矧", "S");
            second_class_HZ.Add("秫", "S");
            second_class_HZ.Add("穑", "S");
            second_class_HZ.Add("鸶", "S");
            second_class_HZ.Add("疝", "S");
            second_class_HZ.Add("痧", "S");
            second_class_HZ.Add("瘙", "S");
            second_class_HZ.Add("竦", "S");
            second_class_HZ.Add("耜", "S");
            second_class_HZ.Add("颡", "S");
            second_class_HZ.Add("蛳", "S");
            second_class_HZ.Add("蜃", "S");
            second_class_HZ.Add("蛸", "S");
            second_class_HZ.Add("螋", "S");
            second_class_HZ.Add("螫", "S");
            second_class_HZ.Add("蟀", "S");
            second_class_HZ.Add("蟮", "S");
            second_class_HZ.Add("舐", "S");
            second_class_HZ.Add("笙", "S");
            second_class_HZ.Add("笥", "S");
            second_class_HZ.Add("筮", "S");
            second_class_HZ.Add("筲", "S");
            second_class_HZ.Add("簌", "S");
            second_class_HZ.Add("舢", "S");
            second_class_HZ.Add("艄", "S");
            second_class_HZ.Add("艏", "S");
            second_class_HZ.Add("裟", "S");
            second_class_HZ.Add("羧", "S");
            second_class_HZ.Add("糁", "S");
            second_class_HZ.Add("酾", "S");
            second_class_HZ.Add("豕", "S");
            second_class_HZ.Add("跚", "S");
            second_class_HZ.Add("觞", "S");
            second_class_HZ.Add("觫", "S");
            second_class_HZ.Add("霎", "S");
            second_class_HZ.Add("隼", "S");
            second_class_HZ.Add("稣", "S");
            second_class_HZ.Add("鲥", "S");
            second_class_HZ.Add("鲨", "S");
            second_class_HZ.Add("鲺", "S");
            second_class_HZ.Add("鳋", "S");
            second_class_HZ.Add("鳝", "S");
            second_class_HZ.Add("麝", "S");
            second_class_HZ.Add("乇", "T");
            second_class_HZ.Add("鼗", "T");
            second_class_HZ.Add("冂", "T");
            second_class_HZ.Add("佟", "T");
            second_class_HZ.Add("佗", "T");
            second_class_HZ.Add("佻", "T");
            second_class_HZ.Add("倜", "T");
            second_class_HZ.Add("傥", "T");
            second_class_HZ.Add("僮", "T");
            second_class_HZ.Add("仝", "T");
            second_class_HZ.Add("氽", "T");
            second_class_HZ.Add("邰", "T");
            second_class_HZ.Add("郯", "T");
            second_class_HZ.Add("坨", "T");
            second_class_HZ.Add("堍", "T");
            second_class_HZ.Add("苕", "T");
            second_class_HZ.Add("茼", "T");
            second_class_HZ.Add("莛", "T");
            second_class_HZ.Add("荼", "T");
            second_class_HZ.Add("萜", "T");
            second_class_HZ.Add("菟", "T");
            second_class_HZ.Add("葶", "T");
            second_class_HZ.Add("薹", "T");
            second_class_HZ.Add("扌", "T");
            second_class_HZ.Add("抟", "T");
            second_class_HZ.Add("掭", "T");
            second_class_HZ.Add("忒", "T");
            second_class_HZ.Add("呔", "T");
            second_class_HZ.Add("啕", "T");
            second_class_HZ.Add("嗵", "T");
            second_class_HZ.Add("帑", "T");
            second_class_HZ.Add("饧", "T");
            second_class_HZ.Add("饨", "T");
            second_class_HZ.Add("庹", "T");
            second_class_HZ.Add("恸", "T");
            second_class_HZ.Add("悌", "T");
            second_class_HZ.Add("忝", "T");
            second_class_HZ.Add("闼", "T");
            second_class_HZ.Add("阗", "T");
            second_class_HZ.Add("洮", "T");
            second_class_HZ.Add("溻", "T");
            second_class_HZ.Add("溏", "T");
            second_class_HZ.Add("潼", "T");
            second_class_HZ.Add("逖", "T");
            second_class_HZ.Add("遢", "T");
            second_class_HZ.Add("彖", "T");
            second_class_HZ.Add("婷", "T");
            second_class_HZ.Add("绨", "T");
            second_class_HZ.Add("缇", "T");
            second_class_HZ.Add("瑭", "T");
            second_class_HZ.Add("韬", "T");
            second_class_HZ.Add("柝", "T");
            second_class_HZ.Add("柁", "T");
            second_class_HZ.Add("梃", "T");
            second_class_HZ.Add("榻", "T");
            second_class_HZ.Add("樘", "T");
            second_class_HZ.Add("橐", "T");
            second_class_HZ.Add("殄", "T");
            second_class_HZ.Add("昙", "T");
            second_class_HZ.Add("暾", "T");
            second_class_HZ.Add("肽", "T");
            second_class_HZ.Add("豚", "T");
            second_class_HZ.Add("滕", "T");
            second_class_HZ.Add("炱", "T");
            second_class_HZ.Add("煺", "T");
            second_class_HZ.Add("焘", "T");
            second_class_HZ.Add("祧", "T");
            second_class_HZ.Add("忑", "T");
            second_class_HZ.Add("忐", "T");
            second_class_HZ.Add("慝", "T");
            second_class_HZ.Add("沓", "T");
            second_class_HZ.Add("砼", "T");
            second_class_HZ.Add("砣", "T");
            second_class_HZ.Add("畋", "T");
            second_class_HZ.Add("疃", "T");
            second_class_HZ.Add("钍", "T");
            second_class_HZ.Add("钛", "T");
            second_class_HZ.Add("钽", "T");
            second_class_HZ.Add("铊", "T");
            second_class_HZ.Add("铴", "T");
            second_class_HZ.Add("铽", "T");
            second_class_HZ.Add("锬", "T");
            second_class_HZ.Add("镗", "T");
            second_class_HZ.Add("镡", "T");
            second_class_HZ.Add("鹈", "T");
            second_class_HZ.Add("窕", "T");
            second_class_HZ.Add("裼", "T");
            second_class_HZ.Add("耥", "T");
            second_class_HZ.Add("蜓", "T");
            second_class_HZ.Add("蜩", "T");
            second_class_HZ.Add("螗", "T");
            second_class_HZ.Add("螳", "T");
            second_class_HZ.Add("笤", "T");
            second_class_HZ.Add("箨", "T");
            second_class_HZ.Add("羰", "T");
            second_class_HZ.Add("粜", "T");
            second_class_HZ.Add("酡", "T");
            second_class_HZ.Add("酴", "T");
            second_class_HZ.Add("醍", "T");
            second_class_HZ.Add("醣", "T");
            second_class_HZ.Add("趿", "T");
            second_class_HZ.Add("跎", "T");
            second_class_HZ.Add("跆", "T");
            second_class_HZ.Add("霆", "T");
            second_class_HZ.Add("龆", "T");
            second_class_HZ.Add("鼍", "T");
            second_class_HZ.Add("鲐", "T");
            second_class_HZ.Add("鲦", "T");
            second_class_HZ.Add("鳎", "T");
            second_class_HZ.Add("骰", "T");
            second_class_HZ.Add("餮", "T");
            second_class_HZ.Add("饕", "T");
            second_class_HZ.Add("髫", "T");
            second_class_HZ.Add("兀", "W");
            second_class_HZ.Add("刎", "W");
            second_class_HZ.Add("剜", "W");
            second_class_HZ.Add("罔", "W");
            second_class_HZ.Add("佤", "W");
            second_class_HZ.Add("仵", "W");
            second_class_HZ.Add("倭", "W");
            second_class_HZ.Add("偎", "W");
            second_class_HZ.Add("亠", "W");
            second_class_HZ.Add("诿", "W");
            second_class_HZ.Add("阢", "W");
            second_class_HZ.Add("隈", "W");
            second_class_HZ.Add("隗", "W");
            second_class_HZ.Add("邬", "W");
            second_class_HZ.Add("圩", "W");
            second_class_HZ.Add("圬", "W");
            second_class_HZ.Add("芄", "W");
            second_class_HZ.Add("芴", "W");
            second_class_HZ.Add("莴", "W");
            second_class_HZ.Add("菀", "W");
            second_class_HZ.Add("葳", "W");
            second_class_HZ.Add("蓊", "W");
            second_class_HZ.Add("薇", "W");
            second_class_HZ.Add("蕹", "W");
            second_class_HZ.Add("喔", "W");
            second_class_HZ.Add("囗", "W");
            second_class_HZ.Add("帏", "W");
            second_class_HZ.Add("帷", "W");
            second_class_HZ.Add("幄", "W");
            second_class_HZ.Add("崴", "W");
            second_class_HZ.Add("嵬", "W");
            second_class_HZ.Add("猥", "W");
            second_class_HZ.Add("猬", "W");
            second_class_HZ.Add("庑", "W");
            second_class_HZ.Add("怃", "W");
            second_class_HZ.Add("忤", "W");
            second_class_HZ.Add("惘", "W");
            second_class_HZ.Add("闱", "W");
            second_class_HZ.Add("阌", "W");
            second_class_HZ.Add("汶", "W");
            second_class_HZ.Add("沩", "W");
            second_class_HZ.Add("洧", "W");
            second_class_HZ.Add("浯", "W");
            second_class_HZ.Add("涠", "W");
            second_class_HZ.Add("渥", "W");
            second_class_HZ.Add("寤", "W");
            second_class_HZ.Add("迕", "W");
            second_class_HZ.Add("逶", "W");
            second_class_HZ.Add("妩", "W");
            second_class_HZ.Add("娲", "W");
            second_class_HZ.Add("娓", "W");
            second_class_HZ.Add("婺", "W");
            second_class_HZ.Add("骛", "W");
            second_class_HZ.Add("纨", "W");
            second_class_HZ.Add("绾", "W");
            second_class_HZ.Add("玮", "W");
            second_class_HZ.Add("琬", "W");
            second_class_HZ.Add("璺", "W");
            second_class_HZ.Add("韪", "W");
            second_class_HZ.Add("杌", "W");
            second_class_HZ.Add("辋", "W");
            second_class_HZ.Add("軎", "W");
            second_class_HZ.Add("牾", "W");
            second_class_HZ.Add("肟", "W");
            second_class_HZ.Add("脘", "W");
            second_class_HZ.Add("腽", "W");
            second_class_HZ.Add("炜", "W");
            second_class_HZ.Add("焐", "W");
            second_class_HZ.Add("煨", "W");
            second_class_HZ.Add("硪", "W");
            second_class_HZ.Add("畹", "W");
            second_class_HZ.Add("鹉", "W");
            second_class_HZ.Add("鹜", "W");
            second_class_HZ.Add("痦", "W");
            second_class_HZ.Add("痿", "W");
            second_class_HZ.Add("蜈", "W");
            second_class_HZ.Add("蜿", "W");
            second_class_HZ.Add("箢", "W");
            second_class_HZ.Add("艉", "W");
            second_class_HZ.Add("雯", "W");
            second_class_HZ.Add("龌", "W");
            second_class_HZ.Add("鋈", "W");
            second_class_HZ.Add("鲔", "W");
            second_class_HZ.Add("魍", "W");
            second_class_HZ.Add("鼯", "W");
            second_class_HZ.Add("囟", "X");
            second_class_HZ.Add("偕", "X");
            second_class_HZ.Add("僖", "X");
            second_class_HZ.Add("儇", "X");
            second_class_HZ.Add("兮", "X");
            second_class_HZ.Add("巽", "X");
            second_class_HZ.Add("亵", "X");
            second_class_HZ.Add("冼", "X");
            second_class_HZ.Add("诩", "X");
            second_class_HZ.Add("谑", "X");
            second_class_HZ.Add("谖", "X");
            second_class_HZ.Add("隰", "X");
            second_class_HZ.Add("郇", "X");
            second_class_HZ.Add("郗", "X");
            second_class_HZ.Add("勖", "X");
            second_class_HZ.Add("勰", "X");
            second_class_HZ.Add("燮", "X");
            second_class_HZ.Add("埙", "X");
            second_class_HZ.Add("馨", "X");
            second_class_HZ.Add("芎", "X");
            second_class_HZ.Add("芗", "X");
            second_class_HZ.Add("苋", "X");
            second_class_HZ.Add("荇", "X");
            second_class_HZ.Add("荀", "X");
            second_class_HZ.Add("莶", "X");
            second_class_HZ.Add("菥", "X");
            second_class_HZ.Add("葙", "X");
            second_class_HZ.Add("葸", "X");
            second_class_HZ.Add("萱", "X");
            second_class_HZ.Add("蓰", "X");
            second_class_HZ.Add("蓿", "X");
            second_class_HZ.Add("蕈", "X");
            second_class_HZ.Add("薤", "X");
            second_class_HZ.Add("薰", "X");
            second_class_HZ.Add("藓", "X");
            second_class_HZ.Add("奚", "X");
            second_class_HZ.Add("揎", "X");
            second_class_HZ.Add("撷", "X");
            second_class_HZ.Add("擤", "X");
            second_class_HZ.Add("哓", "X");
            second_class_HZ.Add("咻", "X");
            second_class_HZ.Add("唏", "X");
            second_class_HZ.Add("岘", "X");
            second_class_HZ.Add("岫", "X");
            second_class_HZ.Add("峋", "X");
            second_class_HZ.Add("崤", "X");
            second_class_HZ.Add("徇", "X");
            second_class_HZ.Add("徙", "X");
            second_class_HZ.Add("狎", "X");
            second_class_HZ.Add("猃", "X");
            second_class_HZ.Add("獬", "X");
            second_class_HZ.Add("獯", "X");
            second_class_HZ.Add("饩", "X");
            second_class_HZ.Add("饷", "X");
            second_class_HZ.Add("馐", "X");
            second_class_HZ.Add("庥", "X");
            second_class_HZ.Add("庠", "X");
            second_class_HZ.Add("廨", "X");
            second_class_HZ.Add("恂", "X");
            second_class_HZ.Add("悻", "X");
            second_class_HZ.Add("阋", "X");
            second_class_HZ.Add("泫", "X");
            second_class_HZ.Add("洫", "X");
            second_class_HZ.Add("洵", "X");
            second_class_HZ.Add("浔", "X");
            second_class_HZ.Add("浠", "X");
            second_class_HZ.Add("淅", "X");
            second_class_HZ.Add("渫", "X");
            second_class_HZ.Add("溆", "X");
            second_class_HZ.Add("渲", "X");
            second_class_HZ.Add("溴", "X");
            second_class_HZ.Add("潇", "X");
            second_class_HZ.Add("漩", "X");
            second_class_HZ.Add("瀣", "X");
            second_class_HZ.Add("逍", "X");
            second_class_HZ.Add("遐", "X");
            second_class_HZ.Add("暹", "X");
            second_class_HZ.Add("邂", "X");
            second_class_HZ.Add("屣", "X");
            second_class_HZ.Add("娴", "X");
            second_class_HZ.Add("嬉", "X");
            second_class_HZ.Add("骁", "X");
            second_class_HZ.Add("骧", "X");
            second_class_HZ.Add("绁", "X");
            second_class_HZ.Add("绡", "X");
            second_class_HZ.Add("缃", "X");
            second_class_HZ.Add("缬", "X");
            second_class_HZ.Add("顼", "X");
            second_class_HZ.Add("玺", "X");
            second_class_HZ.Add("瑕", "X");
            second_class_HZ.Add("璇", "X");
            second_class_HZ.Add("枭", "X");
            second_class_HZ.Add("柙", "X");
            second_class_HZ.Add("枵", "X");
            second_class_HZ.Add("栩", "X");
            second_class_HZ.Add("楦", "X");
            second_class_HZ.Add("榭", "X");
            second_class_HZ.Add("榍", "X");
            second_class_HZ.Add("樨", "X");
            second_class_HZ.Add("昕", "X");
            second_class_HZ.Add("暄", "X");
            second_class_HZ.Add("曛", "X");
            second_class_HZ.Add("曦", "X");
            second_class_HZ.Add("觋", "X");
            second_class_HZ.Add("氙", "X");
            second_class_HZ.Add("欷", "X");
            second_class_HZ.Add("歆", "X");
            second_class_HZ.Add("歙", "X");
            second_class_HZ.Add("炫", "X");
            second_class_HZ.Add("煊", "X");
            second_class_HZ.Add("燹", "X");
            second_class_HZ.Add("煦", "X");
            second_class_HZ.Add("熹", "X");
            second_class_HZ.Add("祆", "X");
            second_class_HZ.Add("禊", "X");
            second_class_HZ.Add("禧", "X");
            second_class_HZ.Add("泶", "X");
            second_class_HZ.Add("硎", "X");
            second_class_HZ.Add("硖", "X");
            second_class_HZ.Add("碹", "X");
            second_class_HZ.Add("盱", "X");
            second_class_HZ.Add("铉", "X");
            second_class_HZ.Add("镟", "X");
            second_class_HZ.Add("皙", "X");
            second_class_HZ.Add("鸺", "X");
            second_class_HZ.Add("鹇", "X");
            second_class_HZ.Add("痃", "X");
            second_class_HZ.Add("痫", "X");
            second_class_HZ.Add("穸", "X");
            second_class_HZ.Add("窨", "X");
            second_class_HZ.Add("胥", "X");
            second_class_HZ.Add("蚬", "X");
            second_class_HZ.Add("蜥", "X");
            second_class_HZ.Add("螅", "X");
            second_class_HZ.Add("蟋", "X");
            second_class_HZ.Add("蟓", "X");
            second_class_HZ.Add("罅", "X");
            second_class_HZ.Add("筅", "X");
            second_class_HZ.Add("筱", "X");
            second_class_HZ.Add("箫", "X");
            second_class_HZ.Add("舄", "X");
            second_class_HZ.Add("舾", "X");
            second_class_HZ.Add("羲", "X");
            second_class_HZ.Add("籼", "X");
            second_class_HZ.Add("粞", "X");
            second_class_HZ.Add("糈", "X");
            second_class_HZ.Add("翕", "X");
            second_class_HZ.Add("酰", "X");
            second_class_HZ.Add("醑", "X");
            second_class_HZ.Add("醯", "X");
            second_class_HZ.Add("醺", "X");
            second_class_HZ.Add("踅", "X");
            second_class_HZ.Add("跣", "X");
            second_class_HZ.Add("跹", "X");
            second_class_HZ.Add("躞", "X");
            second_class_HZ.Add("貅", "X");
            second_class_HZ.Add("霰", "X");
            second_class_HZ.Add("鑫", "X");
            second_class_HZ.Add("鲞", "X");
            second_class_HZ.Add("鲟", "X");
            second_class_HZ.Add("鳕", "X");
            second_class_HZ.Add("魈", "X");
            second_class_HZ.Add("飨", "X");
            second_class_HZ.Add("髹", "X");
            second_class_HZ.Add("黠", "X");
            second_class_HZ.Add("鼷", "X");
            second_class_HZ.Add("禺", "Y");
            second_class_HZ.Add("夭", "Y");
            second_class_HZ.Add("爻", "Y");
            second_class_HZ.Add("胤", "Y");
            second_class_HZ.Add("毓", "Y");
            second_class_HZ.Add("厣", "Y");
            second_class_HZ.Add("靥", "Y");
            second_class_HZ.Add("赝", "Y");
            second_class_HZ.Add("卣", "Y");
            second_class_HZ.Add("刈", "Y");
            second_class_HZ.Add("剡", "Y");
            second_class_HZ.Add("劓", "Y");
            second_class_HZ.Add("仡", "Y");
            second_class_HZ.Add("伛", "Y");
            second_class_HZ.Add("伢", "Y");
            second_class_HZ.Add("攸", "Y");
            second_class_HZ.Add("佚", "Y");
            second_class_HZ.Add("侑", "Y");
            second_class_HZ.Add("佾", "Y");
            second_class_HZ.Add("俨", "Y");
            second_class_HZ.Add("俣", "Y");
            second_class_HZ.Add("俑", "Y");
            second_class_HZ.Add("偃", "Y");
            second_class_HZ.Add("龠", "Y");
            second_class_HZ.Add("兖", "Y");
            second_class_HZ.Add("嬴", "Y");
            second_class_HZ.Add("讠", "Y");
            second_class_HZ.Add("谀", "Y");
            second_class_HZ.Add("谒", "Y");
            second_class_HZ.Add("谕", "Y");
            second_class_HZ.Add("谳", "Y");
            second_class_HZ.Add("阽", "Y");
            second_class_HZ.Add("邺", "Y");
            second_class_HZ.Add("郓", "Y");
            second_class_HZ.Add("郢", "Y");
            second_class_HZ.Add("郾", "Y");
            second_class_HZ.Add("鄢", "Y");
            second_class_HZ.Add("鄞", "Y");
            second_class_HZ.Add("壅", "Y");
            second_class_HZ.Add("圯", "Y");
            second_class_HZ.Add("垭", "Y");
            second_class_HZ.Add("垠", "Y");
            second_class_HZ.Add("垸", "Y");
            second_class_HZ.Add("埸", "Y");
            second_class_HZ.Add("堙", "Y");
            second_class_HZ.Add("塬", "Y");
            second_class_HZ.Add("墉", "Y");
            second_class_HZ.Add("懿", "Y");
            second_class_HZ.Add("芫", "Y");
            second_class_HZ.Add("芸", "Y");
            second_class_HZ.Add("苡", "Y");
            second_class_HZ.Add("茚", "Y");
            second_class_HZ.Add("茔", "Y");
            second_class_HZ.Add("荑", "Y");
            second_class_HZ.Add("荥", "Y");
            second_class_HZ.Add("莠", "Y");
            second_class_HZ.Add("莜", "Y");
            second_class_HZ.Add("莸", "Y");
            second_class_HZ.Add("莺", "Y");
            second_class_HZ.Add("萸", "Y");
            second_class_HZ.Add("菸", "Y");
            second_class_HZ.Add("萦", "Y");
            second_class_HZ.Add("蓥", "Y");
            second_class_HZ.Add("蓣", "Y");
            second_class_HZ.Add("薏", "Y");
            second_class_HZ.Add("弈", "Y");
            second_class_HZ.Add("奕", "Y");
            second_class_HZ.Add("尢", "Y");
            second_class_HZ.Add("挹", "Y");
            second_class_HZ.Add("揶", "Y");
            second_class_HZ.Add("揠", "Y");
            second_class_HZ.Add("揄", "Y");
            second_class_HZ.Add("掾", "Y");
            second_class_HZ.Add("撄", "Y");
            second_class_HZ.Add("弋", "Y");
            second_class_HZ.Add("吆", "Y");
            second_class_HZ.Add("呓", "Y");
            second_class_HZ.Add("吲", "Y");
            second_class_HZ.Add("呦", "Y");
            second_class_HZ.Add("咦", "Y");
            second_class_HZ.Add("哕", "Y");
            second_class_HZ.Add("咿", "Y");
            second_class_HZ.Add("唷", "Y");
            second_class_HZ.Add("喁", "Y");
            second_class_HZ.Add("喑", "Y");
            second_class_HZ.Add("嘤", "Y");
            second_class_HZ.Add("噫", "Y");
            second_class_HZ.Add("囿", "Y");
            second_class_HZ.Add("圄", "Y");
            second_class_HZ.Add("圉", "Y");
            second_class_HZ.Add("岈", "Y");
            second_class_HZ.Add("峄", "Y");
            second_class_HZ.Add("崦", "Y");
            second_class_HZ.Add("崾", "Y");
            second_class_HZ.Add("嵛", "Y");
            second_class_HZ.Add("嶷", "Y");
            second_class_HZ.Add("徉", "Y");
            second_class_HZ.Add("徭", "Y");
            second_class_HZ.Add("狁", "Y");
            second_class_HZ.Add("狳", "Y");
            second_class_HZ.Add("狺", "Y");
            second_class_HZ.Add("猗", "Y");
            second_class_HZ.Add("夤", "Y");
            second_class_HZ.Add("饫", "Y");
            second_class_HZ.Add("饴", "Y");
            second_class_HZ.Add("馀", "Y");
            second_class_HZ.Add("庾", "Y");
            second_class_HZ.Add("膺", "Y");
            second_class_HZ.Add("怏", "Y");
            second_class_HZ.Add("怿", "Y");
            second_class_HZ.Add("怡", "Y");
            second_class_HZ.Add("恹", "Y");
            second_class_HZ.Add("恽", "Y");
            second_class_HZ.Add("悒", "Y");
            second_class_HZ.Add("愠", "Y");
            second_class_HZ.Add("慵", "Y");
            second_class_HZ.Add("闫", "Y");
            second_class_HZ.Add("阈", "Y");
            second_class_HZ.Add("沅", "Y");
            second_class_HZ.Add("泱", "Y");
            second_class_HZ.Add("洇", "Y");
            second_class_HZ.Add("湮", "Y");
            second_class_HZ.Add("滟", "Y");
            second_class_HZ.Add("滢", "Y");
            second_class_HZ.Add("潆", "Y");
            second_class_HZ.Add("漪", "Y");
            second_class_HZ.Add("瀛", "Y");
            second_class_HZ.Add("瀹", "Y");
            second_class_HZ.Add("宥", "Y");
            second_class_HZ.Add("迓", "Y");
            second_class_HZ.Add("迤", "Y");
            second_class_HZ.Add("鬻", "Y");
            second_class_HZ.Add("妍", "Y");
            second_class_HZ.Add("妪", "Y");
            second_class_HZ.Add("妤", "Y");
            second_class_HZ.Add("娅", "Y");
            second_class_HZ.Add("媛", "Y");
            second_class_HZ.Add("嫣", "Y");
            second_class_HZ.Add("驿", "Y");
            second_class_HZ.Add("纡", "Y");
            second_class_HZ.Add("纭", "Y");
            second_class_HZ.Add("缢", "Y");
            second_class_HZ.Add("幺", "Y");
            second_class_HZ.Add("邕", "Y");
            second_class_HZ.Add("琊", "Y");
            second_class_HZ.Add("珧", "Y");
            second_class_HZ.Add("瑛", "Y");
            second_class_HZ.Add("琰", "Y");
            second_class_HZ.Add("瑜", "Y");
            second_class_HZ.Add("瑗", "Y");
            second_class_HZ.Add("璎", "Y");
            second_class_HZ.Add("韫", "Y");
            second_class_HZ.Add("杳", "Y");
            second_class_HZ.Add("柚", "Y");
            second_class_HZ.Add("桠", "Y");
            second_class_HZ.Add("楹", "Y");
            second_class_HZ.Add("樾", "Y");
            second_class_HZ.Add("橼", "Y");
            second_class_HZ.Add("檐", "Y");
            second_class_HZ.Add("猷", "Y");
            second_class_HZ.Add("殒", "Y");
            second_class_HZ.Add("殪", "Y");
            second_class_HZ.Add("轶", "Y");
            second_class_HZ.Add("轺", "Y");
            second_class_HZ.Add("昀", "Y");
            second_class_HZ.Add("昱", "Y");
            second_class_HZ.Add("晔", "Y");
            second_class_HZ.Add("晏", "Y");
            second_class_HZ.Add("曜", "Y");
            second_class_HZ.Add("贻", "Y");
            second_class_HZ.Add("觎", "Y");
            second_class_HZ.Add("氩", "Y");
            second_class_HZ.Add("氤", "Y");
            second_class_HZ.Add("氲", "Y");
            second_class_HZ.Add("牖", "Y");
            second_class_HZ.Add("爰", "Y");
            second_class_HZ.Add("刖", "Y");
            second_class_HZ.Add("肴", "Y");
            second_class_HZ.Add("胭", "Y");
            second_class_HZ.Add("腌", "Y");
            second_class_HZ.Add("腴", "Y");
            second_class_HZ.Add("媵", "Y");
            second_class_HZ.Add("欤", "Y");
            second_class_HZ.Add("於", "Y");
            second_class_HZ.Add("旖", "Y");
            second_class_HZ.Add("炀", "Y");
            second_class_HZ.Add("烨", "Y");
            second_class_HZ.Add("烊", "Y");
            second_class_HZ.Add("焱", "Y");
            second_class_HZ.Add("煜", "Y");
            second_class_HZ.Add("熨", "Y");
            second_class_HZ.Add("熠", "Y");
            second_class_HZ.Add("燠", "Y");
            second_class_HZ.Add("恙", "Y");
            second_class_HZ.Add("肀", "Y");
            second_class_HZ.Add("聿", "Y");
            second_class_HZ.Add("砑", "Y");
            second_class_HZ.Add("眢", "Y");
            second_class_HZ.Add("眙", "Y");
            second_class_HZ.Add("睚", "Y");
            second_class_HZ.Add("罨", "Y");
            second_class_HZ.Add("钇", "Y");
            second_class_HZ.Add("钰", "Y");
            second_class_HZ.Add("钺", "Y");
            second_class_HZ.Add("铕", "Y");
            second_class_HZ.Add("铘", "Y");
            second_class_HZ.Add("铟", "Y");
            second_class_HZ.Add("镒", "Y");
            second_class_HZ.Add("镛", "Y");
            second_class_HZ.Add("镱", "Y");
            second_class_HZ.Add("甬", "Y");
            second_class_HZ.Add("鸢", "Y");
            second_class_HZ.Add("鹆", "Y");
            second_class_HZ.Add("鹞", "Y");
            second_class_HZ.Add("鹦", "Y");
            second_class_HZ.Add("鹬", "Y");
            second_class_HZ.Add("疣", "Y");
            second_class_HZ.Add("痖", "Y");
            second_class_HZ.Add("痍", "Y");
            second_class_HZ.Add("瘐", "Y");
            second_class_HZ.Add("瘀", "Y");
            second_class_HZ.Add("瘗", "Y");
            second_class_HZ.Add("瘿", "Y");
            second_class_HZ.Add("瘾", "Y");
            second_class_HZ.Add("癔", "Y");
            second_class_HZ.Add("翊", "Y");
            second_class_HZ.Add("窈", "Y");
            second_class_HZ.Add("窬", "Y");
            second_class_HZ.Add("窳", "Y");
            second_class_HZ.Add("衤", "Y");
            second_class_HZ.Add("疋", "Y");
            second_class_HZ.Add("颍", "Y");
            second_class_HZ.Add("蚓", "Y");
            second_class_HZ.Add("蚰", "Y");
            second_class_HZ.Add("蚴", "Y");
            second_class_HZ.Add("蛘", "Y");
            second_class_HZ.Add("蜮", "Y");
            second_class_HZ.Add("蜴", "Y");
            second_class_HZ.Add("蝓", "Y");
            second_class_HZ.Add("蝣", "Y");
            second_class_HZ.Add("蝤", "Y");
            second_class_HZ.Add("螈", "Y");
            second_class_HZ.Add("罂", "Y");
            second_class_HZ.Add("竽", "Y");
            second_class_HZ.Add("筵", "Y");
            second_class_HZ.Add("臾", "Y");
            second_class_HZ.Add("舁", "Y");
            second_class_HZ.Add("舣", "Y");
            second_class_HZ.Add("羿", "Y");
            second_class_HZ.Add("翳", "Y");
            second_class_HZ.Add("繇", "Y");
            second_class_HZ.Add("酏", "Y");
            second_class_HZ.Add("酽", "Y");
            second_class_HZ.Add("雩", "Y");
            second_class_HZ.Add("霪", "Y");
            second_class_HZ.Add("龈", "Y");
            second_class_HZ.Add("龉", "Y");
            second_class_HZ.Add("鼋", "Y");
            second_class_HZ.Add("鱿", "Y");
            second_class_HZ.Add("鳐", "Y");
            second_class_HZ.Add("鳙", "Y");
            second_class_HZ.Add("鞅", "Y");
            second_class_HZ.Add("魇", "Y");
            second_class_HZ.Add("餍", "Y");
            second_class_HZ.Add("饔", "Y");
            second_class_HZ.Add("黝", "Y");
            second_class_HZ.Add("黟", "Y");
            second_class_HZ.Add("鼬", "Y");
            second_class_HZ.Add("鼹", "Y");
            second_class_HZ.Add("卮", "Z");
            second_class_HZ.Add("仄", "Z");
            second_class_HZ.Add("赜", "Z");
            second_class_HZ.Add("仉", "Z");
            second_class_HZ.Add("伫", "Z");
            second_class_HZ.Add("侏", "Z");
            second_class_HZ.Add("倬", "Z");
            second_class_HZ.Add("偬", "Z");
            second_class_HZ.Add("俎", "Z");
            second_class_HZ.Add("冢", "Z");
            second_class_HZ.Add("诏", "Z");
            second_class_HZ.Add("诤", "Z");
            second_class_HZ.Add("诹", "Z");
            second_class_HZ.Add("诼", "Z");
            second_class_HZ.Add("谘", "Z");
            second_class_HZ.Add("谪", "Z");
            second_class_HZ.Add("谮", "Z");
            second_class_HZ.Add("谵", "Z");
            second_class_HZ.Add("阝", "Z");
            second_class_HZ.Add("阼", "Z");
            second_class_HZ.Add("陟", "Z");
            second_class_HZ.Add("陬", "Z");
            second_class_HZ.Add("郅", "Z");
            second_class_HZ.Add("邾", "Z");
            second_class_HZ.Add("鄣", "Z");
            second_class_HZ.Add("鄹", "Z");
            second_class_HZ.Add("圳", "Z");
            second_class_HZ.Add("埴", "Z");
            second_class_HZ.Add("芷", "Z");
            second_class_HZ.Add("苎", "Z");
            second_class_HZ.Add("茈", "Z");
            second_class_HZ.Add("茱", "Z");
            second_class_HZ.Add("荮", "Z");
            second_class_HZ.Add("菹", "Z");
            second_class_HZ.Add("蓁", "Z");
            second_class_HZ.Add("蕞", "Z");
            second_class_HZ.Add("奘", "Z");
            second_class_HZ.Add("拶", "Z");
            second_class_HZ.Add("揸", "Z");
            second_class_HZ.Add("搌", "Z");
            second_class_HZ.Add("摭", "Z");
            second_class_HZ.Add("摺", "Z");
            second_class_HZ.Add("撙", "Z");
            second_class_HZ.Add("擢", "Z");
            second_class_HZ.Add("攥", "Z");
            second_class_HZ.Add("吒", "Z");
            second_class_HZ.Add("咂", "Z");
            second_class_HZ.Add("咤", "Z");
            second_class_HZ.Add("哳", "Z");
            second_class_HZ.Add("唣", "Z");
            second_class_HZ.Add("唑", "Z");
            second_class_HZ.Add("啧", "Z");
            second_class_HZ.Add("啭", "Z");
            second_class_HZ.Add("啁", "Z");
            second_class_HZ.Add("帙", "Z");
            second_class_HZ.Add("帻", "Z");
            second_class_HZ.Add("幛", "Z");
            second_class_HZ.Add("峥", "Z");
            second_class_HZ.Add("崽", "Z");
            second_class_HZ.Add("嵫", "Z");
            second_class_HZ.Add("嶂", "Z");
            second_class_HZ.Add("徵", "Z");
            second_class_HZ.Add("獐", "Z");
            second_class_HZ.Add("馇", "Z");
            second_class_HZ.Add("馔", "Z");
            second_class_HZ.Add("忮", "Z");
            second_class_HZ.Add("怍", "Z");
            second_class_HZ.Add("惴", "Z");
            second_class_HZ.Add("浈", "Z");
            second_class_HZ.Add("洙", "Z");
            second_class_HZ.Add("浞", "Z");
            second_class_HZ.Add("渚", "Z");
            second_class_HZ.Add("涿", "Z");
            second_class_HZ.Add("潴", "Z");
            second_class_HZ.Add("濯", "Z");
            second_class_HZ.Add("辶", "Z");
            second_class_HZ.Add("迮", "Z");
            second_class_HZ.Add("彘", "Z");
            second_class_HZ.Add("咫", "Z");
            second_class_HZ.Add("姊", "Z");
            second_class_HZ.Add("妯", "Z");
            second_class_HZ.Add("嫜", "Z");
            second_class_HZ.Add("孳", "Z");
            second_class_HZ.Add("驵", "Z");
            second_class_HZ.Add("驺", "Z");
            second_class_HZ.Add("骓", "Z");
            second_class_HZ.Add("骘", "Z");
            second_class_HZ.Add("纣", "Z");
            second_class_HZ.Add("绉", "Z");
            second_class_HZ.Add("缁", "Z");
            second_class_HZ.Add("缒", "Z");
            second_class_HZ.Add("缜", "Z");
            second_class_HZ.Add("缯", "Z");
            second_class_HZ.Add("缵", "Z");
            second_class_HZ.Add("甾", "Z");
            second_class_HZ.Add("璋", "Z");
            second_class_HZ.Add("瓒", "Z");
            second_class_HZ.Add("杼", "Z");
            second_class_HZ.Add("栉", "Z");
            second_class_HZ.Add("柘", "Z");
            second_class_HZ.Add("枳", "Z");
            second_class_HZ.Add("栀", "Z");
            second_class_HZ.Add("桎", "Z");
            second_class_HZ.Add("桢", "Z");
            second_class_HZ.Add("梓", "Z");
            second_class_HZ.Add("棹", "Z");
            second_class_HZ.Add("椹", "Z");
            second_class_HZ.Add("楂", "Z");
            second_class_HZ.Add("榛", "Z");
            second_class_HZ.Add("槠", "Z");
            second_class_HZ.Add("橥", "Z");
            second_class_HZ.Add("樽", "Z");
            second_class_HZ.Add("轵", "Z");
            second_class_HZ.Add("轸", "Z");
            second_class_HZ.Add("轾", "Z");
            second_class_HZ.Add("辄", "Z");
            second_class_HZ.Add("辎", "Z");
            second_class_HZ.Add("臧", "Z");
            second_class_HZ.Add("甑", "Z");
            second_class_HZ.Add("昃", "Z");
            second_class_HZ.Add("昝", "Z");
            second_class_HZ.Add("贽", "Z");
            second_class_HZ.Add("赀", "Z");
            second_class_HZ.Add("赈", "Z");
            second_class_HZ.Add("肫", "Z");
            second_class_HZ.Add("胄", "Z");
            second_class_HZ.Add("胙", "Z");
            second_class_HZ.Add("胗", "Z");
            second_class_HZ.Add("胝", "Z");
            second_class_HZ.Add("朕", "Z");
            second_class_HZ.Add("腙", "Z");
            second_class_HZ.Add("膣", "Z");
            second_class_HZ.Add("旃", "Z");
            second_class_HZ.Add("炷", "Z");
            second_class_HZ.Add("祉", "Z");
            second_class_HZ.Add("祚", "Z");
            second_class_HZ.Add("祗", "Z");
            second_class_HZ.Add("祯", "Z");
            second_class_HZ.Add("禚", "Z");
            second_class_HZ.Add("恣", "Z");
            second_class_HZ.Add("斫", "Z");
            second_class_HZ.Add("砟", "Z");
            second_class_HZ.Add("砦", "Z");
            second_class_HZ.Add("碡", "Z");
            second_class_HZ.Add("磔", "Z");
            second_class_HZ.Add("黹", "Z");
            second_class_HZ.Add("眦", "Z");
            second_class_HZ.Add("畛", "Z");
            second_class_HZ.Add("罾", "Z");
            second_class_HZ.Add("钊", "Z");
            second_class_HZ.Add("钲", "Z");
            second_class_HZ.Add("铢", "Z");
            second_class_HZ.Add("铮", "Z");
            second_class_HZ.Add("锃", "Z");
            second_class_HZ.Add("锱", "Z");
            second_class_HZ.Add("镯", "Z");
            second_class_HZ.Add("锺", "Z");
            second_class_HZ.Add("雉", "Z");
            second_class_HZ.Add("秭", "Z");
            second_class_HZ.Add("稹", "Z");
            second_class_HZ.Add("鸩", "Z");
            second_class_HZ.Add("鸷", "Z");
            second_class_HZ.Add("鹧", "Z");
            second_class_HZ.Add("痄", "Z");
            second_class_HZ.Add("疰", "Z");
            second_class_HZ.Add("痣", "Z");
            second_class_HZ.Add("瘃", "Z");
            second_class_HZ.Add("瘵", "Z");
            second_class_HZ.Add("窀", "Z");
            second_class_HZ.Add("褶", "Z");
            second_class_HZ.Add("耔", "Z");
            second_class_HZ.Add("颛", "Z");
            second_class_HZ.Add("蚱", "Z");
            second_class_HZ.Add("蛭", "Z");
            second_class_HZ.Add("蜇", "Z");
            second_class_HZ.Add("螽", "Z");
            second_class_HZ.Add("蟑", "Z");
            second_class_HZ.Add("竺", "Z");
            second_class_HZ.Add("笊", "Z");
            second_class_HZ.Add("笫", "Z");
            second_class_HZ.Add("笮", "Z");
            second_class_HZ.Add("筝", "Z");
            second_class_HZ.Add("箦", "Z");
            second_class_HZ.Add("箸", "Z");
            second_class_HZ.Add("箴", "Z");
            second_class_HZ.Add("簪", "Z");
            second_class_HZ.Add("籀", "Z");
            second_class_HZ.Add("舯", "Z");
            second_class_HZ.Add("舳", "Z");
            second_class_HZ.Add("舴", "Z");
            second_class_HZ.Add("粢", "Z");
            second_class_HZ.Add("粽", "Z");
            second_class_HZ.Add("糌", "Z");
            second_class_HZ.Add("翥", "Z");
            second_class_HZ.Add("絷", "Z");
            second_class_HZ.Add("趑", "Z");
            second_class_HZ.Add("趱", "Z");
            second_class_HZ.Add("赭", "Z");
            second_class_HZ.Add("酎", "Z");
            second_class_HZ.Add("酢", "Z");
            second_class_HZ.Add("酯", "Z");
            second_class_HZ.Add("跖", "Z");
            second_class_HZ.Add("踬", "Z");
            second_class_HZ.Add("踯", "Z");
            second_class_HZ.Add("踵", "Z");
            second_class_HZ.Add("躅", "Z");
            second_class_HZ.Add("躜", "Z");
            second_class_HZ.Add("豸", "Z");
            second_class_HZ.Add("觜", "Z");
            second_class_HZ.Add("觯", "Z");
            second_class_HZ.Add("訾", "Z");
            second_class_HZ.Add("龇", "Z");
            second_class_HZ.Add("隹", "Z");
            second_class_HZ.Add("錾", "Z");
            second_class_HZ.Add("鲰", "Z");
            second_class_HZ.Add("鲻", "Z");
            second_class_HZ.Add("鳟", "Z");
            second_class_HZ.Add("髭", "Z");
            second_class_HZ.Add("麈", "Z");
            second_class_HZ.Add("齄", "Z");
            second_class_HZ.Add("（", "(");
            second_class_HZ.Add("）", ")");


        }
    }
} 
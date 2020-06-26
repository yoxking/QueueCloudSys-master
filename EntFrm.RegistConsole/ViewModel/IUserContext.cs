using EntFrm.Framework.Utility;
using Newtonsoft.Json;
using System;

namespace EntFrm.RegistConsole
{
    public class IUserContext
    {  
        public static bool initEncryptDog()
        {
            string keyPath = "";

            //初始化我们的操作加密锁的类
            EncryptDogEx encDog = new EncryptDogEx();
            //这个用于判断系统中是否存在着加密锁。不需要是指定的加密锁, 
            if (encDog.FindPort(0, ref keyPath) != 0)
            {
                //MessageBox.Show("未找到加密锁,请插入加密锁后，再进行操作。");
                return false;
            }
            else
            { 
                //初始化
                return encDog.doInitEntDog(IPublicConsts.ENCKEY, IPublicConsts.WHKey, IPublicConsts.WLKey, IPublicConsts.RHKey, IPublicConsts.RLKey);
            }
        }
        public static EncDogModel getEncryptDog()
        {
            try
            {
                const int strLen = 4;
                string keyPath = "";

                //初始化我们的操作加密锁的类
                EncryptDogEx encDog = new EncryptDogEx();

                //这个用于判断系统中是否存在着加密锁。不需要是指定的加密锁, 
                if (encDog.FindPort(0, ref keyPath) != 0)
                {
                    //MessageBox.Show("未找到加密锁,请插入加密锁后，再进行操作。");
                    return null;
                }
                else
                { 

                    int ret, nlen;
                    string outstring = "";
                    byte[] buf = new byte[strLen];

                    //这个例子与上面的不同之处是，可以读取非固定长度的字符串，它是先从首地址读取字符串的长度，然后再读取相应的字符串
                    //先从地址0读到以前写入的字符串的长度
                    ret = encDog.YReadEx(buf, 0, strLen, IPublicConsts.RHKey, IPublicConsts.RLKey, keyPath);
                    if (ret == 0)
                    {
                        nlen = BitConverter.ToInt32(buf, 0);
                        //再读取相应长度的字符串
                        ret = encDog.YReadString(ref outstring, strLen + 1, nlen, IPublicConsts.RHKey, IPublicConsts.RLKey, keyPath);
                        if (ret == 0)
                        {
                            outstring = encDog.StrDec(outstring, IPublicConsts.ENCKEY);
                            EncDogModel dogCode = JsonConvert.DeserializeObject<EncDogModel>(outstring);

                            return dogCode;
                        }

                    }
                }

                return null;
            }
            catch (Exception ex)
            { return null; }
        }
        
        public static bool setEncryptDog(EncDogModel dogCode)
        {
            if (dogCode == null) { return false; }

            try
            {
                const int strLen = 4;
                string keyPath = "";

                //初始化我们的操作加密锁的类
                EncryptDogEx encDog = new EncryptDogEx();

                //这个用于判断系统中是否存在着加密锁。不需要是指定的加密锁, 
                if (encDog.FindPort(0, ref keyPath) != 0)
                {
                    //MessageBox.Show("未找到加密锁,请插入加密锁后，再进行操作。");
                    return false;
                }
                else
                { 
                    int ret, nlen; 
                    byte[] buf = new byte[strLen];
                    string InString = JsonConvert.SerializeObject(dogCode);

                    //加密数据
                    InString = encDog.StrEnc(InString, IPublicConsts.ENCKEY);

                    nlen = EncryptDogEx.lstrlenA(InString);                     
                    buf = BitConverter.GetBytes(nlen);

                    //写入字符串到地址1
                    ret = encDog.YWriteString(InString, strLen + 1, IPublicConsts.WHKey, IPublicConsts.WLKey, keyPath);
                    if (ret == 0)
                    {
                        //写入字符串的长度到地址0
                        ret = encDog.YWriteEx(buf, 0, strLen, IPublicConsts.WHKey, IPublicConsts.WLKey, keyPath);
                        if (ret == 0)
                        {
                            return true;
                        }
                    }
                }

                return false;
            }
            catch (Exception ex)
            { return false; }
        }
 
    }
}

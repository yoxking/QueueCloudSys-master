using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace EntFrm.RegistConsole
{
    public class IMyPublicUtils
    {
        public static string Get_New16ByteGuid(string sPrefix="")
        {
            try
            {  

                var result = new StringBuilder();
                for (var i = 0; i < 16; i++)
                {
                    var r = new Random(Guid.NewGuid().GetHashCode());
                    result.Append(r.Next(0, 10));
                }

                return sPrefix + result.ToString();
            }
            catch (Exception ex)
            {
                return "";
            }
        }
        public static bool Save_InfoList(List<RegisterInfo> infoList)
        {
            // Create a new crypto provider
            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            FileStream fsDataOut = null;
            CryptoStream csDataOut = null;
            StreamWriter swDataOut = null;

            FileStream fsKeyOut = null;
            BinaryWriter bwKeyOut = null;
            try
            {
                if (infoList != null && infoList.Count > 0)
                {
                    string s = "";
                    string filepath = System.Windows.Forms.Application.StartupPath + "\\data.rcs";
                    fsDataOut = new FileStream(filepath, FileMode.Create);
                    // Create a cryptostream to encrypt to the filestream
                    csDataOut = new CryptoStream(fsDataOut, tdes.CreateEncryptor(), CryptoStreamMode.Write);
                    // Create a StreamWriter to format the output
                    swDataOut = new StreamWriter(csDataOut);

                    foreach (RegisterInfo info in infoList)
                    {
                        s = JsonConvert.SerializeObject(info);

                        swDataOut.WriteLine(s);
                    }

                    swDataOut.Flush();

                    // save the key and IV for future use
                    fsKeyOut = File.Create(System.Windows.Forms.Application.StartupPath + "\\data.key");
                    // use a BinaryWriter to write formatted data to the file
                    bwKeyOut = new BinaryWriter(fsKeyOut);
                    // write data to the file
                    bwKeyOut.Write(tdes.Key);
                    bwKeyOut.Write(tdes.IV);
                    // flush and close
                    bwKeyOut.Flush();


                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (bwKeyOut != null)
                { bwKeyOut.Close(); }
                if (fsKeyOut != null)
                {
                    fsKeyOut.Close();
                }

                if (swDataOut != null)
                {
                    swDataOut.Close();
                }
                if (csDataOut != null)
                { csDataOut.Close(); }
                if (fsDataOut != null)
                { fsDataOut.Close(); }
            }
        }

        public static List<RegisterInfo> Load_InfoList()
        {

            List<RegisterInfo> infoList = new List<RegisterInfo>();
            RegisterInfo info = null;

            // Create a new crypto provider
            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            FileStream fsKeyIn = null;
            BinaryReader brKeyIn = null;

            FileStream fsDataIn = null;
            CryptoStream csDataIn = null;
            StreamReader srDataIn = null;

            try
            {
                string filekey = System.Windows.Forms.Application.StartupPath + "\\data.key";
                string filepath = System.Windows.Forms.Application.StartupPath + "\\data.rcs";
                if (File.Exists(filekey) && File.Exists(filepath))
                {
                    // open the file containing the key and IV
                    fsKeyIn = File.OpenRead(filekey);
                    // use a BinaryReader to read formatted data from the file
                    brKeyIn = new BinaryReader(fsKeyIn);
                    // read data from the file and close it
                    tdes.Key = brKeyIn.ReadBytes(24);
                    tdes.IV = brKeyIn.ReadBytes(8);


                    // Open the encrypted file
                    fsDataIn = File.OpenRead(filepath);
                    if (fsDataIn.Length > 0)
                    {
                        // Create a cryptostream to decrypt from the filestream
                        csDataIn = new CryptoStream(fsDataIn, tdes.CreateDecryptor(), CryptoStreamMode.Read);
                        // Create a StreamReader to format the input
                        srDataIn = new StreamReader(csDataIn);

                        string line = srDataIn.ReadLine();

                        while (!string.IsNullOrEmpty(line))
                        {
                            info = JsonConvert.DeserializeObject<RegisterInfo>(line);

                            if (info != null)
                            {
                                infoList.Add(info);
                            }

                            line = srDataIn.ReadLine();
                        }
                    }
                }

                return infoList;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (brKeyIn != null)
                {
                    brKeyIn.Close();
                }
                if(fsKeyIn!=null)
                {
                    fsKeyIn.Close();
                }

                if (srDataIn != null)
                {
                    srDataIn.Close();
                }
                if (csDataIn != null)
                {
                        csDataIn.Close();
                }
                if(fsDataIn != null)
                {
                    fsDataIn.Close();
                }
            }
        }
    }
}

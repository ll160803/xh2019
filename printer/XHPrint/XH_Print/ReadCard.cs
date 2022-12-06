using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;

namespace XH_Print
{
   public class ReadCard
    {
        static int nPort = 0;//端口

        [DllImport("SynIDCardAPI.dll", EntryPoint = "Syn_FindReader", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int Syn_FindReader();

        [DllImport("SynIDCardAPI.dll", EntryPoint = "Syn_OpenPort", CharSet = CharSet.Ansi)]
        public static extern int Syn_OpenPort(int iPort);

        [DllImport("SynIDCardAPI.dll", EntryPoint = "Syn_SetMaxRFByte", CharSet = CharSet.Ansi)]
        public static extern int Syn_SetMaxRFByte(int iPort, byte ucByte, int iIfOpen);

        [DllImport("SynIDCardAPI.dll", EntryPoint = "Syn_StartFindIDCard", CharSet = CharSet.Ansi)]
        public static extern int Syn_StartFindIDCard(int iPort, ref byte pucIIN, int iIfOpen);

        [DllImport("SynIDCardAPI.dll", EntryPoint = "Syn_SelectIDCard", CharSet = CharSet.Ansi)]
        public static extern int Syn_SelectIDCard(int iPort, ref byte pucSN, int iIfOpen);

        [DllImport("SynIDCardAPI.dll", EntryPoint = "Syn_ReadBaseMsg", CharSet = CharSet.Ansi)]
        public static extern int Syn_ReadBaseMsg(int iPort, IntPtr pucCHMsg, ref uint puiCHMsgLen, IntPtr pucPHMsg, ref uint puiPHMsgLen, int iIfOpen);

        /// <summary>
        /// 自动查询读卡器
        /// </summary>
        /// <param name="err">错误信息</param>
        /// <returns></returns>
        public static bool FindDrivers(out string err)
        {
            int i = 0;
            err = "";
            try
            {
                i = Syn_FindReader();
            }
            catch (Exception e)
            {
                err = e.ToString();
                return false;
            }
            if (i > 0)
            {
                nPort = i;
            }
            else
            {
                nPort = 0;
                return false;
            }
            return true;
        }

        /// <summary>
        /// 读取身份证基本信息
        /// </summary>
        /// <param name="CardMsg"></param>
        /// <param name="errStr"></param>
        /// <returns></returns>
        public static bool ReadIdCard(out IDCardData CardMsg,
            out string errStr)
        {
            CardMsg = new IDCardData();
            errStr = "";
            int nRet;
            byte[] pucIIN = new byte[4];
            byte[] pucSN = new byte[8];

            #region 获取读卡器
            /** 在上一步 做了检测 hsc
            if (nPort == 0)
            {
                if (!FindDrivers(out errStr))
                {
                    if (string.IsNullOrEmpty(errStr))
                        errStr = "没有找到读卡器";
                    return false;
                }
            }*/
            #endregion

            if (Syn_OpenPort(nPort) == 0)
            {
                if (Syn_SetMaxRFByte(nPort, 80, 0) == 0)
                {
                    nRet = Syn_StartFindIDCard(nPort, ref pucIIN[0], 0);
                    nRet = Syn_SelectIDCard(nPort, ref pucSN[0], 0);
                    string cardMsg = new string(' ', 256);  //身份证基本信息返回长度为256
                    string imgMsg = new string(' ', 1024);  //身份证图片信息返回长度为1024
                    IntPtr msg = Marshal.StringToHGlobalAnsi(cardMsg);  //身份证基本信息
                    IntPtr img = Marshal.StringToHGlobalAnsi(imgMsg);   //身份证图片
                    try
                    {
                        uint mLen = 0;
                        uint iLen = 0;
                        nRet = Syn_ReadBaseMsg(nPort, msg, ref mLen, img, ref iLen, 0);
                        if (nRet == 0)
                        {
                            string card = Marshal.PtrToStringUni(msg);
                            char[] cartb = card.ToCharArray();
                            CardMsg.Name = (new string(cartb, 0, 15)).Trim();
                            CardMsg.Sex = new string(cartb, 15, 1);
                            CardMsg.Nation = new string(cartb, 16, 2);
                            CardMsg.Born = new string(cartb, 18, 8);
                            CardMsg.Address = (new string(cartb, 26, 35)).Trim();
                            CardMsg.IDCardNo = new string(cartb, 61, 18);
                            CardMsg.GrantDept = (new string(cartb, 79, 15)).Trim();
                            CardMsg.UserLifeBegin = new string(cartb, 94, 8);
                            CardMsg.UserLifeEnd = new string(cartb, 102, 8);
                            return true;
                        }
                        else
                        {
                            errStr = "读取身份证信息错误";
                        }
                    }
                    catch (Exception e) { errStr = e.Message; }
                    finally
                    {
                        Marshal.FreeHGlobal(msg);
                        Marshal.FreeHGlobal(img);
                    }
                }
                else
                {
                    errStr = "SetMaxRFByte出错";
                }
            }
            else
            {
                errStr = "打开端口失败";
            }
            return false;
        }
        public static void playVoice(String voicePath)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = voicePath;
            player.Load(); //同步加载声音
            player.Play(); //启用新线程播放
        }
    }
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct IDCardData
    {
        //结构中使用的字串，[]类似限定说明 说明此公共结构传输到非托管代码时封装定义
        /// <summary>
        /// 姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string Name;
        /// <summary>
        /// 性别
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
        public string Sex;
        /// <summary>
        /// 名族
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
        public string Nation;
        /// <summary>
        /// 出生日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 18)]
        public string Born;
        /// <summary>
        /// 住址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 72)]
        public string Address;
        /// <summary>
        /// 身份证号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 38)]
        public string IDCardNo;
        /// <summary>
        /// 发证机关
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string GrantDept;
        /// <summary>
        /// 有效开始日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 18)]
        public string UserLifeBegin;
        /// <summary>
        /// 有效截止日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 18)]
        public string UserLifeEnd;
        /// <summary>
        /// 保留
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 38)]
        public string reserved;
        /// <summary>
        /// 照片路径
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 255)]
        public string PhotoFileName;
    }
}

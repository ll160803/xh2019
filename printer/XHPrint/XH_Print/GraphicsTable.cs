using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;

namespace XH_Print
{
    public class GraphicsTable
    {

        /// <summary>
        /// 绘制表格的方法
        /// </summary>
        /// <param name="xc">行的数量</param>
        /// <param name="yc">列的数量</param>
        public static void drawWang(int xc, int yc, int W, int H, Graphics g)
        {
            Rectangle r = new Rectangle(35+40+20, 240+50-20, W + 120-80-40, H / 2 - 230);
            g.DrawRectangle(new Pen(Brushes.Black, 1.0f), r);
            int recCountX = xc;
            int recCountY = yc;
            Point[] sP = new Point[recCountX];  //Up
            Point[] xP = new Point[recCountX];  //down
            Point[] zP = new Point[recCountY];  //left
            Point[] yP = new Point[recCountY];  //regit
            int cW = (int)r.Width / recCountX;  //每个格子的长
            int cH = (int)r.Height / recCountY; //每个格子的宽
            for (int i = 0; i < recCountX - 1; i++)
            {
                int pX = r.X + cW + cW * i;   //计算边上点的坐标的方法
                if (i == 0)//第二个格子放大一些
                {
                    pX = pX - 80;
                }
                if (i == 1)//第二个格子放大一些
                {
                    pX = pX + 40;
                }
                Point p = new Point(pX, r.Y);
                sP[i] = p;
            }
            for (int i = 0; i < recCountX - 1; i++)
            {
                int pX = r.X + cW + cW * i;
                if (i == 0)//第二个格子放大一些
                {
                    pX = pX - 80;
                }
                if (i == 1)//第二个格子放大一些
                {
                    pX = pX + 40;
                }
                Point p = new Point(pX, r.Y + r.Height);
                xP[i] = p;
            }
            for (int i = 0; i < recCountY - 1; i++)
            {
                int pY = r.Y + cH + cH * i;

                Point p = new Point(r.X, pY);
                zP[i] = p;
            }
            for (int i = 0; i < recCountY - 1; i++)
            {
                int pY = r.Y + cH + cH * i;

                Point p = new Point(r.X + r.Width, pY);
                yP[i] = p;
            }
            for (int i = 0; i < recCountX - 1; i++)
            {
                g.DrawLine(new Pen(Brushes.Black, 1.0f), sP[i], xP[i]);
            }
            for (int i = 0; i < recCountY - 1; i++)
            {
                g.DrawLine(new Pen(Brushes.Black, 1.0f), zP[i], yP[i]);
            }
            // g.Dispose();
        }

        /// <summary>
        /// 画表格
        /// </summary>
        /// <param name="yc">列 数量</param>
        /// <param name="xc">行数量</param>
        /// <param name="width">行宽</param>
        /// <param name="height">列宽</param>
        /// <param name="initX">初始化位置X</param>
        /// <param name="initY">初始化位置Y</param>
        /// <param name="firstWidth">第一列宽度</param>
        /// <param name="g"></param>
        public static void drawGrid(int yc, int xc, int width, int height, int initX, int initY, Graphics g, int firstWidth=0)
        {
            Rectangle r = new Rectangle(initX, initY, (yc-1) * width + firstWidth, xc * height);
            g.DrawRectangle(new Pen(Brushes.Black, 1.0f), r);
            int recCountX = yc;
            int recCountY = xc;
            Point[] sP = new Point[recCountX];  //Up
            Point[] xP = new Point[recCountX];  //down
            Point[] zP = new Point[recCountY];  //left
            Point[] yP = new Point[recCountY];  //regit
            int cW = width;  //每个格子的长
            int cH = height; //每个格子的宽
            for (int i = 0; i < recCountX - 1; i++)
            {
                int pX = initX + (firstWidth==0 ?cW: firstWidth) + cW * i;   //上边

                Point p = new Point(pX, initY);
                sP[i] = p;
            }
            for (int i = 0; i < recCountX - 1; i++)//下边
            {
                int pX = initX + (firstWidth == 0 ? cW : firstWidth) + cW * i;
                Point p = new Point(pX, xc * height + initY);
                xP[i] = p;
            }
            for (int i = 0; i < recCountY - 1; i++)
            {
                int pY = initY + cH + cH * i;

                Point p = new Point(initX, pY);
                zP[i] = p;
            }
            for (int i = 0; i < recCountY - 1; i++)
            {
                int pY = initY + cH + cH * i;

                Point p = new Point(initX + (yc-1) * width+ firstWidth, pY);
                yP[i] = p;
            }
            for (int i = 0; i < recCountX - 1; i++)
            {
                g.DrawLine(new Pen(Brushes.Black, 1.0f), sP[i], xP[i]);
            }
            for (int i = 0; i < recCountY - 1; i++)
            {
                g.DrawLine(new Pen(Brushes.Black, 1.0f), zP[i], yP[i]);
            }
        }


        /// <summary>
        /// 绘制表格的方法
        /// </summary>
        /// <param name="xc">行的数量</param>
        /// <param name="yc">列的数量</param>
        public static void drawWang_gjj(int xc, int yc, int W, int H, Graphics g)
        {
            Rectangle r = new Rectangle(30+60, 255, W , H / 2 - 230 + 50 +50);
            g.DrawRectangle(new Pen(Brushes.Black, 1.0f), r);
            int recCountX = xc;
            int recCountY = yc;
            Point[] sP = new Point[recCountX];  //Up
            Point[] xP = new Point[recCountX];  //down
            Point[] zP = new Point[recCountY];  //left
            Point[] yP = new Point[recCountY];  //regit
            int cW = (int)r.Width / recCountX;  //每个格子的长
            int cH = (int)r.Height / recCountY; //每个格子的宽
            for (int i = 0; i < recCountX - 1; i++)
            {
                int pX = r.X + cW + cW * i;   //计算边上点的坐标的方法

                Point p = new Point(pX, r.Y);
                sP[i] = p;
            }
            for (int i = 0; i < recCountX - 1; i++)
            {
                int pX = r.X + cW + cW * i;

                Point p = new Point(pX, r.Y + r.Height);
                xP[i] = p;
            }
            for (int i = 0; i < recCountY - 1; i++)
            {
                int pY = r.Y + cH + cH * i;

                Point p = new Point(r.X, pY);
                zP[i] = p;
            }
            for (int i = 0; i < recCountY - 1; i++)
            {
                int pY = r.Y + cH + cH * i;

                Point p = new Point(r.X + r.Width, pY);
                yP[i] = p;
            }
            for (int i = 0; i < recCountX - 1; i++)
            {
                g.DrawLine(new Pen(Brushes.Black, 1.0f), sP[i], xP[i]);
            }
            for (int i = 0; i < recCountY - 1; i++)
            {
                g.DrawLine(new Pen(Brushes.Black, 1.0f), zP[i], yP[i]);
            }
            // g.Dispose();
        }


        /// <summary>
        /// 金额转换成中文大写金额
        /// </summary>
        /// <param name="LowerMoney">eg:10.74</param>
        /// <returns></returns>
        public static string MoneyToUpper(string LowerMoney)
        {
            string functionReturnValue = null;
            bool IsNegative = false; // 是否是负数
            if (LowerMoney.Trim().Substring(0, 1) == "-")
            {
                // 是负数则先转为正数
                LowerMoney = LowerMoney.Trim().Remove(0, 1);
                IsNegative = true;
            }
            string strLower = null;
            string strUpart = null;
            string strUpper = null;
            int iTemp = 0;
            // 保留两位小数 123.489→123.49　　123.4→123.4
            LowerMoney = Math.Round(double.Parse(LowerMoney), 2).ToString();
            if (LowerMoney.IndexOf(".") > 0)
            {
                if (LowerMoney.IndexOf(".") == LowerMoney.Length - 2)
                {
                    LowerMoney = LowerMoney + "0";
                }
            }
            else
            {
                LowerMoney = LowerMoney + ".00";
            }
            strLower = LowerMoney;
            iTemp = 1;
            strUpper = "";
            while (iTemp <= strLower.Length)
            {
                switch (strLower.Substring(strLower.Length - iTemp, 1))
                {
                    case ".":
                        strUpart = "圆";
                        break;
                    case "0":
                        strUpart = "零";
                        break;
                    case "1":
                        strUpart = "壹";
                        break;
                    case "2":
                        strUpart = "贰";
                        break;
                    case "3":
                        strUpart = "叁";
                        break;
                    case "4":
                        strUpart = "肆";
                        break;
                    case "5":
                        strUpart = "伍";
                        break;
                    case "6":
                        strUpart = "陆";
                        break;
                    case "7":
                        strUpart = "柒";
                        break;
                    case "8":
                        strUpart = "捌";
                        break;
                    case "9":
                        strUpart = "玖";
                        break;
                }

                switch (iTemp)
                {
                    case 1:
                        strUpart = strUpart + "分";
                        break;
                    case 2:
                        strUpart = strUpart + "角";
                        break;
                    case 3:
                        strUpart = strUpart + "";
                        break;
                    case 4:
                        strUpart = strUpart + "";
                        break;
                    case 5:
                        strUpart = strUpart + "拾";
                        break;
                    case 6:
                        strUpart = strUpart + "佰";
                        break;
                    case 7:
                        strUpart = strUpart + "仟";
                        break;
                    case 8:
                        strUpart = strUpart + "万";
                        break;
                    case 9:
                        strUpart = strUpart + "拾";
                        break;
                    case 10:
                        strUpart = strUpart + "佰";
                        break;
                    case 11:
                        strUpart = strUpart + "仟";
                        break;
                    case 12:
                        strUpart = strUpart + "亿";
                        break;
                    case 13:
                        strUpart = strUpart + "拾";
                        break;
                    case 14:
                        strUpart = strUpart + "佰";
                        break;
                    case 15:
                        strUpart = strUpart + "仟";
                        break;
                    case 16:
                        strUpart = strUpart + "万";
                        break;
                    default:
                        strUpart = strUpart + "";
                        break;
                }

                strUpper = strUpart + strUpper;
                iTemp = iTemp + 1;
            }

            strUpper = strUpper.Replace("零拾", "零");
            strUpper = strUpper.Replace("零佰", "零");
            strUpper = strUpper.Replace("零仟", "零");
            strUpper = strUpper.Replace("零零零", "零");
            strUpper = strUpper.Replace("零零", "零");
            strUpper = strUpper.Replace("零角零分", "整");
            strUpper = strUpper.Replace("零分", "整");
            strUpper = strUpper.Replace("零角", "零");
            strUpper = strUpper.Replace("零亿零万零圆", "亿圆");
            strUpper = strUpper.Replace("亿零万零圆", "亿圆");
            strUpper = strUpper.Replace("零亿零万", "亿");
            strUpper = strUpper.Replace("零万零圆", "万圆");
            strUpper = strUpper.Replace("零亿", "亿");
            strUpper = strUpper.Replace("零万", "万");
            strUpper = strUpper.Replace("零圆", "圆");
            strUpper = strUpper.Replace("零零", "零");

            // 对壹圆以下的金额的处理
            if (strUpper.Substring(0, 1) == "圆")
            {
                strUpper = strUpper.Substring(1, strUpper.Length - 1);
            }
            if (strUpper.Substring(0, 1) == "零")
            {
                strUpper = strUpper.Substring(1, strUpper.Length - 1);
            }
            if (strUpper.Substring(0, 1) == "角")
            {
                strUpper = strUpper.Substring(1, strUpper.Length - 1);
            }
            if (strUpper.Substring(0, 1) == "分")
            {
                strUpper = strUpper.Substring(1, strUpper.Length - 1);
            }
            if (strUpper.Substring(0, 1) == "整")
            {
                strUpper = "零圆整";
            }
            functionReturnValue = strUpper;

            if (IsNegative == true)
            {
                return "负" + functionReturnValue;
            }
            else
            {
                return functionReturnValue;
            }
        }

        /// <summary>
        /// 填写打印内容
        /// </summary>
        /// <param name="dataXH"></param>
        /// <param name="g"></param>
        public static void drawInfo(DataXH dataXH, String pageSource, Graphics g)
        {
            List<infoposition> infos = GraphicsTable.getInfos(pageSource);
            foreach (var item in infos)
            {
                if (item.indexRow == 2 && item.indexCol == 2)
                {
                    item.infoValue = dataXH.name; //姓名
                }
                if (item.indexRow == 5 && item.indexCol == 2)
                {
                    // item.fontSize = 12;
                    item.infoValue = dataXH.preMonthMax; //税前月收入
                }
                if (item.indexRow == 5 && item.indexCol == 3)
                {
                    item.infoValue = dataXH.preMonthMin; //
                }
                if (item.indexRow == 7 && item.indexCol == 2)
                {
                    // item.fontSize = 12;
                    item.infoValue = dataXH.afterMonthMax; //税后月收入
                }
                if (item.indexRow == 7 && item.indexCol == 3)
                {
                    item.infoValue = dataXH.afterMonthMin;
                }
                if (item.indexRow == 6 && item.indexCol == 2)
                {
                    //  item.fontSize = 12;
                    item.infoValue = dataXH.preYearMax; //税前年收入
                }
                if (item.indexRow == 6 && item.indexCol == 3)
                {
                    item.infoValue = dataXH.preYearMin; //
                }
                if (item.indexRow == 8 && item.indexCol == 2)
                {
                    // item.fontSize = 12;
                    item.infoValue = dataXH.afterYearMax; //税后年收入
                }
                if (item.indexRow == 8 && item.indexCol == 3)
                {
                    item.infoValue = dataXH.afterYearMin;
                }
                if (item.indexRow == 10 && item.indexCol == 2)
                {
                    item.infoValue = dataXH.phone;
                }
                g.DrawString(item.infoValue, new Font(new FontFamily("宋体"), (item.fontSize == 0 ? 16 : 12)), System.Drawing.Brushes.Black, item.posX, item.posY, new StringFormat());
            }
        }
        /// <summary>
        /// 打印类
        /// </summary>
        /// <param name="infos">需要打印的所有位置的文字</param>
        /// <param name="g"></param>
        public static void printWordInfo(List<infoposition> infos, Graphics g)
        {
            int count = 1;
            foreach (var item in infos)
            {
                if (count == 1)
                {
                    g.DrawString(item.infoValue, new Font(new FontFamily("黑体"), (item.fontSize == 0 ? 22 : item.fontSize), FontStyle.Bold), System.Drawing.Brushes.Black, item.posX, item.posY, new StringFormat());
                }
                else
                {
                    if (item.bold > 0)
                    {
                        g.DrawString(item.infoValue, new Font(new FontFamily("黑体"), (item.fontSize == 0 ? 14 : item.fontSize), FontStyle.Bold), System.Drawing.Brushes.Black, item.posX, item.posY, new StringFormat());
                    }
                    else
                    {
                        g.DrawString(item.infoValue, new Font(new FontFamily("宋体"), (item.fontSize == 0 ? 14 : item.fontSize)), System.Drawing.Brushes.Black, item.posX, item.posY, new StringFormat());
                    }
                }
                count += 1;
            }
        }
        /// <summary>
        /// 收入证明
        /// </summary>
        /// <param name="res"></param>
        /// <param name="infos"></param>
        public static void SetValueByWebservice_srzm(Srzm.Zhr00FmSrzmResponse res, List<infoposition> infos)
        {
            String year = DateTime.Now.Year.ToString();
            String Month = DateTime.Now.Month.ToString().PadLeft(2, '0');
            String Day = DateTime.Now.Day.ToString().PadLeft(2, '0');
            foreach (var item in infos)
            {
                if (item.indexRow == 2 && item.indexCol == 2)
                {
                    item.infoValue = res.Nachn + "，身份证号：" + res.Icnum; //姓名
                }
                if (item.indexRow == 5 && item.indexCol == 2)
                {
                    // item.fontSize = 12;
                    item.infoValue = res.Sqysrdx; //税前月收入
                }
                if (item.indexRow == 5 && item.indexCol == 3)
                {
                    item.infoValue = res.Sqysrxx; //
                }
                if (item.indexRow == 7 && item.indexCol == 2)
                {
                    // item.fontSize = 12;
                    item.infoValue = res.Shysrdx; //税后月收入
                }
                if (item.indexRow == 7 && item.indexCol == 3)
                {
                    item.infoValue = res.Shysrxx;
                }
                if (item.indexRow == 6 && item.indexCol == 2)
                {
                    // item.fontSize = 12;
                    item.infoValue = res.Sqnsrdx; //税前年收入
                }
                if (item.indexRow == 6 && item.indexCol == 3)
                {
                    item.infoValue = res.Sqnsrxx; //
                }
                if (item.indexRow == 8 && item.indexCol == 2)
                {
                    // item.fontSize = 12;
                    item.infoValue = res.Shnsrdx; //税后年收入
                }
                if (item.indexRow == 8 && item.indexCol == 3)
                {
                    item.infoValue = res.Shnsrxx;
                }
                if (item.indexRow == 14 && item.indexCol == 1)
                {
                    item.infoValue = year;
                }
                if (item.indexRow == 14 && item.indexCol == 3)
                {
                    item.infoValue = Month;
                }
                if (item.indexRow == 14 && item.indexCol == 5)
                {
                    item.infoValue = Day;
                }
            }
        }

        /// <summary>
        /// 公积金缴存及收入证明
        /// </summary>
        /// <param name="res"></param>
        /// <param name="infos"></param>
        public static void SetValueByWebservice_qczm(QcSalary.Zhr00FmGjjsrzmResponse res, ref List<infoposition> infos)
        {
            String year = DateTime.Now.Year.ToString();
            String Month = DateTime.Now.Month.ToString().PadLeft(2, '0');
            String Day = DateTime.Now.Day.ToString().PadLeft(2, '0');
            foreach (var item in infos)
            {
                if (item.indexRow == 2 && item.indexCol == 2)
                {
                    item.infoValue = res.Nachn + "，身份证号：" + res.Icnum; //姓名
                }
                if (item.indexRow == 16 && item.indexCol == 2)
                {

                    item.infoValue = res.Shysrxx; //每月收入
                }
                if (item.indexRow == 4 && item.indexCol == 2)
                {

                    item.infoValue = res.Jcyh; //交存银行
                }
                if (item.indexRow == 5 && item.indexCol == 2)
                {
                    item.infoValue = res.Dwgjjzh; // 单位公积金账号
                }
                if (item.indexRow == 6 && item.indexCol == 2)
                {

                    item.infoValue = res.Grgjjzh; //个人公积金账号
                }
                if (item.indexRow == 7 && item.indexCol == 2)
                {
                    item.infoValue = res.Gjjsr;//本人计缴公积金月工资收入
                }
                if (item.indexRow == 8 && item.indexCol == 2)
                {

                    item.infoValue = res.Jjbl; //缴交比例
                }
                if (item.indexRow == 9 && item.indexCol == 2)
                {
                    item.infoValue = res.Gjjjn; //本人上月缴交额(含单位补贴)
                }

                if (item.indexRow == 15 && item.indexCol == 1)
                {
                    item.infoValue = year;
                }
                if (item.indexRow == 15 && item.indexCol == 3)
                {
                    item.infoValue = Month;
                }
                if (item.indexRow == 15 && item.indexCol == 5)
                {
                    item.infoValue = Day;
                }
            }
        }


      
        public static String getInfoByInput(int type, String code, String IdCard, ref List<infoposition> infos)
        {
            String messge = "";
            try
            {
                if (type == 1)//收入证明
                {
                    infos = GraphicsTable.getInfos("infoprint.txt");
                    Srzm.Zhr00FmSrzm srzm = new Srzm.Zhr00FmSrzm();
                    srzm.Icnum = IdCard;
                    srzm.Zdtm = code;
                    srzm.Ip = getIp();
                    Srzm.ZHR00_CW2 cW2 = new Srzm.ZHR00_CW2();
                    var res = cW2.Zhr00FmSrzm(srzm);
                    if (String.IsNullOrEmpty(res.Mes))
                    {
                        SetValueByWebservice_srzm(res, infos);//把从接口获取的值 填入位置信息表里  
                    }
                    else
                    {
                        messge = res.Mes;
                    }
                }
                if (type == 2)//公积金缴存收入证明
                {

                    infos = GraphicsTable.getInfos("infoprint_gjj.txt");

                    QcSalary.ZCW1 qcSalary = new QcSalary.ZCW1();

                    QcSalary.Zhr00FmGjjsrzm inputP = new QcSalary.Zhr00FmGjjsrzm();
                    inputP.Icnum = IdCard;
                    inputP.Zdtm = code;
                    inputP.Ip = getIp();

                    var res2 = qcSalary.Zhr00FmGjjsrzm(inputP);
                    if (String.IsNullOrEmpty(res2.Mes))
                    {
                        SetValueByWebservice_qczm(res2, ref infos);//把从接口获取的值 填入位置信息表里  
                    }
                    else
                    {
                        messge = res2.Mes;
                    }
                }
                if (type == 3)//当前月工资条打印
                {



                    MonthSalary.ZHR00_CW3 mosa = new MonthSalary.ZHR00_CW3();
                    MonthSalary.Zhr00FmGzt inputMonth = new MonthSalary.Zhr00FmGzt();
                    inputMonth.Icnum = IdCard;
                    inputMonth.Month = DateTime.Now.Year.ToString();
                    inputMonth.Month = "LA";
                    var res3 = mosa.Zhr00FmGzt(inputMonth);

                    foreach (var item in res3.TZb)
                    {
                        infos.Add(new infoposition
                        {
                            posX = item.Zx,
                            posY = item.Zy,
                            infoValue = item.Value
                           // fontSize =item.
                        }
                            );
                    }


                   
                    messge = res3.EMessage;
                    
                }
            }
            catch (Exception ex)
            {
                messge = "请联系系统管理员";
            }
            return messge;
        }
        public static String getIp()
        {
            try
            {
                string hostName = Dns.GetHostName();
                IPHostEntry iPHostEntry = Dns.GetHostEntry(hostName);
                foreach ( var item in iPHostEntry.AddressList)
                {
                    if(item.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        return item.ToString();
                    }
                }
                return "127.0.0.1";
            }
            catch (Exception ex)
            {
                return "127.0.0.1";
            }
        }
        public static String getInfoByInput(int type, String code, String IdCard, ref List<infoposition> infos,ref TableInfo tableInfo ,ref PrintDateParam printDateParam)
        {
            String messge = "";
            try
            {
                if (type == 1)//收入证明
                {
                    infos = GraphicsTable.getInfos("infoprint.txt");
                    Srzm.Zhr00FmSrzm srzm = new Srzm.Zhr00FmSrzm();
                    srzm.Icnum = IdCard;
                    srzm.Zdtm = code;
                    srzm.Ip = getIp();
                    Srzm.ZHR00_CW2 cW2 = new Srzm.ZHR00_CW2();
                    var res = cW2.Zhr00FmSrzm(srzm);
                    if (String.IsNullOrEmpty(res.Mes))
                    {
                        SetValueByWebservice_srzm(res, infos);//把从接口获取的值 填入位置信息表里  
                    }
                    else
                    {
                        messge = res.Mes;
                    }
                }
                if (type == 2)//公积金缴存收入证明
                {

                    infos = GraphicsTable.getInfos("infoprint_gjj.txt");

                    QcSalary.ZCW1 qcSalary = new QcSalary.ZCW1();

                    QcSalary.Zhr00FmGjjsrzm inputP = new QcSalary.Zhr00FmGjjsrzm();
                    inputP.Icnum = IdCard;
                    inputP.Zdtm = code;
                    inputP.Ip = getIp();

                    var res2 = qcSalary.Zhr00FmGjjsrzm(inputP);
                    if (String.IsNullOrEmpty(res2.Mes))
                    {
                        SetValueByWebservice_qczm(res2, ref infos);//把从接口获取的值 填入位置信息表里  
                    }
                    else
                    {
                        messge = res2.Mes;
                    }
                }
                if (type == (int)TypeEnum.工资条打印)//当前月工资条打印
                {
                    messge = SalaryPrint(printDateParam.year, printDateParam.month,IdCard, ref infos,ref tableInfo);
                }
               
            }
            catch (Exception ex)
            {
                messge = "请联系系统管理员";
            }
            return messge;
        }
        public static String SalaryPrint(String year,String month,String IdCard, ref List<infoposition> infos, ref TableInfo tableInfo)
        {
            MonthSalary.ZHR00_CW3 mosa = new MonthSalary.ZHR00_CW3();
            MonthSalary.Zhr00FmGzt inputMonth = new MonthSalary.Zhr00FmGzt();
            MonthSalary.Zhr00SBz[] tzb = new MonthSalary.Zhr00SBz[10];
            inputMonth.Icnum = IdCard;
            inputMonth.Year = year;
            inputMonth.Month = month;
            inputMonth.TZb = tzb;
            var res3 = mosa.Zhr00FmGzt(inputMonth);

            foreach (var item in res3.TZb)
            {
                infos.Add(new infoposition
                {
                    posX = item.Zx,
                    posY = item.Zy,
                    infoValue = item.Value,
                    fontSize = item.Zt

                }
                    );
            }
            tableInfo.initX = res3.Tx;
            tableInfo.initY = res3.Ty;
            tableInfo.xc = res3.Jh;
            tableInfo.yc = res3.Jl;
            tableInfo.width = res3.Tk;
            tableInfo.height = res3.Tg;
            tableInfo.firstWidth = res3.Dylk;
            return res3.EMessage;
        }
        /// <summary>
        /// 获取打印位置的配置文件你  infoprint.txt
        /// </summary>
        /// <param name="pageSource"></param>
        /// <returns></returns>
        public static List<infoposition> getInfos(String pageSource)
        {
            StreamReader sr = new StreamReader(pageSource, Encoding.GetEncoding("gb2312"));
            var data = sr.ReadToEnd();
            List<infoposition> listInfoPos = JsonConvert.DeserializeObject<List<infoposition>>(data);

             return listInfoPos;


            // List<infoposition> listInfoPos = JsonConvert.DeserializeObject<List<infoposition>>(printer);
            //return listInfoPos;
        }
        public static List<PointButton> getButtonInfos(String pageSource)
        {
            StreamReader sr = new StreamReader(pageSource, Encoding.GetEncoding("gb2312"));
            var data = sr.ReadToEnd();
            List<PointButton> listInfoPos = JsonConvert.DeserializeObject<List<PointButton>>(data);

            return listInfoPos;
        }
    }
}

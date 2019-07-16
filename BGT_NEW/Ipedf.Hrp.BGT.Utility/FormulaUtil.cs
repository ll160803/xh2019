using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ipedf.Web.Entity;
using Ipedf.Web.BizLogic;
using Ipedf.Common;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.IO;
using System.Data;
using System.Reflection;
using Microsoft.CSharp;
using System.CodeDom.Compiler;

namespace Ipedf.Hrp.BGT.Utility
{
    class FormulaUtil<T>
    {
        /// <summary>
        /// 构造计算类的成员变量
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="args"></param>
        /// <returns></returns>
        public static string GenerateVariate<T>(Dictionary<int, object[]> args)
        {
            StringBuilder variateStr = new StringBuilder();
            if (args != null)
                foreach (var item in args)
                {
                    variateStr.AppendLine(string.Format("public {0} {1}={2}M;", typeof(T), "arg" + item.Key, (T)item.Value[1]));
                }
            return variateStr.ToString();
        }
        /// <summary>
        /// 构造计算类中方法的返回语句
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="args"></param>
        /// <param name="formula"></param>
        /// <returns></returns>
        public static string GenerateResult<T>(Dictionary<int, object[]> args, string formula)
        {
            string strReturn = formula.Replace(",", "");
            if (args != null)
                foreach (var item in args)
                {
                    strReturn.Replace((string)item.Value[0], "arg" + item.Key);
                }
            return strReturn;
        }
        public static string GenerateCode<T>(Dictionary<int, object[]> args, string formula)
        {
            string v = GenerateVariate<T>(args);
            string strReturn = GenerateResult<T>(args, formula);
            return string.Format(@"
                namespace {0}
                {{
                    public class {1}
                    {{
                       {2}
                        public object {3}()
                        {{ 
                            {4}
                        }} 
                    }} 
                }}
                ", "DYNAMIC_NS", "ResolveClass", v, "ResolveFormula", strReturn);

        }
        public static T ResolveFormula(Dictionary<int, object[]> args, string code)
        {
            object result = null;
            CSharpCodeProvider cscpr = new CSharpCodeProvider();
            CompilerParameters cp = new CompilerParameters();
            cp.GenerateExecutable = false;
            cp.GenerateInMemory = true;

            CompilerResults cr = cscpr.CompileAssemblyFromSource(cp, GenerateCode<decimal>(args, code));

            if (cr.Errors.HasErrors)
            {
                Console.WriteLine("编译错误：");
                StringBuilder errorMsg = new StringBuilder();
                foreach (CompilerError err in cr.Errors)
                {
                    SystemLogic.Proxy.Warn("编译错误：" + err.ErrorText);
                    System.Diagnostics.Debug.WriteLine(err.ErrorText);
                    errorMsg.AppendLine(err.ErrorText + "<br>");
                }
                throw new Exception(errorMsg.ToString());
            }
            else
            {
                Assembly objAssembly = cr.CompiledAssembly;
                object objEntity = objAssembly.CreateInstance("DYNAMIC_NS" + "." + "ResolveClass");
                MethodInfo objMethod = objEntity.GetType().GetMethod("ResolveFormula");
                result = objMethod.Invoke(objEntity, null);
                objEntity = null;
            }
            cscpr.Dispose();
            return (T)result;
        }
        public static void Dispose()
        {
            GC.Collect();
        }
    }
}

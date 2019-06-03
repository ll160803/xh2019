using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ipedf.App.Codes
{
    public class GetWhere<T> where T : class
    {
        public void GenerateWhere(T T_Obj, string search)
        {
            var arrStr = search.Split('^')
                   .Where(m => !string.IsNullOrEmpty(m));
            foreach (var splitStr in arrStr)
            {
                var dictQuery = splitStr.Split('@');

                var ColumnName = dictQuery[0];
                var ValueName = dictQuery[1];

                var keyProperty = typeof(T).GetProperties().FirstOrDefault(item => item.Name.ToLower().Equals(ColumnName.Trim().ToLower()));
                if (keyProperty != null)
                {


                    Type baseType = Nullable.GetUnderlyingType(keyProperty.PropertyType);//可空类型做处理
                    if (baseType != null)
                        keyProperty.SetValue(T_Obj, Convert.ChangeType(ValueName, baseType), null);
                    else
                        keyProperty.SetValue(T_Obj, Convert.ChangeType(ValueName, keyProperty.PropertyType), null);//设置对象值
                }
            }

        }
    }
}
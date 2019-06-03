using System;
using System.Collections.Generic;
using System.Web;
using SAP.Middleware.Connector;
using System.Data;

namespace BankService.Pub
{
    public class NcoPub
    {
        /// <summary>
        /// 通过RFC表返回ADO.NET表
        /// </summary>
        /// <param name="lrfcTable">RFC表</param>
        /// <returns>ADO.NET表</returns>
        public static DataTable GetDataTableFromRFCTable(IRfcTable lrfcTable)
        {
            //sapnco_util
            DataTable loTable = new DataTable();

            //Create ADO.Net table.
            for (int liElement = 0; liElement < lrfcTable.ElementCount; liElement++)
            {
                RfcElementMetadata metadata = lrfcTable.GetElementMetadata(liElement);
                loTable.Columns.Add(metadata.Name);
            }

            //Transfer rows from lrfcTable to ADO.Net table.
            foreach (IRfcStructure row in lrfcTable)
            {
                DataRow ldr = loTable.NewRow();
                for (int liElement = 0; liElement < lrfcTable.ElementCount; liElement++)
                {
                    RfcElementMetadata metadata = lrfcTable.GetElementMetadata(liElement);
                    ldr[metadata.Name] = row.GetString(metadata.Name);
                }
                loTable.Rows.Add(ldr);
            }
            return loTable;
        }

        /// <summary>
        /// 通过RFC表返回ADO.NET表
        /// </summary>
        /// <param name="lrfcTable">RFC表</param>
        /// <returns>ADO.NET表</returns>
        public static DataTable GetDataTableFromRFCTable(IRfcTable lrfcTable,string tabName)
        {
            //sapnco_util
            DataTable loTable = new DataTable(tabName);

            //Create ADO.Net table.
            for (int liElement = 0; liElement < lrfcTable.ElementCount; liElement++)
            {
                RfcElementMetadata metadata = lrfcTable.GetElementMetadata(liElement);
                loTable.Columns.Add(metadata.Name);
            }

            //Transfer rows from lrfcTable to ADO.Net table.
            foreach (IRfcStructure row in lrfcTable)
            {
                DataRow ldr = loTable.NewRow();
                for (int liElement = 0; liElement < lrfcTable.ElementCount; liElement++)
                {
                    RfcElementMetadata metadata = lrfcTable.GetElementMetadata(liElement);
                    ldr[metadata.Name] = row.GetString(metadata.Name);
                }
                loTable.Rows.Add(ldr);
            }
            return loTable;
        }


        /// <summary>
        /// 通过RFC结构体获取ADO.NET表
        /// </summary>
        /// <param name="lrfcStructrue">结构体</param>
        /// <returns>ADO.NET表</returns>
        public static DataTable GetDataTableFromRFCStructrue(IRfcStructure lrfcStructrue)
        {
            //sapnco_util
            DataTable loTable = new DataTable();

            //Create ADO.Net table.
            for (int liElement = 0; liElement < lrfcStructrue.ElementCount; liElement++)
            {
                RfcElementMetadata metadata = lrfcStructrue.GetElementMetadata(liElement);
                loTable.Columns.Add(metadata.Name);
            }

            //Transfer rows from lrfcTable to ADO.Net table.
            DataRow ldr = loTable.NewRow();
            for (int liElement = 0; liElement < lrfcStructrue.ElementCount; liElement++)
            {
                RfcElementMetadata metadata = lrfcStructrue.GetElementMetadata(liElement);
                ldr[metadata.Name] = lrfcStructrue.GetString(metadata.Name);
            }
            loTable.Rows.Add(ldr);
            return loTable;
        }


        public static void GetDataTableWithRFCTable(IRfcTable lrfcTable, DataTable loTable)
        {
            //sapnco_util

            //Create ADO.Net table.
            for (int liElement = 0; liElement < lrfcTable.ElementCount; liElement++)
            {
                RfcElementMetadata metadata = lrfcTable.GetElementMetadata(liElement);
                loTable.Columns.Add(metadata.Name);
            }

            //Transfer rows from lrfcTable to ADO.Net table.
            foreach (IRfcStructure row in lrfcTable)
            {
                DataRow ldr = loTable.NewRow();
                for (int liElement = 0; liElement < lrfcTable.ElementCount; liElement++)
                {
                    RfcElementMetadata metadata = lrfcTable.GetElementMetadata(liElement);
                    ldr[metadata.Name] = row.GetString(metadata.Name);
                }
                loTable.Rows.Add(ldr);
            }
        }
    }
}
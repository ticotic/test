using Neo.SmartContract.Framework;
using Neo.SmartContract.Framework.Services.Neo;
using Neo.SmartContract.Framework.Services.System;
using System;
using System.ComponentModel;
using System.Numerics;

namespace Example
{
  
    public class AppContract : SmartContract
    {
        public struct AllowanceParam
        {
            public byte[] from;
            public byte[] to;
        }

        public static object Main(string operation, params object[] args)
        {

            byte[] address = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 };
            byte[] From = (byte[])args[0];
            byte[] To = (byte[])args[1];
            
            AllowanceParam param = new AllowanceParam {from = From, to = To};
            
            byte[] ret = Native.Invoke(0, address, "allowance", param);
            return ret;
        }

    }
}
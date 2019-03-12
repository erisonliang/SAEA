﻿/****************************************************************************
*Copyright (c) 2018 yswenli All Rights Reserved.
*CLR版本： 4.0.30319.42000
*机器名称：WENLI-PC
*公司名称：yswenli
*命名空间：SAEA.RPC.Model
*文件名： RPCSocketException
*版本号： v4.2.3.1
*唯一标识：b5875f05-18ef-494f-948d-ef602c58e921
*当前的用户域：WENLI-PC
*创建人： yswenli
*电子邮箱：wenguoli_520@qq.com
*创建时间：2018/5/17 12:57:31
*描述：
*
*=====================================================================
*修改标记
*修改时间：2018/5/17 12:57:31
*修改人： yswenli
*版本号： v4.2.3.1
*描述：
*
*****************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace SAEA.RPC.Model
{
    public class RPCSocketException : Exception
    {
        public RPCSocketException(string message) : this(message, null) { }

        public RPCSocketException(string message, Exception innerException) : base(message, innerException) { }
    }
}

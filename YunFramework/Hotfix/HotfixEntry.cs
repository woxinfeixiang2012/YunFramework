﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using YunFramework.Load;

namespace Hotfix
{
    /// <summary>
    /// 热更新层入口
    /// </summary>
    public static class HotfixEntry
    {
        public static void Start()
        {
            Debug.Log("热更新层启动！");

            //在完成Hotfix工程的代码编写后，将生成出来的Hotfix.dll与Hotfix.pdb文件复制到Asset/Res/hotfix/dll/目录下，并分别为其添加扩展名.bytes
            //之后进行AB打包即可

            //ILR测试
            //ILRTestMain ilrTestMain = new ILRTestMain();
            //UpdateDriver.Instance.AddUpdater(ilrTestMain, ResLoader.Instance.LoadGameObject("ILRCube"));
        }

    }
}

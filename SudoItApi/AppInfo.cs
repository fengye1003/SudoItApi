﻿namespace SudoItApi
{
    /// <summary>
    /// App信息类
    /// </summary>
    public class AppInfo
    {
        public static string AppName = "$udo!T Api Server";
        public static string Version = "v.1.0.0.2";
        public static string InsideVersion = "Alpha 1";
        public static string Copyright = "EachOther Tech. 2022";
        public static string UpdateLog = "-更新了进程类部分功能\n-添加注释\n-现在,日志文件将被保存到Log文件夹下\n-修复了压缩/解压文件上找不到7z运行库的问题\n-修复了获取状态时会错误记录日志的Bug";
    }
    /// <summary>
    /// 用户信息类(定制)
    /// </summary>
    public class PersonalInfo
    {
        public static string Name;
        public static string Company;
        public static bool InsidePermission;
    }
}

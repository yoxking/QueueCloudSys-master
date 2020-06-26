using System;

namespace EntFrm.RegistConsole
{
    public class ILoginHelper
    { 
        private string LoginId = "";
        private string Password = ""; 
        private bool isLogin = false;
        private DateTime LoginTime;


        private static ILoginHelper _CurrentUser = null;

        /// <summary>
        /// 当前登录的用户
        /// </summary>
        public static ILoginHelper CurrentUser
        {
            get
            {
                if (_CurrentUser == null) _CurrentUser = new ILoginHelper(); //空对象
                return _CurrentUser;
            }
            set
            {
                _CurrentUser = value;
            }
        }
         

        /// <summary>
        /// 用户 
        /// </summary>
        public string sLoginId { get { return LoginId; } set { LoginId = value; } }

        /// <summary>
        /// 用户密码
        /// </summary>
        public string sPassword { get { return Password; } set { Password = value; } }
         
        /// <summary>
        /// 登录时间
        /// </summary>
        public DateTime dLoginTime { get { return LoginTime; } set { LoginTime = value; } }
         

        public bool IsLogin { get { return isLogin; } set { isLogin = value; } }

    }
}
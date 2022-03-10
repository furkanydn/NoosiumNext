namespace Noosium.Resources.Common.Private
{
    /// <summary>
    /// It's a file that stores the names that the Dom Element can access in Selenium's Web Interface.
    /// </summary>
    internal struct ElementValues
    {
        public const string UserName = "Username";
        public const string InvalidUserName = "IUsername";
        public const string Password = "Password";
        public const string InvalidPassword = "IPassword";
        public const string Captcha = "Captcha";
        public const string InvalidCaptcha = "ICaptcha";
    }

    internal struct ElementMessages
    {
        public const string FormMessagesText = "Lütfen resimdeki karakterleri doğru giriniz.";
        public const string AccountDoesNotExist = "Account does not exist or password is incorrect.";
        public const string LtsInfoBoxHeader = "Limitsiz";
        public const string LtsInfoBoxText =
            "Limitsiz\\\\nKatılımcılar herhangi bir limite ulaşmaya çalışmadan en iyiyi yapmayı hedeflemeli.";
    }
    
    internal struct ElementSetting
    {
        public const string BaseUrl = "BaseUrl";
        public const string AdminMissionCom = "Admin/Missions/COM";
    }
}


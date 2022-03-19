namespace Noosium.Resources.Common.Private
{
    /// <summary>
    /// It's a file that stores the names that the Dom Element can access in Selenium's Web Interface.
    /// </summary>
    internal struct ElementValues
    {
        // Element Data Value
        public const string DataZero = "0%";
        public const string DataSix = "6%";
        public const string DataTwelve = "12%";
        public const string MissionGenerateName = "testmissiongenerateselenium";
        public const string MissionGeneratePurpose = "Esas amacı anlatan özlü bir söz kullanabilirsin.";
        // Ql Editor Contexts
        public const string QlEditorFirstText =
            "if(arguments[0].contentEditable === 'true') {arguments[0].innerText = 'Bu görevin anlaşılması için hikaye yazabilirsin.'}";
        public const string QlEditorSecondText =
            "if(arguments[0].contentEditable === 'true') {arguments[0].innerText = 'Bu görevin anlaşılması için hikaye <strong>yazabilirsin.</strong>'}";
        public const string QlEditorThirdText =
            "if(arguments[0].contentEditable === 'true') {arguments[0].innerText = '<h3>bur bir görevin anlaşılması için hikaye <strong>yazabilirsin.</strong></h3>'}";
        public const string QlEditorFourthText =
            "if(arguments[0].contentEditable === 'true') {arguments[0].innerText = '<h3>bur bir görevin anlaşılması için hikaye <strong><em>yazabilirsin.</em></strong></h3>'}";
        public const string QlEditorFifthText =
            "if(arguments[0].contentEditable === 'true') {arguments[0].innerText = '<h2>bur bir görevin anlaşılması için hikaye <strong><em>yazabilirsin.</em></strong></h2>'}";
        public const string QlEditorSixthText =
            "if(arguments[0].contentEditable === 'true') {arguments[0].innerText = '<h2><u>bur</u> bir görevin anlaşılması için hikaye <strong><em>yazabilirsin.</em></strong></h2>'}";
        public const string QlEditorSevenText =
            "if(arguments[0].contentEditable === 'true') {arguments[0].innerText = '<ol><li><u>bur</u> bir görevin anlaşılması için hikaye <strong><em>yazabilirsin.</em></strong></li></ol>'}";
        public const string QlEditorEighthText =
            "if(arguments[0].contentEditable === 'true') {arguments[0].innerText = '<ul><li><u>bur</u> bir görevin anlaşılması için hikaye <strong><em>yazabilirsin.</em></strong></li></ul>'}";
        public const string QlEditorNineText =
            "if(arguments[0].contentEditable === 'true') {arguments[0].innerText = '<p>bur bir görevin anlaşılması için hikaye <strong><em>yazabilirsin.</em></strong></p>'}";
    }

    internal struct ElementMessages
    {
        public const string FormMessagesText = "Lütfen resimdeki karakterleri doğru giriniz.";
        public const string AccountDoesNotExist = "Account does not exist or password is incorrect.";
        public const string LtsInfoBoxText =
            "Limitsiz\nKatılımcılar herhangi bir limite ulaşmaya çalışmadan en iyiyi yapmayı hedeflemeli.";
        public const string MissionGenerateHeader = "Görev Oluştur";
    }
    
    internal struct ElementSetting
    {
        public const string BaseUrl = "BaseUrl";
    }
}


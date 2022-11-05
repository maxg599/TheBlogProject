using System.ComponentModel;

namespace TheBlogProject.Enums
{
    public enum ModerationType
    {
        [Description("Political propaganda")]
        Political,
        [Description("Offensive Language")]
        Language,
        [Description("Drug references")]
        Drugs,
        [Description("Threating speech")]
        Threatening,
        [Description("Sexual Content")]
        Sexual,
        [Description("Hate Speech")]
        HateSpeech,
        [Description("Targeted Shaming")]
        Shaming

    }
}

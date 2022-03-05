using System;
using Microsoft.Toolkit.Uwp.Notifications;
using PrStat.Core;

namespace PrStat.Toaster
{
    public class Toaster
    {
        public static readonly string Arg_Action = "action";
        public static readonly string Arg_PrId = "prId";
        public static readonly string Arg_ToastType = "toastType";
        public static readonly string Arg_Url = "url";
        public static readonly string Action_View = "view";
        public static readonly string Action_MarkRead = "ignore";
        public static readonly string Action_Close = "close";
        public static readonly string ToastType_Pr = "pr";
        public static readonly string ToastType_Update = "update";

        public static void GenerateToastForUpdate(string releasePageUrl, string updateVersion)
        {
            new ToastContentBuilder()
                   .AddArgument(Arg_ToastType, ToastType_Update)
                   .AddArgument(Arg_Url, releasePageUrl)
                   .AddText($"Version {updateVersion} Now Available")
                   .AddText($"Update now or snooze notification until next check")
                   .AddButton(new ToastButton()
                       .SetContent("View Release")
                       .AddArgument(Arg_Action, Action_View)
                       .SetBackgroundActivation())

                   .AddButton(new ToastButton()
                       .SetContent("Snooze")
                       .AddArgument(Arg_Action, Action_Close)
                       .SetBackgroundActivation())
                   .Show();
        }

        public static void GenerateToastForPr(PullRequest pr)
        {
            var shortDescriptionLength = Math.Min(pr.Description?.Length ?? 0, 40);
            var description = pr.Description?[..shortDescriptionLength] ?? string.Empty;
            new ToastContentBuilder()
                .AddAttributionText(pr.Author.Name)
                .AddArgument(Arg_PrId, pr.Id)
                .AddArgument(Arg_Url, pr.Url)
                .AddText($"PR {pr.Id} Needs Review")
                .AddText(pr.Title)
                .AddText(description)

                .AddButton(new ToastButton()
                    .SetContent("View")
                    .AddArgument(Arg_Action, Action_View)
                    .SetBackgroundActivation())

                .AddButton(new ToastButton()
                    .SetContent("Mark Read")
                    .AddArgument(Arg_Action, Action_MarkRead)
                    .SetBackgroundActivation())

                .AddButton(new ToastButton()
                    .SetContent("Dismiss")
                    .AddArgument(Arg_Action, Action_Close)
                    .SetBackgroundActivation())
                .Show();
        }

    }
}

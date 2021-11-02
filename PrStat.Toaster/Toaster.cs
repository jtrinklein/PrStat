using System;
using Microsoft.Toolkit.Uwp.Notifications;
using PrStat.Core;

namespace PrStat.Toaster
{
    public class Toaster
    {
        public static readonly string PrIdArg = "prId";
        public static readonly string PrUrlArg = "prUrl";
        public static readonly string ActionArg = "action";
        public static readonly string Action_View = "view";
        public static readonly string Action_MarkRead = "ignore";
        public static readonly string Action_Close = "close";

        public static void GenerateToastForPr(PullRequest pr)
        {
            var shortDescriptionLength = Math.Min(pr.Description?.Length ?? 0, 40);
            var description = pr.Description?[..shortDescriptionLength] ?? string.Empty;
            new ToastContentBuilder()
                .AddAttributionText(pr.Author.Name)
                .AddArgument(PrIdArg, pr.Id)
                .AddArgument(PrUrlArg, pr.Url)
                .AddText($"PR {pr.Id} Needs Review")
                .AddText(pr.Title)
                .AddText(description)

                .AddButton(new ToastButton()
                    .SetContent("View")
                    .AddArgument(ActionArg, Action_View)
                    .SetBackgroundActivation())

                .AddButton(new ToastButton()
                    .SetContent("Mark Read")
                    .AddArgument(ActionArg, Action_MarkRead)
                    .SetBackgroundActivation())

                .AddButton(new ToastButton()
                    .SetContent("Dismiss")
                    .AddArgument(ActionArg, Action_Close)
                    .SetBackgroundActivation())

                .Show();
        }

    }
}

﻿using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text;

namespace UI.Web.Helpers
{
    [HtmlTargetElement("header-index")]
    public class HeaderHelper : TagHelper
    {
        public string Action { get; set; }

        public string Title { get; set; }

        public string ButtonText { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "HeaderHelper";
            output.TagMode = TagMode.StartTagAndEndTag;
            var sb = new StringBuilder();
            sb.AppendLine(@"<div class=""row mt-4"">");
            sb.AppendLine(@" <div class=""col-lg-12 d-flex justify-content-between align-items-center"">");
            sb.AppendFormat("<div><h2>{0}</h2></div>", Title);
            sb.AppendFormat("<div><a class='btn btn-primary' href='{0}'>{1}</a></div>", Action, ButtonText);
            sb.AppendLine("</div>");
            sb.AppendLine("</div>");
            output.PreContent.SetHtmlContent(sb.ToString());
        }
    }
}

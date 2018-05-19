@Code
    ViewData("Title") = "Home Page"
End Code

<h2>@ViewData("Message")</h2>
<p>
    To learn more about DevExpress Extensions for ASP.NET MVC visit <a href="http://devexpress.com/Products/NET/Controls/ASP-NET-MVC/" title="ASP.NET MVC Website">http://devexpress.com/Products/NET/Controls/ASP-NET-MVC/</a>.
</p>

<script type="text/javascript">
    function OnSubmitButtonClick(s, e) {
        loadingPanel.Show();
    }
</script>

@Using (Html.BeginForm())
    @Html.DevExpress().Button( _
        Sub(settings)
            settings.Name = "btnSubmit"
            settings.Text = "Submit form"
            settings.UseSubmitBehavior = True
            settings.ClientSideEvents.Click = "OnSubmitButtonClick"
        End Sub
    ).GetHtml()
End Using

@Html.DevExpress().PopupControl( _
    Sub(settings)
            settings.Name = "loadingPanel"
            settings.Modal = True
            settings.ShowHeader = False
            settings.ShowFooter = False
            settings.PopupHorizontalAlign = PopupHorizontalAlign.WindowCenter
            settings.PopupVerticalAlign = PopupVerticalAlign.WindowCenter
            settings.CloseAction = CloseAction.None
            settings.SetContent( _
                Sub()
                    ViewContext.Writer.Write(
                        "<div style=""height:30px;"">" +
                            "<img src=""" + Url.Content("~/Content/loading.gif") + """ style=""float:left;padding-left:30px;"">" +
                            "<span style=""padding:10px;float:left;"">Loading...</span>" +
                        "</div>"
                    )
                End Sub
            )
    End Sub
).GetHtml()
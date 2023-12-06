A Card widget is tidy, visually pleasing container that holds images, text, buttons and other elements for displaying information and features compactly.

Installation: Install the RBT.Xperience.Core.Components.Card.1.0.0 NuGet Package to your Kentico Xperience 13 Core MVC Site.

How to Use:-
1.	Select where on the page you would like the widget to appear.
2.	Go to properties of the widget
3.	In the Card widget properties pop up adjust various settings including visibility, items per row, maximum items displayed and content source.
4.	Click on the apply button to save.

Author: Niharika Vasantham (Ray Business Technologies Pvt Ltd.) Last updated 06-12-2023

License: This widget is provided under MIT license.

Reporting issues: Please report any issues seen, in the issue list. We will address at the earliest possibility.

Compatibility: This widget has been tested on Kentico Xperience 13 Core MVC version (13.0.64) and can be used on >=13.0.64

View Structure:Views/Shared/Card/ViewName.cshtml
 You can Add Your Own View.

  Example:
@using Kentico.Content.Web.Mvc;
@using Kentico.Web.Mvc;
@model RBT.Xperience.Core.Components.CardWidget.Components.Widgets.Card.CardViewModel
@if(Model.IsVisible!=null)
{
    string ImageURL = Url.Kentico().ImageUrl(Model.Image, SizeConstraint.Size(Model.Width, Model.Height));
<div class="grid-container">
    <section aria-label="Cheese is <br>trending up." class="card-section mrgTB20 common-content bgTopAlign">
        <div class="grid-x flex-dir-row-reverse align-middle">
            <div class="cell small-12 medium-6">
                <div class="homeProduct grid-x align-center">
                        <img alt="" src="@(ImageURL)" data-e="n49flp-e">
                </div>
            </div>
            <div class="cell small-12 medium-6 text-center medium-text-left">
                <h2><a href="@Model.TargetURL">@Model.Title</a></h2>
                <p>@Model.Description</p>
                @if (Model.IsButton == true)
                {
                    <a href="@Model.ButtonURL" class="" target="@Model.ButtonTarget">@Model.ButtonText</a>
                }
            </div>
        </div>
    </section>
</div>
}



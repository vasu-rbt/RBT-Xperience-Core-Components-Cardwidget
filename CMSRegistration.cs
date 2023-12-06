using CMS;
using Kentico.PageBuilder.Web.Mvc;
using RBT.Xperience.Core.Components.CardWidget.Components.Widgets.Card;

[assembly: AssemblyDiscoverable]
[assembly: RegisterWidget(CardViewComponent.IDENTIFIER, typeof(CardViewComponent), "Card Component", typeof(CardProperties), Description = "Card Description", IconClass = "icon-l-lightbox")]
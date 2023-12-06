using CMS.Core;
using CMS.MediaLibrary;
using CMS.SiteProvider;
using Kentico.PageBuilder.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using RBT.Xperience.Core.Components.CardWidget.Components.Widgets.Card;

[assembly: RegisterWidget(CardViewComponent.IDENTIFIER, typeof(CardViewComponent), "Card Component", typeof(CardProperties), Description = "Card Description", IconClass = "icon-l-lightbox")]
namespace RBT.Xperience.Core.Components.CardWidget.Components.Widgets.Card
{
    public class CardViewComponent:ViewComponent
    {
        public const string IDENTIFIER = "K13Base.Widget.HeroBannerVideo";

        private readonly IEventLogService _eventLogService;

        public CardViewComponent(IEventLogService eventLogService)
        {
            _eventLogService = eventLogService ?? throw new ArgumentNullException(nameof(eventLogService));
        }

        public async Task<IViewComponentResult> InvokeAsync(CardProperties properties, CancellationToken? cancellationToken = null)
        {
            try
            {
                if (properties.IsVisible!=null)
                {
                    
                        var imageguid = properties.Image.FirstOrDefault()?.FileGuid ?? Guid.Empty;
                        var imageInfo = MediaFileInfoProvider.GetMediaFileInfo(imageguid, SiteContext.CurrentSiteName);
                        string imageURL = MediaFileURLProvider.GetMediaFileUrl(imageInfo.FileGUID, imageInfo.FileName) ?? string.Empty;

                    CardViewModel cardModel = new();
                    cardModel.IsVisible = properties.IsVisible;
                    cardModel.Title = properties.Title;
                    cardModel.TargetURL = properties.TargetURL;
                    cardModel.Description = properties.Description;
                    cardModel.ImageAltText = properties.ImageAltText;
                    cardModel.Image = imageURL;
                    cardModel.IsButton = properties.IsButton;
                    cardModel.ButtonText = properties.ButtonText;
                    cardModel.ButtonTarget = properties.ButtonTarget;
                    cardModel.ButtonURL = properties.ButtonURL;
                    cardModel.Height = properties.Height > 0 ? properties.Height : imageInfo.FileImageHeight;
                    cardModel.Width = properties.Width > 0 ? properties.Width : imageInfo.FileImageWidth;
                    return await Task.FromResult((IViewComponentResult)View("~/Views/Shared/Card/"+properties.ViewName+".cshtml", cardModel));
                }

                else { return await Task.FromResult<IViewComponentResult>(Content(string.Empty)); }
            }
            catch (Exception ex)
            {

                _eventLogService.LogException(nameof(CardViewComponent), nameof(InvokeAsync), ex);


                return await Task.FromResult<IViewComponentResult>(Content(string.Empty));

            }

        }


    }
}

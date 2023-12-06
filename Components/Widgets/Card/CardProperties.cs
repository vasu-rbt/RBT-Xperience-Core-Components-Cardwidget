using Kentico.Components.Web.Mvc.FormComponents;
using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace RBT.Xperience.Core.Components.CardWidget.Components.Widgets.Card
{
    public class CardProperties : IWidgetProperties
    {
        /// <summary>
        /// Declaring the widget will visible or not
        /// </summary>
        [EditingComponent(CheckBoxComponent.IDENTIFIER, Order = 0, Label = "Visible", Tooltip = "Set the visibility for widget to render")]
        public bool? IsVisible { get; set; }
        /// <summary>
        /// Declaring to enter the video Title
        /// </summary>
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 1, Label = "Title *", Tooltip = "Enter the Title.")]
        [EditingComponentProperty("Size", 200)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter Title.")]
        public string? Title { get; set; }
        /// <summary>
        /// Title URL
        /// </summary>
        [EditingComponent(UrlSelector.IDENTIFIER, Order = 2, Label = "Target Url", Tooltip = "Enter Image Link Target.")]
        public string? TargetURL { get; set; }
        ///<summary>
        ///Declaring to enter Description
        /// </summary>
        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 3, Label = "Description *", Tooltip = "Enter the Description.")]
        [EditingComponentProperty("Size", 400)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter Description.")]
        public string? Description { get; set; }
        /// <summary>
        /// Width
        /// </summary>
        [EditingComponent(IntInputComponent.IDENTIFIER, Label = "Width", Order = 4)]
        public int Width { get; set; }
        /// <summary>
        /// Height
        /// </summary>
        [EditingComponent(IntInputComponent.IDENTIFIER, Label = "Height", Order = 5)]
        public int Height { get; set; }
        /// <summary>
        /// Declaring to select Image
        /// </summary>
        [EditingComponent(MediaFilesSelector.IDENTIFIER, Order = 6)]
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.MaxFilesLimit), 1)]
        public IList<MediaFilesSelectorItem>? Image { get; set; }
        /// <summary>
        /// Declaring to enter the Alt Image Text
        /// </summary>
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 7, Label = "Image Alt Text", Tooltip = "Enter the Image Alt Text.")]
        [EditingComponentProperty("Size", 200)]
        public string? ImageAltText { get; set; }
        /// <summary>
        /// Select the transformation or view name
        /// </summary>
        [EditingComponent(TextInputComponent.IDENTIFIER, Label = "Transformation", Order = 8)]
        public string? ViewName { get; set; }
        /// <summary>
        /// Declaring the widget will visible or not
        /// </summary>
        [EditingComponent(CheckBoxComponent.IDENTIFIER, Order = 9, Label = "Show Button", Tooltip = "Set the visibility for button to render")]
        public bool? IsButton { get; set; }
        /// <summary>
        /// Declaring to enter the Button Name
        /// </summary>
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 10, Label = "Button Text", Tooltip = "Enter the Button Name.")]
        [EditingComponentProperty("Size", 200)]
        [VisibilityCondition(nameof(IsButton), ComparisonTypeEnum.IsTrue)]
        public string? ButtonText { get; set; }
        /// <summary>
        /// Declaring to enter the Button Target
        /// </summary>
        [EditingComponent(DropDownComponent.IDENTIFIER, Order = 11, Label = "Button Target", Tooltip = "Enter the Button Target.")]
        [VisibilityCondition(nameof(IsButton), ComparisonTypeEnum.IsTrue)]
        [EditingComponentProperty(nameof(DropDownProperties.DataSource), "_self;Self\r\n_blank;Blank")]
        public string? ButtonTarget { get; set; }
        /// <summary>
        /// Declaring to enter the Button URL
        /// </summary>
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 12, Label = "Button URL", Tooltip = "Enter the Button URL.")]
        [EditingComponentProperty("Size", 200)]
        [VisibilityCondition(nameof(IsButton), ComparisonTypeEnum.IsTrue)]
        public string? ButtonURL { get; set; }
    }
}

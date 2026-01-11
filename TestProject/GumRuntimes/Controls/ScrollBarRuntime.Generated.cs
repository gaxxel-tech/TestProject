using System.Linq;
namespace TestProject.GumRuntimes.Controls
{
    public partial class ScrollBarRuntime : global::TestProject.GumRuntimes.ContainerRuntime, global::TestProject.GumRuntimes.IScrollBarBehavior
    {
        #region State Enums
        public new  enum VariableState
        {
            Default
        }
        public  enum ScrollBarCategory
        {
        }
        #endregion
        #region State Fields
        VariableState mCurrentVariableState;
        ScrollBarCategory? mCurrentScrollBarCategoryState;
        #endregion
        #region State Properties
        public new VariableState CurrentVariableState
        {
            get
            {
                return mCurrentVariableState;
            }
            set
            {
                mCurrentVariableState = value;
                switch(mCurrentVariableState)
                {
                    case  VariableState.Default:
                        TrackBackground.Parent = this.GetGraphicalUiElementByName("ThumbContainer") ?? this;
                        ThumbInstance.Parent = this.GetGraphicalUiElementByName("ThumbContainer") ?? this;
                        UpButtonInstance.IconCategory = global::TestProject.GumRuntimes.Elements.IconRuntime.IconCategory.Arrow1;
                        DownButtonInstance.IconCategory = global::TestProject.GumRuntimes.Elements.IconRuntime.IconCategory.Arrow1;
                        TrackBackground.CurrentColorCategoryState = global::TestProject.GumRuntimes.NineSliceRuntime.ColorCategory.Gray;
                        TrackBackground.CurrentStyleCategoryState = global::TestProject.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
                        Height = 0f;
                        HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToParent;
                        Width = 24f;
                        UpButtonInstance.Height = 24f;
                        UpButtonInstance.Rotation = 90f;
                        UpButtonInstance.Width = 24f;
                        UpButtonInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        UpButtonInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        DownButtonInstance.Height = 24f;
                        DownButtonInstance.Rotation = -90f;
                        DownButtonInstance.Width = 24f;
                        DownButtonInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        DownButtonInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        DownButtonInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        ThumbContainer.Height = -48f;
                        ThumbContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToParent;
                        ThumbContainer.Width = 0f;
                        ThumbContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToParent;
                        ThumbContainer.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        ThumbContainer.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        ThumbContainer.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        ThumbContainer.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        TrackBackground.Height = 0f;
                        TrackBackground.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToParent;
                        TrackBackground.Width = 0f;
                        TrackBackground.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToParent;
                        TrackBackground.X = 0f;
                        TrackBackground.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        TrackBackground.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        TrackBackground.Y = 0f;
                        TrackBackground.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        TrackBackground.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        ThumbInstance.ButtonDisplayText = "";
                        ThumbInstance.Width = 0f;
                        ThumbInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToParent;
                        ThumbInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        ThumbInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        ThumbInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        ThumbInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        break;
                }
            }
        }
        public ScrollBarCategory? CurrentScrollBarCategoryState
        {
            get
            {
                return mCurrentScrollBarCategoryState;
            }
            set
            {
                if (value != null)
                {
                    mCurrentScrollBarCategoryState = value;
                }
            }
        }
        #endregion
        #region State Interpolation
        public void InterpolateBetween (VariableState firstState, VariableState secondState, float interpolationValue) 
        {
            #if DEBUG
            if (float.IsNaN(interpolationValue))
            {
                throw new System.Exception("interpolationValue cannot be NaN");
            }
            #endif
            bool setDownButtonInstanceHeightFirstValue = false;
            bool setDownButtonInstanceHeightSecondValue = false;
            float DownButtonInstanceHeightFirstValue= 0;
            float DownButtonInstanceHeightSecondValue= 0;
            bool setDownButtonInstanceRotationFirstValue = false;
            bool setDownButtonInstanceRotationSecondValue = false;
            float DownButtonInstanceRotationFirstValue= 0;
            float DownButtonInstanceRotationSecondValue= 0;
            bool setDownButtonInstanceWidthFirstValue = false;
            bool setDownButtonInstanceWidthSecondValue = false;
            float DownButtonInstanceWidthFirstValue= 0;
            float DownButtonInstanceWidthSecondValue= 0;
            bool setHeightFirstValue = false;
            bool setHeightSecondValue = false;
            float HeightFirstValue= 0;
            float HeightSecondValue= 0;
            bool setThumbContainerHeightFirstValue = false;
            bool setThumbContainerHeightSecondValue = false;
            float ThumbContainerHeightFirstValue= 0;
            float ThumbContainerHeightSecondValue= 0;
            bool setThumbContainerWidthFirstValue = false;
            bool setThumbContainerWidthSecondValue = false;
            float ThumbContainerWidthFirstValue= 0;
            float ThumbContainerWidthSecondValue= 0;
            bool setThumbInstanceWidthFirstValue = false;
            bool setThumbInstanceWidthSecondValue = false;
            float ThumbInstanceWidthFirstValue= 0;
            float ThumbInstanceWidthSecondValue= 0;
            bool setTrackBackgroundCurrentColorCategoryStateFirstValue = false;
            bool setTrackBackgroundCurrentColorCategoryStateSecondValue = false;
            global::TestProject.GumRuntimes.NineSliceRuntime.ColorCategory TrackBackgroundCurrentColorCategoryStateFirstValue= global::TestProject.GumRuntimes.NineSliceRuntime.ColorCategory.Black;
            global::TestProject.GumRuntimes.NineSliceRuntime.ColorCategory TrackBackgroundCurrentColorCategoryStateSecondValue= global::TestProject.GumRuntimes.NineSliceRuntime.ColorCategory.Black;
            bool setTrackBackgroundHeightFirstValue = false;
            bool setTrackBackgroundHeightSecondValue = false;
            float TrackBackgroundHeightFirstValue= 0;
            float TrackBackgroundHeightSecondValue= 0;
            bool setTrackBackgroundCurrentStyleCategoryStateFirstValue = false;
            bool setTrackBackgroundCurrentStyleCategoryStateSecondValue = false;
            global::TestProject.GumRuntimes.NineSliceRuntime.StyleCategory TrackBackgroundCurrentStyleCategoryStateFirstValue= global::TestProject.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
            global::TestProject.GumRuntimes.NineSliceRuntime.StyleCategory TrackBackgroundCurrentStyleCategoryStateSecondValue= global::TestProject.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
            bool setTrackBackgroundWidthFirstValue = false;
            bool setTrackBackgroundWidthSecondValue = false;
            float TrackBackgroundWidthFirstValue= 0;
            float TrackBackgroundWidthSecondValue= 0;
            bool setTrackBackgroundXFirstValue = false;
            bool setTrackBackgroundXSecondValue = false;
            float TrackBackgroundXFirstValue= 0;
            float TrackBackgroundXSecondValue= 0;
            bool setTrackBackgroundYFirstValue = false;
            bool setTrackBackgroundYSecondValue = false;
            float TrackBackgroundYFirstValue= 0;
            float TrackBackgroundYSecondValue= 0;
            bool setUpButtonInstanceHeightFirstValue = false;
            bool setUpButtonInstanceHeightSecondValue = false;
            float UpButtonInstanceHeightFirstValue= 0;
            float UpButtonInstanceHeightSecondValue= 0;
            bool setUpButtonInstanceRotationFirstValue = false;
            bool setUpButtonInstanceRotationSecondValue = false;
            float UpButtonInstanceRotationFirstValue= 0;
            float UpButtonInstanceRotationSecondValue= 0;
            bool setUpButtonInstanceWidthFirstValue = false;
            bool setUpButtonInstanceWidthSecondValue = false;
            float UpButtonInstanceWidthFirstValue= 0;
            float UpButtonInstanceWidthSecondValue= 0;
            bool setWidthFirstValue = false;
            bool setWidthSecondValue = false;
            float WidthFirstValue= 0;
            float WidthSecondValue= 0;
            switch(firstState)
            {
                case  VariableState.Default:
                    setDownButtonInstanceHeightFirstValue = true;
                    DownButtonInstanceHeightFirstValue = 24f;
                    if (interpolationValue < 1)
                    {
                        this.DownButtonInstance.IconCategory = global::TestProject.GumRuntimes.Elements.IconRuntime.IconCategory.Arrow1;
                    }
                    setDownButtonInstanceRotationFirstValue = true;
                    DownButtonInstanceRotationFirstValue = -90f;
                    setDownButtonInstanceWidthFirstValue = true;
                    DownButtonInstanceWidthFirstValue = 24f;
                    if (interpolationValue < 1)
                    {
                        this.DownButtonInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                    }
                    if (interpolationValue < 1)
                    {
                        this.DownButtonInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                    }
                    if (interpolationValue < 1)
                    {
                        this.DownButtonInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                    }
                    setHeightFirstValue = true;
                    HeightFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToParent;
                    }
                    setThumbContainerHeightFirstValue = true;
                    ThumbContainerHeightFirstValue = -48f;
                    if (interpolationValue < 1)
                    {
                        this.ThumbContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToParent;
                    }
                    setThumbContainerWidthFirstValue = true;
                    ThumbContainerWidthFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.ThumbContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToParent;
                    }
                    if (interpolationValue < 1)
                    {
                        this.ThumbContainer.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.ThumbContainer.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    if (interpolationValue < 1)
                    {
                        this.ThumbContainer.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.ThumbContainer.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    if (interpolationValue < 1)
                    {
                        this.ThumbInstance.ButtonDisplayText = "";
                    }
                    if (interpolationValue < 1)
                    {
                        this.ThumbInstance.Parent = this.GetGraphicalUiElementByName("ThumbContainer") ?? this;
                    }
                    setThumbInstanceWidthFirstValue = true;
                    ThumbInstanceWidthFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.ThumbInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToParent;
                    }
                    if (interpolationValue < 1)
                    {
                        this.ThumbInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.ThumbInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    if (interpolationValue < 1)
                    {
                        this.ThumbInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.ThumbInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setTrackBackgroundCurrentColorCategoryStateFirstValue = true;
                    TrackBackgroundCurrentColorCategoryStateFirstValue = global::TestProject.GumRuntimes.NineSliceRuntime.ColorCategory.Gray;
                    setTrackBackgroundHeightFirstValue = true;
                    TrackBackgroundHeightFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.TrackBackground.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToParent;
                    }
                    if (interpolationValue < 1)
                    {
                        this.TrackBackground.Parent = this.GetGraphicalUiElementByName("ThumbContainer") ?? this;
                    }
                    setTrackBackgroundCurrentStyleCategoryStateFirstValue = true;
                    TrackBackgroundCurrentStyleCategoryStateFirstValue = global::TestProject.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
                    setTrackBackgroundWidthFirstValue = true;
                    TrackBackgroundWidthFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.TrackBackground.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToParent;
                    }
                    setTrackBackgroundXFirstValue = true;
                    TrackBackgroundXFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.TrackBackground.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.TrackBackground.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setTrackBackgroundYFirstValue = true;
                    TrackBackgroundYFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.TrackBackground.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.TrackBackground.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setUpButtonInstanceHeightFirstValue = true;
                    UpButtonInstanceHeightFirstValue = 24f;
                    if (interpolationValue < 1)
                    {
                        this.UpButtonInstance.IconCategory = global::TestProject.GumRuntimes.Elements.IconRuntime.IconCategory.Arrow1;
                    }
                    setUpButtonInstanceRotationFirstValue = true;
                    UpButtonInstanceRotationFirstValue = 90f;
                    setUpButtonInstanceWidthFirstValue = true;
                    UpButtonInstanceWidthFirstValue = 24f;
                    if (interpolationValue < 1)
                    {
                        this.UpButtonInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                    }
                    if (interpolationValue < 1)
                    {
                        this.UpButtonInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                    }
                    setWidthFirstValue = true;
                    WidthFirstValue = 24f;
                    break;
            }
            switch(secondState)
            {
                case  VariableState.Default:
                    setDownButtonInstanceHeightSecondValue = true;
                    DownButtonInstanceHeightSecondValue = 24f;
                    if (interpolationValue >= 1)
                    {
                        this.DownButtonInstance.IconCategory = global::TestProject.GumRuntimes.Elements.IconRuntime.IconCategory.Arrow1;
                    }
                    setDownButtonInstanceRotationSecondValue = true;
                    DownButtonInstanceRotationSecondValue = -90f;
                    setDownButtonInstanceWidthSecondValue = true;
                    DownButtonInstanceWidthSecondValue = 24f;
                    if (interpolationValue >= 1)
                    {
                        this.DownButtonInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.DownButtonInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.DownButtonInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                    }
                    setHeightSecondValue = true;
                    HeightSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToParent;
                    }
                    setThumbContainerHeightSecondValue = true;
                    ThumbContainerHeightSecondValue = -48f;
                    if (interpolationValue >= 1)
                    {
                        this.ThumbContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToParent;
                    }
                    setThumbContainerWidthSecondValue = true;
                    ThumbContainerWidthSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.ThumbContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToParent;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.ThumbContainer.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.ThumbContainer.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.ThumbContainer.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.ThumbContainer.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.ThumbInstance.ButtonDisplayText = "";
                    }
                    if (interpolationValue >= 1)
                    {
                        this.ThumbInstance.Parent = this.GetGraphicalUiElementByName("ThumbContainer") ?? this;
                    }
                    setThumbInstanceWidthSecondValue = true;
                    ThumbInstanceWidthSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.ThumbInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToParent;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.ThumbInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.ThumbInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.ThumbInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.ThumbInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setTrackBackgroundCurrentColorCategoryStateSecondValue = true;
                    TrackBackgroundCurrentColorCategoryStateSecondValue = global::TestProject.GumRuntimes.NineSliceRuntime.ColorCategory.Gray;
                    setTrackBackgroundHeightSecondValue = true;
                    TrackBackgroundHeightSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.TrackBackground.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToParent;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.TrackBackground.Parent = this.GetGraphicalUiElementByName("ThumbContainer") ?? this;
                    }
                    setTrackBackgroundCurrentStyleCategoryStateSecondValue = true;
                    TrackBackgroundCurrentStyleCategoryStateSecondValue = global::TestProject.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
                    setTrackBackgroundWidthSecondValue = true;
                    TrackBackgroundWidthSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.TrackBackground.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToParent;
                    }
                    setTrackBackgroundXSecondValue = true;
                    TrackBackgroundXSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.TrackBackground.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.TrackBackground.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setTrackBackgroundYSecondValue = true;
                    TrackBackgroundYSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.TrackBackground.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.TrackBackground.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setUpButtonInstanceHeightSecondValue = true;
                    UpButtonInstanceHeightSecondValue = 24f;
                    if (interpolationValue >= 1)
                    {
                        this.UpButtonInstance.IconCategory = global::TestProject.GumRuntimes.Elements.IconRuntime.IconCategory.Arrow1;
                    }
                    setUpButtonInstanceRotationSecondValue = true;
                    UpButtonInstanceRotationSecondValue = 90f;
                    setUpButtonInstanceWidthSecondValue = true;
                    UpButtonInstanceWidthSecondValue = 24f;
                    if (interpolationValue >= 1)
                    {
                        this.UpButtonInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.UpButtonInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                    }
                    setWidthSecondValue = true;
                    WidthSecondValue = 24f;
                    break;
            }
            var wasSuppressed = mIsLayoutSuspended;
            var shouldSuspend = wasSuppressed == false;
            var suspendRecursively = true;
            if (shouldSuspend)
            {
                SuspendLayout(suspendRecursively);
            }
            if (setDownButtonInstanceHeightFirstValue && setDownButtonInstanceHeightSecondValue)
            {
                DownButtonInstance.Height = DownButtonInstanceHeightFirstValue * (1 - interpolationValue) + DownButtonInstanceHeightSecondValue * interpolationValue;
            }
            if (setDownButtonInstanceRotationFirstValue && setDownButtonInstanceRotationSecondValue)
            {
                DownButtonInstance.Rotation = DownButtonInstanceRotationFirstValue * (1 - interpolationValue) + DownButtonInstanceRotationSecondValue * interpolationValue;
            }
            if (setDownButtonInstanceWidthFirstValue && setDownButtonInstanceWidthSecondValue)
            {
                DownButtonInstance.Width = DownButtonInstanceWidthFirstValue * (1 - interpolationValue) + DownButtonInstanceWidthSecondValue * interpolationValue;
            }
            if (setHeightFirstValue && setHeightSecondValue)
            {
                Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
            }
            if (setThumbContainerHeightFirstValue && setThumbContainerHeightSecondValue)
            {
                ThumbContainer.Height = ThumbContainerHeightFirstValue * (1 - interpolationValue) + ThumbContainerHeightSecondValue * interpolationValue;
            }
            if (setThumbContainerWidthFirstValue && setThumbContainerWidthSecondValue)
            {
                ThumbContainer.Width = ThumbContainerWidthFirstValue * (1 - interpolationValue) + ThumbContainerWidthSecondValue * interpolationValue;
            }
            if (setThumbInstanceWidthFirstValue && setThumbInstanceWidthSecondValue)
            {
                ThumbInstance.Width = ThumbInstanceWidthFirstValue * (1 - interpolationValue) + ThumbInstanceWidthSecondValue * interpolationValue;
            }
            if (setTrackBackgroundCurrentColorCategoryStateFirstValue && setTrackBackgroundCurrentColorCategoryStateSecondValue)
            {
                TrackBackground.InterpolateBetween(TrackBackgroundCurrentColorCategoryStateFirstValue, TrackBackgroundCurrentColorCategoryStateSecondValue, interpolationValue);
            }
            if (setTrackBackgroundHeightFirstValue && setTrackBackgroundHeightSecondValue)
            {
                TrackBackground.Height = TrackBackgroundHeightFirstValue * (1 - interpolationValue) + TrackBackgroundHeightSecondValue * interpolationValue;
            }
            if (setTrackBackgroundCurrentStyleCategoryStateFirstValue && setTrackBackgroundCurrentStyleCategoryStateSecondValue)
            {
                TrackBackground.InterpolateBetween(TrackBackgroundCurrentStyleCategoryStateFirstValue, TrackBackgroundCurrentStyleCategoryStateSecondValue, interpolationValue);
            }
            if (setTrackBackgroundWidthFirstValue && setTrackBackgroundWidthSecondValue)
            {
                TrackBackground.Width = TrackBackgroundWidthFirstValue * (1 - interpolationValue) + TrackBackgroundWidthSecondValue * interpolationValue;
            }
            if (setTrackBackgroundXFirstValue && setTrackBackgroundXSecondValue)
            {
                TrackBackground.X = TrackBackgroundXFirstValue * (1 - interpolationValue) + TrackBackgroundXSecondValue * interpolationValue;
            }
            if (setTrackBackgroundYFirstValue && setTrackBackgroundYSecondValue)
            {
                TrackBackground.Y = TrackBackgroundYFirstValue * (1 - interpolationValue) + TrackBackgroundYSecondValue * interpolationValue;
            }
            if (setUpButtonInstanceHeightFirstValue && setUpButtonInstanceHeightSecondValue)
            {
                UpButtonInstance.Height = UpButtonInstanceHeightFirstValue * (1 - interpolationValue) + UpButtonInstanceHeightSecondValue * interpolationValue;
            }
            if (setUpButtonInstanceRotationFirstValue && setUpButtonInstanceRotationSecondValue)
            {
                UpButtonInstance.Rotation = UpButtonInstanceRotationFirstValue * (1 - interpolationValue) + UpButtonInstanceRotationSecondValue * interpolationValue;
            }
            if (setUpButtonInstanceWidthFirstValue && setUpButtonInstanceWidthSecondValue)
            {
                UpButtonInstance.Width = UpButtonInstanceWidthFirstValue * (1 - interpolationValue) + UpButtonInstanceWidthSecondValue * interpolationValue;
            }
            if (setWidthFirstValue && setWidthSecondValue)
            {
                Width = WidthFirstValue * (1 - interpolationValue) + WidthSecondValue * interpolationValue;
            }
            if (interpolationValue < 1)
            {
                mCurrentVariableState = firstState;
            }
            else
            {
                mCurrentVariableState = secondState;
            }
            if (shouldSuspend)
            {
                ResumeLayout(suspendRecursively);
            }
        }
        public void InterpolateBetween (ScrollBarCategory firstState, ScrollBarCategory secondState, float interpolationValue) 
        {
            #if DEBUG
            if (float.IsNaN(interpolationValue))
            {
                throw new System.Exception("interpolationValue cannot be NaN");
            }
            #endif
            var wasSuppressed = mIsLayoutSuspended;
            var shouldSuspend = wasSuppressed == false;
            var suspendRecursively = true;
            // all values assigned in this state do not require recursive updates:
            suspendRecursively = false;
            var isSafeToInterpolateWithoutSuppression = true;
            if(isSafeToInterpolateWithoutSuppression) shouldSuspend = false;
            if (shouldSuspend)
            {
                SuspendLayout(suspendRecursively);
            }
            if (interpolationValue < 1)
            {
                mCurrentScrollBarCategoryState = firstState;
            }
            else
            {
                mCurrentScrollBarCategoryState = secondState;
            }
            if (shouldSuspend)
            {
                ResumeLayout(suspendRecursively);
            }
        }
        #endregion
        #region State Interpolate To
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (global::TestProject.GumRuntimes.Controls.ScrollBarRuntime.VariableState fromState,global::TestProject.GumRuntimes.Controls.ScrollBarRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
        {
            FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from:0, to:1, duration:(float)secondsToTake, type:interpolationType, easing:easing );
            if (owner == null)
            {
                tweener.Owner = this;
            }
            else
            {
                tweener.Owner = owner;
            }
            tweener.PositionChanged = newPosition => this.InterpolateBetween(fromState, toState, newPosition);
            tweener.Start();
            StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
            return tweener;
        }
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
        {
            Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
            Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.States.First(item => item.Name == toState.ToString());
            FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: (float)secondsToTake, type: interpolationType, easing: easing);
            if (owner == null)
            {
                tweener.Owner = this;
            }
            else
            {
                tweener.Owner = owner;
            }
            tweener.PositionChanged = newPosition => this.InterpolateBetween(current, toAsStateSave, newPosition);
            tweener.Ended += ()=> this.CurrentVariableState = toState;
            tweener.Start();
            StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
            return tweener;
        }
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
        {
            Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
            Gum.DataTypes.Variables.StateSave toAsStateSave = AddToCurrentValuesWithState(toState);
            FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: (float)secondsToTake, type: interpolationType, easing: easing);
            if (owner == null)
            {
                tweener.Owner = this;
            }
            else
            {
                tweener.Owner = owner;
            }
            tweener.PositionChanged = newPosition => this.InterpolateBetween(current, toAsStateSave, newPosition);
            tweener.Ended += ()=> this.CurrentVariableState = toState;
            tweener.Start();
            StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
            return tweener;
        }
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (global::TestProject.GumRuntimes.Controls.ScrollBarRuntime.ScrollBarCategory fromState,global::TestProject.GumRuntimes.Controls.ScrollBarRuntime.ScrollBarCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
        {
            FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from:0, to:1, duration:(float)secondsToTake, type:interpolationType, easing:easing );
            if (owner == null)
            {
                tweener.Owner = this;
            }
            else
            {
                tweener.Owner = owner;
            }
            tweener.PositionChanged = newPosition => this.InterpolateBetween(fromState, toState, newPosition);
            tweener.Start();
            StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
            return tweener;
        }
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (ScrollBarCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
        {
            Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
            Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "ScrollBarCategory").States.First(item => item.Name == toState.ToString());
            FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: (float)secondsToTake, type: interpolationType, easing: easing);
            if (owner == null)
            {
                tweener.Owner = this;
            }
            else
            {
                tweener.Owner = owner;
            }
            tweener.PositionChanged = newPosition => this.InterpolateBetween(current, toAsStateSave, newPosition);
            tweener.Ended += ()=> this.CurrentScrollBarCategoryState = toState;
            tweener.Start();
            StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
            return tweener;
        }
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (ScrollBarCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
        {
            Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
            Gum.DataTypes.Variables.StateSave toAsStateSave = AddToCurrentValuesWithState(toState);
            FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: (float)secondsToTake, type: interpolationType, easing: easing);
            if (owner == null)
            {
                tweener.Owner = this;
            }
            else
            {
                tweener.Owner = owner;
            }
            tweener.PositionChanged = newPosition => this.InterpolateBetween(current, toAsStateSave, newPosition);
            tweener.Ended += ()=> this.CurrentScrollBarCategoryState = toState;
            tweener.Start();
            StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
            return tweener;
        }
        #endregion
        #region State Animations
        #endregion
        public override void StopAnimations () 
        {
            base.StopAnimations();
            UpButtonInstance.StopAnimations();
            DownButtonInstance.StopAnimations();
            ThumbInstance.StopAnimations();
        }
        public override FlatRedBall.Gum.Animation.GumAnimation GetAnimation (string animationName) 
        {
            return base.GetAnimation(animationName);
        }
        #region Get Current Values on State
        private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (VariableState state) 
        {
            Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
            switch(state)
            {
                case  VariableState.Default:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Height",
                        Type = "float",
                        Value = Height
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "HeightUnits",
                        Type = "DimensionUnitType",
                        Value = HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Width",
                        Type = "float",
                        Value = Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "UpButtonInstance.Height",
                        Type = "float",
                        Value = UpButtonInstance.Height
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "UpButtonInstance.IconCategory",
                        Type = "IconCategory",
                        Value = UpButtonInstance.IconCategory
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "UpButtonInstance.Rotation",
                        Type = "float",
                        Value = UpButtonInstance.Rotation
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "UpButtonInstance.Width",
                        Type = "float",
                        Value = UpButtonInstance.Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "UpButtonInstance.XOrigin",
                        Type = "HorizontalAlignment",
                        Value = UpButtonInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "UpButtonInstance.YOrigin",
                        Type = "VerticalAlignment",
                        Value = UpButtonInstance.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "DownButtonInstance.Height",
                        Type = "float",
                        Value = DownButtonInstance.Height
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "DownButtonInstance.IconCategory",
                        Type = "IconCategory",
                        Value = DownButtonInstance.IconCategory
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "DownButtonInstance.Rotation",
                        Type = "float",
                        Value = DownButtonInstance.Rotation
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "DownButtonInstance.Width",
                        Type = "float",
                        Value = DownButtonInstance.Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "DownButtonInstance.XOrigin",
                        Type = "HorizontalAlignment",
                        Value = DownButtonInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "DownButtonInstance.YOrigin",
                        Type = "VerticalAlignment",
                        Value = DownButtonInstance.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "DownButtonInstance.YUnits",
                        Type = "PositionUnitType",
                        Value = DownButtonInstance.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbContainer.Height",
                        Type = "float",
                        Value = ThumbContainer.Height
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbContainer.HeightUnits",
                        Type = "DimensionUnitType",
                        Value = ThumbContainer.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbContainer.Width",
                        Type = "float",
                        Value = ThumbContainer.Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbContainer.WidthUnits",
                        Type = "DimensionUnitType",
                        Value = ThumbContainer.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbContainer.XOrigin",
                        Type = "HorizontalAlignment",
                        Value = ThumbContainer.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbContainer.XUnits",
                        Type = "PositionUnitType",
                        Value = ThumbContainer.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbContainer.YOrigin",
                        Type = "VerticalAlignment",
                        Value = ThumbContainer.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbContainer.YUnits",
                        Type = "PositionUnitType",
                        Value = ThumbContainer.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TrackBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TrackBackground.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TrackBackground.Height",
                        Type = "float",
                        Value = TrackBackground.Height
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TrackBackground.HeightUnits",
                        Type = "DimensionUnitType",
                        Value = TrackBackground.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TrackBackground.Parent",
                        Type = "string",
                        Value = TrackBackground.Parent
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TrackBackground.StyleCategoryState",
                        Type = "StyleCategory",
                        Value = TrackBackground.CurrentStyleCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TrackBackground.Width",
                        Type = "float",
                        Value = TrackBackground.Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TrackBackground.WidthUnits",
                        Type = "DimensionUnitType",
                        Value = TrackBackground.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TrackBackground.X",
                        Type = "float",
                        Value = TrackBackground.X
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TrackBackground.XOrigin",
                        Type = "HorizontalAlignment",
                        Value = TrackBackground.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TrackBackground.XUnits",
                        Type = "PositionUnitType",
                        Value = TrackBackground.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TrackBackground.Y",
                        Type = "float",
                        Value = TrackBackground.Y
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TrackBackground.YOrigin",
                        Type = "VerticalAlignment",
                        Value = TrackBackground.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TrackBackground.YUnits",
                        Type = "PositionUnitType",
                        Value = TrackBackground.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbInstance.ButtonDisplayText",
                        Type = "string",
                        Value = ThumbInstance.ButtonDisplayText
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbInstance.Parent",
                        Type = "string",
                        Value = ThumbInstance.Parent
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbInstance.Width",
                        Type = "float",
                        Value = ThumbInstance.Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbInstance.WidthUnits",
                        Type = "DimensionUnitType",
                        Value = ThumbInstance.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbInstance.XOrigin",
                        Type = "HorizontalAlignment",
                        Value = ThumbInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbInstance.XUnits",
                        Type = "PositionUnitType",
                        Value = ThumbInstance.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbInstance.YOrigin",
                        Type = "VerticalAlignment",
                        Value = ThumbInstance.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbInstance.YUnits",
                        Type = "PositionUnitType",
                        Value = ThumbInstance.YUnits
                    }
                    );
                    break;
            }
            return newState;
        }
        private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (VariableState state) 
        {
            Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
            switch(state)
            {
                case  VariableState.Default:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Height",
                        Type = "float",
                        Value = Height + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "HeightUnits",
                        Type = "DimensionUnitType",
                        Value = HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Width",
                        Type = "float",
                        Value = Width + 24f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "UpButtonInstance.Height",
                        Type = "float",
                        Value = UpButtonInstance.Height + 24f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "UpButtonInstance.IconCategory",
                        Type = "IconCategory",
                        Value = UpButtonInstance.IconCategory
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "UpButtonInstance.Rotation",
                        Type = "float",
                        Value = UpButtonInstance.Rotation + 90f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "UpButtonInstance.Width",
                        Type = "float",
                        Value = UpButtonInstance.Width + 24f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "UpButtonInstance.XOrigin",
                        Type = "HorizontalAlignment",
                        Value = UpButtonInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "UpButtonInstance.YOrigin",
                        Type = "VerticalAlignment",
                        Value = UpButtonInstance.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "DownButtonInstance.Height",
                        Type = "float",
                        Value = DownButtonInstance.Height + 24f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "DownButtonInstance.IconCategory",
                        Type = "IconCategory",
                        Value = DownButtonInstance.IconCategory
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "DownButtonInstance.Rotation",
                        Type = "float",
                        Value = DownButtonInstance.Rotation + -90f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "DownButtonInstance.Width",
                        Type = "float",
                        Value = DownButtonInstance.Width + 24f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "DownButtonInstance.XOrigin",
                        Type = "HorizontalAlignment",
                        Value = DownButtonInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "DownButtonInstance.YOrigin",
                        Type = "VerticalAlignment",
                        Value = DownButtonInstance.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "DownButtonInstance.YUnits",
                        Type = "PositionUnitType",
                        Value = DownButtonInstance.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbContainer.Height",
                        Type = "float",
                        Value = ThumbContainer.Height + -48f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbContainer.HeightUnits",
                        Type = "DimensionUnitType",
                        Value = ThumbContainer.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbContainer.Width",
                        Type = "float",
                        Value = ThumbContainer.Width + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbContainer.WidthUnits",
                        Type = "DimensionUnitType",
                        Value = ThumbContainer.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbContainer.XOrigin",
                        Type = "HorizontalAlignment",
                        Value = ThumbContainer.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbContainer.XUnits",
                        Type = "PositionUnitType",
                        Value = ThumbContainer.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbContainer.YOrigin",
                        Type = "VerticalAlignment",
                        Value = ThumbContainer.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbContainer.YUnits",
                        Type = "PositionUnitType",
                        Value = ThumbContainer.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TrackBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TrackBackground.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TrackBackground.Height",
                        Type = "float",
                        Value = TrackBackground.Height + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TrackBackground.HeightUnits",
                        Type = "DimensionUnitType",
                        Value = TrackBackground.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TrackBackground.Parent",
                        Type = "string",
                        Value = TrackBackground.Parent
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TrackBackground.StyleCategoryState",
                        Type = "StyleCategory",
                        Value = TrackBackground.CurrentStyleCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TrackBackground.Width",
                        Type = "float",
                        Value = TrackBackground.Width + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TrackBackground.WidthUnits",
                        Type = "DimensionUnitType",
                        Value = TrackBackground.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TrackBackground.X",
                        Type = "float",
                        Value = TrackBackground.X + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TrackBackground.XOrigin",
                        Type = "HorizontalAlignment",
                        Value = TrackBackground.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TrackBackground.XUnits",
                        Type = "PositionUnitType",
                        Value = TrackBackground.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TrackBackground.Y",
                        Type = "float",
                        Value = TrackBackground.Y + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TrackBackground.YOrigin",
                        Type = "VerticalAlignment",
                        Value = TrackBackground.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TrackBackground.YUnits",
                        Type = "PositionUnitType",
                        Value = TrackBackground.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbInstance.ButtonDisplayText",
                        Type = "string",
                        Value = ThumbInstance.ButtonDisplayText
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbInstance.Parent",
                        Type = "string",
                        Value = ThumbInstance.Parent
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbInstance.Width",
                        Type = "float",
                        Value = ThumbInstance.Width + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbInstance.WidthUnits",
                        Type = "DimensionUnitType",
                        Value = ThumbInstance.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbInstance.XOrigin",
                        Type = "HorizontalAlignment",
                        Value = ThumbInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbInstance.XUnits",
                        Type = "PositionUnitType",
                        Value = ThumbInstance.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbInstance.YOrigin",
                        Type = "VerticalAlignment",
                        Value = ThumbInstance.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbInstance.YUnits",
                        Type = "PositionUnitType",
                        Value = ThumbInstance.YUnits
                    }
                    );
                    break;
            }
            return newState;
        }
        private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (ScrollBarCategory state) 
        {
            Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
            return newState;
        }
        private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (ScrollBarCategory state) 
        {
            Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
            return newState;
        }
        #endregion
        public override void ApplyState (Gum.DataTypes.Variables.StateSave state) 
        {
            bool matches = this.ElementSave.AllStates.Contains(state);
            if (matches)
            {
                var category = this.ElementSave.Categories.FirstOrDefault(item => item.States.Contains(state));
                if (category == null)
                {
                    if (state.Name == "Default") this.mCurrentVariableState = VariableState.Default;
                }
                else if (category.Name == "ScrollBarCategory")
                {
                }
            }
            base.ApplyState(state);
        }
        global::TestProject.GumRuntimes.IScrollBarBehavior.ScrollBarCategory global::TestProject.GumRuntimes.IScrollBarBehavior.CurrentScrollBarCategoryState
        {
            set
            {
            }
        }
        private bool tryCreateFormsObject;
        public global::TestProject.GumRuntimes.Controls.ButtonIconRuntime UpButtonInstance { get; set; }
        public global::TestProject.GumRuntimes.Controls.ButtonIconRuntime DownButtonInstance { get; set; }
        public global::TestProject.GumRuntimes.ContainerRuntime ThumbContainer { get; set; }
        public global::TestProject.GumRuntimes.NineSliceRuntime TrackBackground { get; set; }
        public global::TestProject.GumRuntimes.Controls.ButtonStandardRuntime ThumbInstance { get; set; }
        public event FlatRedBall.Gui.WindowEvent UpButtonInstanceClick;
        public event FlatRedBall.Gui.WindowEvent DownButtonInstanceClick;
        public event FlatRedBall.Gui.WindowEvent ThumbInstanceClick;
        public ScrollBarRuntime () 
        	: this(true, true)
        {
        }
        public ScrollBarRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
        	: base(false, false)
        {
            this.tryCreateFormsObject = tryCreateFormsObject;
            if (fullInstantiation)
            {
                Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "Controls/ScrollBar");
                this.ElementSave = elementSave;
                string oldDirectory = FlatRedBall.IO.FileManager.RelativeDirectory;
                FlatRedBall.IO.FileManager.RelativeDirectory = FlatRedBall.IO.FileManager.GetDirectory(Gum.Managers.ObjectFinder.Self.GumProjectSave.FullFileName);
                GumRuntime.ElementSaveExtensions.SetGraphicalUiElement(elementSave, this, RenderingLibrary.SystemManagers.Default);
                FlatRedBall.IO.FileManager.RelativeDirectory = oldDirectory;
            }
        }
        public override void SetInitialState () 
        {
            var wasSuppressed = this.IsLayoutSuspended;
            if(!wasSuppressed) this.SuspendLayout();
            base.SetInitialState();
            this.CurrentVariableState = VariableState.Default;
            if(!wasSuppressed) this.ResumeLayout();
            CallCustomInitialize();
        }
        public override void CreateChildrenRecursively (Gum.DataTypes.ElementSave elementSave, RenderingLibrary.ISystemManagers systemManagers) 
        {
            base.CreateChildrenRecursively(elementSave, systemManagers);
            this.AssignInternalReferences();
        }
        private void AssignInternalReferences () 
        {
            UpButtonInstance = this.GetGraphicalUiElementByName("UpButtonInstance") as global::TestProject.GumRuntimes.Controls.ButtonIconRuntime;
            DownButtonInstance = this.GetGraphicalUiElementByName("DownButtonInstance") as global::TestProject.GumRuntimes.Controls.ButtonIconRuntime;
            ThumbContainer = this.GetGraphicalUiElementByName("ThumbContainer") as global::TestProject.GumRuntimes.ContainerRuntime;
            TrackBackground = this.GetGraphicalUiElementByName("TrackBackground") as global::TestProject.GumRuntimes.NineSliceRuntime;
            ThumbInstance = this.GetGraphicalUiElementByName("ThumbInstance") as global::TestProject.GumRuntimes.Controls.ButtonStandardRuntime;
            UpButtonInstance.Click += (unused) => UpButtonInstanceClick?.Invoke(this);
            DownButtonInstance.Click += (unused) => DownButtonInstanceClick?.Invoke(this);
            ThumbInstance.Click += (unused) => ThumbInstanceClick?.Invoke(this);
            if (tryCreateFormsObject)
            {
                FormsControlAsObject = new FlatRedBall.Forms.Controls.ScrollBar(this);
            }
        }
        private void CallCustomInitialize () 
        {
            CustomInitialize();
        }
        partial void CustomInitialize();
        public FlatRedBall.Forms.Controls.ScrollBar FormsControl {get => (FlatRedBall.Forms.Controls.ScrollBar) FormsControlAsObject;}
        public override void RemoveFromManagers () 
        {
            StopAnimations();
            base.RemoveFromManagers();
        }
    }
}

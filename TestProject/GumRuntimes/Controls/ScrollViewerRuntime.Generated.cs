using System.Linq;
namespace TestProject.GumRuntimes.Controls
{
    public partial class ScrollViewerRuntime : global::TestProject.GumRuntimes.ContainerRuntime, global::TestProject.GumRuntimes.IScrollViewerBehavior
    {
        #region State Enums
        public new  enum VariableState
        {
            Default
        }
        public  enum ScrollBarVisibility
        {
            NoScrollBar,
            VerticalScrollVisible
        }
        #endregion
        #region State Fields
        VariableState mCurrentVariableState;
        ScrollBarVisibility? mCurrentScrollBarVisibilityState;
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
                        InnerPanelInstance.Parent = this.GetGraphicalUiElementByName("ClipContainerInstance") ?? this;
                        ListBoxItemInstance.Parent = this.GetGraphicalUiElementByName("InnerPanelInstance") ?? this;
                        Background.CurrentColorCategoryState = global::TestProject.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                        Background.CurrentStyleCategoryState = global::TestProject.GumRuntimes.NineSliceRuntime.StyleCategory.Bordered;
                        ListBoxItemInstance.CurrentListBoxItemCategoryState = global::TestProject.GumRuntimes.Controls.ListBoxItemRuntime.ListBoxItemCategory.Highlighted;
                        Background.Height = 0f;
                        Background.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToParent;
                        Background.Width = 0f;
                        Background.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToParent;
                        Background.X = 0f;
                        Background.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        Background.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        Background.Y = 0f;
                        Background.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        Background.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        VerticalScrollBarInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        VerticalScrollBarInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        VerticalScrollBarInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        VerticalScrollBarInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        ClipContainerInstance.ClipsChildren = true;
                        ClipContainerInstance.Height = -4f;
                        ClipContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToParent;
                        ClipContainerInstance.Width = -27f;
                        ClipContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToParent;
                        ClipContainerInstance.X = 2f;
                        ClipContainerInstance.Y = 2f;
                        ClipContainerInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        ClipContainerInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        InnerPanelInstance.Height = 0f;
                        InnerPanelInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        InnerPanelInstance.Width = 0f;
                        InnerPanelInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToParent;
                        break;
                }
            }
        }
        public ScrollBarVisibility? CurrentScrollBarVisibilityState
        {
            get
            {
                return mCurrentScrollBarVisibilityState;
            }
            set
            {
                if (value != null)
                {
                    mCurrentScrollBarVisibilityState = value;
                    switch(mCurrentScrollBarVisibilityState)
                    {
                        case  ScrollBarVisibility.NoScrollBar:
                            VerticalScrollBarInstance.Visible = false;
                            break;
                        case  ScrollBarVisibility.VerticalScrollVisible:
                            VerticalScrollBarInstance.Visible = true;
                            break;
                    }
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
            bool setBackgroundCurrentColorCategoryStateFirstValue = false;
            bool setBackgroundCurrentColorCategoryStateSecondValue = false;
            global::TestProject.GumRuntimes.NineSliceRuntime.ColorCategory BackgroundCurrentColorCategoryStateFirstValue= global::TestProject.GumRuntimes.NineSliceRuntime.ColorCategory.Black;
            global::TestProject.GumRuntimes.NineSliceRuntime.ColorCategory BackgroundCurrentColorCategoryStateSecondValue= global::TestProject.GumRuntimes.NineSliceRuntime.ColorCategory.Black;
            bool setBackgroundHeightFirstValue = false;
            bool setBackgroundHeightSecondValue = false;
            float BackgroundHeightFirstValue= 0;
            float BackgroundHeightSecondValue= 0;
            bool setBackgroundCurrentStyleCategoryStateFirstValue = false;
            bool setBackgroundCurrentStyleCategoryStateSecondValue = false;
            global::TestProject.GumRuntimes.NineSliceRuntime.StyleCategory BackgroundCurrentStyleCategoryStateFirstValue= global::TestProject.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
            global::TestProject.GumRuntimes.NineSliceRuntime.StyleCategory BackgroundCurrentStyleCategoryStateSecondValue= global::TestProject.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
            bool setBackgroundWidthFirstValue = false;
            bool setBackgroundWidthSecondValue = false;
            float BackgroundWidthFirstValue= 0;
            float BackgroundWidthSecondValue= 0;
            bool setBackgroundXFirstValue = false;
            bool setBackgroundXSecondValue = false;
            float BackgroundXFirstValue= 0;
            float BackgroundXSecondValue= 0;
            bool setBackgroundYFirstValue = false;
            bool setBackgroundYSecondValue = false;
            float BackgroundYFirstValue= 0;
            float BackgroundYSecondValue= 0;
            bool setClipContainerInstanceHeightFirstValue = false;
            bool setClipContainerInstanceHeightSecondValue = false;
            float ClipContainerInstanceHeightFirstValue= 0;
            float ClipContainerInstanceHeightSecondValue= 0;
            bool setClipContainerInstanceWidthFirstValue = false;
            bool setClipContainerInstanceWidthSecondValue = false;
            float ClipContainerInstanceWidthFirstValue= 0;
            float ClipContainerInstanceWidthSecondValue= 0;
            bool setClipContainerInstanceXFirstValue = false;
            bool setClipContainerInstanceXSecondValue = false;
            float ClipContainerInstanceXFirstValue= 0;
            float ClipContainerInstanceXSecondValue= 0;
            bool setClipContainerInstanceYFirstValue = false;
            bool setClipContainerInstanceYSecondValue = false;
            float ClipContainerInstanceYFirstValue= 0;
            float ClipContainerInstanceYSecondValue= 0;
            bool setInnerPanelInstanceHeightFirstValue = false;
            bool setInnerPanelInstanceHeightSecondValue = false;
            float InnerPanelInstanceHeightFirstValue= 0;
            float InnerPanelInstanceHeightSecondValue= 0;
            bool setInnerPanelInstanceWidthFirstValue = false;
            bool setInnerPanelInstanceWidthSecondValue = false;
            float InnerPanelInstanceWidthFirstValue= 0;
            float InnerPanelInstanceWidthSecondValue= 0;
            bool setListBoxItemInstanceCurrentListBoxItemCategoryStateFirstValue = false;
            bool setListBoxItemInstanceCurrentListBoxItemCategoryStateSecondValue = false;
            global::TestProject.GumRuntimes.Controls.ListBoxItemRuntime.ListBoxItemCategory ListBoxItemInstanceCurrentListBoxItemCategoryStateFirstValue= global::TestProject.GumRuntimes.Controls.ListBoxItemRuntime.ListBoxItemCategory.Enabled;
            global::TestProject.GumRuntimes.Controls.ListBoxItemRuntime.ListBoxItemCategory ListBoxItemInstanceCurrentListBoxItemCategoryStateSecondValue= global::TestProject.GumRuntimes.Controls.ListBoxItemRuntime.ListBoxItemCategory.Enabled;
            switch(firstState)
            {
                case  VariableState.Default:
                    setBackgroundCurrentColorCategoryStateFirstValue = true;
                    BackgroundCurrentColorCategoryStateFirstValue = global::TestProject.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                    setBackgroundHeightFirstValue = true;
                    BackgroundHeightFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.Background.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToParent;
                    }
                    setBackgroundCurrentStyleCategoryStateFirstValue = true;
                    BackgroundCurrentStyleCategoryStateFirstValue = global::TestProject.GumRuntimes.NineSliceRuntime.StyleCategory.Bordered;
                    setBackgroundWidthFirstValue = true;
                    BackgroundWidthFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.Background.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToParent;
                    }
                    setBackgroundXFirstValue = true;
                    BackgroundXFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.Background.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Background.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setBackgroundYFirstValue = true;
                    BackgroundYFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.Background.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Background.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    if (interpolationValue < 1)
                    {
                        this.ClipContainerInstance.ClipsChildren = true;
                    }
                    setClipContainerInstanceHeightFirstValue = true;
                    ClipContainerInstanceHeightFirstValue = -4f;
                    if (interpolationValue < 1)
                    {
                        this.ClipContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToParent;
                    }
                    setClipContainerInstanceWidthFirstValue = true;
                    ClipContainerInstanceWidthFirstValue = -27f;
                    if (interpolationValue < 1)
                    {
                        this.ClipContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToParent;
                    }
                    setClipContainerInstanceXFirstValue = true;
                    ClipContainerInstanceXFirstValue = 2f;
                    setClipContainerInstanceYFirstValue = true;
                    ClipContainerInstanceYFirstValue = 2f;
                    if (interpolationValue < 1)
                    {
                        this.ClipContainerInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                    }
                    if (interpolationValue < 1)
                    {
                        this.ClipContainerInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                    }
                    setInnerPanelInstanceHeightFirstValue = true;
                    InnerPanelInstanceHeightFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.InnerPanelInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                    }
                    if (interpolationValue < 1)
                    {
                        this.InnerPanelInstance.Parent = this.GetGraphicalUiElementByName("ClipContainerInstance") ?? this;
                    }
                    setInnerPanelInstanceWidthFirstValue = true;
                    InnerPanelInstanceWidthFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.InnerPanelInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToParent;
                    }
                    setListBoxItemInstanceCurrentListBoxItemCategoryStateFirstValue = true;
                    ListBoxItemInstanceCurrentListBoxItemCategoryStateFirstValue = global::TestProject.GumRuntimes.Controls.ListBoxItemRuntime.ListBoxItemCategory.Highlighted;
                    if (interpolationValue < 1)
                    {
                        this.ListBoxItemInstance.Parent = this.GetGraphicalUiElementByName("InnerPanelInstance") ?? this;
                    }
                    if (interpolationValue < 1)
                    {
                        this.VerticalScrollBarInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                    }
                    if (interpolationValue < 1)
                    {
                        this.VerticalScrollBarInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                    }
                    if (interpolationValue < 1)
                    {
                        this.VerticalScrollBarInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.VerticalScrollBarInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    break;
            }
            switch(secondState)
            {
                case  VariableState.Default:
                    setBackgroundCurrentColorCategoryStateSecondValue = true;
                    BackgroundCurrentColorCategoryStateSecondValue = global::TestProject.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                    setBackgroundHeightSecondValue = true;
                    BackgroundHeightSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.Background.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToParent;
                    }
                    setBackgroundCurrentStyleCategoryStateSecondValue = true;
                    BackgroundCurrentStyleCategoryStateSecondValue = global::TestProject.GumRuntimes.NineSliceRuntime.StyleCategory.Bordered;
                    setBackgroundWidthSecondValue = true;
                    BackgroundWidthSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.Background.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToParent;
                    }
                    setBackgroundXSecondValue = true;
                    BackgroundXSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.Background.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Background.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setBackgroundYSecondValue = true;
                    BackgroundYSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.Background.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Background.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.ClipContainerInstance.ClipsChildren = true;
                    }
                    setClipContainerInstanceHeightSecondValue = true;
                    ClipContainerInstanceHeightSecondValue = -4f;
                    if (interpolationValue >= 1)
                    {
                        this.ClipContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToParent;
                    }
                    setClipContainerInstanceWidthSecondValue = true;
                    ClipContainerInstanceWidthSecondValue = -27f;
                    if (interpolationValue >= 1)
                    {
                        this.ClipContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToParent;
                    }
                    setClipContainerInstanceXSecondValue = true;
                    ClipContainerInstanceXSecondValue = 2f;
                    setClipContainerInstanceYSecondValue = true;
                    ClipContainerInstanceYSecondValue = 2f;
                    if (interpolationValue >= 1)
                    {
                        this.ClipContainerInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.ClipContainerInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                    }
                    setInnerPanelInstanceHeightSecondValue = true;
                    InnerPanelInstanceHeightSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.InnerPanelInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.InnerPanelInstance.Parent = this.GetGraphicalUiElementByName("ClipContainerInstance") ?? this;
                    }
                    setInnerPanelInstanceWidthSecondValue = true;
                    InnerPanelInstanceWidthSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.InnerPanelInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToParent;
                    }
                    setListBoxItemInstanceCurrentListBoxItemCategoryStateSecondValue = true;
                    ListBoxItemInstanceCurrentListBoxItemCategoryStateSecondValue = global::TestProject.GumRuntimes.Controls.ListBoxItemRuntime.ListBoxItemCategory.Highlighted;
                    if (interpolationValue >= 1)
                    {
                        this.ListBoxItemInstance.Parent = this.GetGraphicalUiElementByName("InnerPanelInstance") ?? this;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.VerticalScrollBarInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.VerticalScrollBarInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.VerticalScrollBarInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.VerticalScrollBarInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    break;
            }
            var wasSuppressed = mIsLayoutSuspended;
            var shouldSuspend = wasSuppressed == false;
            var suspendRecursively = true;
            if (shouldSuspend)
            {
                SuspendLayout(suspendRecursively);
            }
            if (setBackgroundCurrentColorCategoryStateFirstValue && setBackgroundCurrentColorCategoryStateSecondValue)
            {
                Background.InterpolateBetween(BackgroundCurrentColorCategoryStateFirstValue, BackgroundCurrentColorCategoryStateSecondValue, interpolationValue);
            }
            if (setBackgroundHeightFirstValue && setBackgroundHeightSecondValue)
            {
                Background.Height = BackgroundHeightFirstValue * (1 - interpolationValue) + BackgroundHeightSecondValue * interpolationValue;
            }
            if (setBackgroundCurrentStyleCategoryStateFirstValue && setBackgroundCurrentStyleCategoryStateSecondValue)
            {
                Background.InterpolateBetween(BackgroundCurrentStyleCategoryStateFirstValue, BackgroundCurrentStyleCategoryStateSecondValue, interpolationValue);
            }
            if (setBackgroundWidthFirstValue && setBackgroundWidthSecondValue)
            {
                Background.Width = BackgroundWidthFirstValue * (1 - interpolationValue) + BackgroundWidthSecondValue * interpolationValue;
            }
            if (setBackgroundXFirstValue && setBackgroundXSecondValue)
            {
                Background.X = BackgroundXFirstValue * (1 - interpolationValue) + BackgroundXSecondValue * interpolationValue;
            }
            if (setBackgroundYFirstValue && setBackgroundYSecondValue)
            {
                Background.Y = BackgroundYFirstValue * (1 - interpolationValue) + BackgroundYSecondValue * interpolationValue;
            }
            if (setClipContainerInstanceHeightFirstValue && setClipContainerInstanceHeightSecondValue)
            {
                ClipContainerInstance.Height = ClipContainerInstanceHeightFirstValue * (1 - interpolationValue) + ClipContainerInstanceHeightSecondValue * interpolationValue;
            }
            if (setClipContainerInstanceWidthFirstValue && setClipContainerInstanceWidthSecondValue)
            {
                ClipContainerInstance.Width = ClipContainerInstanceWidthFirstValue * (1 - interpolationValue) + ClipContainerInstanceWidthSecondValue * interpolationValue;
            }
            if (setClipContainerInstanceXFirstValue && setClipContainerInstanceXSecondValue)
            {
                ClipContainerInstance.X = ClipContainerInstanceXFirstValue * (1 - interpolationValue) + ClipContainerInstanceXSecondValue * interpolationValue;
            }
            if (setClipContainerInstanceYFirstValue && setClipContainerInstanceYSecondValue)
            {
                ClipContainerInstance.Y = ClipContainerInstanceYFirstValue * (1 - interpolationValue) + ClipContainerInstanceYSecondValue * interpolationValue;
            }
            if (setInnerPanelInstanceHeightFirstValue && setInnerPanelInstanceHeightSecondValue)
            {
                InnerPanelInstance.Height = InnerPanelInstanceHeightFirstValue * (1 - interpolationValue) + InnerPanelInstanceHeightSecondValue * interpolationValue;
            }
            if (setInnerPanelInstanceWidthFirstValue && setInnerPanelInstanceWidthSecondValue)
            {
                InnerPanelInstance.Width = InnerPanelInstanceWidthFirstValue * (1 - interpolationValue) + InnerPanelInstanceWidthSecondValue * interpolationValue;
            }
            if (setListBoxItemInstanceCurrentListBoxItemCategoryStateFirstValue && setListBoxItemInstanceCurrentListBoxItemCategoryStateSecondValue)
            {
                ListBoxItemInstance.InterpolateBetween(ListBoxItemInstanceCurrentListBoxItemCategoryStateFirstValue, ListBoxItemInstanceCurrentListBoxItemCategoryStateSecondValue, interpolationValue);
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
        public void InterpolateBetween (ScrollBarVisibility firstState, ScrollBarVisibility secondState, float interpolationValue) 
        {
            #if DEBUG
            if (float.IsNaN(interpolationValue))
            {
                throw new System.Exception("interpolationValue cannot be NaN");
            }
            #endif
            switch(firstState)
            {
                case  ScrollBarVisibility.NoScrollBar:
                    if (interpolationValue < 1)
                    {
                        this.VerticalScrollBarInstance.Visible = false;
                    }
                    break;
                case  ScrollBarVisibility.VerticalScrollVisible:
                    if (interpolationValue < 1)
                    {
                        this.VerticalScrollBarInstance.Visible = true;
                    }
                    break;
            }
            switch(secondState)
            {
                case  ScrollBarVisibility.NoScrollBar:
                    if (interpolationValue >= 1)
                    {
                        this.VerticalScrollBarInstance.Visible = false;
                    }
                    break;
                case  ScrollBarVisibility.VerticalScrollVisible:
                    if (interpolationValue >= 1)
                    {
                        this.VerticalScrollBarInstance.Visible = true;
                    }
                    break;
            }
            var wasSuppressed = mIsLayoutSuspended;
            var shouldSuspend = wasSuppressed == false;
            var suspendRecursively = true;
            // all values assigned in this state do not require recursive updates:
            suspendRecursively = false;
            var isSafeToInterpolateWithoutSuppression = true;
            isSafeToInterpolateWithoutSuppression &= VerticalScrollBarInstance.Parent as Gum.Wireframe.GraphicalUiElement == null && VerticalScrollBarInstance.XUnits == Gum.Converters.GeneralUnitType.PixelsFromSmall && VerticalScrollBarInstance.XOrigin == RenderingLibrary.Graphics.HorizontalAlignment.Left;
            if(isSafeToInterpolateWithoutSuppression) shouldSuspend = false;
            if (shouldSuspend)
            {
                SuspendLayout(suspendRecursively);
            }
            if (interpolationValue < 1)
            {
                mCurrentScrollBarVisibilityState = firstState;
            }
            else
            {
                mCurrentScrollBarVisibilityState = secondState;
            }
            if (shouldSuspend)
            {
                ResumeLayout(suspendRecursively);
            }
        }
        #endregion
        #region State Interpolate To
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (global::TestProject.GumRuntimes.Controls.ScrollViewerRuntime.VariableState fromState,global::TestProject.GumRuntimes.Controls.ScrollViewerRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (global::TestProject.GumRuntimes.Controls.ScrollViewerRuntime.ScrollBarVisibility fromState,global::TestProject.GumRuntimes.Controls.ScrollViewerRuntime.ScrollBarVisibility toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (ScrollBarVisibility toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
        {
            Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
            Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "ScrollBarVisibility").States.First(item => item.Name == toState.ToString());
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
            tweener.Ended += ()=> this.CurrentScrollBarVisibilityState = toState;
            tweener.Start();
            StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
            return tweener;
        }
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (ScrollBarVisibility toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
            tweener.Ended += ()=> this.CurrentScrollBarVisibilityState = toState;
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
            VerticalScrollBarInstance.StopAnimations();
            ListBoxItemInstance.StopAnimations();
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
                        Name = "Background.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = Background.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.Height",
                        Type = "float",
                        Value = Background.Height
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.HeightUnits",
                        Type = "DimensionUnitType",
                        Value = Background.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.StyleCategoryState",
                        Type = "StyleCategory",
                        Value = Background.CurrentStyleCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.Width",
                        Type = "float",
                        Value = Background.Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.WidthUnits",
                        Type = "DimensionUnitType",
                        Value = Background.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.X",
                        Type = "float",
                        Value = Background.X
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.XOrigin",
                        Type = "HorizontalAlignment",
                        Value = Background.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.XUnits",
                        Type = "PositionUnitType",
                        Value = Background.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.Y",
                        Type = "float",
                        Value = Background.Y
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.YOrigin",
                        Type = "VerticalAlignment",
                        Value = Background.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.YUnits",
                        Type = "PositionUnitType",
                        Value = Background.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "VerticalScrollBarInstance.XOrigin",
                        Type = "HorizontalAlignment",
                        Value = VerticalScrollBarInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "VerticalScrollBarInstance.XUnits",
                        Type = "PositionUnitType",
                        Value = VerticalScrollBarInstance.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "VerticalScrollBarInstance.YOrigin",
                        Type = "VerticalAlignment",
                        Value = VerticalScrollBarInstance.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "VerticalScrollBarInstance.YUnits",
                        Type = "PositionUnitType",
                        Value = VerticalScrollBarInstance.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ClipContainerInstance.ClipsChildren",
                        Type = "bool",
                        Value = ClipContainerInstance.ClipsChildren
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ClipContainerInstance.Height",
                        Type = "float",
                        Value = ClipContainerInstance.Height
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ClipContainerInstance.HeightUnits",
                        Type = "DimensionUnitType",
                        Value = ClipContainerInstance.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ClipContainerInstance.Width",
                        Type = "float",
                        Value = ClipContainerInstance.Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ClipContainerInstance.WidthUnits",
                        Type = "DimensionUnitType",
                        Value = ClipContainerInstance.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ClipContainerInstance.X",
                        Type = "float",
                        Value = ClipContainerInstance.X
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ClipContainerInstance.Y",
                        Type = "float",
                        Value = ClipContainerInstance.Y
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ClipContainerInstance.YOrigin",
                        Type = "VerticalAlignment",
                        Value = ClipContainerInstance.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ClipContainerInstance.YUnits",
                        Type = "PositionUnitType",
                        Value = ClipContainerInstance.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.Height",
                        Type = "float",
                        Value = InnerPanelInstance.Height
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.HeightUnits",
                        Type = "DimensionUnitType",
                        Value = InnerPanelInstance.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.Parent",
                        Type = "string",
                        Value = InnerPanelInstance.Parent
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.Width",
                        Type = "float",
                        Value = InnerPanelInstance.Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.WidthUnits",
                        Type = "DimensionUnitType",
                        Value = InnerPanelInstance.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ListBoxItemInstance.ListBoxItemCategoryState",
                        Type = "ListBoxItemCategory",
                        Value = ListBoxItemInstance.CurrentListBoxItemCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ListBoxItemInstance.Parent",
                        Type = "string",
                        Value = ListBoxItemInstance.Parent
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
                        Name = "Background.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = Background.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.Height",
                        Type = "float",
                        Value = Background.Height + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.HeightUnits",
                        Type = "DimensionUnitType",
                        Value = Background.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.StyleCategoryState",
                        Type = "StyleCategory",
                        Value = Background.CurrentStyleCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.Width",
                        Type = "float",
                        Value = Background.Width + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.WidthUnits",
                        Type = "DimensionUnitType",
                        Value = Background.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.X",
                        Type = "float",
                        Value = Background.X + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.XOrigin",
                        Type = "HorizontalAlignment",
                        Value = Background.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.XUnits",
                        Type = "PositionUnitType",
                        Value = Background.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.Y",
                        Type = "float",
                        Value = Background.Y + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.YOrigin",
                        Type = "VerticalAlignment",
                        Value = Background.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.YUnits",
                        Type = "PositionUnitType",
                        Value = Background.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "VerticalScrollBarInstance.XOrigin",
                        Type = "HorizontalAlignment",
                        Value = VerticalScrollBarInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "VerticalScrollBarInstance.XUnits",
                        Type = "PositionUnitType",
                        Value = VerticalScrollBarInstance.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "VerticalScrollBarInstance.YOrigin",
                        Type = "VerticalAlignment",
                        Value = VerticalScrollBarInstance.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "VerticalScrollBarInstance.YUnits",
                        Type = "PositionUnitType",
                        Value = VerticalScrollBarInstance.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ClipContainerInstance.ClipsChildren",
                        Type = "bool",
                        Value = ClipContainerInstance.ClipsChildren
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ClipContainerInstance.Height",
                        Type = "float",
                        Value = ClipContainerInstance.Height + -4f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ClipContainerInstance.HeightUnits",
                        Type = "DimensionUnitType",
                        Value = ClipContainerInstance.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ClipContainerInstance.Width",
                        Type = "float",
                        Value = ClipContainerInstance.Width + -27f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ClipContainerInstance.WidthUnits",
                        Type = "DimensionUnitType",
                        Value = ClipContainerInstance.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ClipContainerInstance.X",
                        Type = "float",
                        Value = ClipContainerInstance.X + 2f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ClipContainerInstance.Y",
                        Type = "float",
                        Value = ClipContainerInstance.Y + 2f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ClipContainerInstance.YOrigin",
                        Type = "VerticalAlignment",
                        Value = ClipContainerInstance.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ClipContainerInstance.YUnits",
                        Type = "PositionUnitType",
                        Value = ClipContainerInstance.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.Height",
                        Type = "float",
                        Value = InnerPanelInstance.Height + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.HeightUnits",
                        Type = "DimensionUnitType",
                        Value = InnerPanelInstance.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.Parent",
                        Type = "string",
                        Value = InnerPanelInstance.Parent
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.Width",
                        Type = "float",
                        Value = InnerPanelInstance.Width + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.WidthUnits",
                        Type = "DimensionUnitType",
                        Value = InnerPanelInstance.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ListBoxItemInstance.ListBoxItemCategoryState",
                        Type = "ListBoxItemCategory",
                        Value = ListBoxItemInstance.CurrentListBoxItemCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ListBoxItemInstance.Parent",
                        Type = "string",
                        Value = ListBoxItemInstance.Parent
                    }
                    );
                    break;
            }
            return newState;
        }
        private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (ScrollBarVisibility state) 
        {
            Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
            switch(state)
            {
                case  ScrollBarVisibility.NoScrollBar:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "VerticalScrollBarInstance.Visible",
                        Type = "bool",
                        Value = VerticalScrollBarInstance.Visible
                    }
                    );
                    break;
                case  ScrollBarVisibility.VerticalScrollVisible:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "VerticalScrollBarInstance.Visible",
                        Type = "bool",
                        Value = VerticalScrollBarInstance.Visible
                    }
                    );
                    break;
            }
            return newState;
        }
        private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (ScrollBarVisibility state) 
        {
            Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
            switch(state)
            {
                case  ScrollBarVisibility.NoScrollBar:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "VerticalScrollBarInstance.Visible",
                        Type = "bool",
                        Value = VerticalScrollBarInstance.Visible
                    }
                    );
                    break;
                case  ScrollBarVisibility.VerticalScrollVisible:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "VerticalScrollBarInstance.Visible",
                        Type = "bool",
                        Value = VerticalScrollBarInstance.Visible
                    }
                    );
                    break;
            }
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
                else if (category.Name == "ScrollBarVisibility")
                {
                    if(state.Name == "NoScrollBar") this.mCurrentScrollBarVisibilityState = ScrollBarVisibility.NoScrollBar;
                    if(state.Name == "VerticalScrollVisible") this.mCurrentScrollBarVisibilityState = ScrollBarVisibility.VerticalScrollVisible;
                }
            }
            base.ApplyState(state);
        }
        global::TestProject.GumRuntimes.IScrollViewerBehavior.ScrollBarVisibility global::TestProject.GumRuntimes.IScrollViewerBehavior.CurrentScrollBarVisibilityState
        {
            set
            {
                switch(value)
                {
                    case  global::TestProject.GumRuntimes.IScrollViewerBehavior.ScrollBarVisibility.NoScrollBar:
                        this.CurrentScrollBarVisibilityState = ScrollBarVisibility.NoScrollBar;
                        break;
                    case  global::TestProject.GumRuntimes.IScrollViewerBehavior.ScrollBarVisibility.VerticalScrollVisible:
                        this.CurrentScrollBarVisibilityState = ScrollBarVisibility.VerticalScrollVisible;
                        break;
                }
            }
        }
        private bool tryCreateFormsObject;
        public global::TestProject.GumRuntimes.NineSliceRuntime Background { get; set; }
        public global::TestProject.GumRuntimes.Controls.ScrollBarRuntime VerticalScrollBarInstance { get; set; }
        public global::TestProject.GumRuntimes.ContainerRuntime ClipContainerInstance { get; set; }
        public global::TestProject.GumRuntimes.ContainerRuntime InnerPanelInstance { get; set; }
        public global::TestProject.GumRuntimes.Controls.ListBoxItemRuntime ListBoxItemInstance { get; set; }
        public event FlatRedBall.Gui.WindowEvent VerticalScrollBarInstanceClick;
        public event FlatRedBall.Gui.WindowEvent ListBoxItemInstanceClick;
        public ScrollViewerRuntime () 
        	: this(true, true)
        {
        }
        public ScrollViewerRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
        	: base(false, false)
        {
            this.tryCreateFormsObject = tryCreateFormsObject;
            if (fullInstantiation)
            {
                Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "Controls/ScrollViewer");
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
            Background = this.GetGraphicalUiElementByName("Background") as global::TestProject.GumRuntimes.NineSliceRuntime;
            VerticalScrollBarInstance = this.GetGraphicalUiElementByName("VerticalScrollBarInstance") as global::TestProject.GumRuntimes.Controls.ScrollBarRuntime;
            ClipContainerInstance = this.GetGraphicalUiElementByName("ClipContainerInstance") as global::TestProject.GumRuntimes.ContainerRuntime;
            InnerPanelInstance = this.GetGraphicalUiElementByName("InnerPanelInstance") as global::TestProject.GumRuntimes.ContainerRuntime;
            ListBoxItemInstance = this.GetGraphicalUiElementByName("ListBoxItemInstance") as global::TestProject.GumRuntimes.Controls.ListBoxItemRuntime;
            VerticalScrollBarInstance.Click += (unused) => VerticalScrollBarInstanceClick?.Invoke(this);
            ListBoxItemInstance.Click += (unused) => ListBoxItemInstanceClick?.Invoke(this);
            if (tryCreateFormsObject)
            {
                FormsControlAsObject = new FlatRedBall.Forms.Controls.ScrollViewer(this);
            }
        }
        private void CallCustomInitialize () 
        {
            CustomInitialize();
        }
        partial void CustomInitialize();
        public FlatRedBall.Forms.Controls.ScrollViewer FormsControl {get => (FlatRedBall.Forms.Controls.ScrollViewer) FormsControlAsObject;}
        public override void RemoveFromManagers () 
        {
            StopAnimations();
            base.RemoveFromManagers();
        }
    }
}

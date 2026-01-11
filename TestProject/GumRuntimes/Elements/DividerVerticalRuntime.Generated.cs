using System.Linq;
namespace TestProject.GumRuntimes.Elements
{
    public partial class DividerVerticalRuntime : global::TestProject.GumRuntimes.ContainerRuntime
    {
        #region State Enums
        public new  enum VariableState
        {
            Default
        }
        #endregion
        #region State Fields
        VariableState mCurrentVariableState;
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
                        AccentTop.CurrentColorCategoryState = global::TestProject.GumRuntimes.SpriteRuntime.ColorCategory.Gray;
                        Line.CurrentColorCategoryState = global::TestProject.GumRuntimes.SpriteRuntime.ColorCategory.Gray;
                        AccentRight.CurrentColorCategoryState = global::TestProject.GumRuntimes.SpriteRuntime.ColorCategory.Gray;
                        Height = 128f;
                        Width = 0f;
                        WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        AccentTop.Height = 100f;
                        AccentTop.HeightUnits = Gum.DataTypes.DimensionUnitType.PercentageOfSourceFile;
                        SetProperty("AccentTop.SourceFile", "UISpriteSheet.png");
                        AccentTop.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        AccentTop.TextureHeight = 3;
                        AccentTop.TextureLeft = 281;
                        AccentTop.TextureTop = 0;
                        AccentTop.TextureWidth = 3;
                        AccentTop.Width = 100f;
                        AccentTop.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        AccentTop.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        Line.Height = -8f;
                        Line.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToParent;
                        SetProperty("Line.SourceFile", "UISpriteSheet.png");
                        Line.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        Line.TextureHeight = 1;
                        Line.TextureLeft = 281;
                        Line.TextureTop = 1;
                        Line.TextureWidth = 3;
                        Line.Width = 1f;
                        Line.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        Line.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        Line.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        Line.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        Line.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        AccentRight.Height = 100f;
                        AccentRight.HeightUnits = Gum.DataTypes.DimensionUnitType.PercentageOfSourceFile;
                        SetProperty("AccentRight.SourceFile", "UISpriteSheet.png");
                        AccentRight.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        AccentRight.TextureHeight = 3;
                        AccentRight.TextureLeft = 281;
                        AccentRight.TextureTop = 0;
                        AccentRight.TextureWidth = 3;
                        AccentRight.Width = 100f;
                        AccentRight.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        AccentRight.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        AccentRight.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        AccentRight.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        break;
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
            bool setAccentRightCurrentColorCategoryStateFirstValue = false;
            bool setAccentRightCurrentColorCategoryStateSecondValue = false;
            global::TestProject.GumRuntimes.SpriteRuntime.ColorCategory AccentRightCurrentColorCategoryStateFirstValue= global::TestProject.GumRuntimes.SpriteRuntime.ColorCategory.Black;
            global::TestProject.GumRuntimes.SpriteRuntime.ColorCategory AccentRightCurrentColorCategoryStateSecondValue= global::TestProject.GumRuntimes.SpriteRuntime.ColorCategory.Black;
            bool setAccentRightHeightFirstValue = false;
            bool setAccentRightHeightSecondValue = false;
            float AccentRightHeightFirstValue= 0;
            float AccentRightHeightSecondValue= 0;
            bool setAccentRightTextureHeightFirstValue = false;
            bool setAccentRightTextureHeightSecondValue = false;
            int AccentRightTextureHeightFirstValue= 0;
            int AccentRightTextureHeightSecondValue= 0;
            bool setAccentRightTextureLeftFirstValue = false;
            bool setAccentRightTextureLeftSecondValue = false;
            int AccentRightTextureLeftFirstValue= 0;
            int AccentRightTextureLeftSecondValue= 0;
            bool setAccentRightTextureTopFirstValue = false;
            bool setAccentRightTextureTopSecondValue = false;
            int AccentRightTextureTopFirstValue= 0;
            int AccentRightTextureTopSecondValue= 0;
            bool setAccentRightTextureWidthFirstValue = false;
            bool setAccentRightTextureWidthSecondValue = false;
            int AccentRightTextureWidthFirstValue= 0;
            int AccentRightTextureWidthSecondValue= 0;
            bool setAccentRightWidthFirstValue = false;
            bool setAccentRightWidthSecondValue = false;
            float AccentRightWidthFirstValue= 0;
            float AccentRightWidthSecondValue= 0;
            bool setAccentTopCurrentColorCategoryStateFirstValue = false;
            bool setAccentTopCurrentColorCategoryStateSecondValue = false;
            global::TestProject.GumRuntimes.SpriteRuntime.ColorCategory AccentTopCurrentColorCategoryStateFirstValue= global::TestProject.GumRuntimes.SpriteRuntime.ColorCategory.Black;
            global::TestProject.GumRuntimes.SpriteRuntime.ColorCategory AccentTopCurrentColorCategoryStateSecondValue= global::TestProject.GumRuntimes.SpriteRuntime.ColorCategory.Black;
            bool setAccentTopHeightFirstValue = false;
            bool setAccentTopHeightSecondValue = false;
            float AccentTopHeightFirstValue= 0;
            float AccentTopHeightSecondValue= 0;
            bool setAccentTopTextureHeightFirstValue = false;
            bool setAccentTopTextureHeightSecondValue = false;
            int AccentTopTextureHeightFirstValue= 0;
            int AccentTopTextureHeightSecondValue= 0;
            bool setAccentTopTextureLeftFirstValue = false;
            bool setAccentTopTextureLeftSecondValue = false;
            int AccentTopTextureLeftFirstValue= 0;
            int AccentTopTextureLeftSecondValue= 0;
            bool setAccentTopTextureTopFirstValue = false;
            bool setAccentTopTextureTopSecondValue = false;
            int AccentTopTextureTopFirstValue= 0;
            int AccentTopTextureTopSecondValue= 0;
            bool setAccentTopTextureWidthFirstValue = false;
            bool setAccentTopTextureWidthSecondValue = false;
            int AccentTopTextureWidthFirstValue= 0;
            int AccentTopTextureWidthSecondValue= 0;
            bool setAccentTopWidthFirstValue = false;
            bool setAccentTopWidthSecondValue = false;
            float AccentTopWidthFirstValue= 0;
            float AccentTopWidthSecondValue= 0;
            bool setHeightFirstValue = false;
            bool setHeightSecondValue = false;
            float HeightFirstValue= 0;
            float HeightSecondValue= 0;
            bool setLineCurrentColorCategoryStateFirstValue = false;
            bool setLineCurrentColorCategoryStateSecondValue = false;
            global::TestProject.GumRuntimes.SpriteRuntime.ColorCategory LineCurrentColorCategoryStateFirstValue= global::TestProject.GumRuntimes.SpriteRuntime.ColorCategory.Black;
            global::TestProject.GumRuntimes.SpriteRuntime.ColorCategory LineCurrentColorCategoryStateSecondValue= global::TestProject.GumRuntimes.SpriteRuntime.ColorCategory.Black;
            bool setLineHeightFirstValue = false;
            bool setLineHeightSecondValue = false;
            float LineHeightFirstValue= 0;
            float LineHeightSecondValue= 0;
            bool setLineTextureHeightFirstValue = false;
            bool setLineTextureHeightSecondValue = false;
            int LineTextureHeightFirstValue= 0;
            int LineTextureHeightSecondValue= 0;
            bool setLineTextureLeftFirstValue = false;
            bool setLineTextureLeftSecondValue = false;
            int LineTextureLeftFirstValue= 0;
            int LineTextureLeftSecondValue= 0;
            bool setLineTextureTopFirstValue = false;
            bool setLineTextureTopSecondValue = false;
            int LineTextureTopFirstValue= 0;
            int LineTextureTopSecondValue= 0;
            bool setLineTextureWidthFirstValue = false;
            bool setLineTextureWidthSecondValue = false;
            int LineTextureWidthFirstValue= 0;
            int LineTextureWidthSecondValue= 0;
            bool setLineWidthFirstValue = false;
            bool setLineWidthSecondValue = false;
            float LineWidthFirstValue= 0;
            float LineWidthSecondValue= 0;
            bool setWidthFirstValue = false;
            bool setWidthSecondValue = false;
            float WidthFirstValue= 0;
            float WidthSecondValue= 0;
            switch(firstState)
            {
                case  VariableState.Default:
                    setAccentRightCurrentColorCategoryStateFirstValue = true;
                    AccentRightCurrentColorCategoryStateFirstValue = global::TestProject.GumRuntimes.SpriteRuntime.ColorCategory.Gray;
                    setAccentRightHeightFirstValue = true;
                    AccentRightHeightFirstValue = 100f;
                    if (interpolationValue < 1)
                    {
                        this.AccentRight.HeightUnits = Gum.DataTypes.DimensionUnitType.PercentageOfSourceFile;
                    }
                    if (interpolationValue < 1)
                    {
                        SetProperty("AccentRight.SourceFile", "UISpriteSheet.png");
                    }
                    if (interpolationValue < 1)
                    {
                        this.AccentRight.TextureAddress = Gum.Managers.TextureAddress.Custom;
                    }
                    setAccentRightTextureHeightFirstValue = true;
                    AccentRightTextureHeightFirstValue = 3;
                    setAccentRightTextureLeftFirstValue = true;
                    AccentRightTextureLeftFirstValue = 281;
                    setAccentRightTextureTopFirstValue = true;
                    AccentRightTextureTopFirstValue = 0;
                    setAccentRightTextureWidthFirstValue = true;
                    AccentRightTextureWidthFirstValue = 3;
                    setAccentRightWidthFirstValue = true;
                    AccentRightWidthFirstValue = 100f;
                    if (interpolationValue < 1)
                    {
                        this.AccentRight.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.AccentRight.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    if (interpolationValue < 1)
                    {
                        this.AccentRight.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                    }
                    if (interpolationValue < 1)
                    {
                        this.AccentRight.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                    }
                    setAccentTopCurrentColorCategoryStateFirstValue = true;
                    AccentTopCurrentColorCategoryStateFirstValue = global::TestProject.GumRuntimes.SpriteRuntime.ColorCategory.Gray;
                    setAccentTopHeightFirstValue = true;
                    AccentTopHeightFirstValue = 100f;
                    if (interpolationValue < 1)
                    {
                        this.AccentTop.HeightUnits = Gum.DataTypes.DimensionUnitType.PercentageOfSourceFile;
                    }
                    if (interpolationValue < 1)
                    {
                        SetProperty("AccentTop.SourceFile", "UISpriteSheet.png");
                    }
                    if (interpolationValue < 1)
                    {
                        this.AccentTop.TextureAddress = Gum.Managers.TextureAddress.Custom;
                    }
                    setAccentTopTextureHeightFirstValue = true;
                    AccentTopTextureHeightFirstValue = 3;
                    setAccentTopTextureLeftFirstValue = true;
                    AccentTopTextureLeftFirstValue = 281;
                    setAccentTopTextureTopFirstValue = true;
                    AccentTopTextureTopFirstValue = 0;
                    setAccentTopTextureWidthFirstValue = true;
                    AccentTopTextureWidthFirstValue = 3;
                    setAccentTopWidthFirstValue = true;
                    AccentTopWidthFirstValue = 100f;
                    if (interpolationValue < 1)
                    {
                        this.AccentTop.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.AccentTop.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setHeightFirstValue = true;
                    HeightFirstValue = 128f;
                    setLineCurrentColorCategoryStateFirstValue = true;
                    LineCurrentColorCategoryStateFirstValue = global::TestProject.GumRuntimes.SpriteRuntime.ColorCategory.Gray;
                    setLineHeightFirstValue = true;
                    LineHeightFirstValue = -8f;
                    if (interpolationValue < 1)
                    {
                        this.Line.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToParent;
                    }
                    if (interpolationValue < 1)
                    {
                        SetProperty("Line.SourceFile", "UISpriteSheet.png");
                    }
                    if (interpolationValue < 1)
                    {
                        this.Line.TextureAddress = Gum.Managers.TextureAddress.Custom;
                    }
                    setLineTextureHeightFirstValue = true;
                    LineTextureHeightFirstValue = 1;
                    setLineTextureLeftFirstValue = true;
                    LineTextureLeftFirstValue = 281;
                    setLineTextureTopFirstValue = true;
                    LineTextureTopFirstValue = 1;
                    setLineTextureWidthFirstValue = true;
                    LineTextureWidthFirstValue = 3;
                    setLineWidthFirstValue = true;
                    LineWidthFirstValue = 1f;
                    if (interpolationValue < 1)
                    {
                        this.Line.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Line.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Line.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Line.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Line.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setWidthFirstValue = true;
                    WidthFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                    }
                    break;
            }
            switch(secondState)
            {
                case  VariableState.Default:
                    setAccentRightCurrentColorCategoryStateSecondValue = true;
                    AccentRightCurrentColorCategoryStateSecondValue = global::TestProject.GumRuntimes.SpriteRuntime.ColorCategory.Gray;
                    setAccentRightHeightSecondValue = true;
                    AccentRightHeightSecondValue = 100f;
                    if (interpolationValue >= 1)
                    {
                        this.AccentRight.HeightUnits = Gum.DataTypes.DimensionUnitType.PercentageOfSourceFile;
                    }
                    if (interpolationValue >= 1)
                    {
                        SetProperty("AccentRight.SourceFile", "UISpriteSheet.png");
                    }
                    if (interpolationValue >= 1)
                    {
                        this.AccentRight.TextureAddress = Gum.Managers.TextureAddress.Custom;
                    }
                    setAccentRightTextureHeightSecondValue = true;
                    AccentRightTextureHeightSecondValue = 3;
                    setAccentRightTextureLeftSecondValue = true;
                    AccentRightTextureLeftSecondValue = 281;
                    setAccentRightTextureTopSecondValue = true;
                    AccentRightTextureTopSecondValue = 0;
                    setAccentRightTextureWidthSecondValue = true;
                    AccentRightTextureWidthSecondValue = 3;
                    setAccentRightWidthSecondValue = true;
                    AccentRightWidthSecondValue = 100f;
                    if (interpolationValue >= 1)
                    {
                        this.AccentRight.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.AccentRight.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.AccentRight.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.AccentRight.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                    }
                    setAccentTopCurrentColorCategoryStateSecondValue = true;
                    AccentTopCurrentColorCategoryStateSecondValue = global::TestProject.GumRuntimes.SpriteRuntime.ColorCategory.Gray;
                    setAccentTopHeightSecondValue = true;
                    AccentTopHeightSecondValue = 100f;
                    if (interpolationValue >= 1)
                    {
                        this.AccentTop.HeightUnits = Gum.DataTypes.DimensionUnitType.PercentageOfSourceFile;
                    }
                    if (interpolationValue >= 1)
                    {
                        SetProperty("AccentTop.SourceFile", "UISpriteSheet.png");
                    }
                    if (interpolationValue >= 1)
                    {
                        this.AccentTop.TextureAddress = Gum.Managers.TextureAddress.Custom;
                    }
                    setAccentTopTextureHeightSecondValue = true;
                    AccentTopTextureHeightSecondValue = 3;
                    setAccentTopTextureLeftSecondValue = true;
                    AccentTopTextureLeftSecondValue = 281;
                    setAccentTopTextureTopSecondValue = true;
                    AccentTopTextureTopSecondValue = 0;
                    setAccentTopTextureWidthSecondValue = true;
                    AccentTopTextureWidthSecondValue = 3;
                    setAccentTopWidthSecondValue = true;
                    AccentTopWidthSecondValue = 100f;
                    if (interpolationValue >= 1)
                    {
                        this.AccentTop.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.AccentTop.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setHeightSecondValue = true;
                    HeightSecondValue = 128f;
                    setLineCurrentColorCategoryStateSecondValue = true;
                    LineCurrentColorCategoryStateSecondValue = global::TestProject.GumRuntimes.SpriteRuntime.ColorCategory.Gray;
                    setLineHeightSecondValue = true;
                    LineHeightSecondValue = -8f;
                    if (interpolationValue >= 1)
                    {
                        this.Line.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToParent;
                    }
                    if (interpolationValue >= 1)
                    {
                        SetProperty("Line.SourceFile", "UISpriteSheet.png");
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Line.TextureAddress = Gum.Managers.TextureAddress.Custom;
                    }
                    setLineTextureHeightSecondValue = true;
                    LineTextureHeightSecondValue = 1;
                    setLineTextureLeftSecondValue = true;
                    LineTextureLeftSecondValue = 281;
                    setLineTextureTopSecondValue = true;
                    LineTextureTopSecondValue = 1;
                    setLineTextureWidthSecondValue = true;
                    LineTextureWidthSecondValue = 3;
                    setLineWidthSecondValue = true;
                    LineWidthSecondValue = 1f;
                    if (interpolationValue >= 1)
                    {
                        this.Line.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Line.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Line.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Line.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Line.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setWidthSecondValue = true;
                    WidthSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
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
            if (setAccentRightCurrentColorCategoryStateFirstValue && setAccentRightCurrentColorCategoryStateSecondValue)
            {
                AccentRight.InterpolateBetween(AccentRightCurrentColorCategoryStateFirstValue, AccentRightCurrentColorCategoryStateSecondValue, interpolationValue);
            }
            if (setAccentRightHeightFirstValue && setAccentRightHeightSecondValue)
            {
                AccentRight.Height = AccentRightHeightFirstValue * (1 - interpolationValue) + AccentRightHeightSecondValue * interpolationValue;
            }
            if (setAccentRightTextureHeightFirstValue && setAccentRightTextureHeightSecondValue)
            {
                AccentRight.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(AccentRightTextureHeightFirstValue* (1 - interpolationValue) + AccentRightTextureHeightSecondValue * interpolationValue);
            }
            if (setAccentRightTextureLeftFirstValue && setAccentRightTextureLeftSecondValue)
            {
                AccentRight.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(AccentRightTextureLeftFirstValue* (1 - interpolationValue) + AccentRightTextureLeftSecondValue * interpolationValue);
            }
            if (setAccentRightTextureTopFirstValue && setAccentRightTextureTopSecondValue)
            {
                AccentRight.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(AccentRightTextureTopFirstValue* (1 - interpolationValue) + AccentRightTextureTopSecondValue * interpolationValue);
            }
            if (setAccentRightTextureWidthFirstValue && setAccentRightTextureWidthSecondValue)
            {
                AccentRight.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(AccentRightTextureWidthFirstValue* (1 - interpolationValue) + AccentRightTextureWidthSecondValue * interpolationValue);
            }
            if (setAccentRightWidthFirstValue && setAccentRightWidthSecondValue)
            {
                AccentRight.Width = AccentRightWidthFirstValue * (1 - interpolationValue) + AccentRightWidthSecondValue * interpolationValue;
            }
            if (setAccentTopCurrentColorCategoryStateFirstValue && setAccentTopCurrentColorCategoryStateSecondValue)
            {
                AccentTop.InterpolateBetween(AccentTopCurrentColorCategoryStateFirstValue, AccentTopCurrentColorCategoryStateSecondValue, interpolationValue);
            }
            if (setAccentTopHeightFirstValue && setAccentTopHeightSecondValue)
            {
                AccentTop.Height = AccentTopHeightFirstValue * (1 - interpolationValue) + AccentTopHeightSecondValue * interpolationValue;
            }
            if (setAccentTopTextureHeightFirstValue && setAccentTopTextureHeightSecondValue)
            {
                AccentTop.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(AccentTopTextureHeightFirstValue* (1 - interpolationValue) + AccentTopTextureHeightSecondValue * interpolationValue);
            }
            if (setAccentTopTextureLeftFirstValue && setAccentTopTextureLeftSecondValue)
            {
                AccentTop.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(AccentTopTextureLeftFirstValue* (1 - interpolationValue) + AccentTopTextureLeftSecondValue * interpolationValue);
            }
            if (setAccentTopTextureTopFirstValue && setAccentTopTextureTopSecondValue)
            {
                AccentTop.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(AccentTopTextureTopFirstValue* (1 - interpolationValue) + AccentTopTextureTopSecondValue * interpolationValue);
            }
            if (setAccentTopTextureWidthFirstValue && setAccentTopTextureWidthSecondValue)
            {
                AccentTop.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(AccentTopTextureWidthFirstValue* (1 - interpolationValue) + AccentTopTextureWidthSecondValue * interpolationValue);
            }
            if (setAccentTopWidthFirstValue && setAccentTopWidthSecondValue)
            {
                AccentTop.Width = AccentTopWidthFirstValue * (1 - interpolationValue) + AccentTopWidthSecondValue * interpolationValue;
            }
            if (setHeightFirstValue && setHeightSecondValue)
            {
                Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
            }
            if (setLineCurrentColorCategoryStateFirstValue && setLineCurrentColorCategoryStateSecondValue)
            {
                Line.InterpolateBetween(LineCurrentColorCategoryStateFirstValue, LineCurrentColorCategoryStateSecondValue, interpolationValue);
            }
            if (setLineHeightFirstValue && setLineHeightSecondValue)
            {
                Line.Height = LineHeightFirstValue * (1 - interpolationValue) + LineHeightSecondValue * interpolationValue;
            }
            if (setLineTextureHeightFirstValue && setLineTextureHeightSecondValue)
            {
                Line.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(LineTextureHeightFirstValue* (1 - interpolationValue) + LineTextureHeightSecondValue * interpolationValue);
            }
            if (setLineTextureLeftFirstValue && setLineTextureLeftSecondValue)
            {
                Line.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(LineTextureLeftFirstValue* (1 - interpolationValue) + LineTextureLeftSecondValue * interpolationValue);
            }
            if (setLineTextureTopFirstValue && setLineTextureTopSecondValue)
            {
                Line.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(LineTextureTopFirstValue* (1 - interpolationValue) + LineTextureTopSecondValue * interpolationValue);
            }
            if (setLineTextureWidthFirstValue && setLineTextureWidthSecondValue)
            {
                Line.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(LineTextureWidthFirstValue* (1 - interpolationValue) + LineTextureWidthSecondValue * interpolationValue);
            }
            if (setLineWidthFirstValue && setLineWidthSecondValue)
            {
                Line.Width = LineWidthFirstValue * (1 - interpolationValue) + LineWidthSecondValue * interpolationValue;
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
        #endregion
        #region State Interpolate To
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (global::TestProject.GumRuntimes.Elements.DividerVerticalRuntime.VariableState fromState,global::TestProject.GumRuntimes.Elements.DividerVerticalRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
        #endregion
        #region State Animations
        #endregion
        public override void StopAnimations () 
        {
            base.StopAnimations();
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
                        Name = "Width",
                        Type = "float",
                        Value = Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "WidthUnits",
                        Type = "DimensionUnitType",
                        Value = WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentTop.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = AccentTop.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentTop.Height",
                        Type = "float",
                        Value = AccentTop.Height
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentTop.HeightUnits",
                        Type = "DimensionUnitType",
                        Value = AccentTop.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentTop.SourceFile",
                        Type = "string",
                        Value = AccentTop.SourceFile
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentTop.TextureAddress",
                        Type = "TextureAddress",
                        Value = AccentTop.TextureAddress
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentTop.TextureHeight",
                        Type = "int",
                        Value = AccentTop.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentTop.TextureLeft",
                        Type = "int",
                        Value = AccentTop.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentTop.TextureTop",
                        Type = "int",
                        Value = AccentTop.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentTop.TextureWidth",
                        Type = "int",
                        Value = AccentTop.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentTop.Width",
                        Type = "float",
                        Value = AccentTop.Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentTop.XOrigin",
                        Type = "HorizontalAlignment",
                        Value = AccentTop.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentTop.XUnits",
                        Type = "PositionUnitType",
                        Value = AccentTop.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = Line.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.Height",
                        Type = "float",
                        Value = Line.Height
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.HeightUnits",
                        Type = "DimensionUnitType",
                        Value = Line.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.SourceFile",
                        Type = "string",
                        Value = Line.SourceFile
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.TextureAddress",
                        Type = "TextureAddress",
                        Value = Line.TextureAddress
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.TextureHeight",
                        Type = "int",
                        Value = Line.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.TextureLeft",
                        Type = "int",
                        Value = Line.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.TextureTop",
                        Type = "int",
                        Value = Line.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.TextureWidth",
                        Type = "int",
                        Value = Line.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.Width",
                        Type = "float",
                        Value = Line.Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.WidthUnits",
                        Type = "DimensionUnitType",
                        Value = Line.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.XOrigin",
                        Type = "HorizontalAlignment",
                        Value = Line.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.XUnits",
                        Type = "PositionUnitType",
                        Value = Line.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.YOrigin",
                        Type = "VerticalAlignment",
                        Value = Line.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.YUnits",
                        Type = "PositionUnitType",
                        Value = Line.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = AccentRight.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.Height",
                        Type = "float",
                        Value = AccentRight.Height
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.HeightUnits",
                        Type = "DimensionUnitType",
                        Value = AccentRight.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.SourceFile",
                        Type = "string",
                        Value = AccentRight.SourceFile
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.TextureAddress",
                        Type = "TextureAddress",
                        Value = AccentRight.TextureAddress
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.TextureHeight",
                        Type = "int",
                        Value = AccentRight.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.TextureLeft",
                        Type = "int",
                        Value = AccentRight.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.TextureTop",
                        Type = "int",
                        Value = AccentRight.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.TextureWidth",
                        Type = "int",
                        Value = AccentRight.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.Width",
                        Type = "float",
                        Value = AccentRight.Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.XOrigin",
                        Type = "HorizontalAlignment",
                        Value = AccentRight.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.XUnits",
                        Type = "PositionUnitType",
                        Value = AccentRight.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.YOrigin",
                        Type = "VerticalAlignment",
                        Value = AccentRight.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.YUnits",
                        Type = "PositionUnitType",
                        Value = AccentRight.YUnits
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
                        Value = Height + 128f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Width",
                        Type = "float",
                        Value = Width + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "WidthUnits",
                        Type = "DimensionUnitType",
                        Value = WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentTop.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = AccentTop.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentTop.Height",
                        Type = "float",
                        Value = AccentTop.Height + 100f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentTop.HeightUnits",
                        Type = "DimensionUnitType",
                        Value = AccentTop.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentTop.SourceFile",
                        Type = "string",
                        Value = AccentTop.SourceFile
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentTop.TextureAddress",
                        Type = "TextureAddress",
                        Value = AccentTop.TextureAddress
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentTop.TextureHeight",
                        Type = "int",
                        Value = AccentTop.TextureHeight + 3
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentTop.TextureLeft",
                        Type = "int",
                        Value = AccentTop.TextureLeft + 281
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentTop.TextureTop",
                        Type = "int",
                        Value = AccentTop.TextureTop + 0
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentTop.TextureWidth",
                        Type = "int",
                        Value = AccentTop.TextureWidth + 3
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentTop.Width",
                        Type = "float",
                        Value = AccentTop.Width + 100f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentTop.XOrigin",
                        Type = "HorizontalAlignment",
                        Value = AccentTop.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentTop.XUnits",
                        Type = "PositionUnitType",
                        Value = AccentTop.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = Line.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.Height",
                        Type = "float",
                        Value = Line.Height + -8f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.HeightUnits",
                        Type = "DimensionUnitType",
                        Value = Line.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.SourceFile",
                        Type = "string",
                        Value = Line.SourceFile
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.TextureAddress",
                        Type = "TextureAddress",
                        Value = Line.TextureAddress
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.TextureHeight",
                        Type = "int",
                        Value = Line.TextureHeight + 1
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.TextureLeft",
                        Type = "int",
                        Value = Line.TextureLeft + 281
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.TextureTop",
                        Type = "int",
                        Value = Line.TextureTop + 1
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.TextureWidth",
                        Type = "int",
                        Value = Line.TextureWidth + 3
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.Width",
                        Type = "float",
                        Value = Line.Width + 1f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.WidthUnits",
                        Type = "DimensionUnitType",
                        Value = Line.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.XOrigin",
                        Type = "HorizontalAlignment",
                        Value = Line.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.XUnits",
                        Type = "PositionUnitType",
                        Value = Line.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.YOrigin",
                        Type = "VerticalAlignment",
                        Value = Line.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.YUnits",
                        Type = "PositionUnitType",
                        Value = Line.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = AccentRight.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.Height",
                        Type = "float",
                        Value = AccentRight.Height + 100f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.HeightUnits",
                        Type = "DimensionUnitType",
                        Value = AccentRight.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.SourceFile",
                        Type = "string",
                        Value = AccentRight.SourceFile
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.TextureAddress",
                        Type = "TextureAddress",
                        Value = AccentRight.TextureAddress
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.TextureHeight",
                        Type = "int",
                        Value = AccentRight.TextureHeight + 3
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.TextureLeft",
                        Type = "int",
                        Value = AccentRight.TextureLeft + 281
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.TextureTop",
                        Type = "int",
                        Value = AccentRight.TextureTop + 0
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.TextureWidth",
                        Type = "int",
                        Value = AccentRight.TextureWidth + 3
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.Width",
                        Type = "float",
                        Value = AccentRight.Width + 100f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.XOrigin",
                        Type = "HorizontalAlignment",
                        Value = AccentRight.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.XUnits",
                        Type = "PositionUnitType",
                        Value = AccentRight.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.YOrigin",
                        Type = "VerticalAlignment",
                        Value = AccentRight.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.YUnits",
                        Type = "PositionUnitType",
                        Value = AccentRight.YUnits
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
            }
            base.ApplyState(state);
        }
        public global::TestProject.GumRuntimes.SpriteRuntime AccentTop { get; set; }
        public global::TestProject.GumRuntimes.SpriteRuntime Line { get; set; }
        public global::TestProject.GumRuntimes.SpriteRuntime AccentRight { get; set; }
        public DividerVerticalRuntime () 
        	: this(true, true)
        {
        }
        public DividerVerticalRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
        	: base(false, tryCreateFormsObject)
        {
            if (fullInstantiation)
            {
                Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "Elements/DividerVertical");
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
            AccentTop = this.GetGraphicalUiElementByName("AccentTop") as global::TestProject.GumRuntimes.SpriteRuntime;
            Line = this.GetGraphicalUiElementByName("Line") as global::TestProject.GumRuntimes.SpriteRuntime;
            AccentRight = this.GetGraphicalUiElementByName("AccentRight") as global::TestProject.GumRuntimes.SpriteRuntime;
        }
        private void CallCustomInitialize () 
        {
            CustomInitialize();
        }
        partial void CustomInitialize();
        public override void RemoveFromManagers () 
        {
            StopAnimations();
            base.RemoveFromManagers();
        }
    }
}

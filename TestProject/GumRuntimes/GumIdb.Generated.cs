namespace FlatRedBall.Gum
{
    public  class GumIdbExtensions
    {
        public static void RegisterTypes () 
        {
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Circle", typeof(global::TestProject.GumRuntimes.CircleRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("ColoredRectangle", typeof(global::TestProject.GumRuntimes.ColoredRectangleRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Container", typeof(global::TestProject.GumRuntimes.ContainerRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Container<T>", typeof(global::TestProject.GumRuntimes.ContainerRuntime<>));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("NineSlice", typeof(global::TestProject.GumRuntimes.NineSliceRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Polygon", typeof(global::TestProject.GumRuntimes.PolygonRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Rectangle", typeof(global::TestProject.GumRuntimes.RectangleRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Sprite", typeof(global::TestProject.GumRuntimes.SpriteRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Text", typeof(global::TestProject.GumRuntimes.TextRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/ButtonClose", typeof(global::TestProject.GumRuntimes.Controls.ButtonCloseRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/ButtonConfirm", typeof(global::TestProject.GumRuntimes.Controls.ButtonConfirmRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/ButtonDeny", typeof(global::TestProject.GumRuntimes.Controls.ButtonDenyRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/ButtonIcon", typeof(global::TestProject.GumRuntimes.Controls.ButtonIconRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/ButtonStandard", typeof(global::TestProject.GumRuntimes.Controls.ButtonStandardRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/ButtonStandardIcon", typeof(global::TestProject.GumRuntimes.Controls.ButtonStandardIconRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/ButtonTab", typeof(global::TestProject.GumRuntimes.Controls.ButtonTabRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/CheckBox", typeof(global::TestProject.GumRuntimes.Controls.CheckBoxRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/ComboBox", typeof(global::TestProject.GumRuntimes.Controls.ComboBoxRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/DialogBox", typeof(global::TestProject.GumRuntimes.Controls.DialogBoxRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/InputDeviceSelectionItem", typeof(global::TestProject.GumRuntimes.Controls.InputDeviceSelectionItemRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/InputDeviceSelector", typeof(global::TestProject.GumRuntimes.Controls.InputDeviceSelectorRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/Keyboard", typeof(global::TestProject.GumRuntimes.Controls.KeyboardRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/KeyboardKey", typeof(global::TestProject.GumRuntimes.Controls.KeyboardKeyRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/ListBox", typeof(global::TestProject.GumRuntimes.Controls.ListBoxRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/ListBoxItem", typeof(global::TestProject.GumRuntimes.Controls.ListBoxItemRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/PasswordBox", typeof(global::TestProject.GumRuntimes.Controls.PasswordBoxRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/PlayerJoinView", typeof(global::TestProject.GumRuntimes.Controls.PlayerJoinViewRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/PlayerJoinViewItem", typeof(global::TestProject.GumRuntimes.Controls.PlayerJoinViewItemRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/RadioButton", typeof(global::TestProject.GumRuntimes.Controls.RadioButtonRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/ScrollBar", typeof(global::TestProject.GumRuntimes.Controls.ScrollBarRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/ScrollViewer", typeof(global::TestProject.GumRuntimes.Controls.ScrollViewerRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/SettingsView", typeof(global::TestProject.GumRuntimes.Controls.SettingsViewRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/Slider", typeof(global::TestProject.GumRuntimes.Controls.SliderRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/TextBox", typeof(global::TestProject.GumRuntimes.Controls.TextBoxRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/Toast", typeof(global::TestProject.GumRuntimes.Controls.ToastRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/TreeView", typeof(global::TestProject.GumRuntimes.Controls.TreeViewRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/TreeViewItem", typeof(global::TestProject.GumRuntimes.Controls.TreeViewItemRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/TreeViewToggle", typeof(global::TestProject.GumRuntimes.Controls.TreeViewToggleRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/UserControl", typeof(global::TestProject.GumRuntimes.Controls.UserControlRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Elements/CautionLines", typeof(global::TestProject.GumRuntimes.Elements.CautionLinesRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Elements/Divider", typeof(global::TestProject.GumRuntimes.Elements.DividerRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Elements/DividerHorizontal", typeof(global::TestProject.GumRuntimes.Elements.DividerHorizontalRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Elements/DividerVertical", typeof(global::TestProject.GumRuntimes.Elements.DividerVerticalRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Elements/Icon", typeof(global::TestProject.GumRuntimes.Elements.IconRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Elements/Label", typeof(global::TestProject.GumRuntimes.Elements.LabelRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Elements/PercentBar", typeof(global::TestProject.GumRuntimes.Elements.PercentBarRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Elements/PercentBarIcon", typeof(global::TestProject.GumRuntimes.Elements.PercentBarIconRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Elements/VerticalLines", typeof(global::TestProject.GumRuntimes.Elements.VerticalLinesRuntime));
            
            FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.Button)] = typeof(global::TestProject.GumRuntimes.Controls.ButtonStandardRuntime);
            FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.CheckBox)] = typeof(global::TestProject.GumRuntimes.Controls.CheckBoxRuntime);
            FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.ComboBox)] = typeof(global::TestProject.GumRuntimes.Controls.ComboBoxRuntime);
            FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.Games.DialogBox)] = typeof(global::TestProject.GumRuntimes.Controls.DialogBoxRuntime);
            FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.Games.InputDeviceSelectionItem)] = typeof(global::TestProject.GumRuntimes.Controls.InputDeviceSelectionItemRuntime);
            FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.Games.InputDeviceSelector)] = typeof(global::TestProject.GumRuntimes.Controls.InputDeviceSelectorRuntime);
            FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.Games.OnScreenKeyboard)] = typeof(global::TestProject.GumRuntimes.Controls.KeyboardRuntime);
            FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.ListBox)] = typeof(global::TestProject.GumRuntimes.Controls.ListBoxRuntime);
            FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.ListBoxItem)] = typeof(global::TestProject.GumRuntimes.Controls.ListBoxItemRuntime);
            FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.PasswordBox)] = typeof(global::TestProject.GumRuntimes.Controls.PasswordBoxRuntime);
            FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.Games.PlayerJoinView)] = typeof(global::TestProject.GumRuntimes.Controls.PlayerJoinViewRuntime);
            FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.Games.PlayerJoinViewItem)] = typeof(global::TestProject.GumRuntimes.Controls.PlayerJoinViewItemRuntime);
            FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.RadioButton)] = typeof(global::TestProject.GumRuntimes.Controls.RadioButtonRuntime);
            FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.ScrollBar)] = typeof(global::TestProject.GumRuntimes.Controls.ScrollBarRuntime);
            FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.ScrollViewer)] = typeof(global::TestProject.GumRuntimes.Controls.ScrollViewerRuntime);
            FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.Games.SettingsView)] = typeof(global::TestProject.GumRuntimes.Controls.SettingsViewRuntime);
            FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.Slider)] = typeof(global::TestProject.GumRuntimes.Controls.SliderRuntime);
            FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.TextBox)] = typeof(global::TestProject.GumRuntimes.Controls.TextBoxRuntime);
            FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.Popups.Toast)] = typeof(global::TestProject.GumRuntimes.Controls.ToastRuntime);
            FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.TreeView)] = typeof(global::TestProject.GumRuntimes.Controls.TreeViewRuntime);
            FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.TreeViewItem)] = typeof(global::TestProject.GumRuntimes.Controls.TreeViewItemRuntime);
            FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.ToggleButton)] = typeof(global::TestProject.GumRuntimes.Controls.TreeViewToggleRuntime);
            FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.UserControl)] = typeof(global::TestProject.GumRuntimes.Controls.UserControlRuntime);
            FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.Label)] = typeof(global::TestProject.GumRuntimes.Elements.LabelRuntime);
        }
    }
}

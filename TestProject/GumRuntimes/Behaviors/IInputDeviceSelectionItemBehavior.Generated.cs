namespace TestProject.GumRuntimes
{
    public interface IInputDeviceSelectionItemBehavior
    {
        #region State Enums
        public  enum JoinedCategory
        {
            HasInputDevice,
            NoInputDevice
        }
        #endregion
        JoinedCategory CurrentJoinedCategoryState {set;}
    }
}

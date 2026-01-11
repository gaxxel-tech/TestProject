#pragma warning disable
#if ANDROID || IOS || DESKTOP_GL
#define REQUIRES_PRIMARY_THREAD_LOADING
#endif
#define SUPPORTS_GLUEVIEW_2
using Color = Microsoft.Xna.Framework.Color;
using System.Linq;
using FlatRedBall.Graphics;
using FlatRedBall.Math;
using FlatRedBall;
using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Entities.Components;
namespace TestProject.Entities
{
    public partial class Player : FlatRedBall.PositionedObject, FlatRedBall.Graphics.IDestroyable, FlatRedBall.Entities.IEntity, FlatRedBall.Math.Geometry.ICollidable
    {
        // This is made static so that static lazy-loaded content can access it.
        public static string ContentManagerName { get; set; }
        #if DEBUG
        private double mLastTimeCalledActivity=-1;
        #endif
        #if DEBUG
        public static bool HasBeenLoadedWithGlobalContentManager { get; private set; }= false;
        #endif
        static object mLockObject = new object();
        static System.Collections.Generic.List<string> mRegisteredUnloads = new System.Collections.Generic.List<string>();
        static System.Collections.Generic.List<string> LoadedContentManagers = new System.Collections.Generic.List<string>();
        protected static global::Microsoft.Xna.Framework.Graphics.Texture2D characterSpritesheet;
        
        private global::FlatRedBall.Sprite SpriteInstance;
        private global::TestProject.Entities.Components.MovementController mMovementControllerInstance;
        public global::TestProject.Entities.Components.MovementController MovementControllerInstance
        {
            get
            {
                return mMovementControllerInstance;
            }
            private set
            {
                mMovementControllerInstance = value;
            }
        }
        private global::TestProject.Entities.Components.InputController InputControllerInstance;
        private FlatRedBall.Math.Geometry.ShapeCollection mGeneratedCollision;
        public FlatRedBall.Math.Geometry.ShapeCollection Collision
        {
            get
            {
                return mGeneratedCollision;
            }
        }
        public HashSet<string> ItemsCollidedAgainst { get; private set;} = new HashSet<string>();
        public HashSet<string> LastFrameItemsCollidedAgainst { get; private set;} = new HashSet<string>();
        public HashSet<object> ObjectsCollidedAgainst { get; private set;} = new HashSet<object>();
        public HashSet<object> LastFrameObjectsCollidedAgainst { get; private set;} = new HashSet<object>();
        public string EditModeType { get; set; } = "TestProject.Entities.Player";
        protected FlatRedBall.Graphics.Layer LayerProvidedByContainer = null;
        public Player () 
        	: this(FlatRedBall.Screens.ScreenManager.CurrentScreen.ContentManagerName, true)
        {
        }
        public Player (string contentManagerName) 
        	: this(contentManagerName, true)
        {
        }
        public Player (string contentManagerName, bool addToManagers) 
        	: base()
        {
            ContentManagerName = contentManagerName;
            InitializeEntity(addToManagers);
        }
        protected virtual void InitializeEntity (bool addToManagers) 
        {
            LoadStaticContent(ContentManagerName);
            SpriteInstance = new global::FlatRedBall.Sprite();
            SpriteInstance.Name = "SpriteInstance";
            SpriteInstance.CreationSource = "Glue";
            mMovementControllerInstance = new global::TestProject.Entities.Components.MovementController(ContentManagerName, false);
            mMovementControllerInstance.Name = "MovementControllerInstance";
            mMovementControllerInstance.CreationSource = "Glue";
            InputControllerInstance = new global::TestProject.Entities.Components.InputController(ContentManagerName, false);
            InputControllerInstance.Name = "InputControllerInstance";
            InputControllerInstance.CreationSource = "Glue";
            
            PostInitialize();
            if (addToManagers)
            {
                AddToManagers(null);
            }
        }
        public virtual void AddToManagers (FlatRedBall.Graphics.Layer layerToAddTo) 
        {
            LayerProvidedByContainer = layerToAddTo;
            FlatRedBall.SpriteManager.AddPositionedObject(this);
            FlatRedBall.SpriteManager.AddToLayer(SpriteInstance, LayerProvidedByContainer);
            mMovementControllerInstance.AddToManagers(LayerProvidedByContainer);
            InputControllerInstance.AddToManagers(LayerProvidedByContainer);
            AddToManagersBottomUp(layerToAddTo);
            GlueControl.InstanceLogic.Self.ApplyEditorCommandsToNewEntity(this, GlueControl.CommandReceiver.GameElementTypeToGlueElement(this.GetType().FullName));
            CustomInitialize();
        }
        public virtual void Activity () 
        {
            #if DEBUG
            if(TimeManager.TimeFactor > 0 && mLastTimeCalledActivity > 0 && mLastTimeCalledActivity == FlatRedBall.TimeManager.CurrentScreenTime)
            {
                throw new System.Exception("Activity was called twice in the same frame. This can cause objects to move 2x as fast.");
            }
            mLastTimeCalledActivity = FlatRedBall.TimeManager.CurrentScreenTime;
            #endif
            
            MovementControllerInstance.Activity();
            InputControllerInstance.Activity();
            CustomActivity();
        }
        public virtual void ActivityEditMode () 
        {
            CustomActivityEditMode();
        }
        public virtual void Destroy () 
        {
            FlatRedBall.SpriteManager.RemovePositionedObject(this);
            
            if (SpriteInstance != null)
            {
                FlatRedBall.SpriteManager.RemoveSpriteOneWay(SpriteInstance);
            }
            if (MovementControllerInstance != null)
            {
                MovementControllerInstance.Destroy();
                MovementControllerInstance.Detach();
            }
            if (InputControllerInstance != null)
            {
                InputControllerInstance.Destroy();
                InputControllerInstance.Detach();
            }
            mGeneratedCollision.RemoveFromManagers(clearThis: true);
            CustomDestroy();
        }
        public virtual void PostInitialize () 
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            if (SpriteInstance.Parent == null)
            {
                SpriteInstance.CopyAbsoluteToRelative();
                SpriteInstance.AttachTo(this, false);
            }
            SpriteInstance.Texture = characterSpritesheet;
            SpriteInstance.RightTexturePixel = 64f;
            SpriteInstance.TopTexturePixel = 128f;
            SpriteInstance.BottomTexturePixel = 192f;
            SpriteInstance.TextureScale = 1f;
            if (mMovementControllerInstance.Parent == null)
            {
                mMovementControllerInstance.CopyAbsoluteToRelative();
                mMovementControllerInstance.AttachTo(this, false);
            }
            MovementControllerInstance.CurrentSpeed = 50f;
            if (InputControllerInstance.Parent == null)
            {
                InputControllerInstance.CopyAbsoluteToRelative();
                InputControllerInstance.AttachTo(this, false);
            }
            mGeneratedCollision = new FlatRedBall.Math.Geometry.ShapeCollection();
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
        }
        public virtual void AddToManagersBottomUp (FlatRedBall.Graphics.Layer layerToAddTo) 
        {
            AssignCustomVariables(false);
        }
        public virtual void RemoveFromManagers () 
        {
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(this);
            if (SpriteInstance != null)
            {
                FlatRedBall.SpriteManager.RemoveSpriteOneWay(SpriteInstance);
            }
            MovementControllerInstance.RemoveFromManagers();
            InputControllerInstance.RemoveFromManagers();
            mGeneratedCollision.RemoveFromManagers(clearThis: false);
        }
        public virtual void AssignCustomVariables (bool callOnContainedElements) 
        {
            if (callOnContainedElements)
            {
                MovementControllerInstance.AssignCustomVariables(true);
                InputControllerInstance.AssignCustomVariables(true);
            }
            SpriteInstance.Texture = characterSpritesheet;
            SpriteInstance.RightTexturePixel = 64f;
            SpriteInstance.TopTexturePixel = 128f;
            SpriteInstance.BottomTexturePixel = 192f;
            SpriteInstance.TextureScale = 1f;
            MovementControllerInstance.CurrentSpeed = 50f;
        }
        public virtual void ConvertToManuallyUpdated () 
        {
            this.ForceUpdateDependenciesDeep();
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(this);
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(SpriteInstance);
            MovementControllerInstance.ConvertToManuallyUpdated();
            InputControllerInstance.ConvertToManuallyUpdated();
        }
        public static void LoadStaticContent (string contentManagerName) 
        {
            if (LoadedContentManagers.Contains(contentManagerName))
            {
                return;
            }
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            if (string.IsNullOrEmpty(contentManagerName))
            {
                throw new System.ArgumentException("contentManagerName cannot be empty or null");
            }
            ContentManagerName = contentManagerName;
            // Set the content manager for Gum
            var contentManagerWrapper = new FlatRedBall.Gum.ContentManagerWrapper();
            contentManagerWrapper.ContentManagerName = contentManagerName;
            RenderingLibrary.Content.LoaderManager.Self.ContentLoader = contentManagerWrapper;
            // Access the GumProject just in case it's async loaded
            var throwaway = GlobalContent.GumProject;
            #if DEBUG
            if (contentManagerName == FlatRedBall.FlatRedBallServices.GlobalContentManager)
            {
                HasBeenLoadedWithGlobalContentManager = true;
            }
            else if (HasBeenLoadedWithGlobalContentManager)
            {
                throw new System.Exception( "Player has been loaded with a Global content manager, then loaded with a non-global.  This can lead to a lot of bugs");
            }
            #endif
            bool registerUnload = false;
            if (LoadedContentManagers.Contains(contentManagerName) == false)
            {
                LoadedContentManagers.Add(contentManagerName);
                lock (mLockObject)
                {
                    if (!mRegisteredUnloads.Contains(ContentManagerName) && ContentManagerName != FlatRedBall.FlatRedBallServices.GlobalContentManager)
                    {
                        FlatRedBall.FlatRedBallServices.GetContentManagerByName(ContentManagerName).AddUnloadMethod("PlayerStaticUnload", UnloadStaticContent);
                        mRegisteredUnloads.Add(ContentManagerName);
                    }
                }
                if (!FlatRedBall.FlatRedBallServices.IsLoaded<Microsoft.Xna.Framework.Graphics.Texture2D>(@"Content/Entities/Player/characterSpritesheet.png", ContentManagerName))
                {
                    registerUnload = true;
                }
                characterSpritesheet = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Graphics.Texture2D>(@"Content/Entities/Player/characterSpritesheet.png", ContentManagerName);
            }
            global::TestProject.Entities.Components.MovementController.LoadStaticContent(contentManagerName);
            global::TestProject.Entities.Components.InputController.LoadStaticContent(contentManagerName);
            if (registerUnload && ContentManagerName != FlatRedBall.FlatRedBallServices.GlobalContentManager)
            {
                lock (mLockObject)
                {
                    if (!mRegisteredUnloads.Contains(ContentManagerName) && ContentManagerName != FlatRedBall.FlatRedBallServices.GlobalContentManager)
                    {
                        FlatRedBall.FlatRedBallServices.GetContentManagerByName(ContentManagerName).AddUnloadMethod("PlayerStaticUnload", UnloadStaticContent);
                        mRegisteredUnloads.Add(ContentManagerName);
                    }
                }
            }
            CustomLoadStaticContent(contentManagerName);
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
        }
        public static void UnloadStaticContent () 
        {
            if (LoadedContentManagers.Count != 0)
            {
                LoadedContentManagers.RemoveAt(0);
                mRegisteredUnloads.RemoveAt(0);
            }
            if (LoadedContentManagers.Count == 0)
            {
                if (characterSpritesheet != null)
                {
                    characterSpritesheet= null;
                }
            }
        }
        [System.Obsolete("Use GetFile instead")]
        public static object GetStaticMember (string memberName) 
        {
            switch(memberName)
            {
                case  "characterSpritesheet":
                    return characterSpritesheet;
            }
            return null;
        }
        public static object GetFile (string memberName) 
        {
            switch(memberName)
            {
                case  "characterSpritesheet":
                    return characterSpritesheet;
            }
            return null;
        }
        object GetMember (string memberName) 
        {
            switch(memberName)
            {
                case  "characterSpritesheet":
                    return characterSpritesheet;
            }
            return null;
        }
        public static void Reload (object whatToReload) 
        {
            if (whatToReload == characterSpritesheet)
            {
                var oldTexture = characterSpritesheet;
                {
                    var cm = FlatRedBall.FlatRedBallServices.GetContentManagerByName("Global");
                    cm.UnloadAsset(characterSpritesheet);
                    characterSpritesheet = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Graphics.Texture2D>("Content/Entities/Player/characterSpritesheet.png");
                }
                FlatRedBall.FlatRedBallServices.ReplaceTexture(oldTexture, characterSpritesheet);
            }
        }
        protected bool mIsPaused;
        public override void Pause (FlatRedBall.Instructions.InstructionList instructions) 
        {
            base.Pause(instructions);
            mIsPaused = true;
        }
        public virtual void SetToIgnorePausing () 
        {
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(this);
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(SpriteInstance);
            MovementControllerInstance.SetToIgnorePausing();
            InputControllerInstance.SetToIgnorePausing();
        }
        public virtual void MoveToLayer (FlatRedBall.Graphics.Layer layerToMoveTo) 
        {
            var layerToRemoveFrom = LayerProvidedByContainer;
            if (layerToRemoveFrom != null)
            {
                layerToRemoveFrom.Remove(SpriteInstance);
            }
            if (layerToMoveTo != null || !SpriteManager.AutomaticallyUpdatedSprites.Contains(SpriteInstance))
            {
                FlatRedBall.SpriteManager.AddToLayer(SpriteInstance, layerToMoveTo);
            }
            MovementControllerInstance.MoveToLayer(layerToMoveTo);
            InputControllerInstance.MoveToLayer(layerToMoveTo);
            LayerProvidedByContainer = layerToMoveTo;
        }
        partial void CustomActivityEditMode();
    }
}

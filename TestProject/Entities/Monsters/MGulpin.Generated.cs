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
namespace TestProject.Entities.Monsters
{
    public partial class MGulpin : TestProject.Entities.Monsters.BaseMonster, FlatRedBall.Graphics.IDestroyable, FlatRedBall.Entities.IEntity
    {
        // This is made static so that static lazy-loaded content can access it.
        public static new string ContentManagerName
        {
            get
            {
                return TestProject.Entities.Monsters.BaseMonster.ContentManagerName;
            }
            set
            {
                TestProject.Entities.Monsters.BaseMonster.ContentManagerName = value;
            }
        }
        #if DEBUG
        private double mLastTimeCalledActivity=-1;
        #endif
        #if DEBUG
        public static bool HasBeenLoadedWithGlobalContentManager { get; private set; }= false;
        #endif
        static object mLockObject = new object();
        static System.Collections.Generic.List<string> mRegisteredUnloads = new System.Collections.Generic.List<string>();
        static System.Collections.Generic.List<string> LoadedContentManagers = new System.Collections.Generic.List<string>();
        protected static global::Microsoft.Xna.Framework.Graphics.Texture2D GulpinSprites;
        protected static global::FlatRedBall.Graphics.Animation.AnimationChainList GulpinAnimations;
        
        public MGulpin () 
        	: this(FlatRedBall.Screens.ScreenManager.CurrentScreen.ContentManagerName, true)
        {
        }
        public MGulpin (string contentManagerName) 
        	: this(contentManagerName, true)
        {
        }
        public MGulpin (string contentManagerName, bool addToManagers) 
        	: base(contentManagerName, addToManagers)
        {
            ContentManagerName = contentManagerName;
            // skipping instantiation of FlatRedBall.Sprite SpriteInstance in Entities\Monsters\MGulpin because it has its InstantiatedByBase set to true
            // skipping instantiation of StatsComponent StatsComponentInstance in Entities\Monsters\MGulpin because it has its InstantiatedByBase set to true
            // skipping instantiation of MovementController MovementControllerInstance in Entities\Monsters\MGulpin because it has its InstantiatedByBase set to true
            // skipping instantiation of HealthComponent HealthComponentInstance in Entities\Monsters\MGulpin because it has its InstantiatedByBase set to true
            // skipping instantiation of FlatRedBall.Math.Geometry.Circle CircleInstance in Entities\Monsters\MGulpin because it has its InstantiatedByBase set to true
        }
        protected override void InitializeEntity (bool addToManagers) 
        {
            LoadStaticContent(ContentManagerName);
            // skipping instantiation of FlatRedBall.Sprite SpriteInstance in Entities\Monsters\MGulpin because it has its InstantiatedByBase set to true
            // skipping instantiation of StatsComponent StatsComponentInstance in Entities\Monsters\MGulpin because it has its InstantiatedByBase set to true
            // skipping instantiation of MovementController MovementControllerInstance in Entities\Monsters\MGulpin because it has its InstantiatedByBase set to true
            // skipping instantiation of HealthComponent HealthComponentInstance in Entities\Monsters\MGulpin because it has its InstantiatedByBase set to true
            // skipping instantiation of FlatRedBall.Math.Geometry.Circle CircleInstance in Entities\Monsters\MGulpin because it has its InstantiatedByBase set to true
            
            base.InitializeEntity(addToManagers);
        }
        public override void AddToManagers (FlatRedBall.Graphics.Layer layerToAddTo) 
        {
            LayerProvidedByContainer = layerToAddTo;
            base.AddToManagers(layerToAddTo);
            CustomInitialize();
        }
        public override void Activity () 
        {
            #if DEBUG
            if(TimeManager.TimeFactor > 0 && mLastTimeCalledActivity > 0 && mLastTimeCalledActivity == FlatRedBall.TimeManager.CurrentScreenTime)
            {
                throw new System.Exception("Activity was called twice in the same frame. This can cause objects to move 2x as fast.");
            }
            mLastTimeCalledActivity = FlatRedBall.TimeManager.CurrentScreenTime;
            #endif
            base.Activity();
            
            SpriteInstance.SetCollisionFromAnimation(this, true);
            CustomActivity();
        }
        public override void ActivityEditMode () 
        {
            CustomActivityEditMode();
            base.ActivityEditMode();
        }
        public override void Destroy () 
        {
            base.Destroy();
            
            CustomDestroy();
        }
        public override void PostInitialize () 
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            base.PostInitialize();
            if (SpriteInstance!= null)
            {
                if (SpriteInstance.Parent == null)
                {
                    SpriteInstance.CopyAbsoluteToRelative();
                    SpriteInstance.AttachTo(this, false);
                }
                base.SpriteInstance.Texture = null;
                base.SpriteInstance.TextureScale = 1f;
                base.SpriteInstance.UseAnimationRelativePosition = true;
                base.SpriteInstance.AnimationChains = GulpinAnimations;
                base.SpriteInstance.CurrentChainName = "Moving";
            }
            if (StatsComponentInstance!= null)
            {
                if (mStatsComponentInstance.Parent == null)
                {
                    mStatsComponentInstance.CopyAbsoluteToRelative();
                    mStatsComponentInstance.AttachTo(this, false);
                }
            }
            if (MovementControllerInstance!= null)
            {
                if (mMovementControllerInstance.Parent == null)
                {
                    mMovementControllerInstance.CopyAbsoluteToRelative();
                    mMovementControllerInstance.AttachTo(this, false);
                }
            }
            if (HealthComponentInstance!= null)
            {
                if (mHealthComponentInstance.Parent == null)
                {
                    mHealthComponentInstance.CopyAbsoluteToRelative();
                    mHealthComponentInstance.AttachTo(this, false);
                }
            }
            if (CircleInstance!= null)
            {
                if (mCircleInstance.Parent == null)
                {
                    mCircleInstance.CopyAbsoluteToRelative();
                    mCircleInstance.AttachTo(this, false);
                }
                base.CircleInstance.Radius = 5f;
            }
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
        }
        public override void AddToManagersBottomUp (FlatRedBall.Graphics.Layer layerToAddTo) 
        {
            base.AddToManagersBottomUp(layerToAddTo);
            CurrentHealth = MaxHealth;
        }
        public override void RemoveFromManagers () 
        {
            base.RemoveFromManagers();
        }
        public override void AssignCustomVariables (bool callOnContainedElements) 
        {
            base.AssignCustomVariables(callOnContainedElements);
            if (callOnContainedElements)
            {
            }
            base.SpriteInstance.Texture = null;
            base.SpriteInstance.TextureScale = 1f;
            base.SpriteInstance.UseAnimationRelativePosition = true;
            base.SpriteInstance.AnimationChains = GulpinAnimations;
            base.SpriteInstance.CurrentChainName = "Moving";
            base.CircleInstance.Radius = 5f;
            MonsterData = GlobalContent.EnemyData["Gulpin"];
        }
        public override void ConvertToManuallyUpdated () 
        {
            base.ConvertToManuallyUpdated();
            this.ForceUpdateDependenciesDeep();
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(this);
        }
        public static new void LoadStaticContent (string contentManagerName) 
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
            global::TestProject.Entities.Monsters.BaseMonster.LoadStaticContent(contentManagerName);
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
                throw new System.Exception( "MGulpin has been loaded with a Global content manager, then loaded with a non-global.  This can lead to a lot of bugs");
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
                        FlatRedBall.FlatRedBallServices.GetContentManagerByName(ContentManagerName).AddUnloadMethod("MGulpinStaticUnload", UnloadStaticContent);
                        mRegisteredUnloads.Add(ContentManagerName);
                    }
                }
                if (!FlatRedBall.FlatRedBallServices.IsLoaded<Microsoft.Xna.Framework.Graphics.Texture2D>(@"Content/Entities/Monsters/MGulpin/GulpinSprites.png", ContentManagerName))
                {
                    registerUnload = true;
                }
                GulpinSprites = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Graphics.Texture2D>(@"Content/Entities/Monsters/MGulpin/GulpinSprites.png", ContentManagerName);
                if (!FlatRedBall.FlatRedBallServices.IsLoaded<FlatRedBall.Graphics.Animation.AnimationChainList>(@"Content/Entities/Monsters/MGulpin/GulpinAnimations.achx", ContentManagerName))
                {
                    registerUnload = true;
                }
                GulpinAnimations = FlatRedBall.FlatRedBallServices.Load<FlatRedBall.Graphics.Animation.AnimationChainList>(@"Content/Entities/Monsters/MGulpin/GulpinAnimations.achx", ContentManagerName);
            }
            global::TestProject.Entities.Components.StatsComponent.LoadStaticContent(contentManagerName);
            global::TestProject.Entities.Components.MovementController.LoadStaticContent(contentManagerName);
            global::TestProject.Entities.Components.HealthComponent.LoadStaticContent(contentManagerName);
            if (registerUnload && ContentManagerName != FlatRedBall.FlatRedBallServices.GlobalContentManager)
            {
                lock (mLockObject)
                {
                    if (!mRegisteredUnloads.Contains(ContentManagerName) && ContentManagerName != FlatRedBall.FlatRedBallServices.GlobalContentManager)
                    {
                        FlatRedBall.FlatRedBallServices.GetContentManagerByName(ContentManagerName).AddUnloadMethod("MGulpinStaticUnload", UnloadStaticContent);
                        mRegisteredUnloads.Add(ContentManagerName);
                    }
                }
            }
            CustomLoadStaticContent(contentManagerName);
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
        }
        public static new void UnloadStaticContent () 
        {
            if (LoadedContentManagers.Count != 0)
            {
                LoadedContentManagers.RemoveAt(0);
                mRegisteredUnloads.RemoveAt(0);
            }
            if (LoadedContentManagers.Count == 0)
            {
                if (GulpinSprites != null)
                {
                    GulpinSprites= null;
                }
                if (GulpinAnimations != null)
                {
                    GulpinAnimations= null;
                }
            }
        }
        [System.Obsolete("Use GetFile instead")]
        public static new object GetStaticMember (string memberName) 
        {
            switch(memberName)
            {
                case  "GulpinSprites":
                    return GulpinSprites;
                case  "GulpinAnimations":
                    return GulpinAnimations;
            }
            return null;
        }
        public static new object GetFile (string memberName) 
        {
            switch(memberName)
            {
                case  "GulpinSprites":
                    return GulpinSprites;
                case  "GulpinAnimations":
                    return GulpinAnimations;
            }
            return null;
        }
        object GetMember (string memberName) 
        {
            switch(memberName)
            {
                case  "GulpinSprites":
                    return GulpinSprites;
                case  "GulpinAnimations":
                    return GulpinAnimations;
            }
            return null;
        }
        public static void Reload (object whatToReload) 
        {
            if (whatToReload == GulpinSprites)
            {
                var oldTexture = GulpinSprites;
                {
                    var cm = FlatRedBall.FlatRedBallServices.GetContentManagerByName("Global");
                    cm.UnloadAsset(GulpinSprites);
                    GulpinSprites = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Graphics.Texture2D>("Content/Entities/Monsters/MGulpin/GulpinSprites.png");
                }
                FlatRedBall.FlatRedBallServices.ReplaceTexture(oldTexture, GulpinSprites);
            }
            if (whatToReload == GulpinAnimations)
            {
                {
                    var cm = FlatRedBall.FlatRedBallServices.GetContentManagerByName("Global");
                    cm.UnloadAsset(GulpinAnimations);
                    GulpinAnimations = FlatRedBall.FlatRedBallServices.Load<FlatRedBall.Graphics.Animation.AnimationChainList>("Content/Entities/Monsters/MGulpin/GulpinAnimations.achx");
                }
            }
        }
        public override void SetToIgnorePausing () 
        {
            base.SetToIgnorePausing();
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(SpriteInstance);
            StatsComponentInstance.SetToIgnorePausing();
            MovementControllerInstance.SetToIgnorePausing();
            HealthComponentInstance.SetToIgnorePausing();
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(CircleInstance);
        }
        public override void MoveToLayer (FlatRedBall.Graphics.Layer layerToMoveTo) 
        {
            var layerToRemoveFrom = LayerProvidedByContainer; // assign before calling base so removal is not impacted by base call
            base.MoveToLayer(layerToMoveTo);
        }
        partial void CustomActivityEditMode();
    }
}

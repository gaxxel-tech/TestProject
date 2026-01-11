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
    public partial class BaseMonster : FlatRedBall.PositionedObject, FlatRedBall.Graphics.IDestroyable, FlatRedBall.Entities.IEntity, FlatRedBall.Math.Geometry.ICollidable, FlatRedBall.Entities.IDamageArea, FlatRedBall.Entities.IDamageable
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
        
        protected global::FlatRedBall.Sprite mSpriteInstance;
        public global::FlatRedBall.Sprite SpriteInstance
        {
            get
            {
                return mSpriteInstance;
            }
            private set
            {
                mSpriteInstance = value;
            }
        }
        protected global::TestProject.Entities.Components.StatsComponent mStatsComponentInstance;
        public global::TestProject.Entities.Components.StatsComponent StatsComponentInstance
        {
            get
            {
                return mStatsComponentInstance;
            }
            private set
            {
                mStatsComponentInstance = value;
            }
        }
        protected global::TestProject.Entities.Components.MovementController mMovementControllerInstance;
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
        protected global::TestProject.Entities.Components.HealthComponent mHealthComponentInstance;
        public global::TestProject.Entities.Components.HealthComponent HealthComponentInstance
        {
            get
            {
                return mHealthComponentInstance;
            }
            private set
            {
                mHealthComponentInstance = value;
            }
        }
        protected global::FlatRedBall.Math.Geometry.Circle mCircleInstance;
        public global::FlatRedBall.Math.Geometry.Circle CircleInstance
        {
            get
            {
                return mCircleInstance;
            }
            private set
            {
                mCircleInstance = value;
            }
        }
        private int mTeamIndex = 1;
        public virtual int TeamIndex
        {
            set
            {
                mTeamIndex = value;
            }
            get
            {
                return mTeamIndex;
            }
        }
        private decimal mMaxHealth = 100m;
        public virtual decimal MaxHealth
        {
            set
            {
                mMaxHealth = value;
            }
            get
            {
                return mMaxHealth;
            }
        }
        private System.Double mInvulnerabilityTimeAfterDamage = 0;
        public virtual System.Double InvulnerabilityTimeAfterDamage
        {
            set
            {
                mInvulnerabilityTimeAfterDamage = value;
            }
            get
            {
                return mInvulnerabilityTimeAfterDamage;
            }
        }
        private System.Double mSecondsBetweenDamage = 0;
        /// <summary>
        /// The number of seconds between dealing damage to the same object. 0 means every frame.
        /// </summary>
        public virtual System.Double SecondsBetweenDamage
        {
            set
            {
                mSecondsBetweenDamage = value;
            }
            get
            {
                return mSecondsBetweenDamage;
            }
        }
        private decimal mDamageToDeal = 10m;
        public virtual decimal DamageToDeal
        {
            set
            {
                mDamageToDeal = value;
            }
            get
            {
                return mDamageToDeal;
            }
        }
        private TestProject.DataTypes.EnemyData mMonsterData;
        public virtual TestProject.DataTypes.EnemyData MonsterData
        {
            set
            {
                mMonsterData = value;
            }
            get
            {
                return mMonsterData;
            }
        }
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
        public string EditModeType { get; set; } = "TestProject.Entities.Monsters.BaseMonster";
        public Action<decimal, FlatRedBall.Entities.IDamageable> ReactToDamageDealt { get; set; }
        public Func<decimal, FlatRedBall.Entities.IDamageable, decimal> ModifyDamageDealt { get; set; }
        public object DamageDealer { get; set; }
        public event Action Destroyed;
        public Action<decimal, FlatRedBall.Entities.IDamageable> KilledDamageable { get; set; }
        public Action<FlatRedBall.Entities.IDamageable> RemovedByCollision { get; set; }
        public bool IsDamageDealingEnabled { get; set; } = true;
        public System.Collections.Generic.Dictionary<FlatRedBall.Entities.IDamageArea, double> DamageAreaLastDamage { get; set; } = new System.Collections.Generic.Dictionary<FlatRedBall.Entities.IDamageArea, double>();
        public Action<decimal, FlatRedBall.Entities.IDamageArea> ReactToDamageReceived { get; set; }
        public Func<decimal, FlatRedBall.Entities.IDamageArea, decimal> ModifyDamageReceived { get; set; }
        public decimal CurrentHealth { get; set; }
        public Action<decimal, FlatRedBall.Entities.IDamageArea> Died { get; set; }
        public bool IsDamageReceivingEnabled { get; set; } = true;
        public double LastDamageTime { get; set; } = -999;
        protected FlatRedBall.Graphics.Layer LayerProvidedByContainer = null;
        public BaseMonster () 
        	: this(FlatRedBall.Screens.ScreenManager.CurrentScreen.ContentManagerName, true)
        {
        }
        public BaseMonster (string contentManagerName) 
        	: this(contentManagerName, true)
        {
        }
        public BaseMonster (string contentManagerName, bool addToManagers) 
        	: base()
        {
            ContentManagerName = contentManagerName;
            InitializeEntity(addToManagers);
        }
        protected virtual void InitializeEntity (bool addToManagers) 
        {
            LoadStaticContent(ContentManagerName);
            mSpriteInstance = new global::FlatRedBall.Sprite();
            mSpriteInstance.Name = "SpriteInstance";
            mSpriteInstance.CreationSource = "Glue";
            mStatsComponentInstance = new global::TestProject.Entities.Components.StatsComponent(ContentManagerName, false);
            mStatsComponentInstance.Name = "StatsComponentInstance";
            mStatsComponentInstance.CreationSource = "Glue";
            mMovementControllerInstance = new global::TestProject.Entities.Components.MovementController(ContentManagerName, false);
            mMovementControllerInstance.Name = "MovementControllerInstance";
            mMovementControllerInstance.CreationSource = "Glue";
            mHealthComponentInstance = new global::TestProject.Entities.Components.HealthComponent(ContentManagerName, false);
            mHealthComponentInstance.Name = "HealthComponentInstance";
            mHealthComponentInstance.CreationSource = "Glue";
            mCircleInstance = new global::FlatRedBall.Math.Geometry.Circle();
            mCircleInstance.Name = "CircleInstance";
            mCircleInstance.CreationSource = "Glue";
            
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
            FlatRedBall.SpriteManager.AddToLayer(mSpriteInstance, LayerProvidedByContainer);
            mStatsComponentInstance.AddToManagers(LayerProvidedByContainer);
            mMovementControllerInstance.AddToManagers(LayerProvidedByContainer);
            mHealthComponentInstance.AddToManagers(LayerProvidedByContainer);
            CircleInstance.Visible = true;FlatRedBall.Math.Geometry.ShapeManager.AddToLayer(CircleInstance, LayerProvidedByContainer);
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
            
            StatsComponentInstance.Activity();
            MovementControllerInstance.Activity();
            HealthComponentInstance.Activity();
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
                FlatRedBall.SpriteManager.RemoveSprite(SpriteInstance);
            }
            if (StatsComponentInstance != null)
            {
                StatsComponentInstance.Destroy();
                StatsComponentInstance.Detach();
            }
            if (MovementControllerInstance != null)
            {
                MovementControllerInstance.Destroy();
                MovementControllerInstance.Detach();
            }
            if (HealthComponentInstance != null)
            {
                HealthComponentInstance.Destroy();
                HealthComponentInstance.Detach();
            }
            if (CircleInstance != null)
            {
                FlatRedBall.Math.Geometry.ShapeManager.Remove(CircleInstance);
            }
            mGeneratedCollision.RemoveFromManagers(clearThis: true);
            Destroyed?.Invoke();
            CustomDestroy();
        }
        public virtual void PostInitialize () 
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            if (mSpriteInstance.Parent == null)
            {
                mSpriteInstance.CopyAbsoluteToRelative();
                mSpriteInstance.AttachTo(this, false);
            }
            SpriteInstance.TextureScale = 1f;
            if (mStatsComponentInstance.Parent == null)
            {
                mStatsComponentInstance.CopyAbsoluteToRelative();
                mStatsComponentInstance.AttachTo(this, false);
            }
            if (mMovementControllerInstance.Parent == null)
            {
                mMovementControllerInstance.CopyAbsoluteToRelative();
                mMovementControllerInstance.AttachTo(this, false);
            }
            if (mHealthComponentInstance.Parent == null)
            {
                mHealthComponentInstance.CopyAbsoluteToRelative();
                mHealthComponentInstance.AttachTo(this, false);
            }
            if (mCircleInstance.Parent == null)
            {
                mCircleInstance.CopyAbsoluteToRelative();
                mCircleInstance.AttachTo(this, false);
            }
            CircleInstance.Radius = 16f;
            mGeneratedCollision = new FlatRedBall.Math.Geometry.ShapeCollection();
            Collision.Circles.AddOneWay(mCircleInstance);
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
        }
        public virtual void AddToManagersBottomUp (FlatRedBall.Graphics.Layer layerToAddTo) 
        {
            CurrentHealth = MaxHealth;
            AssignCustomVariables(false);
        }
        public virtual void RemoveFromManagers () 
        {
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(this);
            if (SpriteInstance != null)
            {
                FlatRedBall.SpriteManager.RemoveSpriteOneWay(SpriteInstance);
            }
            StatsComponentInstance.RemoveFromManagers();
            MovementControllerInstance.RemoveFromManagers();
            HealthComponentInstance.RemoveFromManagers();
            if (CircleInstance != null)
            {
                FlatRedBall.Math.Geometry.ShapeManager.RemoveOneWay(CircleInstance);
            }
            mGeneratedCollision.RemoveFromManagers(clearThis: false);
        }
        public virtual void AssignCustomVariables (bool callOnContainedElements) 
        {
            if (callOnContainedElements)
            {
                StatsComponentInstance.AssignCustomVariables(true);
                MovementControllerInstance.AssignCustomVariables(true);
                HealthComponentInstance.AssignCustomVariables(true);
            }
            SpriteInstance.TextureScale = 1f;
            CircleInstance.Radius = 16f;
            TeamIndex = 1;
            MaxHealth = 100m;
            InvulnerabilityTimeAfterDamage = 0;
            SecondsBetweenDamage = 0;
            DamageToDeal = 10m;
            MonsterData = null;
        }
        public virtual void ConvertToManuallyUpdated () 
        {
            this.ForceUpdateDependenciesDeep();
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(this);
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(SpriteInstance);
            StatsComponentInstance.ConvertToManuallyUpdated();
            MovementControllerInstance.ConvertToManuallyUpdated();
            HealthComponentInstance.ConvertToManuallyUpdated();
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
                throw new System.Exception( "BaseMonster has been loaded with a Global content manager, then loaded with a non-global.  This can lead to a lot of bugs");
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
                        FlatRedBall.FlatRedBallServices.GetContentManagerByName(ContentManagerName).AddUnloadMethod("BaseMonsterStaticUnload", UnloadStaticContent);
                        mRegisteredUnloads.Add(ContentManagerName);
                    }
                }
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
                        FlatRedBall.FlatRedBallServices.GetContentManagerByName(ContentManagerName).AddUnloadMethod("BaseMonsterStaticUnload", UnloadStaticContent);
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
            }
        }
        [System.Obsolete("Use GetFile instead")]
        public static object GetStaticMember (string memberName) 
        {
            return null;
        }
        public static object GetFile (string memberName) 
        {
            return null;
        }
        object GetMember (string memberName) 
        {
            return null;
        }
        public static void Reload (object whatToReload) 
        {
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
            StatsComponentInstance.SetToIgnorePausing();
            MovementControllerInstance.SetToIgnorePausing();
            HealthComponentInstance.SetToIgnorePausing();
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(CircleInstance);
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
            StatsComponentInstance.MoveToLayer(layerToMoveTo);
            MovementControllerInstance.MoveToLayer(layerToMoveTo);
            HealthComponentInstance.MoveToLayer(layerToMoveTo);
            if (layerToRemoveFrom != null)
            {
                layerToRemoveFrom.Remove(CircleInstance);
            }
            FlatRedBall.Math.Geometry.ShapeManager.AddToLayer(CircleInstance, layerToMoveTo);
            LayerProvidedByContainer = layerToMoveTo;
        }
        partial void CustomActivityEditMode();
    }
    public partial class BaseMonsterVariant
    {
        public string Name { get; set; }
        public override string ToString() {return Name; }
        public Type Type { get; set; }
        public Performance.IEntityFactory Factory { get; set; }
        public Func<string, object> GetFile {get; private set; }
        public Action<string> LoadStaticContent { get; private set; }
        public BaseMonster CreateNew (Microsoft.Xna.Framework.Vector3 position) 
        {
            if (this.Factory != null)
            {
                var toReturn = Factory.CreateNew(position.X, position.Y) as BaseMonster;
                return toReturn;
            }
            else
            {
                return null;
            }
        }
        public BaseMonster CreateNew (float x = 0, float y = 0) 
        {
            if (this.Factory != null)
            {
                var toReturn = Factory.CreateNew(x, y) as BaseMonster;
                return toReturn;
            }
            else
            {
                return null;
            }
        }
        public float X;
        public float Y;
        public float Z;
        public int TeamIndex = 1;
        public decimal MaxHealth = 100m;
        public System.Double InvulnerabilityTimeAfterDamage = 0;
        public System.Double SecondsBetweenDamage = 0;
        public decimal DamageToDeal = 10m;
        public TestProject.DataTypes.EnemyData MonsterData;
        public static BaseMonsterVariant FromName (string name) 
        {
            switch(name)
            {
                case "TestProject.Entities.Monsters.MGulpin":
                case  "MGulpin":
                    return MGulpin;
                case "TestProject.Entities.Monsters.BaseMonster":
                case  "BaseMonster":
                    return BaseMonster;
            }
            return null;
        }
        public static BaseMonsterVariant MGulpin { get; private set; } = new BaseMonsterVariant
        {
            Name = "MGulpin",
            Type = typeof(Entities.Monsters.MGulpin),
            Factory = Factories.MGulpinFactory.Self,
            GetFile = fileName => global::TestProject.Entities.Monsters.MGulpin.GetFile(fileName)  ?? global::TestProject.Entities.Monsters.BaseMonster.GetFile(fileName),
            LoadStaticContent = global::TestProject.Entities.Monsters.MGulpin.LoadStaticContent,
            MonsterData = GlobalContent.EnemyData["Gulpin"],
        }
        ;
        public static BaseMonsterVariant BaseMonster { get; private set; } = new BaseMonsterVariant
        {
            Name = "BaseMonster",
            Type = typeof(Entities.Monsters.BaseMonster),
            GetFile = fileName => global::TestProject.Entities.Monsters.BaseMonster.GetFile(fileName) ,
            LoadStaticContent = global::TestProject.Entities.Monsters.BaseMonster.LoadStaticContent,
            TeamIndex = 1,
            MaxHealth = 100m,
            InvulnerabilityTimeAfterDamage = 0,
            SecondsBetweenDamage = 0,
            DamageToDeal = 10m,
            MonsterData = null,
        }
        ;
        public static List<BaseMonsterVariant> All = new List<BaseMonsterVariant>{
            MGulpin,
        };
    }
}

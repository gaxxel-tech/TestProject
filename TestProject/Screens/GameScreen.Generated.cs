#pragma warning disable
#if ANDROID || IOS || DESKTOP_GL
#define REQUIRES_PRIMARY_THREAD_LOADING
#endif
#define SUPPORTS_GLUEVIEW_2
using Color = Microsoft.Xna.Framework.Color;
using System.Linq;
using FlatRedBall;
using System;
using System.Collections.Generic;
using System.Text;
namespace TestProject.Screens
{
    public abstract partial class GameScreen : FlatRedBall.Screens.Screen
    {
        #if DEBUG
        public static bool HasBeenLoadedWithGlobalContentManager { get; private set; }= false;
        #endif
        
        protected global::FlatRedBall.Math.PositionedObjectList<global::TestProject.Entities.Components.MovementController> MovementControllerList = new global::FlatRedBall.Math.PositionedObjectList<global::TestProject.Entities.Components.MovementController>();
        protected global::FlatRedBall.Math.PositionedObjectList<global::TestProject.Entities.Player> PlayerList = new global::FlatRedBall.Math.PositionedObjectList<global::TestProject.Entities.Player>();
        protected global::FlatRedBall.Math.PositionedObjectList<global::TestProject.Entities.Components.InputController> InputControllerList = new global::FlatRedBall.Math.PositionedObjectList<global::TestProject.Entities.Components.InputController>();
        protected global::FlatRedBall.Math.PositionedObjectList<global::TestProject.Entities.Components.StatsComponent> StatsComponentList = new global::FlatRedBall.Math.PositionedObjectList<global::TestProject.Entities.Components.StatsComponent>();
        protected global::FlatRedBall.Math.PositionedObjectList<global::TestProject.Entities.Components.HealthComponent> HealthComponentList = new global::FlatRedBall.Math.PositionedObjectList<global::TestProject.Entities.Components.HealthComponent>();
        protected global::FlatRedBall.Math.PositionedObjectList<global::TestProject.Entities.Monsters.BaseMonster> BaseMonsterList = new global::FlatRedBall.Math.PositionedObjectList<global::TestProject.Entities.Monsters.BaseMonster>();
        protected global::FlatRedBall.Math.PositionedObjectList<global::TestProject.Entities.Managers.SpawnManager> SpawnManagerList = new global::FlatRedBall.Math.PositionedObjectList<global::TestProject.Entities.Managers.SpawnManager>();
        protected global::FlatRedBall.TileGraphics.LayeredTileMap Map;
        public GameScreen () 
        	: this ("GameScreen")
        {
        }
        public GameScreen (string contentManagerName) 
        	: base (contentManagerName)
        {
            MovementControllerList.Name = "MovementControllerList";
            PlayerList.Name = "PlayerList";
            InputControllerList.Name = "InputControllerList";
            StatsComponentList.Name = "StatsComponentList";
            HealthComponentList.Name = "HealthComponentList";
            BaseMonsterList.Name = "BaseMonsterList";
            SpawnManagerList.Name = "SpawnManagerList";
            // Not instantiating for FlatRedBall.TileGraphics.LayeredTileMap Map in Screens\GameScreen (Screen) because properties on the object prevent it
        }
        public override void Initialize (bool addToManagers) 
        {
            LoadStaticContent(ContentManagerName);
            MovementControllerList?.Clear();
            PlayerList?.Clear();
            InputControllerList?.Clear();
            StatsComponentList?.Clear();
            HealthComponentList?.Clear();
            BaseMonsterList?.Clear();
            SpawnManagerList?.Clear();
            // Not instantiating for FlatRedBall.TileGraphics.LayeredTileMap Map in Screens\GameScreen (Screen) because properties on the object prevent it
            
            
            PostInitialize();
            base.Initialize(addToManagers);
            this.Name = "GameScreen";
            if (addToManagers)
            {
                AddToManagers();
            }
        }
        public override void AddToManagers () 
        {
            mAccumulatedPausedTime = TimeManager.CurrentTime;
            mTimeScreenWasCreated = FlatRedBall.TimeManager.CurrentTime;
            InitializeFactoriesAndSorting();
            var Map_gameplayLayer = Map.MapLayers.FindByName("GameplayLayer");
            if (Map_gameplayLayer != null)
            {
                Map_gameplayLayer.ForceUpdateDependencies();
                // What if the map's Z isn't 0? Add its Z to make up for that
                Map.Z = Map.Z - Map_gameplayLayer.Z;
            }
            CustomBeforeCreateEntitiesFromTiles(Map);
            FlatRedBall.TileEntities.TileEntityInstantiator.CreateEntitiesFrom(Map);
            base.AddToManagers();
            AddToManagersBottomUp();
            BeforeCustomInitialize?.Invoke();
            GlueControl.InstanceLogic.Self.ApplyEditorCommandsToNewEntity(null, GlueControl.CommandReceiver.GameElementTypeToGlueElement(this.GetType().FullName));
            CustomInitialize();
        }
        public override void Activity (bool firstTimeCalled) 
        {
            if (!IsPaused)
            {
                
                for (int i = MovementControllerList.Count - 1; i > -1; i--)
                {
                    if (i < MovementControllerList.Count)
                    {
                        // We do the extra if-check because activity could destroy any number of entities
                        MovementControllerList[i].Activity();
                    }
                }
                for (int i = PlayerList.Count - 1; i > -1; i--)
                {
                    if (i < PlayerList.Count)
                    {
                        // We do the extra if-check because activity could destroy any number of entities
                        PlayerList[i].Activity();
                    }
                }
                for (int i = InputControllerList.Count - 1; i > -1; i--)
                {
                    if (i < InputControllerList.Count)
                    {
                        // We do the extra if-check because activity could destroy any number of entities
                        InputControllerList[i].Activity();
                    }
                }
                for (int i = StatsComponentList.Count - 1; i > -1; i--)
                {
                    if (i < StatsComponentList.Count)
                    {
                        // We do the extra if-check because activity could destroy any number of entities
                        StatsComponentList[i].Activity();
                    }
                }
                for (int i = HealthComponentList.Count - 1; i > -1; i--)
                {
                    if (i < HealthComponentList.Count)
                    {
                        // We do the extra if-check because activity could destroy any number of entities
                        HealthComponentList[i].Activity();
                    }
                }
                for (int i = BaseMonsterList.Count - 1; i > -1; i--)
                {
                    if (i < BaseMonsterList.Count)
                    {
                        // We do the extra if-check because activity could destroy any number of entities
                        BaseMonsterList[i].Activity();
                    }
                }
                for (int i = SpawnManagerList.Count - 1; i > -1; i--)
                {
                    if (i < SpawnManagerList.Count)
                    {
                        // We do the extra if-check because activity could destroy any number of entities
                        SpawnManagerList[i].Activity();
                    }
                }
            }
            else
            {
            }
            base.Activity(firstTimeCalled);
            if (!IsActivityFinished)
            {
                CustomActivity(firstTimeCalled);
            }
        }
        public override void ActivityEditMode () 
        {
            if (FlatRedBall.Screens.ScreenManager.IsInEditMode)
            {
                for (int i = FlatRedBall.SpriteManager.ManagedPositionedObjects.Count - 1; i > -1; i--)
                {
                    var item = FlatRedBall.SpriteManager.ManagedPositionedObjects[i];
                    if (item is FlatRedBall.Entities.IEntity entity)
                    {
                        entity.ActivityEditMode();
                    }
                }
                CustomActivityEditMode();
                base.ActivityEditMode();
            }
        }
        public override void Destroy () 
        {
            base.Destroy();
            Factories.MovementControllerFactory.Destroy();
            Factories.MovementControllerFactory.DefaultLayer = null;
            Factories.PlayerFactory.Destroy();
            Factories.PlayerFactory.DefaultLayer = null;
            Factories.InputControllerFactory.Destroy();
            Factories.InputControllerFactory.DefaultLayer = null;
            Factories.StatsComponentFactory.Destroy();
            Factories.StatsComponentFactory.DefaultLayer = null;
            Factories.HealthComponentFactory.Destroy();
            Factories.HealthComponentFactory.DefaultLayer = null;
            Factories.MGulpinFactory.Destroy();
            Factories.MGulpinFactory.DefaultLayer = null;
            Factories.SpawnManagerFactory.Destroy();
            Factories.SpawnManagerFactory.DefaultLayer = null;
            
            for (int i = MovementControllerList.Count - 1; i > -1; i--)
            {
                MovementControllerList[i].Destroy();
            }
            for (int i = PlayerList.Count - 1; i > -1; i--)
            {
                PlayerList[i].Destroy();
            }
            for (int i = InputControllerList.Count - 1; i > -1; i--)
            {
                InputControllerList[i].Destroy();
            }
            for (int i = StatsComponentList.Count - 1; i > -1; i--)
            {
                StatsComponentList[i].Destroy();
            }
            for (int i = HealthComponentList.Count - 1; i > -1; i--)
            {
                HealthComponentList[i].Destroy();
            }
            for (int i = BaseMonsterList.Count - 1; i > -1; i--)
            {
                BaseMonsterList[i].Destroy();
            }
            for (int i = SpawnManagerList.Count - 1; i > -1; i--)
            {
                SpawnManagerList[i].Destroy();
            }
            FlatRedBall.Math.Collision.CollisionManager.Self.Relationships.Clear();
            CustomDestroy();
        }
        public virtual void PostInitialize () 
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            if (Map!= null)
            {
            }
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
        }
        public virtual void AddToManagersBottomUp () 
        {
            CameraSetup.ResetCamera(SpriteManager.Camera);
            AssignCustomVariables(false);
        }
        public virtual void RemoveFromManagers () 
        {
            for (int i = MovementControllerList.Count - 1; i > -1; i--)
            {
                MovementControllerList[i].Destroy();
            }
            for (int i = PlayerList.Count - 1; i > -1; i--)
            {
                PlayerList[i].Destroy();
            }
            for (int i = InputControllerList.Count - 1; i > -1; i--)
            {
                InputControllerList[i].Destroy();
            }
            for (int i = StatsComponentList.Count - 1; i > -1; i--)
            {
                StatsComponentList[i].Destroy();
            }
            for (int i = HealthComponentList.Count - 1; i > -1; i--)
            {
                HealthComponentList[i].Destroy();
            }
            for (int i = BaseMonsterList.Count - 1; i > -1; i--)
            {
                BaseMonsterList[i].Destroy();
            }
            for (int i = SpawnManagerList.Count - 1; i > -1; i--)
            {
                SpawnManagerList[i].Destroy();
            }
        }
        public virtual void AssignCustomVariables (bool callOnContainedElements) 
        {
            if (callOnContainedElements)
            {
            }
            if (Map != null)
            {
            }
            
        }
        public virtual void ConvertToManuallyUpdated () 
        {
            for (int i = 0; i < MovementControllerList.Count; i++)
            {
                MovementControllerList[i].ConvertToManuallyUpdated();
            }
            for (int i = 0; i < PlayerList.Count; i++)
            {
                PlayerList[i].ConvertToManuallyUpdated();
            }
            for (int i = 0; i < InputControllerList.Count; i++)
            {
                InputControllerList[i].ConvertToManuallyUpdated();
            }
            for (int i = 0; i < StatsComponentList.Count; i++)
            {
                StatsComponentList[i].ConvertToManuallyUpdated();
            }
            for (int i = 0; i < HealthComponentList.Count; i++)
            {
                HealthComponentList[i].ConvertToManuallyUpdated();
            }
            for (int i = 0; i < BaseMonsterList.Count; i++)
            {
                BaseMonsterList[i].ConvertToManuallyUpdated();
            }
            for (int i = 0; i < SpawnManagerList.Count; i++)
            {
                SpawnManagerList[i].ConvertToManuallyUpdated();
            }
            if (Map != null)
            {
            }
        }
        public static void LoadStaticContent (string contentManagerName) 
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            if (string.IsNullOrEmpty(contentManagerName))
            {
                throw new System.ArgumentException("contentManagerName cannot be empty or null");
            }
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
                throw new System.Exception( "GameScreen has been loaded with a Global content manager, then loaded with a non-global.  This can lead to a lot of bugs");
            }
            #endif
            CustomLoadStaticContent(contentManagerName);
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
        }
        public override void PauseThisScreen () 
        {
            StateInterpolationPlugin.TweenerManager.Self.Pause();
            base.PauseThisScreen();
        }
        public override void UnpauseThisScreen () 
        {
            StateInterpolationPlugin.TweenerManager.Self.Unpause();
            base.UnpauseThisScreen();
        }
        private void InitializeFactoriesAndSorting () 
        {
            Factories.MovementControllerFactory.Initialize(ContentManagerName);
            Factories.MovementControllerFactory.DefaultLayer = this.DefaultLayer;
            Factories.PlayerFactory.Initialize(ContentManagerName);
            Factories.PlayerFactory.DefaultLayer = this.DefaultLayer;
            Factories.InputControllerFactory.Initialize(ContentManagerName);
            Factories.InputControllerFactory.DefaultLayer = this.DefaultLayer;
            Factories.StatsComponentFactory.Initialize(ContentManagerName);
            Factories.StatsComponentFactory.DefaultLayer = this.DefaultLayer;
            Factories.HealthComponentFactory.Initialize(ContentManagerName);
            Factories.HealthComponentFactory.DefaultLayer = this.DefaultLayer;
            Factories.MGulpinFactory.Initialize(ContentManagerName);
            Factories.MGulpinFactory.DefaultLayer = this.DefaultLayer;
            Factories.SpawnManagerFactory.Initialize(ContentManagerName);
            Factories.SpawnManagerFactory.DefaultLayer = this.DefaultLayer;
            Factories.MovementControllerFactory.AddList(MovementControllerList);
            Factories.PlayerFactory.AddList(PlayerList);
            Factories.InputControllerFactory.AddList(InputControllerList);
            Factories.StatsComponentFactory.AddList(StatsComponentList);
            Factories.HealthComponentFactory.AddList(HealthComponentList);
            Factories.MGulpinFactory.AddList(BaseMonsterList);
            Factories.SpawnManagerFactory.AddList(SpawnManagerList);
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
        partial void CustomBeforeCreateEntitiesFromTiles(FlatRedBall.TileGraphics.LayeredTileMap layeredTileMap);
        partial void CustomActivityEditMode();
    }
    public partial class GameScreenVariant
    {
        public string Name { get; set; }
        public override string ToString() {return Name; }
        public Type Type { get; set; }
        public Performance.IEntityFactory Factory { get; set; }
        public Func<string, object> GetFile {get; private set; }
        public Action<string> LoadStaticContent { get; private set; }
        public GameScreen CreateNew (Microsoft.Xna.Framework.Vector3 position) 
        {
            if (this.Factory != null)
            {
                var toReturn = Factory.CreateNew(position.X, position.Y) as GameScreen;
                return toReturn;
            }
            else
            {
                return null;
            }
        }
        public GameScreen CreateNew (float x = 0, float y = 0) 
        {
            if (this.Factory != null)
            {
                var toReturn = Factory.CreateNew(x, y) as GameScreen;
                return toReturn;
            }
            else
            {
                return null;
            }
        }
        public static GameScreenVariant FromName (string name) 
        {
            switch(name)
            {
                case "TestProject.Screens.Level1":
                case  "Level1":
                    return Level1;
                case "TestProject.Screens.GameScreen":
                case  "GameScreen":
                    return GameScreen;
            }
            return null;
        }
        public static GameScreenVariant Level1 { get; private set; } = new GameScreenVariant
        {
            Name = "Level1",
            Type = typeof(Screens.Level1),
            GetFile = fileName => global::TestProject.Screens.Level1.GetFile(fileName)  ?? global::TestProject.Screens.GameScreen.GetFile(fileName),
            LoadStaticContent = global::TestProject.Screens.Level1.LoadStaticContent,
        }
        ;
        public static GameScreenVariant GameScreen { get; private set; } = new GameScreenVariant
        {
            Name = "GameScreen",
            Type = typeof(Screens.GameScreen),
            GetFile = fileName => global::TestProject.Screens.GameScreen.GetFile(fileName) ,
            LoadStaticContent = global::TestProject.Screens.GameScreen.LoadStaticContent,
        }
        ;
        public static List<GameScreenVariant> All = new List<GameScreenVariant>{
            Level1,
        };
    }
}

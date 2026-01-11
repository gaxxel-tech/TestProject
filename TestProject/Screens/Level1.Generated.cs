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
    public partial class Level1 : Screens.GameScreen
    {
        #if DEBUG
        public static bool HasBeenLoadedWithGlobalContentManager { get; private set; }= false;
        #endif
        protected static global::FlatRedBall.TileGraphics.LayeredTileMap Map1;
        
        private global::TestProject.Entities.Player Player1;
        private global::TestProject.Entities.Managers.SpawnManager SpawnManager1;
        private global::FlatRedBall.Entities.CameraControllingEntity CameraControllingEntityInstance;
        private global::FlatRedBall.Math.Collision.ListVsListRelationship<Entities.Monsters.BaseMonster, Entities.Monsters.BaseMonster> MonsterVsMonster;
        public Level1 () 
        	: this ("Level1")
        {
        }
        public Level1 (string contentManagerName) 
        	: base (contentManagerName)
        {
            // skipping instantiation of FlatRedBall.Math.PositionedObjectList<Player> PlayerList in Screens\Level1 (Screen) because it has its InstantiatedByBase set to true
            // skipping instantiation of FlatRedBall.Math.PositionedObjectList<InputController> InputControllerList in Screens\Level1 (Screen) because it has its InstantiatedByBase set to true
            // skipping instantiation of FlatRedBall.Math.PositionedObjectList<StatsComponent> StatsComponentList in Screens\Level1 (Screen) because it has its InstantiatedByBase set to true
            // skipping instantiation of FlatRedBall.Math.PositionedObjectList<HealthComponent> HealthComponentList in Screens\Level1 (Screen) because it has its InstantiatedByBase set to true
            // skipping instantiation of FlatRedBall.Math.PositionedObjectList<BaseMonster> BaseMonsterList in Screens\Level1 (Screen) because it has its InstantiatedByBase set to true
            // skipping instantiation of FlatRedBall.Math.PositionedObjectList<SpawnManager> SpawnManagerList in Screens\Level1 (Screen) because it has its InstantiatedByBase set to true
            // skipping instantiation of FlatRedBall.Math.PositionedObjectList<MovementController> MovementControllerList in Screens\Level1 (Screen) because it has its InstantiatedByBase set to true
        }
        public override void Initialize (bool addToManagers) 
        {
            LoadStaticContent(ContentManagerName);
            Map = new global::FlatRedBall.TileGraphics.LayeredTileMap();
            Map.Name = "Map";
            // skipping instantiation of FlatRedBall.Math.PositionedObjectList<Player> PlayerList in Screens\Level1 (Screen) because it has its InstantiatedByBase set to true
            Player1 = new global::TestProject.Entities.Player(ContentManagerName, false);
            Player1.Name = "Player1";
            Player1.CreationSource = "Glue";
            // skipping instantiation of FlatRedBall.Math.PositionedObjectList<InputController> InputControllerList in Screens\Level1 (Screen) because it has its InstantiatedByBase set to true
            // skipping instantiation of FlatRedBall.Math.PositionedObjectList<StatsComponent> StatsComponentList in Screens\Level1 (Screen) because it has its InstantiatedByBase set to true
            // skipping instantiation of FlatRedBall.Math.PositionedObjectList<HealthComponent> HealthComponentList in Screens\Level1 (Screen) because it has its InstantiatedByBase set to true
            // skipping instantiation of FlatRedBall.Math.PositionedObjectList<BaseMonster> BaseMonsterList in Screens\Level1 (Screen) because it has its InstantiatedByBase set to true
            // skipping instantiation of FlatRedBall.Math.PositionedObjectList<SpawnManager> SpawnManagerList in Screens\Level1 (Screen) because it has its InstantiatedByBase set to true
            SpawnManager1 = new global::TestProject.Entities.Managers.SpawnManager(ContentManagerName, false);
            SpawnManager1.Name = "SpawnManager1";
            SpawnManager1.CreationSource = "Glue";
            CameraControllingEntityInstance = new global::FlatRedBall.Entities.CameraControllingEntity();
            CameraControllingEntityInstance.Name = "CameraControllingEntityInstance";
            CameraControllingEntityInstance.CreationSource = "Glue";
            // skipping instantiation of FlatRedBall.Math.PositionedObjectList<MovementController> MovementControllerList in Screens\Level1 (Screen) because it has its InstantiatedByBase set to true
            FlatRedBall.Math.Collision.CollisionManager.Self.BeforeCollision += HandleBeforeCollisionGenerated;
            MonsterVsMonster = FlatRedBall.Math.Collision.CollisionManager.Self.CreateRelationship(BaseMonsterList, BaseMonsterList);
MonsterVsMonster.SetFirstSubCollision(item => item.CircleInstance, "CircleInstance");
MonsterVsMonster.SetSecondSubCollision(item => item.CircleInstance, "CircleInstance");
MonsterVsMonster.CollisionLimit = FlatRedBall.Math.Collision.CollisionLimit.All;
MonsterVsMonster.ListVsListLoopingMode = FlatRedBall.Math.Collision.ListVsListLoopingMode.PreventDoubleChecksPerFrame;
MonsterVsMonster.Name = "MonsterVsMonster";
MonsterVsMonster.SetMoveSoftCollision(1f, 1f, 10f);

            
            
            base.Initialize(addToManagers);
            this.Name = "Level1";
        }
        public override void AddToManagers () 
        {
            mAccumulatedPausedTime = TimeManager.CurrentTime;
            mTimeScreenWasCreated = FlatRedBall.TimeManager.CurrentTime;
            Map1.AddToManagers(mLayer);
            InitializeFactoriesAndSorting();
            Map.AddToManagers();
            Player1.AddToManagers(mLayer);
            SpawnManager1.AddToManagers(mLayer);
            FlatRedBall.SpriteManager.AddPositionedObject(CameraControllingEntityInstance); CameraControllingEntityInstance.Activity();
            base.AddToManagers();
            CustomInitialize();
        }
        public override void Activity (bool firstTimeCalled) 
        {
            if (!IsPaused)
            {
                
                Map1?.AnimateSelf();;
                Map?.AnimateSelf();;
                CameraControllingEntityInstance.Activity();
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
                CustomActivityEditMode();
                base.ActivityEditMode();
            }
        }
        public override void Destroy () 
        {
            base.Destroy();
            Map1.Destroy();
            Map1 = null;
            
            if (Map != null)
            {
                Map.Destroy();
            }
            if (CameraControllingEntityInstance != null)
            {
                FlatRedBall.SpriteManager.RemovePositionedObject(CameraControllingEntityInstance);;
            }
            FlatRedBall.Math.Collision.CollisionManager.Self.BeforeCollision -= HandleBeforeCollisionGenerated;
            FlatRedBall.Math.Collision.CollisionManager.Self.Relationships.Clear();
            CustomDestroy();
        }
        public override void PostInitialize () 
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            base.PostInitialize();
            if (Map!= null)
            {
            }
            if (PlayerList!= null)
            {
                if (!PlayerList.Contains(Player1))
                {
                    PlayerList.Add(Player1);
                }
                if (Player1.Parent == null)
                {
                    Player1.X = 20f;
                }
                else
                {
                    Player1.RelativeX = 20f;
                }
            }
            if (InputControllerList!= null)
            {
            }
            if (StatsComponentList!= null)
            {
            }
            if (HealthComponentList!= null)
            {
            }
            if (BaseMonsterList!= null)
            {
            }
            if (SpawnManagerList!= null)
            {
                if (!SpawnManagerList.Contains(SpawnManager1))
                {
                    SpawnManagerList.Add(SpawnManager1);
                }
            }
            CameraControllingEntityInstance.Targets.Clear(); CameraControllingEntityInstance.Targets.Add(Player1);
            if (MovementControllerList!= null)
            {
            }
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
        }
        public override void AddToManagersBottomUp () 
        {
            base.AddToManagersBottomUp();
        }
        public override void RemoveFromManagers () 
        {
            base.RemoveFromManagers();
            Map1.Destroy();
            if (Map != null)
            {
                Map.Destroy();
            }
            if (CameraControllingEntityInstance != null)
            {
                FlatRedBall.SpriteManager.RemovePositionedObject(CameraControllingEntityInstance);;
            }
        }
        public override void AssignCustomVariables (bool callOnContainedElements) 
        {
            base.AssignCustomVariables(callOnContainedElements);
            if (callOnContainedElements)
            {
                Player1.AssignCustomVariables(true);
                SpawnManager1.AssignCustomVariables(true);
            }
            if (Player1.Parent == null)
            {
                Player1.X = 20f;
            }
            else
            {
                Player1.RelativeX = 20f;
            }
            CameraControllingEntityInstance.Targets.Clear(); CameraControllingEntityInstance.Targets.Add(Player1);
            
        }
        public override void ConvertToManuallyUpdated () 
        {
            base.ConvertToManuallyUpdated();
        }
        public static new void LoadStaticContent (string contentManagerName) 
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            if (string.IsNullOrEmpty(contentManagerName))
            {
                throw new System.ArgumentException("contentManagerName cannot be empty or null");
            }
            global::TestProject.Screens.GameScreen.LoadStaticContent(contentManagerName);
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
                throw new System.Exception( "Level1 has been loaded with a Global content manager, then loaded with a non-global.  This can lead to a lot of bugs");
            }
            #endif
            Map1 = FlatRedBall.TileGraphics.LayeredTileMap.FromTiledMapSave("Content/Screens/Level1/Map1.tmx", contentManagerName);
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
        }
        [System.Obsolete("Use GetFile instead")]
        public static new object GetStaticMember (string memberName) 
        {
            switch(memberName)
            {
                case  "Map1":
                    return Map1;
            }
            return null;
        }
        public static new object GetFile (string memberName) 
        {
            switch(memberName)
            {
                case  "Map1":
                    return Map1;
            }
            return null;
        }
        object GetMember (string memberName) 
        {
            switch(memberName)
            {
                case  "Map1":
                    return Map1;
            }
            return null;
        }
        public static void Reload (object whatToReload) 
        {
        }
        void HandleBeforeCollisionGenerated () 
        {
        }
        partial void CustomActivityEditMode();
    }
}

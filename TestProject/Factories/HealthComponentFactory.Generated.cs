using TestProject.Entities.Components;
using System;
using FlatRedBall.Math;
using FlatRedBall.Graphics;
using TestProject.Performance;

namespace TestProject.Factories
{
    public class HealthComponentFactory : IEntityFactory
    {
        public static FlatRedBall.Math.Axis? SortAxis { get; set;}
        public static Layer DefaultLayer { get; set; }
        /// <summary>
        /// Creates a new HealthComponent using either the explicit positon values, or the default position of the entity.
        /// </summary>
        /// <param name="x">The optional X position</param>
        /// <param name="y">The optional Y position</param>
        /// <param name="z">The optional Z position</param>
        /// <returns>The newly-created instance</returns>
        public static HealthComponent CreateNew (float? x = null, float? y = null, float? z = null) 
        {
            return CreateNew(DefaultLayer, x, y, z);
        }
        public static HealthComponent CreateNew (Microsoft.Xna.Framework.Vector3 position) 
        {
            return CreateNew(DefaultLayer, position.X, position.Y, position.Z);
        }
        public static HealthComponent CreateNew (Microsoft.Xna.Framework.Vector2 position) 
        {
            return CreateNew(DefaultLayer, position.X, position.Y, 0);
        }
        public static HealthComponent CreateNew (Layer layer, Microsoft.Xna.Framework.Vector3 position) 
        {
            return CreateNew(layer , position.X, position.Y, position.Z);
        }
        public static HealthComponent CreateNew (Layer layer, float? x = null, float? y = null, float? z = null) 
        {
            HealthComponent instance = null;
            instance = new HealthComponent(mContentManagerName ?? FlatRedBall.Screens.ScreenManager.CurrentScreen.ContentManagerName, false);
            instance.AddToManagers(layer);
            NewInstancesCreatedThisScreen++;
            if (x != null) instance.X = x.Value;
            if (y != null) instance.Y = y.Value;
            if (z != null) instance.Z = z.Value;
            foreach (var list in ListsToAddTo)
            {
                if (SortAxis == FlatRedBall.Math.Axis.X && list is PositionedObjectList<HealthComponent>)
                {
                    var index = (list as PositionedObjectList<HealthComponent>).GetFirstAfter(instance.Position.X, Axis.X, 0, list.Count);
                    list.Insert(index, instance);
                }
                else if (SortAxis == FlatRedBall.Math.Axis.Y && list is PositionedObjectList<HealthComponent>)
                {
                    var index = (list as PositionedObjectList<HealthComponent>).GetFirstAfter(instance.Position.Y, Axis.Y, 0, list.Count);
                    list.Insert(index, instance);
                }
                else
                {
                    // Sort Z not supported
                    list.Add(instance);
                }
            }
            if (EntitySpawned != null)
            {
                EntitySpawned(instance);
            }
            return instance;
        }
        
        public static void Initialize (string contentManager) 
        {
            mContentManagerName = contentManager;
        }
        
        public static void Destroy () 
        {
            mContentManagerName = null;
            ListsToAddTo.Clear();
            SortAxis = null;
            NewInstancesCreatedThisScreen = 0;
            EntitySpawned = null;
        }
        void IEntityFactory.Destroy() => Destroy();
        
        private static void FactoryInitialize () 
        {
        }
        
        /// <summary>
        /// Makes the argument objectToMakeUnused marked as unused.  This method is generated to be used
        /// by generated code.  Use Destroy instead when writing custom code so that your code will behave
        /// the same whether your Entity is pooled or not.
        /// </summary>
        public static void MakeUnused (HealthComponent objectToMakeUnused) 
        {
            MakeUnused(objectToMakeUnused, true);
        }
        
        /// <summary>
        /// Makes the argument objectToMakeUnused marked as unused.  This method is generated to be used
        /// by generated code.  Use Destroy instead when writing custom code so that your code will behave
        /// the same whether your Entity is pooled or not.
        /// </summary>
        public static void MakeUnused (HealthComponent objectToMakeUnused, bool callDestroy) 
        {
            if (callDestroy)
            {
                objectToMakeUnused.Destroy();
            }
        }
        
        public static void AddList<T> (System.Collections.Generic.IList<T> newList) where T : HealthComponent
        {
            ListsToAddTo.Add(newList as System.Collections.IList);
        }
        public static void RemoveList<T> (System.Collections.Generic.IList<T> listToRemove) where T : HealthComponent
        {
            ListsToAddTo.Remove(listToRemove as System.Collections.IList);
        }
        public static void ClearListsToAddTo () 
        {
            ListsToAddTo.Clear();
        }
        
        
        static string mContentManagerName;
        static System.Collections.Generic.List<System.Collections.IList> ListsToAddTo = new System.Collections.Generic.List<System.Collections.IList>();
        public static int NewInstancesCreatedThisScreen;
        int IEntityFactory.NewInstancesCreatedThisScreen => NewInstancesCreatedThisScreen;
        /// <summary> Event raised whenever an instance is created through this factory.
        /// These events are cleared out whenever a Screen is destroyed, so there is 
        /// no reason to explicitly remove added events. </summary>
        public static event Action<HealthComponent> EntitySpawned;
        object IEntityFactory.CreateNew (float x, float y) 
        {
            return HealthComponentFactory.CreateNew(x, y);
        }
        object IEntityFactory.CreateNew (Microsoft.Xna.Framework.Vector3 position) 
        {
            return HealthComponentFactory.CreateNew(position);
        }
        object IEntityFactory.CreateNew (Layer layer) 
        {
            return HealthComponentFactory.CreateNew(layer);
        }
        void IEntityFactory.Initialize (string contentManagerName) 
        {
            HealthComponentFactory.Initialize(contentManagerName);
        }
        void IEntityFactory.ClearListsToAddTo () 
        {
            HealthComponentFactory.ClearListsToAddTo();
        }
        System.Collections.Generic.List<System.Collections.IList> IEntityFactory.ListsToAddTo => HealthComponentFactory.ListsToAddTo;
        static HealthComponentFactory mSelf;
        public static HealthComponentFactory Self
        {
            get
            {
                if (mSelf == null)
                {
                    mSelf = new HealthComponentFactory();
                }
                return mSelf;
            }
        }
    }
}

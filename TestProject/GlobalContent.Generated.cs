#if ANDROID || IOS || DESKTOP_GL || WEB
// Android doesn't allow background loading. iOS doesn't allow background rendering (which is used by converting textures to use premult alpha)
#define REQUIRES_PRIMARY_THREAD_LOADING
#endif
using System.Collections.Generic;
using System.Threading;
using FlatRedBall;
using FlatRedBall.Math.Geometry;
using FlatRedBall.ManagedSpriteGroups;
using FlatRedBall.Graphics.Animation;
using FlatRedBall.Graphics.Particle;
using FlatRedBall.AI.Pathfinding;
using FlatRedBall.Utilities;
using BitmapFont = FlatRedBall.Graphics.BitmapFont;
using FlatRedBall.Localization;
using TestProject.DataTypes;
using FlatRedBall.IO.Csv;

namespace TestProject
{
    public static partial class GlobalContent
    {
        
        public static global::FlatRedBall.Gum.GumIdb GumProject { get; set; }
        public static global::System.Collections.Generic.Dictionary<string, global::TestProject.DataTypes.EnemyData> EnemyData { get; set; }
        [System.Obsolete("Use GetFile instead")]
        public static object GetStaticMember (string memberName) 
        {
            switch(memberName)
            {
                case  "GumProject":
                    return GumProject;
                case  "EnemyData":
                    return EnemyData;
            }
            return null;
        }
        public static object GetFile (string memberName) 
        {
            switch(memberName)
            {
                case  "GumProject":
                    return GumProject;
                case  "EnemyData":
                    return EnemyData;
            }
            return null;
        }
        public static bool IsInitialized { get; private set; }
        public static bool ShouldStopLoading { get; set; }
        const string ContentManagerName = "Global";
        public static void Initialize () 
        {
            
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            // Added by GumPlugin becasue of the Show Mouse checkbox on the .gumx:
            FlatRedBall.FlatRedBallServices.Game.IsMouseVisible = true;
            // Set the content manager for Gum
            var contentManagerWrapper = new FlatRedBall.Gum.ContentManagerWrapper();
            contentManagerWrapper.ContentManagerName = FlatRedBall.FlatRedBallServices.GlobalContentManager;
            RenderingLibrary.Content.LoaderManager.Self.ContentLoader = contentManagerWrapper;
            FlatRedBall.Gum.GumIdb.StaticInitialize("Content/GumProject/GumProject.gumx"); FlatRedBall.Gum.GumIdbExtensions.RegisterTypes();  FlatRedBall.Gui.GuiManager.BringsClickedWindowsToFront = false;FlatRedBall.Gum.GumIdb.FixedCanvasAspectRatio = null;Gum.Wireframe.GraphicalUiElement.ShowLineRectangles = false;
            if (EnemyData == null)
            {
                {
                    // We put the { and } to limit the scope of oldDelimiter
                    char oldDelimiter = FlatRedBall.IO.Csv.CsvFileManager.Delimiter;
                    FlatRedBall.IO.Csv.CsvFileManager.Delimiter = ',';
                    System.Collections.Generic.Dictionary<string, global::TestProject.DataTypes.EnemyData> temporaryCsvObject = new System.Collections.Generic.Dictionary<string, global::TestProject.DataTypes.EnemyData>();
                    FlatRedBall.IO.Csv.CsvFileManager.CsvDeserializeDictionary<string, global::TestProject.DataTypes.EnemyData>("Content/GlobalContent/EnemyData.csv", temporaryCsvObject, FlatRedBall.IO.Csv.DuplicateDictionaryEntryBehavior.Replace);
                    FlatRedBall.IO.Csv.CsvFileManager.Delimiter = oldDelimiter;
                    EnemyData = temporaryCsvObject;
                }
            }
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
            			IsInitialized = true;
            #if DEBUG && WINDOWS
            InitializeFileWatch();
            #endif
        }
        public static void Reload (object whatToReload) 
        {
            if (whatToReload == EnemyData)
            {
                FlatRedBall.IO.Csv.CsvFileManager.UpdateDictionaryValuesFromCsv(EnemyData, "content/globalcontent/enemydata.csv");
            }
        }
        #if DEBUG && WINDOWS
        static System.IO.FileSystemWatcher watcher;
        private static void InitializeFileWatch () 
        {
            string globalContent = FlatRedBall.IO.FileManager.RelativeDirectory + "content/globalcontent/";
            if (System.IO.Directory.Exists(globalContent))
            {
                watcher = new System.IO.FileSystemWatcher();
                watcher.Path = globalContent;
                watcher.NotifyFilter = System.IO.NotifyFilters.LastWrite;
                watcher.Filter = "*.*";
                watcher.Changed += HandleFileChanged;
                watcher.EnableRaisingEvents = true;
            }
        }
        private static void HandleFileChanged (object sender, System.IO.FileSystemEventArgs e) 
        {
            try
            {
                System.Threading.Thread.Sleep(500);
                var fullFileName = e.FullPath;
                var relativeFileName = FlatRedBall.IO.FileManager.MakeRelative(FlatRedBall.IO.FileManager.Standardize(fullFileName));
                if (relativeFileName == "Content/GumProject/GumProject.gumx")
                {
                    Reload(GumProject);
                }
            }
            catch{}
        }
        #endif
        
        
    }
}

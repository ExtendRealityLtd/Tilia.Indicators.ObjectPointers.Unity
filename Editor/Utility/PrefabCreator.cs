namespace Tilia.Indicators.ObjectPointers.Utility
{
    using System.IO;
    using UnityEditor;
    using Zinnia.Utility;

    public class PrefabCreator : BasePrefabCreator
    {
        private const string group = "Tilia/";
        private const string project = "Indicators/ObjectPointers/";
        private const string menuItemRoot = topLevelMenuLocation + group + subLevelMenuLocation + project;

        private const string package = "io.extendreality.tilia.indicators.objectpointers.unity";
        private const string baseDirectory = "Runtime";
        private const string prefabDirectory = "Prefabs";
        private const string prefabSuffix = ".prefab";

        private const string prefabObjectPointersStraight = "Indicators.ObjectPointers.Straight";
        private const string prefabObjectPointersCurved = "Indicators.ObjectPointers.Curved";

        [MenuItem(menuItemRoot + prefabObjectPointersStraight, false, priority)]
        private static void AddObjectPointersStraight()
        {
            string prefab = prefabObjectPointersStraight + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, prefab);
            CreatePrefab(packageLocation);
        }

        [MenuItem(menuItemRoot + prefabObjectPointersCurved, false, priority)]
        private static void AddObjectPointersCurved()
        {
            string prefab = prefabObjectPointersCurved + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, prefab);
            CreatePrefab(packageLocation);
        }
    }
}
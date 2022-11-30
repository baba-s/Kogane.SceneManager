using System.Collections.Generic;
using UnityEngine.SceneManagement;

namespace Kogane
{
    /// <summary>
    /// SceneManager に関する処理をまとめたクラス
    /// </summary>
    public static class KoganeSceneManager
    {
        //================================================================================
        // 関数(static)
        //================================================================================
        /// <summary>
        /// 現在読み込まれているすべてのシーンを返します
        /// </summary>
        public static IEnumerable<Scene> GetAllScenes()
        {
            var sceneCount = SceneManager.sceneCount;

            for ( var i = 0; i < sceneCount; i++ )
            {
                yield return SceneManager.GetSceneAt( i );
            }
        }

        /// <summary>
        /// 指定された名前のシーンが読み込まれている場合 true を返します
        /// </summary>
        public static bool IsLoaded( string sceneName )
        {
            var sceneCount = SceneManager.sceneCount;

            for ( var i = 0; i < sceneCount; i++ )
            {
                var scene = SceneManager.GetSceneAt( i );

                if ( scene.name == sceneName && scene.isLoaded ) return true;
            }

            return false;
        }
    }
}
# Kogane Scene Manager

SceneManager に関する処理をまとめたクラス

## 使用例

```csharp
// 現在読み込まれているすべてのシーンを取得
foreach ( var scene in KoganeSceneManager.GetAllScenes() )
{
    Debug.Log( scene.name );
}

// 指定された名前のシーンが読み込まれている場合 true
Debug.Log( KoganeSceneManager.IsLoaded( "SampleScene" ) );
```
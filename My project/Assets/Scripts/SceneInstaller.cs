using System.Collections;
using System.Collections.Generic;
using GameFoundation.Scripts.UIModule.ScreenFlow.Managers;
using GameFoundation.Scripts.UIModule.Utilities;
using UnityEngine;

public class SceneInstaller : BaseSceneInstaller
{
    public override void InstallBindings()
    {
        base.InstallBindings();
        this.Container.InitScreenManually<LoadingScreenPresenter>();
    }
}

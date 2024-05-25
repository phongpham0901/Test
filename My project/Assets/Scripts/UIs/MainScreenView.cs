using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using GameFoundation.Scripts.UIModule.ScreenFlow.BaseScreen.Presenter;
using GameFoundation.Scripts.UIModule.ScreenFlow.BaseScreen.View;
using GameFoundation.Scripts.UIModule.ScreenFlow.Managers;
using GameFoundation.Scripts.Utilities.LogService;
using UnityEngine;
using Zenject;

public class MainScreenModel 
{
    
}

public class MainScreenView : BaseView
{
    
}

[ScreenInfo(nameof(MainScreenView))]
public class MainScreenPresenter : BaseScreenPresenter<MainScreenView, MainScreenModel>
{
    private readonly IScreenManager screenManager;
    public MainScreenPresenter(SignalBus signalBus, ILogService logger, IScreenManager screenManager) : base(signalBus, logger)
    {
        this.screenManager = screenManager;
    }

    protected override void OnViewReady()
    {
        base.OnViewReady();
    }

    public override UniTask BindData(MainScreenModel screenModel)
    {
        return UniTask.CompletedTask;
    }
}

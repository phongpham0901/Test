using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using GameFoundation.Scripts.UIModule.ScreenFlow.BaseScreen.Presenter;
using GameFoundation.Scripts.UIModule.ScreenFlow.BaseScreen.View;
using GameFoundation.Scripts.UIModule.ScreenFlow.Managers;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class LoadingScreenView : BaseView
{
    public Button btnChangeScreen;
}

[ScreenInfo(nameof(LoadingScreenView))]
public class LoadingScreenPresenter : BaseScreenPresenter<LoadingScreenView>
{

    private readonly IScreenManager iScreenManager;
    
    public LoadingScreenPresenter(SignalBus signalBus, IScreenManager iScreenManager) : base(signalBus)
    {
        this.iScreenManager = iScreenManager;
    }

    protected override void OnViewReady()
    {
        base.OnViewReady();
        this.OpenViewAsync().Forget();
        this.View.btnChangeScreen.onClick.AddListener(this.OnClick);
    }

    private void OnClick()
    {
        this.iScreenManager.OpenScreen<MainScreenPresenter>();
    }

    public override UniTask BindData()
    {
        return UniTask.CompletedTask;
    }
}

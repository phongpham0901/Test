using System.Collections;
using System.Collections.Generic;
using GameFoundation.Scripts;
using UnityEngine;
using UnityEngine.EventSystems;
using Zenject;

public class ProjectInstaller : MonoInstaller<ProjectInstaller>
{
   public override void InstallBindings()
   {
      GameFoundationInstaller.Install(this.Container);
      this.Container.Bind<EventSystem>().FromNewComponentOnNewPrefabResource(nameof(EventSystem)).AsCached().NonLazy();
   }
}

using System.Collections.Generic;
using svanderweele.Mine.Core.Pieces.GridEditor.Interfaces;
using svanderweele.Mine.Game.Unity;
using svanderweele.Mine.Game.Unity.GridEditor;
using UnityEngine;

namespace svanderweele.Mine.Engine.Unity.MapEditor.Views.GridEditor
{
    public class UnityGridEditorBayView : UnityBaseGameView, IGridEditorAssetBay
    {
        [SerializeField] private UnityGridEditorObjectView _objectPrefab;
        [SerializeField] private Transform _bayContent;

        public List<IGridEditorObjectViewController> CreateViews(int views)
        {
            var newViews = new List<IGridEditorObjectViewController>();
            for (int i = 0; i < views; i++)
            {
                newViews.Add(GameObject.Instantiate(_objectPrefab, _bayContent) as IGridEditorObjectViewController);
            }

            return newViews;
        }
    }
}
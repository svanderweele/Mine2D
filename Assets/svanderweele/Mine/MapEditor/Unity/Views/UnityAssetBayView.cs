using System.Collections.Generic;
using System.Linq;
using Entitas;
using svanderweele.Core.Pieces.GridEditor.Interfaces;
using svanderweele.Mine.GameEditor.Unity.Data;
using UnityEngine;

namespace svanderweele.Mine.GameEditor.Unity.Views
{
    public class UnityAssetBayView : UnityMapEditorBaseView, IGridEditorAssetBay
    {
        [SerializeField] private GameObject _assetUiPrefab;
        [SerializeField] private Transform _assetContainerTransform;


        public List<IGridEditorObjectViewController> CreateViews(int amount)
        {
            var list = new List<IGridEditorObjectViewController>();

            for (int i = 0; i < amount; i++)
            {
                var obj = GameObject.Instantiate(_assetUiPrefab, _assetContainerTransform);
                list.Add(obj.GetComponent<IGridEditorObjectViewController>());
            }

            return list;
        }

        public List<IGridEditorObjectViewController> GetCurrentViews()
        {
            return _assetContainerTransform.GetComponentsInChildren<IGridEditorObjectViewController>().ToList();
        }

    }
}
// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using Microsoft.MixedReality.Toolkit.UI;
using UnityEngine;

namespace Microsoft.MixedReality.Toolkit.Examples.Demos
{
    //[AddComponentMenu("Scripts/MRTK/Examples/SliderLunarLander")]
    public class Transform_EjeY: MonoBehaviour
    {
        [SerializeField]
        private Transform target = null;

        public void OnSliderUpdated(SliderEventData eventData)
        {
            if (target != null)
            {
                // Rotate the target object using Slider's eventData.NewValue
                target.localPosition = new Vector3(target.localPosition.x, (float)(eventData.NewValue * 0.24 - 0.05) , target.localPosition.z);
            }
        }
    }
}
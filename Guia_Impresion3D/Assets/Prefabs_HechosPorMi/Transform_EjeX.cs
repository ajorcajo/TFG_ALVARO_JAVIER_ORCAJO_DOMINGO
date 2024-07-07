// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using Microsoft.MixedReality.Toolkit.UI;
using UnityEngine;

namespace Microsoft.MixedReality.Toolkit.Examples.Demos
{
    //[AddComponentMenu("Scripts/MRTK/Examples/SliderLunarLander")]
    public class Transform_EjeX: MonoBehaviour
    {
        [SerializeField]
        private Transform target = null;

        public void OnSliderUpdated(SliderEventData eventData)
        {
            if (target != null)
            {
                // Rotate the target object using Slider's eventData.NewValue
                target.localPosition = new Vector3((float)(eventData.NewValue * -0.2293 + 0.0073), target.localPosition.y, target.localPosition.z);
            }
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets._Scripts
{
    internal class GameParameters : MonoBehaviour
    {
        [Header("Bubbles")]
        public float GunLatSpeed = 1.0f;
        public float InitialBubbleSize = 1.0f;
        public float MaximalBubbleSize = 8.0f;
        public float SoapFlowRate = 0.1f;
        public int BubbleColorsCount = 5;
        public float BubbleInflationRate = 0.1f;
        public float BubbleFlowSpeed = 5.0f;
        public float BubbleMinimumSoapConsumption = 0.25f;

        [Header("Spikes")]
        public int SpikeCount = 6;
        public float MinSpikeLength = 0.3f;
        public float MaxSpikeLength = 0.6f;
        public int MinSpikeCountOnEachSide = 2;

        public static GameParameters Instance { get; private set; }

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }

    }
}

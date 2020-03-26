﻿using Aurora.Devices;
using Aurora.EffectsEngine.Animations;
using Aurora.Settings;
using Aurora.Settings.Layers;
using Aurora.Settings.Overrides;
using Aurora.Settings.Overrides.Logic;
using Aurora.Settings.Overrides.Logic.Builder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aurora.Profiles.Spotify
{
    public class SpotifyProfile : ApplicationProfile
    {
        public SpotifyProfile() : base() { }

        public override void Reset()
        {
            base.Reset();

            OverlayLayers = new System.Collections.ObjectModel.ObservableCollection<Layer>()
            {
                new Layer("Desaturated", new SolidColorLayerHandler()
                {
                    Properties = new LayerHandlerProperties()
                    {
                        _PrimaryColor = Color.Transparent,
                        _Sequence = new KeySequence(new DeviceKeys[]{ DeviceKeys.ONE})
                    }
                },
                new OverrideLogicBuilder()
                .SetDynamicColor("_PrimaryColor", new NumberConstant(1),
                    new NumberGSINumeric("Colors/Desaturated/Red"),
                    new NumberGSINumeric("Colors/Desaturated/Green"),
                    new NumberGSINumeric("Colors/Desaturated/Blue"))
                .SetDynamicBoolean("_Enabled", new BooleanGSIBoolean("Player/Playing"))
                ),

                new Layer("LightVibrant", new SolidColorLayerHandler()
                {
                    Properties = new LayerHandlerProperties()
                    {
                        _PrimaryColor = Color.Transparent,
                        _Sequence = new KeySequence(new DeviceKeys[]{ DeviceKeys.TWO})
                    }
                },
                new OverrideLogicBuilder()
                .SetDynamicColor("_PrimaryColor", new NumberConstant(1),
                    new NumberGSINumeric("Colors/LightVibrant/Red"),
                    new NumberGSINumeric("Colors/LightVibrant/Green"),
                    new NumberGSINumeric("Colors/LightVibrant/Blue"))
                .SetDynamicBoolean("_Enabled", new BooleanGSIBoolean("Player/Playing"))
                ),

                new Layer("Prominent", new SolidColorLayerHandler()
                {
                    Properties = new LayerHandlerProperties()
                    {
                        _PrimaryColor = Color.Transparent,
                        _Sequence = new KeySequence(new DeviceKeys[]{ DeviceKeys.THREE})
                    }
                },
                new OverrideLogicBuilder()
                .SetDynamicColor("_PrimaryColor", new NumberConstant(1),
                    new NumberGSINumeric("Colors/Prominent/Red"),
                    new NumberGSINumeric("Colors/Prominent/Green"),
                    new NumberGSINumeric("Colors/Prominent/Blue"))
                .SetDynamicBoolean("_Enabled", new BooleanGSIBoolean("Player/Playing"))
                ),

                new Layer("Vibrant", new SolidColorLayerHandler()
                {
                    Properties = new LayerHandlerProperties()
                    {
                        _PrimaryColor = Color.Transparent,
                        _Sequence = new KeySequence(new DeviceKeys[]{ DeviceKeys.FOUR})
                    }
                },
                new OverrideLogicBuilder()
                .SetDynamicColor("_PrimaryColor", new NumberConstant(1),
                    new NumberGSINumeric("Colors/Vibrant/Red"),
                    new NumberGSINumeric("Colors/Vibrant/Green"),
                    new NumberGSINumeric("Colors/Vibrant/Blue"))
                .SetDynamicBoolean("_Enabled", new BooleanGSIBoolean("Player/Playing"))
                ),

                new Layer("VibrantNonAlarming", new SolidColorLayerHandler()
                {
                    Properties = new LayerHandlerProperties()
                    {
                        _PrimaryColor = Color.Transparent,
                        _Sequence = new KeySequence(new DeviceKeys[]{ DeviceKeys.FIVE})
                    }
                },
                new OverrideLogicBuilder()
                .SetDynamicColor("_PrimaryColor", new NumberConstant(1),
                    new NumberGSINumeric("Colors/VibrantNonAlarming/Red"),
                    new NumberGSINumeric("Colors/VibrantNonAlarming/Green"),
                    new NumberGSINumeric("Colors/VibrantNonAlarming/Blue"))
                .SetDynamicBoolean("_Enabled", new BooleanGSIBoolean("Player/Playing"))
                ),

                new Layer("EQ", new EqualizerLayerHandler()
                {
                    Properties = new EqualizerLayerHandlerProperties()
                    {
                        _PrimaryColor = Color.Transparent,
                        _BackgroundMode = EqualizerBackgroundMode.AlwaysOn
                    }
                },
                new OverrideLogicBuilder()
                .SetDynamicColor("_PrimaryColor", new NumberConstant(1),
                    new NumberGSINumeric("Colors/Desaturated/Red"),
                    new NumberGSINumeric("Colors/Desaturated/Green"),
                    new NumberGSINumeric("Colors/Desaturated/Blue"))
                .SetDynamicColor("_DimColor", new NumberConstant(1),
                    new NumberGSINumeric("Colors/Prominent/Red"),
                    new NumberGSINumeric("Colors/Prominent/Green"),
                    new NumberGSINumeric("Colors/Prominent/Blue"))
                .SetDynamicBoolean("_Enabled", new BooleanGSIBoolean("Player/Playing"))
                )
            };    
        }
    }
}
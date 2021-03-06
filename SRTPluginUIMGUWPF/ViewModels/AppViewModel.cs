﻿using SRTPluginBase;
using SRTPluginProviderMGU;
using SRTPluginProviderMGU.Models;
using SRTPluginUIMGUWPF.Models;
using System;

namespace SRTPluginUIMGUWPF.ViewModels
{
    public class AppViewModel : BaseNotifyModel
    {
        public IPluginInfo PluginInfo => Plugin.PluginUI.Info;

        public string PluginName => Plugin.Name;
        public string PluginVersion => Plugin.Version;
        public string PluginProvider => Plugin.PluginUI.RequiredProvider;
        public string PluginTitle => String.Format("MGU SRT {0}", Plugin.Version);

        public PluginConfig Options { get; } = Plugin.Config;

        private IGameMemoryMGU _gameMemory;
        public IGameMemoryMGU GameMemory
        {
            get => _gameMemory;
            private set => SetField(ref _gameMemory, value);
        }

        private CharacterModel _characters;
        public CharacterModel Characters
        {
            get => _characters;
            private set => SetField(ref _characters, value);
        }

        private CharacterItem _character;
        public CharacterItem Character
        {
            get => _character;
            private set => SetField(ref _character, value);
        }

        public void Initalize(IGameMemoryMGU gameMemory)
        {
            if (GameMemory != null)
                return;

            GameMemory = gameMemory;

            Characters = new CharacterModel(GameMemory.Characters);
            Character = new CharacterItem(GameMemory.State.CurrentCharacter);
        }
    }
}
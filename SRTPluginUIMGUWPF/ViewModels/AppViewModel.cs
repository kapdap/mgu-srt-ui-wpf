using SRTPluginBase;
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

        public OptionModel Options { get; } = new OptionModel();

        private GameMemoryMGU _gameMemory;
        public GameMemoryMGU GameMemory
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

        private CharacterItem _equipment;
        public CharacterItem Equipment
        {
            get => _equipment;
            private set => SetField(ref _equipment, value);
        }

        public void Initalize(GameMemoryMGU gameMemory)
        {
            if (GameMemory != null)
                return;

            GameMemory = gameMemory;

            Characters = new CharacterModel(GameMemory.Characters);
            //Equipment = new InventoryItem(GameMemory.Player.Equipment);
        }
    }
}
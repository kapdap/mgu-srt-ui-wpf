using SRTPluginProviderMGU.Models;
using System.Collections.Generic;

namespace SRTPluginUIMGUWPF.Models
{
    public class CharacterModel : BaseNotifyModel
    {
        public List<CharacterItem> Items { get; private set; } = new List<CharacterItem>();

        public CharacterModel(CharacterEntry[] entries) =>
            Initalize(entries);

        public void Initalize(CharacterEntry[] entries)
        {
            if (entries == null)
                return;

            Items.Clear();

            for (int i = 0; i < entries.Length; i++)
                Items.Add(new CharacterItem(entries[i]));

            OnPropertyChanged("Items");
        }
    }
}
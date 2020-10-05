using SRTPluginProviderMGU.Enumerations;
using SRTPluginProviderMGU.Models;

namespace SRTPluginUIMGUWPF.Models
{
    public class CharacterItem : BaseNotifyModel
    {
        public const int ImageWidth = 38;
        public const int ImageHeight = 38;

        public CharacterEntry Entry { get; set; }
        public InventoryModel Inventory { get; set; }

        public ClippingModel Clipping { get; } = new ClippingModel(ImageWidth, ImageHeight);

        public CharacterItem(CharacterEntry entry)
        {
            Entry = entry;
            UpdateClipping();

            Inventory = new InventoryModel(entry.Inventory);
        }

        private void UpdateClipping()
        {
            switch (Entry.Character)
            {
                case CharacterEnumeration.Uji:
                    Clipping.Update(0, 1);
                    break;

                case CharacterEnumeration.Diane:
                    Clipping.Update(0, 2);
                    break;

                default:
                    Clipping.Update(0, 0);
                    break;
            }
        }
    }
}
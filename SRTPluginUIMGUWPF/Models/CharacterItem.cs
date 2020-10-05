using SRTPluginProviderMGU.Enumerations;
using SRTPluginProviderMGU.Models;
using System;

namespace SRTPluginUIMGUWPF.Models
{
    public class CharacterItem : BaseNotifyModel
    {
        public const int ImageWidth = 38;
        public const int ImageHeight = 38;

        public CharacterEntry Entry { get; set; }
        public InventoryModel Inventory { get; set; }

        public ClippingModel Clipping { get; } = new ClippingModel();

        public CharacterItem(CharacterEntry entry)
        {
            Entry = entry;
            UpdateClipping();

            Inventory = new InventoryModel(entry.Inventory);
        }

        private void UpdateClipping() =>
            Clipping.Update(GetClipping());

        private int[] GetClipping()
        {
            switch (Entry.Character)
            {
                case CharacterEnumeration.Uji:
                    return GenerateClipping(0, 1);

                case CharacterEnumeration.Diane:
                    return GenerateClipping(0, 2);

                default:
                    return GenerateClipping(0, 0);
            }
        }

        private int[] GenerateClipping(int column, int row)
        {
            int[] clipping = new int[4];

            clipping[0] = ImageWidth * column;
            clipping[1] = ImageHeight * row;
            clipping[2] = ImageWidth;
            clipping[3] = ImageHeight;

            return clipping;
        }
    }
}
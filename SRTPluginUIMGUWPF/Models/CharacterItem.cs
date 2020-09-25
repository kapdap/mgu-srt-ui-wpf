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

        public int ClipX { get; set; }
        public int ClipY { get; set; }
        public int ClipWidth { get; set; }
        public int ClipHeight { get; set; }
        public string Clipping { get; set; }

        public CharacterItem(CharacterEntry entry)
        {
            Entry = entry;
            UpdateClipping();
        }

        private void UpdateClipping()
        {
            int[] clipping = GetClipping();

            ClipX = clipping[0];
            ClipY = clipping[1];
            ClipWidth = clipping[2];
            ClipHeight = clipping[3];

            Clipping = String.Format("{0},{1},{2},{3}", ClipX, ClipY, ClipWidth, ClipHeight);
        }

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
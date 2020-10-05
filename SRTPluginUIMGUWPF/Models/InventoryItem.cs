using SRTPluginProviderMGU.Enumerations;
using SRTPluginProviderMGU.Models;
using System;
using System.ComponentModel;

namespace SRTPluginUIMGUWPF.Models
{
    public class InventoryItem : BaseNotifyModel
    {
        public const int ImageWidth = 48;
        public const int ImageHeight = 48;

        private InventoryEntry _entry;
        public InventoryEntry Entry
        {
            get => _entry;
            set
            {
                if (!value.Equals(_entry))
                {
                    _entry = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _clipX;
        public int ClipX
        {
            get => _clipX;
            set
            {
                if (_clipX != value)
                {
                    _clipX = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _clipY;
        public int ClipY
        {
            get => _clipY;
            set
            {
                if (_clipY != value)
                {
                    _clipY = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _clipWidth;
        public int ClipWidth
        {
            get => _clipWidth;
            set
            {
                if (_clipWidth != value)
                {
                    _clipWidth = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _clipHeight;
        public int ClipHeight
        {
            get => _clipHeight;
            set
            {
                if (_clipHeight != value)
                {
                    _clipHeight = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _clipping;
        public string Clipping
        {
            get => _clipping;
            set
            {
                if (_clipping != value)
                {
                    _clipping = value;
                    OnPropertyChanged();
                }
            }
        }

        public InventoryItem(InventoryEntry entry)
        {
            Entry = entry;
            Entry.PropertyChanged += UpdatePropertyEvent;

            UpdateClipping();
        }

        private void UpdatePropertyEvent(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName != "UpdateEntry")
                return;

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
			switch (Entry.Type)
			{
				case ItemEnumeration.Door:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Helmet:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Panel:
					return GenerateClipping(0, 0);

				case ItemEnumeration.StorageHatch:
					return GenerateClipping(0, 0);

				case ItemEnumeration.MainDoor:
					return GenerateClipping(0, 0);

				case ItemEnumeration.VacTube:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Computer:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Drawer:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Rover:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Cutter:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Microscope:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Fan:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Mood:
					return GenerateClipping(0, 0);

				case ItemEnumeration.SpiritusFireplace:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Chair:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Table:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Radio:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Lighter:
					return GenerateClipping(0, 0);

				case ItemEnumeration.MicrocorderAndrewMuir:
					return GenerateClipping(0, 0);

				case ItemEnumeration.FlareGun:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Scarab:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Tag:
					return GenerateClipping(0, 0);

				case ItemEnumeration.BenGunn:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Book:
					return GenerateClipping(0, 0);

				case ItemEnumeration.NoteBabybug:
					return GenerateClipping(0, 0);

				case ItemEnumeration.DeadBody:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Biosensor:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Digicamera:
					return GenerateClipping(0, 0);

				case ItemEnumeration.HairClippers:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Flask:
					return GenerateClipping(0, 0);

				case ItemEnumeration.BrownHerbs:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Newspaper:
					return GenerateClipping(0, 0);

				case ItemEnumeration.GardenClippers:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Container:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Gloves:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Adhesive:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Padlock:
					return GenerateClipping(0, 0);

				case ItemEnumeration.MusicBox:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Dart:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Toy:
					return GenerateClipping(0, 0);

				case ItemEnumeration.GamesChest:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Crank:
					return GenerateClipping(0, 0);

				case ItemEnumeration.SoilScoop:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Slides:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Cannister:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Syringe:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Stethoscope:
					return GenerateClipping(0, 0);

				case ItemEnumeration.AlarmClock:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Elevator:
					return GenerateClipping(0, 0);

				case ItemEnumeration.ElectronicScrewdriver:
					return GenerateClipping(0, 0);

				case ItemEnumeration.MeasuringTape:
					return GenerateClipping(0, 0);

				case ItemEnumeration.DuctPanel:
					return GenerateClipping(0, 0);

				case ItemEnumeration.DuctEntrance:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Hacksaw:
					return GenerateClipping(0, 0);

				case ItemEnumeration.MonkeyWrench:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Key:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Lenses:
					return GenerateClipping(0, 0);

				case ItemEnumeration.FlareBolts:
					return GenerateClipping(0, 0);

				case ItemEnumeration.DriveBelt:
					return GenerateClipping(0, 0);

				case ItemEnumeration.ExerciseBike:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Lighter2:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Cigarettes:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Watch:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Satsuma:
					return GenerateClipping(0, 0);

				case ItemEnumeration.NicotinePatch:
					return GenerateClipping(0, 0);

				case ItemEnumeration.ContactLens:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Lipstick:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Booklet:
					return GenerateClipping(0, 0);

				case ItemEnumeration.PhotoMatlock:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Letter:
					return GenerateClipping(0, 0);

				case ItemEnumeration.SilverBullet:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Wrapper:
					return GenerateClipping(0, 0);

				case ItemEnumeration.BrownTag:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Cable:
					return GenerateClipping(0, 0);

				case ItemEnumeration.LooseCable:
					return GenerateClipping(0, 0);

				case ItemEnumeration.GardenClippers2:
					return GenerateClipping(0, 0);

				case ItemEnumeration.OilyRag:
					return GenerateClipping(0, 0);

				case ItemEnumeration.ControlPanel:
					return GenerateClipping(0, 0);

				case ItemEnumeration.BlueTag:
					return GenerateClipping(0, 0);

				case ItemEnumeration.GreenTagDorm1:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Corpse:
					return GenerateClipping(0, 0);

				case ItemEnumeration.YellowTag:
					return GenerateClipping(0, 0);

				case ItemEnumeration.OrangeTag:
					return GenerateClipping(0, 0);

				case ItemEnumeration.PurpleTag:
					return GenerateClipping(0, 0);

				case ItemEnumeration.GrayTag:
					return GenerateClipping(0, 0);

				case ItemEnumeration.RedTag:
					return GenerateClipping(0, 0);

				case ItemEnumeration.WhiteTag:
					return GenerateClipping(0, 0);

				case ItemEnumeration.BlackTag:
					return GenerateClipping(0, 0);

				case ItemEnumeration.RainbowTag:
					return GenerateClipping(0, 0);

				case ItemEnumeration.EvaSuit:
					return GenerateClipping(0, 0);

				case ItemEnumeration.PopGun:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Piccolo:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Diabolus:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Dillinger:
					return GenerateClipping(0, 0);

				case ItemEnumeration.NailGun:
					return GenerateClipping(0, 0);

				case ItemEnumeration.FlareGun2:
					return GenerateClipping(0, 0);

				case ItemEnumeration.WeedKillerSprayGun:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Welder:
					return GenerateClipping(0, 0);

				case ItemEnumeration.MartianRock:
					return GenerateClipping(0, 0);

				case ItemEnumeration.RockCutter:
					return GenerateClipping(0, 0);

				case ItemEnumeration.ShapedRock:
					return GenerateClipping(0, 0);

				case ItemEnumeration.RockSculpture:
					return GenerateClipping(0, 0);

				case ItemEnumeration.ReceptorPanel:
					return GenerateClipping(0, 0);

				case ItemEnumeration.GeneratorHood:
					return GenerateClipping(0, 0);

				case ItemEnumeration.ChemicalCombiner:
					return GenerateClipping(0, 0);

				case ItemEnumeration.MeltedFlask:
					return GenerateClipping(0, 0);

				case ItemEnumeration.FlaskNitroglycerine:
					return GenerateClipping(0, 0);

				case ItemEnumeration.SprayCartridgeAcid:
					return GenerateClipping(0, 0);

				case ItemEnumeration.PiccoloAmmo:
					return GenerateClipping(0, 0);

				case ItemEnumeration.AirFilter:
					return GenerateClipping(0, 0);

				case ItemEnumeration.CleanAirFilter:
					return GenerateClipping(0, 0);

				case ItemEnumeration.VibroScourer:
					return GenerateClipping(0, 0);

				case ItemEnumeration.DrawerKey:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Rug:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Locker:
					return GenerateClipping(0, 0);

				case ItemEnumeration.SeveredHand:
					return GenerateClipping(0, 0);

				case ItemEnumeration.SunBed:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Biosensor2:
					return GenerateClipping(0, 0);

				case ItemEnumeration.PaperClip:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Notes:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Notes2:
					return GenerateClipping(0, 0);

				case ItemEnumeration.SilverBell:
					return GenerateClipping(0, 0);

				case ItemEnumeration.PalmtopComputer:
					return GenerateClipping(0, 0);

				case ItemEnumeration.DoorControl:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Babybug:
					return GenerateClipping(0, 0);

				case ItemEnumeration.BabybugRemote:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Resonator:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Crate:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Explosives:
					return GenerateClipping(0, 0);

				case ItemEnumeration.DillingerAmmo:
					return GenerateClipping(0, 0);

				case ItemEnumeration.ChemicalExtractor:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Antitoxin:
					return GenerateClipping(0, 0);

				case ItemEnumeration.HealthBoost:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Lichen:
					return GenerateClipping(0, 0);

				case ItemEnumeration.NeedleAndThread:
					return GenerateClipping(0, 0);

				case ItemEnumeration.BenGunnsHead:
					return GenerateClipping(0, 0);

				case ItemEnumeration.TrimorphedAnimals:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Switch:
					return GenerateClipping(0, 0);

				case ItemEnumeration.HourglassEmpty:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Keypad:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Button:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Instrument:
					return GenerateClipping(0, 0);

				case ItemEnumeration.GreenTagDorm2:
					return GenerateClipping(0, 0);

				case ItemEnumeration.GreenTagDorm3:
					return GenerateClipping(0, 0);

				case ItemEnumeration.GreenTagDorm4:
					return GenerateClipping(0, 0);

				case ItemEnumeration.MetalCase:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Psionara:
					return GenerateClipping(0, 0);

				case ItemEnumeration.PasscodeArboretum:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Desk:
					return GenerateClipping(0, 0);

				case ItemEnumeration.LaserScalpel:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Storeroom1Key:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Spectrometer:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Clothes:
					return GenerateClipping(0, 0);

				case ItemEnumeration.NoteMrOba:
					return GenerateClipping(0, 0);

				case ItemEnumeration.CleaningFluid:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Jar:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Wool:
					return GenerateClipping(0, 0);

				case ItemEnumeration.DiabolusAmmo:
					return GenerateClipping(0, 0);

				case ItemEnumeration.RemoteControlSpiritus:
					return GenerateClipping(0, 0);

				case ItemEnumeration.DeflatedMarsHopper:
					return GenerateClipping(0, 0);

				case ItemEnumeration.DeskKey:
					return GenerateClipping(0, 0);

				case ItemEnumeration.SprayCartridgeEmpty:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Respirator:
					return GenerateClipping(0, 0);

				case ItemEnumeration.BicyclePump:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Screwdriver:
					return GenerateClipping(0, 0);

				case ItemEnumeration.NotesPickman:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Diary:
					return GenerateClipping(0, 0);

				case ItemEnumeration.GreenTag:
					return GenerateClipping(0, 0);

				case ItemEnumeration.StudyDrawerKey:
					return GenerateClipping(0, 0);

				case ItemEnumeration.HorribleArm:
					return GenerateClipping(0, 0);

				case ItemEnumeration.AirlockDoor:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Detonator:
					return GenerateClipping(0, 0);

				case ItemEnumeration.PrimedExplosives:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Fissure:
					return GenerateClipping(0, 0);

				case ItemEnumeration.HeartOfStone:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Wire:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Rock:
					return GenerateClipping(0, 0);

				case ItemEnumeration.StorageBox1:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Artifact:
					return GenerateClipping(0, 0);

				case ItemEnumeration.KeyMed:
					return GenerateClipping(0, 0);

				case ItemEnumeration.EvaSuit2:
					return GenerateClipping(0, 0);

				case ItemEnumeration.ElevatorDrive:
					return GenerateClipping(0, 0);

				case ItemEnumeration.SilverPlatter:
					return GenerateClipping(0, 0);

				case ItemEnumeration.RedSand:
					return GenerateClipping(0, 0);

				case ItemEnumeration.BaconSlicer:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Graffiti:
					return GenerateClipping(0, 0);

				case ItemEnumeration.ElevatorShaft:
					return GenerateClipping(0, 0);

				case ItemEnumeration.ElevatorButton:
					return GenerateClipping(0, 0);

				case ItemEnumeration.TrimorphSample:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Centrifuge:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Thermaliser:
					return GenerateClipping(0, 0);

				case ItemEnumeration.BloodSampleKarne:
					return GenerateClipping(0, 0);

				case ItemEnumeration.BloodSampleKenzo:
					return GenerateClipping(0, 0);

				case ItemEnumeration.BloodSampleMatlock:
					return GenerateClipping(0, 0);

				case ItemEnumeration.VirusAntidote:
					return GenerateClipping(0, 0);

				case ItemEnumeration.MilkBloodSample:
					return GenerateClipping(0, 0);

				case ItemEnumeration.FleshHeart:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Obelisk:
					return GenerateClipping(0, 0);

				case ItemEnumeration.ChargedChorus:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Altar:
					return GenerateClipping(0, 0);

				case ItemEnumeration.ArkhamTag:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Crane:
					return GenerateClipping(0, 0);

				case ItemEnumeration.HydraulicPlatform:
					return GenerateClipping(0, 0);

				case ItemEnumeration.AlienBreastSac:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Generator:
					return GenerateClipping(0, 0);

				case ItemEnumeration.GeneratorCable:
					return GenerateClipping(0, 0);

				case ItemEnumeration.DeadBattery:
					return GenerateClipping(0, 0);

				case ItemEnumeration.ChargedBattery:
					return GenerateClipping(0, 0);

				case ItemEnumeration.AlienMilk:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Breach:
					return GenerateClipping(0, 0);

				case ItemEnumeration.MarsHopper:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Nails:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Checker:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Winch:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Niche:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Membrane:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Radio2:
					return GenerateClipping(0, 0);

				case ItemEnumeration.SmallHatch:
					return GenerateClipping(0, 0);

				case ItemEnumeration.PsionCell:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Locker2:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Hole:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Statue:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Vent:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Pit:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Screen:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Dartboard:
					return GenerateClipping(0, 0);

				case ItemEnumeration.MorgueSlab:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Grave:
					return GenerateClipping(0, 0);

				case ItemEnumeration.BloodTransfuser:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Painting:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Books:
					return GenerateClipping(0, 0);

				case ItemEnumeration.PasscodeAirlock5:
					return GenerateClipping(0, 0);

				case ItemEnumeration.PasscodeMainHatch:
					return GenerateClipping(0, 0);

				case ItemEnumeration.LockerKey:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Bible:
					return GenerateClipping(0, 0);

				case ItemEnumeration.MicrocorderDietaMentz:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Lockers:
					return GenerateClipping(0, 0);

				case ItemEnumeration.NoteHolmes:
					return GenerateClipping(0, 0);

				case ItemEnumeration.MicrocorderAndreivitch:
					return GenerateClipping(0, 0);

				case ItemEnumeration.NoteBenGunn1:
					return GenerateClipping(0, 0);

				case ItemEnumeration.DormLocker:
					return GenerateClipping(0, 0);

				case ItemEnumeration.MicrocorderTierney:
					return GenerateClipping(0, 0);

				case ItemEnumeration.NoteSuicide:
					return GenerateClipping(0, 0);

				case ItemEnumeration.ErebusPasscode:
					return GenerateClipping(0, 0);

				case ItemEnumeration.NoteAltar:
					return GenerateClipping(0, 0);

				case ItemEnumeration.NotePowerCoreRequest:
					return GenerateClipping(0, 0);

				case ItemEnumeration.NoteChorus:
					return GenerateClipping(0, 0);

				case ItemEnumeration.PasscodeDowningStreet:
					return GenerateClipping(0, 0);

				case ItemEnumeration.PumiceStone:
					return GenerateClipping(0, 0);

				case ItemEnumeration.BakerStreetHatch:
					return GenerateClipping(0, 0);

				case ItemEnumeration.DowningStreetHatch:
					return GenerateClipping(0, 0);

				case ItemEnumeration.BroadwayHatch:
					return GenerateClipping(0, 0);

				case ItemEnumeration.LonelyStreetHatch:
					return GenerateClipping(0, 0);

				case ItemEnumeration.ParkLaneHatch:
					return GenerateClipping(0, 0);

				case ItemEnumeration.WallStreetHatch:
					return GenerateClipping(0, 0);

				case ItemEnumeration.BoulevardStMichelHatch:
					return GenerateClipping(0, 0);

				case ItemEnumeration.ShuttleBayHatch:
					return GenerateClipping(0, 0);

				case ItemEnumeration.KremlinMainHatch:
					return GenerateClipping(0, 0);

				case ItemEnumeration.KremlinEmergencyHatch:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Printout:
					return GenerateClipping(0, 0);

				case ItemEnumeration.MicrocorderFelicci:
					return GenerateClipping(0, 0);

				case ItemEnumeration.NoteBenGunn2:
					return GenerateClipping(0, 0);

				case ItemEnumeration.NoteBenGunn3:
					return GenerateClipping(0, 0);

				case ItemEnumeration.NoteBenGunn4:
					return GenerateClipping(0, 0);

				case ItemEnumeration.InvitiationBenGunn:
					return GenerateClipping(0, 0);

				case ItemEnumeration.MicrocorderMaiLin:
					return GenerateClipping(0, 0);

				case ItemEnumeration.MicrocorderDeborahTrask:
					return GenerateClipping(0, 0);

				case ItemEnumeration.MicrocorderIzumiKeiko:
					return GenerateClipping(0, 0);

				case ItemEnumeration.MicrocorderJeanMerrow:
					return GenerateClipping(0, 0);

				case ItemEnumeration.MicrocorderJonathonDarnley1:
					return GenerateClipping(0, 0);

				case ItemEnumeration.MicrocorderJonathonDarnley2:
					return GenerateClipping(0, 0);

				case ItemEnumeration.MicrocorderLukeBarton:
					return GenerateClipping(0, 0);

				case ItemEnumeration.MicrocorderNadjaKerenski:
					return GenerateClipping(0, 0);

				case ItemEnumeration.MicrocorderRobertSeager:
					return GenerateClipping(0, 0);

				case ItemEnumeration.MicrocorderSimonFellner:
					return GenerateClipping(0, 0);

				case ItemEnumeration.PhotoKenzo:
					return GenerateClipping(0, 0);

				case ItemEnumeration.HourglassFull:
					return GenerateClipping(0, 0);

				case ItemEnumeration.Sand:
					return GenerateClipping(0, 0);

				case ItemEnumeration.PasscodeStoreroom2:
					return GenerateClipping(0, 0);

				case ItemEnumeration.PalmtopComputer2:
					return GenerateClipping(0, 0);

				case ItemEnumeration.BloodSampleBenGunn:
					return GenerateClipping(0, 0);

				case ItemEnumeration.StorageBox2:
					return GenerateClipping(0, 0);

				case ItemEnumeration.StorageBox3:
					return GenerateClipping(0, 0);

				case ItemEnumeration.StorageBox4:
					return GenerateClipping(0, 0);

				case ItemEnumeration.None:
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
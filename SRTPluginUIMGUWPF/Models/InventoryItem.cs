using SRTPluginProviderMGU.Enumerations;
using SRTPluginProviderMGU.Models;
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

		public ClippingModel Clipping { get; } = new ClippingModel(ImageWidth, ImageHeight);

        public InventoryItem(InventoryEntry entry)
        {
            Entry = entry;
            Entry.PropertyChanged += UpdatePropertyEvent;

            UpdateClipping();
        }

        private void UpdatePropertyEvent(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Type" && e.PropertyName != "UpdateEntry")
				UpdateClipping();
        }

		private void UpdateClipping()
		{
			switch (Entry.Type)
			{
				case ItemEnumeration.Door:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Helmet:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Panel:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.StorageHatch:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.MainDoor:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.VacTube:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Computer:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Drawer:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Rover:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Cutter:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Microscope:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Fan:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Mood:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.SpiritusFireplace:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Chair:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Table:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Radio:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Lighter:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.MicrocorderAndrewMuir:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.FlareGun:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Scarab:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Tag:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.BenGunn:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Book:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.NoteBabybug:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.DeadBody:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Biosensor:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Digicamera:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.HairClippers:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Flask:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.BrownHerbs:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Newspaper:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.GardenClippers:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Container:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Gloves:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Adhesive:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Padlock:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.MusicBox:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Dart:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Toy:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.GamesChest:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Crank:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.SoilScoop:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Slides:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Cannister:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Syringe:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Stethoscope:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.AlarmClock:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Elevator:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.ElectronicScrewdriver:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.MeasuringTape:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.DuctPanel:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.DuctEntrance:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Hacksaw:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.MonkeyWrench:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Key:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Lenses:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.FlareBolts:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.DriveBelt:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.ExerciseBike:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Lighter2:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Cigarettes:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Watch:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Satsuma:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.NicotinePatch:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.ContactLens:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Lipstick:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Booklet:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.PhotoMatlock:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Letter:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.SilverBullet:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Wrapper:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.BrownTag:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Cable:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.LooseCable:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.GardenClippers2:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.OilyRag:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.ControlPanel:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.BlueTag:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.GreenTagDorm1:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Corpse:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.YellowTag:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.OrangeTag:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.PurpleTag:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.GrayTag:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.RedTag:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.WhiteTag:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.BlackTag:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.RainbowTag:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.EvaSuit:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.PopGun:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Piccolo:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Diabolus:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Dillinger:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.NailGun:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.FlareGun2:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.WeedKillerSprayGun:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Welder:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.MartianRock:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.RockCutter:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.ShapedRock:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.RockSculpture:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.ReceptorPanel:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.GeneratorHood:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.ChemicalCombiner:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.MeltedFlask:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.FlaskNitroglycerine:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.SprayCartridgeAcid:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.PiccoloAmmo:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.AirFilter:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.CleanAirFilter:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.VibroScourer:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.DrawerKey:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Rug:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Locker:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.SeveredHand:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.SunBed:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Biosensor2:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.PaperClip:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Notes:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Notes2:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.SilverBell:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.PalmtopComputer:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.DoorControl:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Babybug:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.BabybugRemote:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Resonator:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Crate:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Explosives:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.DillingerAmmo:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.ChemicalExtractor:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Antitoxin:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.HealthBoost:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Lichen:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.NeedleAndThread:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.BenGunnsHead:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.TrimorphedAnimals:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Switch:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.HourglassEmpty:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Keypad:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Button:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Instrument:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.GreenTagDorm2:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.GreenTagDorm3:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.GreenTagDorm4:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.MetalCase:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Psionara:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.PasscodeArboretum:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Desk:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.LaserScalpel:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Storeroom1Key:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Spectrometer:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Clothes:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.NoteMrOba:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.CleaningFluid:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Jar:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Wool:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.DiabolusAmmo:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.RemoteControlSpiritus:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.DeflatedMarsHopper:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.DeskKey:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.SprayCartridgeEmpty:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Respirator:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.BicyclePump:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Screwdriver:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.NotesPickman:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Diary:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.GreenTag:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.StudyDrawerKey:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.HorribleArm:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.AirlockDoor:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Detonator:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.PrimedExplosives:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Fissure:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.HeartOfStone:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Wire:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Rock:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.StorageBox1:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Artifact:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.KeyMed:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.EvaSuit2:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.ElevatorDrive:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.SilverPlatter:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.RedSand:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.BaconSlicer:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Graffiti:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.ElevatorShaft:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.ElevatorButton:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.TrimorphSample:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Centrifuge:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Thermaliser:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.BloodSampleKarne:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.BloodSampleKenzo:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.BloodSampleMatlock:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.VirusAntidote:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.MilkBloodSample:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.FleshHeart:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Obelisk:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.ChargedChorus:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Altar:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.ArkhamTag:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Crane:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.HydraulicPlatform:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.AlienBreastSac:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Generator:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.GeneratorCable:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.DeadBattery:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.ChargedBattery:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.AlienMilk:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Breach:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.MarsHopper:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Nails:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Checker:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Winch:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Niche:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Membrane:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Radio2:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.SmallHatch:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.PsionCell:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Locker2:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Hole:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Statue:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Vent:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Pit:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Screen:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Dartboard:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.MorgueSlab:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Grave:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.BloodTransfuser:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Painting:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Books:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.PasscodeAirlock5:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.PasscodeMainHatch:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.LockerKey:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Bible:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.MicrocorderDietaMentz:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Lockers:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.NoteHolmes:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.MicrocorderAndreivitch:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.NoteBenGunn1:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.DormLocker:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.MicrocorderTierney:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.NoteSuicide:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.ErebusPasscode:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.NoteAltar:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.NotePowerCoreRequest:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.NoteChorus:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.PasscodeDowningStreet:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.PumiceStone:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.BakerStreetHatch:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.DowningStreetHatch:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.BroadwayHatch:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.LonelyStreetHatch:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.ParkLaneHatch:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.WallStreetHatch:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.BoulevardStMichelHatch:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.ShuttleBayHatch:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.KremlinMainHatch:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.KremlinEmergencyHatch:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Printout:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.MicrocorderFelicci:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.NoteBenGunn2:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.NoteBenGunn3:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.NoteBenGunn4:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.InvitiationBenGunn:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.MicrocorderMaiLin:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.MicrocorderDeborahTrask:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.MicrocorderIzumiKeiko:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.MicrocorderJeanMerrow:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.MicrocorderJonathonDarnley1:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.MicrocorderJonathonDarnley2:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.MicrocorderLukeBarton:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.MicrocorderNadjaKerenski:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.MicrocorderRobertSeager:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.MicrocorderSimonFellner:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.PhotoKenzo:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.HourglassFull:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.Sand:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.PasscodeStoreroom2:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.PalmtopComputer2:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.BloodSampleBenGunn:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.StorageBox2:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.StorageBox3:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.StorageBox4:
					Clipping.Update(0, 0);
					break;

				case ItemEnumeration.None:
				default:
					Clipping.Update(0, 0);
					break;
			}
		}
    }
}
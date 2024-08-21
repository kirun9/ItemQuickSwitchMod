using BepInEx.Configuration;
using UnityEngine.InputSystem;

namespace ItemQuickSwitchMod
{
    public sealed class CustomAction
    {
        public static readonly ActionItem Emote1 = new ActionItem("Emote1", Key.F1, "Dance emote", 0);
        public static readonly ActionItem Emote2 = new ActionItem("Emote2", Key.F2, "Point emote", 0);
        public static readonly ActionItem Slot1 = new ActionItem("Slot1", Key.Digit1, "Equip Slot 1", 0);
        public static readonly ActionItem Slot2 = new ActionItem("Slot2", Key.Digit2, "Equip Slot 2", 1);
        public static readonly ActionItem Slot3 = new ActionItem("Slot3", Key.Digit3, "Equip Slot 3", 2);
        public static readonly ActionItem Slot4 = new ActionItem("Slot4", Key.Digit4, "Equip Slot 4", 3);
        public static readonly ActionItem Slot5 = new ActionItem("Slot5", Key.Digit5, "Equip Slot 5", 4);
        public static readonly ActionItem Slot6 = new ActionItem("Slot6", Key.Digit6, "Equip Slot 6", 5);
        public static readonly ActionItem Slot7 = new ActionItem("Slot7", Key.Digit7, "Equip Slot 7", 6);
        public static readonly ActionItem Slot8 = new ActionItem("Slot8", Key.Digit8, "Equip Slot 8", 7);
        public static readonly ActionItem Slot9 = new ActionItem("Slot9", Key.Digit9, "Equip Slot 9", 8);

        public static readonly ActionItem[] AllActions = { Emote1, Emote2, Slot1, Slot2, Slot3, Slot4, Slot5, Slot6, Slot7, Slot8, Slot9 };

        public class ActionItem
        {
            public string Id { get; }
            public Key Shortcut { get; }
            public string Description { get; }
            public int SlotNumber { get; }

            public ConfigEntry<Key> ConfigEntry { get; set; }

            public ActionItem(string id, Key config, string description, int slotNumber)
                => (Id, Shortcut, Description, SlotNumber) = (id, config, description, slotNumber);
        }
    }
}

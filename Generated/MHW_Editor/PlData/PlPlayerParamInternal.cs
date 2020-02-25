using System.Collections.ObjectModel;
using MHW_Editor.Models;

namespace MHW_Editor.PlData {
    public partial class PlPlayerParam {
        public ObservableCollection<PlDataItemCustomView> GetCustomView() {
            return new ObservableCollection<PlDataItemCustomView> {
                new PlDataItemCustomView(this, "Unk1", "Unk1", Bytes, 8),
                new PlDataItemCustomView(this, "Unk2", "Unk2", Bytes, 12),
                new PlDataItemCustomView(this, "Unk3", "Unk3", Bytes, 16),
                new PlDataItemCustomView(this, "Unk4", "Unk4", Bytes, 20),
                new PlDataItemCustomView(this, "Unk5", "Unk5", Bytes, 24),
                new PlDataItemCustomView(this, "Unk6", "Unk6", Bytes, 28),
                new PlDataItemCustomView(this, "Unk7", "Unk7", Bytes, 32),
                new PlDataItemCustomView(this, "Unk8", "Unk8", Bytes, 36),
                new PlDataItemCustomView(this, "Unk9", "Unk9", Bytes, 40),
                new PlDataItemCustomView(this, "Unk10", "Unk10", Bytes, 44),
                new PlDataItemCustomView(this, "Unk11", "Unk11", Bytes, 48),
                new PlDataItemCustomView(this, "Unk12", "Unk12", Bytes, 52),
                new PlDataItemCustomView(this, "Unk13", "Unk13", Bytes, 56),
                new PlDataItemCustomView(this, "Unk14", "Unk14", Bytes, 60),
                new PlDataItemCustomView(this, "Unk15", "Unk15", Bytes, 64),
                new PlDataItemCustomView(this, "Unk16", "Unk16", Bytes, 68),
                new PlDataItemCustomView(this, "Unk17", "Unk17", Bytes, 72),
                new PlDataItemCustomView(this, "Unk18", "Unk18", Bytes, 76),
                new PlDataItemCustomView(this, "Unk19", "Unk19", Bytes, 80),
                new PlDataItemCustomView(this, "Unk20", "Unk20", Bytes, 84),
                new PlDataItemCustomView(this, "Unk21", "Unk21", Bytes, 88),
                new PlDataItemCustomView(this, "Unk22", "Unk22", Bytes, 92),
                new PlDataItemCustomView(this, "Unk23", "Unk23", Bytes, 96),
                new PlDataItemCustomView(this, "Unk24", "Unk24", Bytes, 100),
                new PlDataItemCustomView(this, "Unk25", "Unk25", Bytes, 104),
                new PlDataItemCustomView(this, "Unk26", "Unk26", Bytes, 108),
                new PlDataItemCustomView(this, "Unk27", "Unk27", Bytes, 112),
                new PlDataItemCustomView(this, "Unk28", "Unk28", Bytes, 116),
                new PlDataItemCustomView(this, "Unk29", "Unk29", Bytes, 120),
                new PlDataItemCustomView(this, "Unk30", "Unk30", Bytes, 124),
                new PlDataItemCustomView(this, "Unk31", "Unk31", Bytes, 128),
                new PlDataItemCustomView(this, "Unk32", "Unk32", Bytes, 132),
                new PlDataItemCustomView(this, "Unk33", "Unk33", Bytes, 136),
                new PlDataItemCustomView(this, "Unk34", "Unk34", Bytes, 140),
                new PlDataItemCustomView(this, "Unk35", "Unk35", Bytes, 144),
                new PlDataItemCustomView(this, "Unk36", "Unk36", Bytes, 148),
                new PlDataItemCustomView(this, "Unk37", "Unk37", Bytes, 152),
                new PlDataItemCustomView(this, "Unk38", "Unk38", Bytes, 156),
                new PlDataItemCustomView(this, "Unk39", "Unk39", Bytes, 160),
                new PlDataItemCustomView(this, "Unk40", "Unk40", Bytes, 164),
                new PlDataItemCustomView(this, "Unk41", "Unk41", Bytes, 168),
                new PlDataItemCustomView(this, "Unk42", "Unk42", Bytes, 172),
                new PlDataItemCustomView(this, "Unk43", "Unk43", Bytes, 176),
                new PlDataItemCustomView(this, "Unk44", "Unk44", Bytes, 180),
                new PlDataItemCustomView(this, "Unk45", "Unk45", Bytes, 184),
                new PlDataItemCustomView(this, "Unk46", "Unk46", Bytes, 188),
                new PlDataItemCustomView(this, "Unk47", "Unk47", Bytes, 192),
                new PlDataItemCustomView(this, "Unk48", "Unk48", Bytes, 196),
                new PlDataItemCustomView(this, "Unk49", "Unk49", Bytes, 200),
                new PlDataItemCustomView(this, "Unk50", "Unk50", Bytes, 204),
                new PlDataItemCustomView(this, "Unk51", "Unk51", Bytes, 208),
                new PlDataItemCustomView(this, "Unk52", "Unk52", Bytes, 212),
                new PlDataItemCustomView(this, "Unk53", "Unk53", Bytes, 216),
                new PlDataItemCustomView(this, "Unk54", "Unk54", Bytes, 220),
                new PlDataItemCustomView(this, "Unk55", "Unk55", Bytes, 224),
                new PlDataItemCustomView(this, "Unk56", "Unk56", Bytes, 228),
                new PlDataItemCustomView(this, "Unk57", "Unk57", Bytes, 232),
                new PlDataItemCustomView(this, "Unk58", "Unk58", Bytes, 236),
                new PlDataItemCustomView(this, "Unk59", "Unk59", Bytes, 237),
                new PlDataItemCustomView(this, "Unk60", "Unk60", Bytes, 239),
                new PlDataItemCustomView(this, "Unk61", "Unk61", Bytes, 241),
                new PlDataItemCustomView(this, "Unk62", "Unk62", Bytes, 245),
                new PlDataItemCustomView(this, "Unk63", "Unk63", Bytes, 246),
                new PlDataItemCustomView(this, "Unk64", "Unk64", Bytes, 248),
                new PlDataItemCustomView(this, "Unk65", "Unk65", Bytes, 250),
                new PlDataItemCustomView(this, "Unk66", "Unk66", Bytes, 252),
                new PlDataItemCustomView(this, "------Skipping ahead 1.", "_Skipping_ahead_1_", Bytes, 256),
                new PlDataItemCustomView(this, "Health Initial Value", "Health_Initial_Value", Bytes, 408),
                new PlDataItemCustomView(this, "Health Max Value", "Health_Max_Value", Bytes, 412),
                new PlDataItemCustomView(this, "Health Damage Recovery Rate", "Health_Damage_Recovery_Rate", Bytes, 416),
                new PlDataItemCustomView(this, "Health Damage Recovery Wait Time", "Health_Damage_Recovery_Wait_Time", Bytes, 420),
                new PlDataItemCustomView(this, "Health Damage Recovery Interval", "Health_Damage_Recovery_Interval", Bytes, 424),
                new PlDataItemCustomView(this, "Health Damage Recovery Value", "Health_Damage_Recovery_Value", Bytes, 428),
                new PlDataItemCustomView(this, "Stamina Initial Value", "Stamina_Initial_Value", Bytes, 432),
                new PlDataItemCustomView(this, "Stamina Max Value", "Stamina_Max_Value", Bytes, 436),
                new PlDataItemCustomView(this, "Stamina Min Value", "Stamina_Min_Value", Bytes, 440),
                new PlDataItemCustomView(this, "Stamina Tired Value", "Stamina_Tired_Value", Bytes, 444),
                new PlDataItemCustomView(this, "Stamina Auto Recover", "Stamina_Auto_Recover", Bytes, 448),
                new PlDataItemCustomView(this, "Stamina Auto Max Reduce", "Stamina_Auto_Max_Reduce", Bytes, 452),
                new PlDataItemCustomView(this, "Stamina Auto Max Reduce Time", "Stamina_Auto_Max_Reduce_Time", Bytes, 456),
                new PlDataItemCustomView(this, "Stamina IB Unknown", "Stamina_IB_Unknown", Bytes, 460),
                new PlDataItemCustomView(this, "Stamina Escape Dash Rate", "Stamina_Escape_Dash_Rate", Bytes, 464),
                new PlDataItemCustomView(this, "Stamina Out of Battle Rate", "Stamina_Out_of_Battle_Rate", Bytes, 468),
                new PlDataItemCustomView(this, "Stamina Reduce Rate Limit Trigger", "Stamina_Reduce_Rate_Limit_Trigger", Bytes, 472),
                new PlDataItemCustomView(this, "Stamina Reduce Rate Limit Time", "Stamina_Reduce_Rate_Limit_Time", Bytes, 476),
                new PlDataItemCustomView(this, "Stamina Mount Endurance Rate", "Stamina_Mount_Endurance_Rate", Bytes, 480),
                new PlDataItemCustomView(this, "Stamina Consumption: Dodge", "Stamina_Consumption_Dodge", Bytes, 484),
                new PlDataItemCustomView(this, "Stamina Consumption: LS Counter", "Stamina_Consumption_LS_Counter", Bytes, 488),
                new PlDataItemCustomView(this, "Stamina Consumption: Unk1", "Stamina_Consumption_Unk1", Bytes, 492),
                new PlDataItemCustomView(this, "Stamina Consumption: Unk2", "Stamina_Consumption_Unk2", Bytes, 496),
                new PlDataItemCustomView(this, "Stamina Consumption: Unk3", "Stamina_Consumption_Unk3", Bytes, 500),
                new PlDataItemCustomView(this, "Stamina Consumption: Unk4", "Stamina_Consumption_Unk4", Bytes, 504),
                new PlDataItemCustomView(this, "Stamina Consumption: Bow Shoot", "Stamina_Consumption_Bow_Shoot", Bytes, 508),
                new PlDataItemCustomView(this, "Stamina Consumption: Unk5", "Stamina_Consumption_Unk5", Bytes, 512),
                new PlDataItemCustomView(this, "Stamina Consumption: Unk6", "Stamina_Consumption_Unk6", Bytes, 516),
                new PlDataItemCustomView(this, "Stamina Consumption: Unk7", "Stamina_Consumption_Unk7", Bytes, 520),
                new PlDataItemCustomView(this, "Stamina Consumption: Bow Charge Step", "Stamina_Consumption_Bow_Charge_Step", Bytes, 524),
                new PlDataItemCustomView(this, "Stamina Consumption: Unk8", "Stamina_Consumption_Unk8", Bytes, 528),
                new PlDataItemCustomView(this, "Stamina Consumption: IB Unk9", "Stamina_Consumption_IB_Unk9", Bytes, 532),
                new PlDataItemCustomView(this, "Stamina Consumption: IB Unk10", "Stamina_Consumption_IB_Unk10", Bytes, 536),
                new PlDataItemCustomView(this, "Stamina Consumption: IB Unk11", "Stamina_Consumption_IB_Unk11", Bytes, 540),
                new PlDataItemCustomView(this, "Stamina Consumption: IB Unk12", "Stamina_Consumption_IB_Unk12", Bytes, 544),
                new PlDataItemCustomView(this, "Stamina Consumption: Unk13", "Stamina_Consumption_Unk13", Bytes, 548),
                new PlDataItemCustomView(this, "Stamina Consumption: Unk14", "Stamina_Consumption_Unk14", Bytes, 552),
                new PlDataItemCustomView(this, "Stamina Time Reduce mCore: Unk1", "Stamina_Time_Reduce_mCore_Unk1", Bytes, 556),
                new PlDataItemCustomView(this, "Stamina Time Reduce mCore: Unk2", "Stamina_Time_Reduce_mCore_Unk2", Bytes, 560),
                new PlDataItemCustomView(this, "Stamina Time Reduce mCore: Unk3", "Stamina_Time_Reduce_mCore_Unk3", Bytes, 564),
                new PlDataItemCustomView(this, "Stamina Time Reduce mCore: Unk4", "Stamina_Time_Reduce_mCore_Unk4", Bytes, 568),
                new PlDataItemCustomView(this, "Stamina Time Reduce mCore: Unk5", "Stamina_Time_Reduce_mCore_Unk5", Bytes, 572),
                new PlDataItemCustomView(this, "Stamina Time Reduce mCore: Unk6", "Stamina_Time_Reduce_mCore_Unk6", Bytes, 576),
                new PlDataItemCustomView(this, "Stamina Time Reduce mCore: Unk7", "Stamina_Time_Reduce_mCore_Unk7", Bytes, 580),
                new PlDataItemCustomView(this, "Stamina Time Reduce mCore: Unk8", "Stamina_Time_Reduce_mCore_Unk8", Bytes, 584),
                new PlDataItemCustomView(this, "Stamina Time Reduce mCore: Unk9", "Stamina_Time_Reduce_mCore_Unk9", Bytes, 588),
                new PlDataItemCustomView(this, "Stamina Time Reduce mCore: Unk10", "Stamina_Time_Reduce_mCore_Unk10", Bytes, 592),
                new PlDataItemCustomView(this, "Stamina Time Reduce mCore: Unk11", "Stamina_Time_Reduce_mCore_Unk11", Bytes, 596),
                new PlDataItemCustomView(this, "Stamina Time Reduce mCore: Unk12", "Stamina_Time_Reduce_mCore_Unk12", Bytes, 600),
                new PlDataItemCustomView(this, "Stamina Time Reduce mCore: Unk13", "Stamina_Time_Reduce_mCore_Unk13", Bytes, 604),
                new PlDataItemCustomView(this, "Stamina Time Reduce mCore: Unk14", "Stamina_Time_Reduce_mCore_Unk14", Bytes, 608),
                new PlDataItemCustomView(this, "Stamina Time Reduce mCore: Unk15", "Stamina_Time_Reduce_mCore_Unk15", Bytes, 612),
                new PlDataItemCustomView(this, "Stamina Time Reduce mCore: Unk16", "Stamina_Time_Reduce_mCore_Unk16", Bytes, 616),
                new PlDataItemCustomView(this, "Stamina Time Reduce mCore: Unk17", "Stamina_Time_Reduce_mCore_Unk17", Bytes, 620),
                new PlDataItemCustomView(this, "Stamina Time Reduce mCore: Unk18", "Stamina_Time_Reduce_mCore_Unk18", Bytes, 624),
                new PlDataItemCustomView(this, "Mount Reduce Stamina mCore: Unk1", "Mount_Reduce_Stamina_mCore_Unk1", Bytes, 628),
                new PlDataItemCustomView(this, "Mount Reduce Stamina mCore: Unk2", "Mount_Reduce_Stamina_mCore_Unk2", Bytes, 632),
                new PlDataItemCustomView(this, "Mount Life Reduce Stamina mCore: Unk1", "Mount_Life_Reduce_Stamina_mCore_Unk1", Bytes, 636),
                new PlDataItemCustomView(this, "Mount Life Reduce Stamina mCore: Unk2", "Mount_Life_Reduce_Stamina_mCore_Unk2", Bytes, 640),
                new PlDataItemCustomView(this, "Mount Life Reduce Stamina mCore: Unk3", "Mount_Life_Reduce_Stamina_mCore_Unk3", Bytes, 644),
                new PlDataItemCustomView(this, "Mount Life Reduce Stamina mCore: Unk4", "Mount_Life_Reduce_Stamina_mCore_Unk4", Bytes, 648),
                new PlDataItemCustomView(this, "Unk67", "Unk67", Bytes, 652),
                new PlDataItemCustomView(this, "Unk68", "Unk68", Bytes, 656),
                new PlDataItemCustomView(this, "Unk69", "Unk69", Bytes, 660),
                new PlDataItemCustomView(this, "Quest Level HR Fix Attack Rate", "Quest_Level_HR_Fix_Attack_Rate", Bytes, 664),
                new PlDataItemCustomView(this, "Quest Level MR Fix Attack Rate", "Quest_Level_MR_Fix_Attack_Rate", Bytes, 668),
                new PlDataItemCustomView(this, "Critical Attack Rate", "Critical_Attack_Rate", Bytes, 672),
                new PlDataItemCustomView(this, "Bad Critical Attack Rate", "Bad_Critical_Attack_Rate", Bytes, 676),
                new PlDataItemCustomView(this, "Sharpness Recoil Reduction %", "Sharpness_Recoil_Reduction_", Bytes, 680),
                new PlDataItemCustomView(this, "Sharpness Recoil Reduction Value", "Sharpness_Recoil_Reduction_Value", Bytes, 681),
                new PlDataItemCustomView(this, "Unk70", "Unk70", Bytes, 682),
                new PlDataItemCustomView(this, "Unk71", "Unk71", Bytes, 686),
                new PlDataItemCustomView(this, "Unk72", "Unk72", Bytes, 690),
                new PlDataItemCustomView(this, "Unk73", "Unk73", Bytes, 694),
                new PlDataItemCustomView(this, "Unk74", "Unk74", Bytes, 698),
                new PlDataItemCustomView(this, "Physical Attack Rate Limit", "Physical_Attack_Rate_Limit", Bytes, 702),
                new PlDataItemCustomView(this, "Elemental Attack Rate Limit", "Elemental_Attack_Rate_Limit", Bytes, 706),
                new PlDataItemCustomView(this, "Condition Attack Flat Limit", "Condition_Attack_Flat_Limit", Bytes, 710),
                new PlDataItemCustomView(this, "Bowgun Elemental Attack Rate Limit", "Bowgun_Elemental_Attack_Rate_Limit", Bytes, 714),
                new PlDataItemCustomView(this, "Condition Attack Rate Limit", "Condition_Attack_Rate_Limit", Bytes, 718),
                new PlDataItemCustomView(this, "Stun Attack Rate Limit", "Stun_Attack_Rate_Limit", Bytes, 722),
                new PlDataItemCustomView(this, "Stamina Attack Rate Limit", "Stamina_Attack_Rate_Limit", Bytes, 726),
                new PlDataItemCustomView(this, "Mount Attack Rate Limit", "Mount_Attack_Rate_Limit", Bytes, 730),
                new PlDataItemCustomView(this, "Super Armor Stun Damage Rate", "Super_Armor_Stun_Damage_Rate", Bytes, 734),
                new PlDataItemCustomView(this, "Hyper Armor Damage Rate", "Hyper_Armor_Damage_Rate", Bytes, 738),
                new PlDataItemCustomView(this, "Hyper Armor Stun Damage Rate", "Hyper_Armor_Stun_Damage_Rate", Bytes, 742),
                new PlDataItemCustomView(this, "Gunner Defense Rate", "Gunner_Defense_Rate", Bytes, 746),
                new PlDataItemCustomView(this, "Gunner Elemental Resistance Bonus", "Gunner_Elemental_Resistance_Bonus", Bytes, 750),
                new PlDataItemCustomView(this, "------Skipping ahead 2.", "_Skipping_ahead_2_", Bytes, 751),
            };
        }
    }
}
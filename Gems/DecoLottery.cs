﻿using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Gems {
    public partial class DecoLottery : DecoPercent {
        public DecoLottery(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string UniqueId => $"{Item_Id}";

        [SortOrder(0)]
        [DisplayName("Name/Id")]
        [CustomSorter(typeof(DecoLotteryNameIdSorter))]
        public IdNamePair Name_And_Id => DataHelper.itemData[MainWindow.locale].TryGet((ushort) Item_Id, IdNamePair.Unknown((ushort) Item_Id));

        public override string Name => "None";
    }

    public class DecoLotteryNameIdSorter : ICustomSorter {
        public ListSortDirection SortDirection { get; set; } = ListSortDirection.Ascending;

        public int Compare(object x, object y) {
            if (x is DecoLottery x1 && y is DecoLottery x2) {
                if (MainWindow.showIdBeforeName) {
                    return x1.Name_And_Id.id.CompareTo(x2.Name_And_Id.id) * (SortDirection == ListSortDirection.Ascending ? 1 : -1);
                } else {
                    return string.Compare(x1.Name_And_Id.name, x2.Name_And_Id.name, StringComparison.Ordinal) * (SortDirection == ListSortDirection.Ascending ? 1 : -1);
                }
            }

            return 0;
        }
    }
}
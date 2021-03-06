using System.Collections.ObjectModel;
using MHW_Editor.Models;

namespace MHW_Editor.Weapons {
    public partial class Wp11Param {
        public ObservableCollection<PlDataItemCustomView> GetCustomView() {
            return new ObservableCollection<PlDataItemCustomView> {
                new PlDataItemCustomView(this, "Dragonpiercer X1", "Dragonpiercer_X1", Bytes, 1313),
                new PlDataItemCustomView(this, "Dragonpiercer Y1", "Dragonpiercer_Y1", Bytes, 1317),
                new PlDataItemCustomView(this, "Dragonpiercer X2", "Dragonpiercer_X2", Bytes, 1321),
                new PlDataItemCustomView(this, "Dragonpiercer Y2", "Dragonpiercer_Y2", Bytes, 1325),
                new PlDataItemCustomView(this, "-------------------------------------------------------------------------------------------", "__250", Bytes, 3),
                new PlDataItemCustomView(this, "Thousand Dragons X1", "Thousand_Dragons_X1", Bytes, 2569),
                new PlDataItemCustomView(this, "Thousand Dragons Y1", "Thousand_Dragons_Y1", Bytes, 2573),
                new PlDataItemCustomView(this, "Thousand Dragons X2", "Thousand_Dragons_X2", Bytes, 2577),
                new PlDataItemCustomView(this, "Thousand Dragons Y2", "Thousand_Dragons_Y2", Bytes, 2581),
            };
        }
    }
}
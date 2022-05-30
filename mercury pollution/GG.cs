using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.ToolTips;

namespace yt_DesignUI
{
    internal class GMarkerGoogle
    {
        private PointLatLng pointLatLng;
        private object red_small;

        public GMarkerGoogle(PointLatLng pointLatLng, object red_small)
        {
            this.pointLatLng = pointLatLng;
            this.red_small = red_small;
        }

        public GMapRoundedToolTip ToolTip { get; internal set; }
        public object ToolTipText { get; internal set; }
        public MarkerTooltipMode ToolTipMode { get; internal set; }
    }
}
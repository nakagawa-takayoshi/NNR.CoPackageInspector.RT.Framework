using NNR.CoPakageInspector.RT.MainApp.View.Interface;
using System.Drawing;

namespace NNR.CoPakageInspector.RT.MainApp.View.Model.Factory
{
    internal class TitleBarPolygonFactory
    {

        private readonly Point _startPoint;
        private readonly Point _endPoint;
        public TitleBarPolygonFactory(Point startPoint, Point endPoint)
        {
            _startPoint = startPoint;
            _endPoint = endPoint;
        }

        public ITitleBarPolygon Create(int index, bool isTopTitle)
        {
            if (index == 0) return new TitleBarFirstPolygon(_startPoint, _endPoint, isTopTitle);
            if (isTopTitle) return new TitleBarParentPolygon(_startPoint, _endPoint, index);

            return new TitleBarChildPolygon(_startPoint, _endPoint, index);
        }
    }
}

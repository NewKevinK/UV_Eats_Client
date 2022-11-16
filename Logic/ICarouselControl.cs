using System;
using System.Collections.Generic;
using System.Text;

namespace UV_Eats_Client.Logic
{
    public interface ICarouselControl
    {
        double Rotate(double startXInScreenCoordinates, double endXInScreenCoordinates);
        void RotateIncrement(int increment);
        void RotateRight();
        void RotateLeft();
        bool ShowRotation { get; set; }
    }
}

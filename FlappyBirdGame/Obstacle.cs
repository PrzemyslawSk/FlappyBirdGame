using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;

namespace FlappyBirdGame
{
    class Obstacle
    {
        Rectangle texture;
        Vector startPosition = new Vector(0, 0);
        public Obstacle(Rectangle texture, Vector startPosition)
        {
            this.startPosition = startPosition;
            this.texture = texture;
        }



    }
}

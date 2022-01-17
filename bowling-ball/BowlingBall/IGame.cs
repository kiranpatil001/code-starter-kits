using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall
{
    public interface IGame
    {
        void Roll(int pinsHit);
        int GetScore();

    }
}

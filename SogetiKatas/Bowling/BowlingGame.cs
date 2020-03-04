using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SogetiKatas.Bowling
{
    public class BowlingGame
    {
        public BowlingGame()
        {
            Frames = new List<Frame>();
        }
        public List<Frame> Frames { get; }

        public int GetScore()
        {

            for(int i = 0; i < Frames.Count; i++)
            {
                if (i == 9)
                {
                    var finalFrame = Frames[i] as TenthFrame;
                    if (finalFrame.IsSpare || finalFrame.IsStrike)
                        finalFrame.Score = finalFrame.FirstRoll + finalFrame.SecondRoll + finalFrame.BonusRoll;
                    else
                        finalFrame.Score = finalFrame.FirstRoll + finalFrame.SecondRoll;
                    continue;
                }

                if (i == 8)
                {
                    var ninthFrame = Frames[i];
                    var tenthFrame = Frames[i + 1];
                    if (ninthFrame.IsStrike)
                    {
                        ninthFrame.Score = ninthFrame.FirstRoll + tenthFrame.FirstRoll + tenthFrame.SecondRoll;
                    }
                    else if(ninthFrame.IsSpare)
                    {
                        ninthFrame.Score = ninthFrame.FirstRoll + ninthFrame.SecondRoll + tenthFrame.FirstRoll;
                    }
                    else
                    {
                        ninthFrame.Score = ninthFrame.FirstRoll + ninthFrame.SecondRoll;
                    }
                    continue;
                }

                var frame = Frames[i];
                var frameScore = frame.FirstRoll;

                if (frame.IsStrike)
                {

                    var nextFrame = Frames[i + 1];
                    frameScore += nextFrame.FirstRoll;
                    if (nextFrame.IsStrike)
                    {
                        var thirdFrame = Frames[i + 2];
                        frameScore += thirdFrame.FirstRoll;
                    }
                    else
                        frameScore += nextFrame.SecondRoll;
                }
                else if (frame.IsSpare)
                {
                    frameScore += frame.SecondRoll;
                    var nextFrame = Frames[i + 1];
                    frameScore += nextFrame.FirstRoll;
                }
                else
                {
                    frameScore += frame.SecondRoll;
                }
                frame.Score = frameScore;
            }
            return Frames.Sum(frame => frame.Score);
        }
    }
}

namespace GoGameTest
{
    public class Board
    {
        private const int BOARDSIZE = 19;

        private PositionStatus[,] positionStatusMatrix = new PositionStatus[BOARDSIZE, BOARDSIZE];
        private StoneColor?[,] stoneColorMatrix = new StoneColor?[BOARDSIZE, BOARDSIZE];
        private StoneColor CurrentWinner = StoneColor.White;
        private bool inKomiMode = true;


        public PositionStatus GetPositionStatus(int x, int y)
        {

            return stoneColorMatrix[x, y] == null ? PositionStatus.EmptyPosition : PositionStatus.FilledPosition;
        }

        public void AddStoneToPosition(StoneColor stoneColor, int x, int y)
        {
            inKomiMode = false;
            CurrentWinner = stoneColor;
            positionStatusMatrix[x, y] = PositionStatus.FilledPosition;
            stoneColorMatrix[x, y] = stoneColor;

            //making assuptions make algorithm make more easy - fixed values
            //make it more easy to make algorithm later on


            CheckStonesArroundPositionAndRemove(x, y);
        }

        private void CheckStonesArroundPositionAndRemove(int x, int y)
        {
            RemoveSurroundedStone(x, y - 1);
            RemoveSurroundedStone(x, y + 1);
            RemoveSurroundedStone(x - 1, y);
            RemoveSurroundedStone(x + 1, y);
        }

        private void RemoveSurroundedStone(int x, int y)
        {
            if(IsFullySurrounded(x, y, StoneColor.White))
            {
                positionStatusMatrix[x, y] = PositionStatus.EmptyPosition;
                stoneColorMatrix[x, y] = null;
            }
        }

        private bool IsFullySurrounded(int x, int y, StoneColor surroundingStoneColor)
        {
            //if (positionStatusMatrix[x, y] != PositionStatus.FilledPosition)
            //{
            //    return false;
            //}

            //if (x > 0 && stoneColorMatrix[x - 1, y] == surroundingStoneColor &&
            //    stoneColorMatrix[x + 1, y] == surroundingStoneColor &&
            //    y > 0 && stoneColorMatrix[x, y - 1] == surroundingStoneColor &&
            //    stoneColorMatrix[x, y + 1] == surroundingStoneColor)
            //{
            //    return true;
            //}
            //return false;

            bool surroundedLeft = (x == 0 || stoneColorMatrix[x - 1, y] == surroundingStoneColor);
            bool surroundedRight = (stoneColorMatrix[x + 1, y] == surroundingStoneColor);
            bool surroundedBottom = (stoneColorMatrix[x, y + 1] == surroundingStoneColor);
            bool surroundedUp = (y == 0 || stoneColorMatrix[x, y - 1] == surroundingStoneColor);

            if (surroundedLeft
                && surroundedRight
                && surroundedBottom
                && surroundedUp)
            {
                return true;
            }
            return false;
        }

        public StoneColor GetWinner()
        {
            if (inKomiMode)
            {
                return StoneColor.White; ;
            }

            bool surrounding = IsFullySurrounded(1, 1, StoneColor.Black);
            var color1 = stoneColorMatrix[1, 2];
            if(surrounding)
            {
                if (color1 != null) return color1.Value;
            }
            return CurrentWinner; 
        }
    }
}
namespace GameClicker
{


    class ClickerGame
    {

        private int _points = 0, _pointsPerClick = 1, _pointsPerClickIncreas = 1;

        public int _Points
        {
            get { return _points; }
            set { _points = value; }
        }

        public int _PointsPerClick
        {
            get { return _pointsPerClick; }
            set { _pointsPerClick = value; }
        }

        public int _PointsPerClickIncrease
        {
            get { return _pointsPerClickIncreas; }
            set { _pointsPerClickIncreas = value; }
        }

        public int click()
        {
            _points += _pointsPerClick;
            return _points;
        }

        public int upgrade()
        {
            if (_points > 10)
            {
                _points -= 10;
                _pointsPerClick += _pointsPerClickIncreas;
            }
            return _points;
        }

        public int superUpgrade()
        {
            if (_points > 100)
            {
                _points -= 100;
                _pointsPerClickIncreas++;
            }
            return _pointsPerClickIncreas;
        }
    }


}

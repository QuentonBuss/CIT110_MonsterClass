using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monsterClass
{
    public class SeaMonster
    {
        public enum EmotionalState
        {
            Happy,
            Sad,
            Angry
        }

        private string _name;
        private double _weight;
        private bool _canUseFreshwater;
        private EmotionalState _currentEmotionalState;
        private string _homeSea;




        #region PROPS

        public string HomeSea
        {
            get { return _homeSea; }
            set { _homeSea = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public bool CanUseFreshWater
        {
            get { return _canUseFreshwater; }
            set { _canUseFreshwater = value; }
        }

        public EmotionalState CurrentEmotionalState
        {
            get { return _currentEmotionalState; }
            set { _currentEmotionalState = value; }
        }

        #endregion
        #region METHODS
        public string SeaMonsterAttitude()
        {
            return _name + " is " + _currentEmotionalState + ".";
        }
        #endregion

        public SeaMonster()
        {

        }

        public SeaMonster(string name)
        {
            _name = name;
        }
    }
}

using System;
using System.Data.SqlTypes;

namespace EternalQuest
{
    public abstract class Goal
    {
        protected string _shortName;
        protected string _description;
        protected string _points;

        public Goal(string name, string description,int points)
        {
            _shortName = name;
            _description = description;
            _points = points.ToString();
        }
        public abstract void RecordEvent();

        public abstract bool IsComplete();

        public virtual string GetDetailsString()
        {   string status = IsComplete() ? "[X]" : "[ ]";
            return $"{status} {_shortName} ({_description})";
           
        }
        public abstract string GetStringRepresentation();

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class LocatinEventArgs : EventArgs
    {
        public Location Location { get; set; }
    }
    //Publisher ==> Like Parernt
    internal class Ball
    {
        public int Id { get; set; }
        private Location location;

        public Ball(int id)
        {
            Id = id;
        }

        public event EventHandler<LocatinEventArgs> OnBallChanged;  //Can Remove "event" ==> it's not better

        public Location Location
        {
            get { return location; }
            set
            {
                if (!location.Equals(value))
                {
                    location = value;
                    On_BallChanged(location);
                }
            }
        }
        protected virtual void On_BallChanged(Location location)
        {
            OnBallChanged?.Invoke(this, new LocatinEventArgs { Location = location });
        }
        public override string ToString()
        {
            return $"Ball: {Id}";
        }
    }
}

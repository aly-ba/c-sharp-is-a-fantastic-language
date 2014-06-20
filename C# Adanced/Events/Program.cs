using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitTyping
{
   

    class Program
    {
        static void Main(string [] args )
        {

            var tower = new ClockTower();

            var john = new Person("John", tower);

            var sally = new Person("Sally", tower);

            tower.ChimeFimePM();
        }
         

    }

    public class Person
    {
        

        public string  _name { get; set; }
        private ClockTower _tower;

        public Person(string name, ClockTower tower)
        {
            _name = name;
            _name = name;
            _tower.Chime += (object sender, EventArgs args) =>
            {
                Console.WriteLine("{0} heard the clock chime.", _name);
                switch(args.Time)
                {
                    case 6: Console.WriteLine("{0} heard is wake up.", _name);
                        break;
                    case 17: Console.WriteLine(" {1} is going home .", _name);
                        break;

                }
            };
        }

        
    }

    public delegate void ChimeEventHandller(object sender , EventArgs  args);

    public class ClockTowerEventArgs : EventArgs
    {
        public int Time { get; set; }
    }

    public class ClockTower 
    {
        public event ChimeEventHandller Chime;
        public void ChimeFimePM()
        {

            Chime(this, new ClockTowerEventArgs {Time =17} );
        }
            //Chime(this, EventArgs.Empty );
        

        public void ChimeSiwAM()
        {

             Chime(this,  new ClockTowerEventArgs {Time =6} );
            //Chime(this, EventArgs.Empty );
        }

    }
}

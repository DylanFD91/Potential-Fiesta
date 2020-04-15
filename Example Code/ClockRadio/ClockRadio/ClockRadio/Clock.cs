using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockRadio
{
    class Clock
    {
        //memeber variables (Has A)
        public string time;
        public bool alarmStatus;
        public string alarmTime;
        public string date;


        //constuctor (spawner)
        public Clock()
        {
            time = "12:00am";
            alarmStatus = false;
            alarmTime = null;
            date = "01/01/0001";
        }
        //member methods (Can Do)
        public void Initialize()
        {
            ChangeTime();
            ChangeDate();
            AlarmSetup();
        }
        public void ChangeTime()
        {
            Console.WriteLine("Please enter the new time: ");
            time = Console.ReadLine();
        }
        public void ChangeDate()
        {
            Console.WriteLine("Please enter the new Date: ");
            date = Console.ReadLine();
        }
        public void AlarmSetup()
        {
            bool isValid = false;
            int numberOfWrong = 0;
            do
            {
                Console.WriteLine("Would you like to set up an alarm?");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "Yeah":
                    case "Yup":
                    case "yup":
                    case "Yes":
                    case "yes":
                        ToggleAlarm();
                        SetAlarm();
                        isValid = true;
                        break;
                    case "no":
                        Console.WriteLine("You can set an alarm later");
                        isValid = true;
                        break;
                    default:
                        Console.WriteLine("Please enter a confirmation");
                        numberOfWrong++;
                        break;
                }
            } while (isValid == false && numberOfWrong < 5);
        }
        public void ToggleAlarm()
        {
            alarmStatus = !alarmStatus;
        }
        public void SetAlarm()
        {
            Console.WriteLine("Please enter the new alarm time: ");
            alarmTime = Console.ReadLine();
        }
        public void DisplayTime()
        {
            Console.WriteLine("The current time is: " + time);
        }
        public void DisplayDate()
        {
            Console.WriteLine("The current date is: " + date);
        }
    }
}

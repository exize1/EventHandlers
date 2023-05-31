using System;

namespace EventHandlers // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //delegate


            void ToUpperCase(string text) => Console.WriteLine(text.ToUpper());
            void ToLowerCase(string text) => Console.WriteLine(text.ToLower());

            TryDelegate.WriteOutput("this was lower case", ToUpperCase);
            TryDelegate.WriteOutput("this was UPPER CASE", ToLowerCase);


            var buttonMaster = new Button();
            buttonMaster.ButtonPressed += (sender, eventArgs) =>
            {
                Console.WriteLine($"Button {eventArgs.Keycode} was pressed");
            };

            Start:

            var keycode = Console.ReadKey(true).KeyChar;
            buttonMaster.OnButtonPressed(keycode);

            goto Start;

        }

        

    }
}

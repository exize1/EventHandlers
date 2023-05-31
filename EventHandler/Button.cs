using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlers
{
    internal class Button
    {
        public EventHandler<MyCustomArguments> ButtonPressed;

        public void OnButtonPressed( char keyCode)
        {
            ButtonPressed?.Invoke(this, new MyCustomArguments(keyCode));
        }
    }
}

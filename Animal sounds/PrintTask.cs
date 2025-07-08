using System;

namespace Animal_sounds
{
    public class PrintTask : ICommand
    {
        private string _message;

        public PrintTask(string message)
        {
            _message = message;
        }

        public void Execute()
        {
            Console.WriteLine(_message);
        }
    }
}

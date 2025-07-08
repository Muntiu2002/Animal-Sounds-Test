using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Animal_sounds
{
    public class TaskQueueManager
    {
        private static readonly Lazy<TaskQueueManager> _instance =
            new Lazy<TaskQueueManager>(() => new TaskQueueManager());

        public static TaskQueueManager Instance => _instance.Value;

        private readonly Queue<ICommand> _commands = new Queue<ICommand>();

        private TaskQueueManager() { }

        public void EnqueueCommand(ICommand command)
        {
            _commands.Enqueue(command);
        }

        public async Task ExecuteCommands()
        {
            while (_commands.Count > 0)
            {
                var command = _commands.Dequeue();
                command.Execute();
                await Task.Delay(10);
            }
        }
    }
}

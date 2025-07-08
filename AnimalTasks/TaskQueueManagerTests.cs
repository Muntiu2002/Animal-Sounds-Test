using Animal_sounds;
using System.Threading.Tasks;
using Xunit;

namespace AnimalTasks
{
    public class TaskQueueManagerTests
    {
        [Fact]
        public void Instance_ShouldReturnSameObject()
        {
            var manager1 = TaskQueueManager.Instance;
            var manager2 = TaskQueueManager.Instance;

            Assert.Same(manager1, manager2);
        }

        [Fact]
        public async Task EnqueueCommand_ShouldExecuteWithoutException()
        {
            var manager = TaskQueueManager.Instance;
            manager.EnqueueCommand(new PrintTask("Test message"));

            var exception = await Record.ExceptionAsync(() => manager.ExecuteCommands());

            Assert.Null(exception);
        }
    }
}

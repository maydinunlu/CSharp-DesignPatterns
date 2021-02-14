namespace TemplateMethodPattern
{
    public class SendMailExecuter
    {
        private Task _task;

        public SendMailExecuter()
        {
            _task = new SendMailTask();
        }

        public void Execute()
        {
            _task.Execute();
        }
    }
}
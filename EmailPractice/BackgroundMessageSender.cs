namespace EmailPractice
{
    public class BackgroundMessageSender : BackgroundService
    {
        private readonly IServiceProvider _SP;

        public BackgroundMessageSender(IServiceProvider SP)
        {
            _SP = SP;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            using var scope = _SP.CreateScope();
            var scopeSendMessage = scope.ServiceProvider.GetRequiredService<IMailKit>();

            Console.WriteLine("Server started successfully ");

            while (!stoppingToken.IsCancellationRequested)
            {
                scopeSendMessage.Send("Testing",
                    "asp2022pd011@rodion-m.ru",
                    "alexey_teterin@mail.ru",
                    "Server is working",
                    "Server is working now succesfully!" + " Total memory size: " +
                    GC.GetTotalMemory(false) + " bytes."
                );

                await Task.Delay(new TimeSpan(1, 0, 0));
            }
        }
    }
}

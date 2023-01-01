namespace DIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Email email = new Email();
            //email.Send();

            SMS sms = new SMS();
            //sms.Send();
            Whatsapp whatsapp = new Whatsapp();

            List<INotification> notificationList = new List<INotification>();
            notificationList.Add(email);
            notificationList.Add(sms);
            //notificationList.Add(whatsapp);
            notificationList.Add(new Facebook());

            MessageSender messageSender = new MessageSender(notificationList);

            messageSender.Send();
        }
    }
}
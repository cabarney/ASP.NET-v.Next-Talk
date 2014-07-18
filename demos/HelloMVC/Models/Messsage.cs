namespace Demo.Models
{ 
    public class Message
    {
        public string From { get; set; }
        public string Text { get; set; }
    }

    public interface IMessageGenerator
    {
    	Message GetMessage();
    }

    public class MessageGenerator : IMessageGenerator
    {
    	public Message GetMessage()
    	{
    		return new Message{
    			From = "The Injected Service",
    			Text = "Hello!"
    		};
    	}
    }
}
using System;

namespace Message
{
    public abstract class Message
    {
        public abstract void execute();
    }

    public class MessageA : Message
    {





        public override void execute()
        {
            throw new NotImplementedException();
        }
    }

    public class MessageB : Message
    {





        public override void execute()
        {
            throw new NotImplementedException();
        }
    }

    public class MessageC : Message
    {




        public override void execute()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Message message = new MessageA();
            message.execute();
        }
    }
}

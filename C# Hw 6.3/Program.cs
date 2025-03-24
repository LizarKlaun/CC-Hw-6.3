namespace C__Hw_6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRemoteControl tv = new Television();
            IRemoteControl radio = new Radio();

            tv.TurnOn();
            tv.SetChannel(5);
            tv.TurnOff();

            radio.TurnOn();
            radio.SetChannel(104);
            radio.TurnOff();
        }

        public interface IRemoteControl
        {
            void TurnOn();
            void TurnOff();
            void SetChannel(int channel);
        }

        public class Television : IRemoteControl
        {
            private bool isOn = false;
            private int currentChannel = 1;

            public void TurnOn()
            {
                isOn = true;
                Console.WriteLine("Телевізор увімкнено.");
            }

            public void TurnOff()
            {
                isOn = false;
                Console.WriteLine("Телевізор вимкнено.");
            }

            public void SetChannel(int channel)
            {
                if (isOn)
                {
                    currentChannel = channel;
                    Console.WriteLine($"Перемкнуто на канал {channel}.");
                }
                else
                {
                    Console.WriteLine("Неможливо змінити канал. Телевізор вимкнено.");
                }
            }
        }

        public class Radio : IRemoteControl
        {
            private bool isOn = false;
            private int currentFrequency = 101;

            public void TurnOn()
            {
                isOn = true;
                Console.WriteLine("Радіо увімкнено.");
            }

            public void TurnOff()
            {
                isOn = false;
                Console.WriteLine("Радіо вимкнено.");
            }

            public void SetChannel(int channel)
            {
                if (isOn)
                {
                    currentFrequency = channel;
                    Console.WriteLine($"Перемкнуто на частоту {channel} FM.");
                }
                else
                {
                    Console.WriteLine("Неможливо змінити частоту. Радіо вимкнено.");
                }
            }
        }
    }
}

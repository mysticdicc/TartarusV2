using Newtonsoft.Json;

namespace TartarusV2.Classes
{
    class Configuration
    {
        public Key[] Keys;

        public Configuration()
        {
            Keys = new Key[20];

            for (int i = 1; i < 21; i++)
            {
                Keys[i - 1] = new Key(i);
            }
        }
    }
}

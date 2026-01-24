namespace Lab7
{
    internal class Program
    {
        public enum NICType
        {
            Ethernet,
            TokenRing
        }
        class NIC
        {
            public string Manufacture { get; private set; }
            public string MacAddress { get; private set; }
            public NICType Type { get; private set; }

            private static NIC test;

            private NIC(string manufacture, string macaddress, NICType type)
            {
                this.Manufacture = manufacture;
                this.MacAddress = macaddress;
                this.Type = type;
            }
            public static NIC GetNIC(string manufacture, string macaddress, NICType type)
            {
                if (test == null)
                {
                    test = new NIC(manufacture, macaddress, type);
                }

                return test;
            }
        }
        class Machine
        {
            NIC nIC;
            public Machine(NIC nic)
            {
                this.nIC = nic;
            }
        }
        static void Main(string[] args)
        {
            NIC nIC = new NIC("Intel", "00-14-22-01-23-45", NICType.Ethernet);
            Machine machine = new Machine(nIC);
        }
    }
}

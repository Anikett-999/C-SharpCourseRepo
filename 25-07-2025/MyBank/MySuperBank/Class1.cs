namespace MySuperBank
{
        public class MyBank
        {
            public string Number { get; set; }
            public string Owner { get; set; }
            public string Balance { get; set; }

            public MyBank(string Name, string InitialBalance)
            {
                Owner = Name ;
                Balance = InitialBalance ;

            }
        }
}

    public int secondindexsum(int[] input, int Sum , int index)
        {
            if (input == null || Sum == null || index ==null) {throw new ArgumentNullException("null input array");}
            else if (input.Length == 0 ) { throw new ArgumentException("input array has no elements");}
            else
            {
                Dictionary<int,int> Counter = new Dictionary<int,int>();
                Dictionary<int,int> IndexMapper = new Dictionary<int,int>();
            
             //Data loader
            for (int k=0 ; k<input.Length-1 ; k++)
            {
                if (Counter.ContainsKey(input[k]))
                {
                    Counter[input[k]] = Counter[input[k]] + 1;
                    IndexMapper[input[k]] = k;
                }
                else 
                {
                    Counter.Add(input[k],1);
                    IndexMapper[input[k]] = k;
                }
            }
            
            //find the difference 
            int count = 0;
            int otherindex = 0;
            int Diff = 0 ;
            int FI = 0;

            for (int y = 0; y < input.Length - 1 && count < index; y++)
            {
                    Diff = Sum - input[y];

                    if (Counter.ContainsKey(Diff))
                    {
                        FI=y;
                        otherindex = IndexMapper[Diff];
                        count++;

                        if (Counter[input[y]] > 1)
                        { Counter[input[y]] -= 1; }
                        else if(Counter[input[y]]==1)
                        { Counter.Remove(input[y]);}
                    }
            }

            Console.WriteLine("Second matching value is at index:{0} & {1}",FI,otherindex);
            return otherindex;
            
            }
        
        
        }

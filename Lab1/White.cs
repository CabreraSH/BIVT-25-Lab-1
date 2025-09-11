namespace Lab1
{
    public class White
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            if (d > 0)
            {
                answer = true;
            }
            // end

            return answer;
        }
        public bool Task2(int n)
        {
            bool answer = false;

            // code here
            if (n % 2 == 0)
            {
            answer = true;
            }
            // end

            return answer;
        }
        public int Task3(int a, int b)
        {
            int answer = 0;

            // code here
            if (a > b)
            {
                answer = a;
            }
            
            else
            {
                answer = b;
            }
            // end

            return answer;
        }
        public double Task4(double d, double f)
        {
            double answer = 0;

            // code here
            double Trued = d;
            double Truef = f;
            
            if (d < 0)
            {
                Trued = -d;
            }
            if (f < 0)
            {
                Truef = -f;
            }

            if (Trued <= Truef)
            {
                answer = d;
            }
            else
            {
                answer = f;
            }
        }
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double abx = x;
            
                if (x >= 0)
                {
                    abx = x;
                }
                    else
                    {
                        abx = -x;
                    }

                if (abx > 1)
                {
                    answer = 1;
                }
                    else
                    {
                    answer = x;
                    }
            // end

            return answer;
        }
        public bool Task6(double x, double y, double r)
        {
            bool answer = false;

            // code here
                double circle = x * x + y * y + r * r;

                    if (circle < 0)
                    {
                        circle = -circle;
                    }

                if (circle <= 1e-6 )
                {
                    answer = true;
                }
            // end

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = false;

            // code here
                int s = n * n;

                    if ((s - n) > (2 * n))
                    { 
                        if (n % 2 == 0)
                        {
                            answer = true;
                        }
                    }
            return answer;
            
            // end

            return answer;
        }
        public bool Task8(double L, int T, int M)
        {
            bool answer = false;

            // code here
                if ((L <= 30) && (T + M >= 5) && (M % 2 == 0)) {
                answer = true;
            }
            // end

            return answer;
        }
    }
}

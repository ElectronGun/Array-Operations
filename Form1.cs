namespace Lab_4
{
    public partial class Form1 : Form
    {
        private int[] array = new int[100];   //array with 100 elements

        private int currentIndex = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = sum(array).ToString();
        }

        public int sum(int[] a)   //function sum that takes int array 'a' and returns a int
        {   //begin function
            // YOUR CODE HERE
            int sum = 0;   //initialize int sum to zero
            for (int i = 0; i < a.Length; i++)   //start loop to check all elements of the array 'a'
            {   //begin loop
                sum += a[i];  //adds the value of an element and stores in variable sum
            }   //end of loop
            return sum;   // Calculated sum
        }   //end function

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = max(array).ToString();
        }

        public int max(int[] a)    //function max that takes int array 'a' as input and returns a int
        {   //begin function
            // YOUR CODE HERE
            int max = a[0];   //initialize int max to zero
            for (int i = 1; i < a.Length; i++)   //start loop to check all elements except 1st(already assigned to max outside loop) in array 'a'
            {   //begin loop
                if (a[i] > max)  //determine IF current element in array 'a' is greater than max
                {   //begin if
                    max = a[i];  //put value of current element in array 'a' to variable max
                }   //end if
            }   //end loop
            return max; // Calculated maximum.
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = oddAvg(array).ToString();
        }

        public float oddAvg(int[] a)   //function oddAvg that takes int array 'a' as input and returns avg of odd numbers in array
        {   //begin function
            // YOUR CODE HERE
            float sum = 0;   //initialize int sum to zero - sum to determine average
            float count = 0;   //initialize int count to zero - # of elements to average
            for (int i = 0; i < a.Length; i++)   //start loop to check all elements in array 'a'
            {   //begin loop
                if (a[i] % 2.0f != 0)  //divide, decide if not equal - divide current element by 2 and check that not equal to zero
                {   //begin if
                    sum += a[i];   //adds the value in element and stores in variable sum
                    count++;   //increment variable count
                }   //end if
            }   //end loop
            return sum / count; // Calculated average of all odd numbers in array. 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[] reversedArray = reverse(array);
            textBox2.Text = string.Join(", ", reversedArray.Select(p => p.ToString()).ToArray());   //string representation display in textBox2
        }

        public int[] reverse(int[] a)   //function reverse that takes array 'a' as input and returns a int
        {   //begin function
            // YOUR CODE HERE
            int[] output = new int[a.Length];   //initialize int array output with same length and input array 'a'
            for (int i = 0; i < a.Length; i++)   //start loop to check all elements in array 'a'
            {   //begin loop
                output[i] = a[a.Length - 1 - i];  //calc position from end of input array 'a' using current element value and place into new array 'output'
            }   //end loop
            return output;  //return reverse array of same length as input
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int n;
            bool success = int.TryParse(textBox3.Text, out n);
            if (success)
            {
                int[] result = take(array, n); // take n elements
                textBox2.Text = string.Join(", ", result);   //input textbox2
            }
            else
            {
                MessageBox.Show("Error: enter a number.");
            }
        }

        public int[] take(int[] a, int n)   //function take that considers int array 'a' and int 'n' as inputs and returns a new array 'output'
        {   //begin function
            // YOUR CODE HERE
            if (n <= 0 || n > a.Length)  // check n<=0, n>length of array 'a'. if either true then both true
            {   //begin if
                return a;   //returns orig array 'a' if either true
            }   //end if
            else   //if neither true then create new int array 'output' with size = n
            {   //begin else
                int[] output = new int[n];   // initialize new int array 'output' with size determined by 'n' input
                for (int i = 0; i < n; i++) //start loop to check all elements in array 'a' up to n-1(the last element)
                {   //begin loop
                    output[i] = a[i];   //put value of current element in array 'a' to new array 'output' 
                }   //end loop
                return output;  //return output array with 1st n elements of array 'a'
            }  //end else
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (currentIndex < 100)
            {
                int number;
                bool success = int.TryParse(textBox1.Text, out number);
                if (success)
                {
                    array[currentIndex] = number;
                    currentIndex++;
                }
                else
                {
                    MessageBox.Show("Error: enter a number.");
                }
            }
            else
            {
                MessageBox.Show("Array is maxed out...disk starting on fire");
            }
        }

    }
}
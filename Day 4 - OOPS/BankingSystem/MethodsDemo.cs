public class MethodsDemo
{
    //Methods overloading - 
    //you can have same name for the many methods doing similar kind of operations, but the return type or parameters would be different


        // public int Add(int num1, int num2)
        // {
        //     return num1 + num2;
        // }

        // public int Add(int num1, int num2, int num3)
        // {
        //     return num1 + num2 + num3;
        // }

        // public int Add(int num1, int num2, int num3 , int num4)
        // {
        //     return num1 + num2 + num3 + num4;
        // }

            //instead of keeping on writeing more and more methods for adding integers, C# has a feature call Param Array


      


        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public string Add(string str1, string str2)
        {
            return str1 + " " + str2;
        }

        public int Add(int num1, int num2,params int[] moreNumbers)
        {
             int total = num1 + num2;
            foreach(int num in moreNumbers)
            {
                total = total + num;
            }
            return total;
        }


        public string PlaceAnOrderAtRestaurant(string soupName, string mainCourseName, string starterName = "",string desertName = "")
        {
            return "Your order is : " + soupName + " " + mainCourseName + " " + starterName + " " + desertName;
        }

}
# c_sharp basic grammar

```c#
using System;
using System.Collections.Generic;
using System.Ling;
using System.Text;
using System.Threading.Tasks;


namespace C샵_수업_1
{
    class Program
    {
        // 정수 값을 입력받아 3으로 나눈 결과를 출력
        static void ValMain()
        {
            int nScore = 0;
            float fAverage = 0.0f;
            string sScore, sAverage;
            Console.WriteLine("Score: " + nScore);
            Console.WriteLine("Average: " + fAverage);
            Console.WriteLine("Please input integer\n: ");
            sScore = Console.ReadLine();
            
            nScore = Convert.ToInt32(sScore);
            fAverage = nScore / 3.0f;
            Console.WriteLine("sore: " + nScore + "average : " + fAverage);
            sAverrage = Convert.ToString(fAverage);
            Console.WriteLine("string average : " + sAverage);
        }
        
        // 랜덤클래스를 활용해본 예제  
    }
}


// 
```




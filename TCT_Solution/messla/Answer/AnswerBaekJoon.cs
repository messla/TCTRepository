using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Answer
{
    class AnswerBaekJoon
    {
        static void Main(string[] args)
        {
            #region 가이드

            // 01) GitHub 와 Visual Studio 연동
            //https://it-earth.tistory.com/112

            //레파지토리
            //https://lheon.tistory.com/29

            #endregion

            #region 2021-03-24 (수) 2231번 분해합

            //int iData = Convert.ToInt32(Console.ReadLine());
            //var lisData = new List<int>();
            //int curData = iData;
            //int sum = 0;
            //int iOutData = 0;

            //for (int i = 0; i < iData; i++)
            //{
            //    curData = i;

            //    for (int j = 0; j < i.ToString().Length; j++)
            //    {

            //        if (curData.ToString().Length > 1)
            //        {
            //            lisData.Add(curData % 10);
            //            curData = curData / 10;
            //        }
            //        else
            //        {
            //            lisData.Add(curData);
            //        }
            //    }

            //    for (int k = 0; k < lisData.Count; k++)
            //    {
            //        sum += lisData[k];
            //    }

            //    sum = sum + i; // 분해합 구하기

            //    if (sum == iData) // 합이 일치하면 break
            //    {
            //        iOutData = i;
            //        break;
            //    }
            //    else // 초기화
            //    {
            //        sum = 0;
            //        lisData.Clear();
            //    }
            //}

            //Console.WriteLine(iOutData);

            #endregion

            #region 2021-03-24 (수) 7568번 덩치

            //int iData = Convert.ToInt32(Console.ReadLine());
            //int[,] arriData = new int[iData, 2];
            //int[] arriData2 = new int[2];
            //string strData = string.Empty;
            //int[] arrOutData = new int[iData];
            //int k = 0;
            ////ArrayList arrlist = new ArrayList();  // 어레이 리스트 사용으로 string을 split하여 각각 [0], [1] 배열에 저장 // using System.Collections; 선언할 것


            //for (int i = 0; i < iData; i++)
            //{
            //    strData = Console.ReadLine();
            //    arriData2 = Array.ConvertAll(strData.Split(' '), p => Convert.ToInt32(p));

            //    //arrlist.Add(strData.Split(' '));

            //    for (int j = 0; j < arriData2.Length; j++)
            //    {
            //        arriData[i, j] = arriData2[j];
            //    }
            //}

            //for (int i = 0; i < iData; i++)
            //{
            //    k = 0;

            //    for (int j = 0; j < iData; j++)
            //    {
            //        if (arriData[i, 0] < arriData[j, 0] && arriData[i, 1] < arriData[j, 1])
            //        {
            //            k++;
            //        }
            //    }
            //    arrOutData[i] = k + 1;
            //}

            //for (int i = 0; i < arrOutData.Length; i++)
            //{
            //    Console.Write(arrOutData[i] + " ");
            //}

            #endregion

        }
    }
}

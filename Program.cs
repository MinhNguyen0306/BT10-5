using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapDiemDanh_10_5_LeMinh
{
    class Program
    {
        static int timsomax(int[] a_235, int n)
        {
            int max = a_235[0];
            for (int i = 0; i < a_235.Length; i++)
            {
                if (max < a_235[i])
                    max = a_235[i];
            }
            return max;
        }

        static void Main(string[] args)
        {
            int[] a_235 = { 12, 4, 10, 4, 2, 7, -2, -6 , 2, 6};
            int n = 10;
            //sử dụng vòng lặp for để hiển thị các phần tử trong mảng ra màn hình
            Console.Write("\n Cac phan tu trong mang la: ");
            for (int i = 0; i < a_235.Length; i++)
            {
                Console.Write(a_235[i] + " ");
            }
            Console.WriteLine(" pt lon nhat: " + timsomax(a_235, n));
            Console.WriteLine(" so lan xuat hien max:  " + Timsolanxuathien(a_235, n));
            Console.WriteLine("Săp xep day so tang: ");
            mangtang(a_235, n);
            Console.WriteLine("Săp xep day so giam: ");
            manggiam(a_235, n);
        }

        static int Timsolanxuathien(int[] a_235, int n)
        {
            mangtang(a_235, n);
            int max = 0;
            int dem = 1;
            for (int i = 0; i < n; i++)
            {
                if (a_235[i] == a_235[i + 1])
                {
                    dem++;
                    if (dem > max)
                    {
                        max = dem;
                    }

                }
                else
                {

                    dem = 1;
                }
            }
            return max;
        }

        public static void mangtang(int[] a_235, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a_235[i] > a_235[j])
                    {
                        int temp = a_235[i];
                        a_235[i] = a_235[j];
                        a_235[j] = temp;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(a_235[i] + " ");
            }
        }

        public static void manggiam(int[] a_235, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a_235[i] < a_235[j])
                    {
                        int temp = a_235[i];
                        a_235[i] = a_235[j];
                        a_235[j] = temp;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(a_235[i] + " ");
            }
        }
    }
}

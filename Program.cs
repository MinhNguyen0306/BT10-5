using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapDiemDanh_10_5_LeMinh
{
    class Program
    {
        int timsomax(int[] a, int n)
        {
            int max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (max < a[i])
                    max = a[i];
            }
            return max;
        }

        static void Main(string[] args)
        {
            int[] arr = { 12, 4, 10, 4, 2, 7, -2, -6 , 2, 6};
            //sử dụng vòng lặp for để hiển thị các phần tử trong mảng ra màn hình
            Console.Write("\n Cac phan tu trong mang la: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine(" pt lon nhat:  " + timsomax(arr,10));
            Console.WriteLine(" so lan xuat hien max:  " + Timsolanxuathien(arr, 10));

        }

        int Timsolanxuathien(int[] a, int n)
        {
            mangtang(a, n);
            int max = 0;
            int dem = 1;
            for (int i = 0; i < n; i++)
            {
                if (a[i] == a[i + 1])
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

        public void mangtang(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        public void manggiam(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        }
}

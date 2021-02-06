using System;

namespace calcforcuri
{
    class Program
    {


        static void Main(string[] args)
        {
            try
            {
                string zaif = Console.ReadLine();
                string bitfryer = Console.ReadLine();
                string bitbank = Console.ReadLine();

                double bene1 = double.Parse(zaif);
                double bene2 = double.Parse(bitfryer);
                double bene3 = double.Parse(bitbank);
                double profit = bene1 + bene2 + bene3;//雑所得総額
                double interesrtToFather = 100;
                double boughtAmount = 300;
                double cost = interesrtToFather+boughtAmount ; //費用
                double taxrate;
                double pureBenefit = profit - cost;//純利益
                double minus = 0;//控除額の変数
                const int forfather = 300;//貸借金



                double calcedmyTaxAmount() //税金計算のメソッド
                {
                    if (pureBenefit == 0)
                    {
                        return -300;

                    }
                    else if (pureBenefit < 195)
                    {
                        taxrate = 0.05;
                        return (profit - cost) * taxrate - minus;

                    }
                    else if (pureBenefit < 330)
                    {
                        taxrate = 0.10;
                        minus = 9.7;
                        return (profit - cost) * taxrate - minus;
                    }
                    else if (pureBenefit < 695)
                    {
                        taxrate = 0.20;
                        minus = 42.7;
                        return (profit - cost) * taxrate - minus;
                    }
                    else if (pureBenefit < 900)
                    {
                        taxrate = 0.23;
                        minus = 63.6;
                        return (profit - cost) * taxrate - minus;
                    }
                    else if (pureBenefit < 1800)
                    {
                        taxrate = 0.33;
                        minus = 153.6;

                        return (profit - cost) * taxrate - minus;

                    }
                    else
                    {
                        taxrate = 0.4;
                        minus = 279.6;
                        return (profit - cost) * taxrate - minus;

                    }
                }
                    double myProfit()
                    {
                        return profit - forfather - calcedmyTaxAmount();
                    }

                Console.WriteLine("利益：" + profit);
                Console.WriteLine("税：" + calcedmyTaxAmount());
                Console.WriteLine("my利益 ：" + myProfit());
                Console.WriteLine("父親:" + forfather);
                Console.WriteLine("（*単位：万）");



            }



            catch (Exception ex)
            {
                Console.WriteLine("入力に誤りがあります。");

            }


        }
    }

    }


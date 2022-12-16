using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CircularQueues_CSharp
{
    class Queues
    {
        int FRONT, REAR, max = 5;
        int[] queue_array = new int[5];

        public Queues()
        {
            FRONT = -1;
            REAR = -1;
        }

        public void insert(int element)
        {
            if((FRONT == 0 && REAR == max -1) || (FRONT == REAR + 1))
            {
                Console.WriteLine("\n Queue Overflow\n");
                return;
            }

            if (FRONT == -1)
            {
                FRONT = 0;
                REAR = 0;
            }
            else
            {
                if (REAR == max - 1)
                    REAR = 0;
                   else
                    REAR = REAR + 1;
                
            }
            queue_array[REAR] = element;
        }
        public void remove()
        {
            if (FRONT == -1)
            {
                Console.WriteLine("\n Queue Underflow\n");
                return;
            }
            Console.WriteLine("\n The Element deleted from the Queue is: " + queue_array[FRONT] + "\n");
            if (FRONT == REAR)
            {
                FRONT = -1;
                REAR = -1;
            }
            else
            {
                if (FRONT == max -1)
                    FRONT = 0;
                else
                    FRONT = FRONT + 1;
            }
        }
        public void Dispaly()
        {
            int FRONT_position = FRONT;
            int REAR_position = REAR;
            if (FRONT == -1)
            {
                Console.WriteLine("\n Queue Empty \n");
                return;
            }
            else
            {
                Console.WriteLine("\nElements in the Queue are ................ \n");
                if(FRONT_position <= REAR_position)
                {
                    while(FRONT_position <= REAR_position)
                    {
                        Console.Write(queue_array[FRONT_position] + "   " );
                        FRONT_position++;
                    }
                    Console.WriteLine();
                }
                else
                {
                    while(FRONT_position <= max - 1)
                    {
                        Console.Write(queue_array[FRONT_position] + "   ");
                        FRONT_position++;
                    }
                    FRONT_position = 0;

                    while(FRONT_position <= REAR_position)
                    {
                        Console.Write(queue_array[FRONT_position] + "   ");
                        FRONT_position++;
                    }
                    Console.WriteLine();

                }
            }
        }

        static void Main(string[] args)
        {
            Queues q = new Queues();
            char ch;
            while (true)
            {
                try
                {
                    Console.WriteLine("\nMenu");
                    Console.WriteLine("1. Implement insert operaiton");
                    Console.WriteLine("2. Implement delete operaiton");
                    Console.WriteLine("3. Dispaly values");
                    Console.WriteLine("4. Exit\n");
                    Console.WriteLine("Enter yor choice(1-4):");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            {
                                Console.Write("Enter a number: ");
                                int num = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine();
                                q.insert(num);
                            }
                            break;

                        case '2':
                            {
                                q.remove();
                            }
                            break;

                        case '3':
                            {
                                q.Dispaly();
                            }
                            break;
                        case '4':
                            Console.WriteLine("\nThanks for using my program");
                            Thread.Sleep(2000);
                            Environment.Exit(0);
                            break;
                        default:
                            {
                                Console.WriteLine("\nInvalid option");
                            }
                            break;

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Check the enterd values");
                }

            }

        }
    }
}

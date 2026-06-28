//  //exercise 1 A
//  const short size = 5;
//  int[] arr = new int[size];
//
//  int user_numbers = default;
//
//  for (int i = 0; i < size; i++)
//  {
//      Console.Write("Enter a number: ");
//      user_numbers = int.Parse(Console.ReadLine());
//      arr[i] = user_numbers;
//  }
//
//  Console.WriteLine("1-SHOW\n2-SUM\n3-AVERAGE\n4-MIN\n5-MAX\n6-EVEN_ODD\n7-EXIT\n");
//
//  short choice = default;
//
//
//  while (true)
//  {
//      
//      Console.Write("Choose an option:");
//      choice = short.Parse(Console.ReadLine());
//      switch (choice)
//      {
//          case (short)Menu_choice.SHOW:
//              for (int i = 0; i < arr.Length; i++)
//              {
//                  Console.Write(arr[i] + " ");
//              }
//
//              break;
//          case (short)Menu_choice.SUM:
//              int sum = default;
//
//              for (int i = 0; i < arr.Length; i++)
//              {
//                  sum += arr[i];
//              }
//
//              Console.WriteLine(sum);
//
//              break;
//          case (short)Menu_choice.AVERAGE:
//              double average = default;
//
//              for (int i = 0; i < arr.Length; i++)
//              {
//                  average += arr[i];
//              }
//              
//              average /= arr.Length;
//
//              Console.WriteLine(average);
//              break;
//          case (short)Menu_choice.MIN:
//
//              int min = default;
//
//              for (int i = 0; i < arr.Length; i++)
//              {
//                  if (arr[i] < min)
//                  {
//                      min = arr[i];
//                  }
//              }
//
//              Console.WriteLine(min);
//              break;
//
//          case (short)Menu_choice.MAX:
//              int max = default;
//
//              for (int i = 0; i < arr.Length; i++)
//              {
//                  if (arr[i] > max)
//                  {
//                      max = arr[i];
//                  }
//              }
//
//              Console.WriteLine(max);
//              break;
//          case (short)Menu_choice.EVEN_AND_ODD:
//              for (int i = 0; i < arr.Length; i++)
//              {
//                  if (arr[i] % 2 == 0)
//                  {
//                      Console.WriteLine("Even:" + arr[i]);
//                  }
//                  else
//                  {
//                      Console.WriteLine("Odd:" + arr[i]);
//                  }
//              }
//
//              break;
//
//          case (short)Menu_choice.EXIT:
//              return;
//
//          default:
//              Console.WriteLine("Invalid choice");
//              break;
//      }
//  }
//
//  enum Menu_choice
//  {
//      SHOW = 1,
//      SUM,
//      AVERAGE,
//      MIN,
//      MAX,
//      EVEN_AND_ODD,
//      EXIT
//  }
//
// exercise 1 B
//
//  const short size = 5;
//  int[] arr = new int[size];
//
//  int user_numbers = default;
//
//  for (int i = 0; i < size; i++)
//  {
//      user_numbers = int.Parse(Console.ReadLine());
//      arr[i] = user_numbers;
//  }
//
//  Console.WriteLine("1-SHOW\n2-SUM\n3-AVERAGE\n4-MIN\n5-MAX\n6-EVEN_ODD\n7-EXIT\n");
//
//  short choice = default;
//
//
//  while (true)
//  {
//      
//      Console.Write("Choose an option:");
//      choice = short.Parse(Console.ReadLine());
//      switch (choice)
//      {
//          case (short)Menu_choice.SHOW:
//              for (int i = 0; i < arr.Length; i++)
//              {
//                  Console.Write(arr[i] + " ");
//              }
//
//              break;
//          case (short)Menu_choice.SUM:
//              int sum = arr.Sum();
//              Console.WriteLine(sum);
//              
//              break;
//          case (short)Menu_choice.AVERAGE:
//              double average = arr.Average();
//
//              Console.WriteLine(average);
//              break;
//          case (short)Menu_choice.MIN:
//
//              int min = arr.Min();
//
//              Console.WriteLine(min);
//              break;
//
//          case (short)Menu_choice.MAX:
//              int max = arr.Max();
//              
//              Console.WriteLine(max);
//              break;
//          case (short)Menu_choice.EVEN_AND_ODD:
//              for (int i = 0; i < arr.Length; i++)
//              {
//                  if (arr[i] % 2 == 0)
//                  {
//                      Console.WriteLine("Even:" + arr[i]);
//                  }
//                  else
//                  {
//                      Console.WriteLine("Odd:" + arr[i]);
//                  }
//              }
//
//              break;
//
//          case (short)Menu_choice.EXIT:
//              return;
//
//          default:
//              Console.WriteLine("Invalid choice");
//              break;
//      }
//  }
//
//  enum Menu_choice
//  {
//      SHOW = 1,
//      SUM,
//      AVERAGE,
//      MIN,
//      MAX,
//      EVEN_AND_ODD,
//      EXIT
//  }
//
// //exercise 2 A
//
//  int[] arr = {1488,228,52,67,666,777,-67,-52,-1488,-666,-42-9,300,0,0,0};
//
//  bool @true = true;
//  while (@true)
//  {
//      short choice = default;
//      choice = short.Parse(Console.ReadLine());
//      switch (choice)
//      {
//          case (short)Menu_choice.SHOW:
//              for (int i = 0; i < arr.Length; i++)
//              {
//                  Console.Write(arr[i] + " ");
//              }
//              
//              Console.WriteLine();
//              break;
//          
//          case (short)Menu_choice.CLAMPTOZERO:
//              for (int i = 0; i < arr.Length; i++)
//              {
//                  if (arr[i] < 0)
//                  {
//                      arr[i] = 0;
//                  }
//              }
//              
//              Console.WriteLine();
//              
//              break;
//          
//          case (short)Menu_choice.COUNTER:
//              ushort pos_count = default;
//              ushort neg_count = default;
//              ushort zero_count = default;
//              for (int i = 0; i < arr.Length; i++)
//              {
//                  if (arr[i] == 0)
//                  {
//                      zero_count++;
//                  }
//                  
//                  else if (arr[i] > 0)
//                  {
//                      pos_count++;
//                  }
//                  
//                  else neg_count++;
//              }
//              
//              Console.WriteLine();
//
//              break;
//              
//          case (short)Menu_choice.MAX_INDEX:
//              int max = default;
//              short max_index = 0;
//              for (int i = 0; i < arr.Length; i++)
//              {
//                  if (arr[i] > max)
//                  {
//                      max = arr[i];
//                      max_index++;
//                  }
//              }
//              
//              Console.WriteLine("Max number: " + max," index:" + max_index );
//              
//              Console.WriteLine();
//              
//              break;
//          
//          case (short)Menu_choice.EXIT:
//              @true = false;
//              break;
//          
//          default:
//              Console.WriteLine("invalid input");
//              break;
//      }
//  }
//
//  for (int i = 0; i < arr.Length; i++)
//  {
//      Console.WriteLine(arr[i]+" ");
//  }
//
//
//  enum Menu_choice
//  {
//      SHOW=1,
//      CLAMPTOZERO,
//      COUNTER,
//      MAX_INDEX,
//      EXIT
//  }
//
// // exercise 2 B
//
//  int[] arr = {1488,228,52,67,666,777,-67,-52,-1488,-666,-42-9,300,0,0,0};
//  for (int i = 0; i < arr.Length; i++)
//  {
//      Console.Write(arr[i] + " ");
//  }
//  bool @true = true;
//  while (@true)
//  {
//      short choice = default;
//      choice = short.Parse(Console.ReadLine());
//      switch (choice)
//      {
//          case (short)Menu_choice.SHOW:
//              for (int i = 0; i < arr.Length; i++)
//              {
//                  Console.Write(arr[i] + " ");
//              }
//              
//              Console.WriteLine();
//              break;
//          
//          case (short)Menu_choice.CLAMPTOZERO:
//              for (int i = 0; i < arr.Length; i++)
//              {
//                  if (arr[i] < 0)
//                  {
//                      arr[i] = 0;
//                  }
//              }
//              
//              Console.WriteLine();
//              
//              break;
//          
//          case (short)Menu_choice.COUNTER:
//              int pos_count = arr.Count(x=>x>0);
//              int neg_count = arr.Count(y=>y<0);
//              int zero_count = arr.Count(z=>z==0);
//              
//              Console.WriteLine("Positive"+pos_count+"\nNegative"+neg_count+"\nZero"+zero_count);
//              
//              Console.WriteLine();
//
//              break;
//              
//          case (short)Menu_choice.MAX_INDEX:
//              int index = Array.IndexOf(arr, arr.Max());
//
//              Console.WriteLine(index);
//              
//              break;
//          
//          case (short)Menu_choice.EXIT:
//              @true = false;
//              break;
//          
//          default:
//              Console.WriteLine("invalid input");
//              break;
//      }
//  }
//
//  enum Menu_choice
//  {
//      SHOW=1,
//      CLAMPTOZERO,
//      COUNTER,
//      MAX_INDEX,
//      EXIT
//  }
//
// // exercise 3 A
//
//  int[] arr = {1488,52,67,300};
//  int first_el = arr[0];
//  int[] arr2 = new int[arr.Length];
//  int j = 0;
//  for(int i = arr.Length-1; i >= 0; i--)
//  { 
//      arr2[j] = arr[i];
//      j++;
//  }
//
//  Console.WriteLine();
//  arr = arr2;
//
//  int second_el = arr[0];
//
//  for (int i = 0; i < arr2.Length; i++)
//  {
//      Console.Write(arr[i]);
//  }
//
//  Console.WriteLine();
//
//  if (first_el == second_el)
//  {
//      Console.WriteLine("no change");
//  }
//  else Console.WriteLine("change");
//
// // exercise 3 B
//
//  int[] arr = {1488,52,67,300};
//  int first_el = arr[0];
//  Array.Reverse(arr);
//  int second_el = arr[0];
//
//  for (int i = 0; i < arr.Length; i++)
//  {
//      Console.Write(arr[i]);
//  }
//
//  Console.WriteLine();
//
//  if (first_el == second_el)
//  {
//      Console.WriteLine("no change");
//  }
//  else Console.WriteLine("change");
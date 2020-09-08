using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Collections.Generic; 

namespace TelCo.ColorCoder
{
public class ManualPrint: PairToColor
{
internal static int GetManual()
        {
            string finalManual = "";
            
            int pairNumber = 1;
            
            for(int i = 0; i < colorMapMajor.Length; i++)
             {
             
             string printManual = "";
             
            for(int j = 0; j < colorMapMinor.Length; j++)
             {
              string majCol= colorMapMajor[i];
              string minCol = colorMapMinor[j];
              
              string pairNumbertoString = pairNumber.ToString();
              
              printManual = printManual + pairNumbertoString majCol + minCol;
              
              pairNumber = pairNumber + 1;
            }
            finalManual = finalManual + printManual;
          }
          Console.writeLine(finalManual);
        }
     }
  }

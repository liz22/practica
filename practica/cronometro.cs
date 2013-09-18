/*
 * Created by SharpDevelop.
 * User: lizbeth
 * Date: 17/09/2013
 * Time: 10:36 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

	using System;

namespace Reloj
{
	public class Cronometro
	{
				int min, seg, mseg; 

		public Cronometro ()
		{
		this.min =00;
		this.seg = 00;
		this.mseg = 00;	
		}
		
		
			public void iniciarCronometro(){
	
        Console.WriteLine("Cronometro");
        while (true)
        {
				Console.WriteLine("{0:D2}:{1:D2}:{2:D2}",min,seg,mseg);
					System.Threading.Thread.Sleep(100);

				
            mseg = mseg + 1;

            if (mseg == 60)
            {
                mseg = 0;
                seg = seg + 1;
                if (seg == 60)
                {
                    seg = 0;
                    min = min + 1;
                    if (min == 60)
                    {
                        min = 0;
                       }
                    }
                }		
	    }
	}
     }
 }
	

	
	


